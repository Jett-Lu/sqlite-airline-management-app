using System;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;

namespace jlu119_PRG455D_FP
{
    public partial class bookingFrm : Form
    {
        private string connectionString;
        private double originalPrice;
        private double currentPrice;
        private string flightID;

        public bookingFrm(string connectionString, double price, string flightID)
        {
            InitializeComponent();
            this.connectionString = connectionString;
            originalPrice = price;
            currentPrice = originalPrice;
            this.flightID = flightID;
            UpdatePrice();
            UpdateAvailableSeats();
            Load += bookingFrm_Load;
        }

        private void bookingFrm_Load(object sender, EventArgs e)
        {
            // Additional initialization
        }

        private void confirmPurchaseBtn_Click(object sender, EventArgs e)
        {
            string name = bookNameTb.Text;
            string telephone = bookTeleTb.Text;
            string address = bookAddrTb.Text;

            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(telephone) || string.IsNullOrWhiteSpace(address))
            {
                MessageBox.Show("Please enter all customer information.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string insertCustomerQuery = @"INSERT INTO CustomerInformation (Name, Telephone, Address) VALUES (@Name, @Telephone, @Address);";
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                using (SQLiteCommand command = new SQLiteCommand(insertCustomerQuery, connection))
                {
                    command.Parameters.AddWithValue("@Name", name);
                    command.Parameters.AddWithValue("@Telephone", telephone);
                    command.Parameters.AddWithValue("@Address", address);

                    try
                    {
                        connection.Open();
                        command.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occurred while adding customer information: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
            }

            int customerID = GetLastCustomerID();

            string insertPurchaseQuery = @"INSERT INTO FlightPurchases (FlightID, CustomerID) VALUES (@FlightID, @CustomerID);";
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                using (SQLiteCommand command = new SQLiteCommand(insertPurchaseQuery, connection))
                {
                    command.Parameters.AddWithValue("@FlightID", flightID);
                    command.Parameters.AddWithValue("@CustomerID", customerID);

                    try
                    {
                        connection.Open();
                        command.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occurred while adding purchase information: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
            }

            if (bookYesRad.Checked)
            {
                UpdateFlightRecords("FirstClassSeatsAvailable", "FirstClassSeatsSold", flightID);
            }
            else if (bookNoRad.Checked)
            {
                UpdateFlightRecords("CoachSeatsAvailable", "CoachSeatsSold", flightID);
            }

            MessageBox.Show("Purchase confirmed successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            OpenReceiptForm(GetLastPurchaseID(), currentPrice);

            Close();
        }

        private void UpdateFlightRecords(string availableColumn, string soldColumn, string flightID)
        {
            string updateQuery = $"UPDATE FlightRecords SET {availableColumn} = {availableColumn} - 1, {soldColumn} = {soldColumn} + 1 WHERE FlightID = @FlightID;";

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                using (SQLiteCommand command = new SQLiteCommand(updateQuery, connection))
                {
                    command.Parameters.AddWithValue("@FlightID", flightID);

                    try
                    {
                        connection.Open();
                        command.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occurred while updating flight records: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void OpenReceiptForm(int purchaseID, double totalAmountPaid)
        {
            string departureCity = bookDepCtyLbl.Text;
            string destinationCity = bookDestCtyLbl.Text;
            string departureDate = bookDepDateLbl.Text;

            receiptFrm receiptForm = new receiptFrm(purchaseID, flightID, departureCity, destinationCity, departureDate, totalAmountPaid, GetLastCustomerID());
            receiptForm.Show();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            Hide();

            mainFrm mainForm = new mainFrm();
            mainForm.Show();
        }

        private void bookYesRad_CheckedChanged(object sender, EventArgs e)
        {
            if (bookYesRad.Checked)
            {
                currentPrice = originalPrice + 200;
                currentPrice *= 1.13;
                UpdatePrice();
            }
        }

        private void bookNoRad_CheckedChanged(object sender, EventArgs e)
        {
            if (bookNoRad.Checked)
            {
                currentPrice = originalPrice * 1.13;
                UpdatePrice();
            }
        }

        private void UpdatePrice()
        {
            bookPriceLbl.Text = "$" + currentPrice.ToString("0.00");
        }

        private void UpdateAvailableSeats()
        {
            string query = "SELECT FirstClassSeatsAvailable, CoachSeatsAvailable FROM FlightRecords WHERE FlightID = @FlightID;";

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@FlightID", flightID);

                    try
                    {
                        connection.Open();
                        using (SQLiteDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                int firstClassSeatsAvailable = reader.GetInt32(0);
                                int coachSeatsAvailable = reader.GetInt32(1);

                                bookAvaSeatLbl.Text = $"First Class: {firstClassSeatsAvailable}, Coach: {coachSeatsAvailable}";
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occurred while retrieving available seats: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private int GetLastPurchaseID()
        {
            string query = "SELECT MAX(PurchaseID) FROM FlightPurchases;";

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    try
                    {
                        connection.Open();
                        object result = command.ExecuteScalar();
                        if (result != DBNull.Value && result != null)
                        {
                            return Convert.ToInt32(result);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occurred while retrieving the last PurchaseID: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

            return 0;
        }

        private int GetLastCustomerID()
        {
            string query = "SELECT MAX(CustomerID) FROM CustomerInformation;";

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    try
                    {
                        connection.Open();
                        object result = command.ExecuteScalar();
                        if (result != DBNull.Value && result != null)
                        {
                            return Convert.ToInt32(result);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occurred while retrieving the last CustomerID: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

            return 0;
        }
    }
}
