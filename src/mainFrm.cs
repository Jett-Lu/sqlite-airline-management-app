using System;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;

namespace jlu119_PRG455D_FP
{
    public partial class mainFrm : Form
    {
        private const string connectionString = "Data Source=AirlineReservationSystem.db;Version=3;";

        public mainFrm()
        {
            InitializeComponent();
            searchFlightBtn.Click -= searchFlightBtn_Click;
            searchFlightBtn.Click += searchFlightBtn_Click;
            CreateTables();
        }

        private void CreateTables()
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                string[] createTableQueries = {
                    @"CREATE TABLE IF NOT EXISTS FlightRecords (
                        FlightID INTEGER PRIMARY KEY AUTOINCREMENT,
                        DepartureCity TEXT,
                        DestinationCity TEXT,
                        DepartureDateTime DATETIME,
                        ArrivalDateTime DATETIME,
                        Price REAL,
                        FirstClassSeatsAvailable INTEGER,
                        FirstClassSeatsSold INTEGER,
                        CoachSeatsAvailable INTEGER,
                        CoachSeatsSold INTEGER
                    );",
                    @"CREATE TABLE IF NOT EXISTS CustomerInformation (
                        CustomerID INTEGER PRIMARY KEY AUTOINCREMENT,
                        Name TEXT,
                        Telephone TEXT,
                        Address TEXT
                    );",
                    @"CREATE TABLE IF NOT EXISTS FlightPurchases (
                        PurchaseID INTEGER PRIMARY KEY AUTOINCREMENT,
                        FlightID INTEGER,
                        CustomerID INTEGER,
                        FOREIGN KEY (FlightID) REFERENCES FlightRecords(FlightID),
                        FOREIGN KEY (CustomerID) REFERENCES CustomerInformation(CustomerID)
                    );"
                };

                foreach (string query in createTableQueries)
                {
                    using (SQLiteCommand command = new SQLiteCommand(query, connection))
                    {
                        command.ExecuteNonQuery();
                    }
                }
            }
        }

        private void searchFlightBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(depCityCmb.Text) || string.IsNullOrWhiteSpace(desCityCmb.Text) || string.IsNullOrWhiteSpace(depDateCmb.Text))
            {
                MessageBox.Show("Please enter all fields", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (depCityCmb.Text == desCityCmb.Text)
            {
                MessageBox.Show("Departure and destination airport can't be the same", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string departureCity = MapCityName(depCityCmb.Text);
            string destinationCity = MapCityName(desCityCmb.Text);
            string departureDate = depDateCmb.Text;

            string query = @"SELECT * FROM FlightRecords 
                             WHERE DepartureCity = @DepartureCity 
                             AND DestinationCity = @DestinationCity 
                             AND DepartureDateTime >= @DepartureDate";

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@DepartureCity", departureCity);
                    command.Parameters.AddWithValue("@DestinationCity", destinationCity);
                    command.Parameters.AddWithValue("@DepartureDate", departureDate);

                    try
                    {
                        connection.Open();
                        DataTable dt = new DataTable();
                        SQLiteDataAdapter adapter = new SQLiteDataAdapter(command);
                        adapter.Fill(dt);
                        sqlFlightGrid.DataSource = dt;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occurred while searching for flights: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void makePurchaseBtn_Click(object sender, EventArgs e)
        {
            if (sqlFlightGrid.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a flight to make a purchase.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DataGridViewRow selectedRow = sqlFlightGrid.SelectedRows[0];

            string flightID = selectedRow.Cells["FlightID"].Value.ToString();
            string departureCity = selectedRow.Cells["DepartureCity"].Value.ToString();
            string destinationCity = selectedRow.Cells["DestinationCity"].Value.ToString();
            string departureDate = selectedRow.Cells["DepartureDateTime"].Value.ToString();
            double price = Convert.ToDouble(selectedRow.Cells["Price"].Value);
            int firstClassSeatsAvailable = Convert.ToInt32(selectedRow.Cells["FirstClassSeatsAvailable"].Value);
            int coachSeatsAvailable = Convert.ToInt32(selectedRow.Cells["CoachSeatsAvailable"].Value);

            double taxedPrice = price * 1.13;

            bookingFrm bookingForm = new bookingFrm(connectionString, taxedPrice, flightID);

            bookingForm.bookFlightIdLbl.Text = flightID;
            bookingForm.bookDepCtyLbl.Text = departureCity;
            bookingForm.bookDestCtyLbl.Text = destinationCity;
            bookingForm.bookDepDateLbl.Text = departureDate;
            bookingForm.bookPriceLbl.Text = $"${taxedPrice.ToString("F2")}";
            bookingForm.bookAvaSeatLbl.Text = $"First Class Seats ({firstClassSeatsAvailable}) Coach Seats ({coachSeatsAvailable})";

            bookingForm.Show();
            this.Hide();
        }

        private string MapCityName(string airportName)
        {
            switch (airportName)
            {
                case "Calgary International Airport (YYC)": return "Calgary";
                case "Toronto Pearson International Airport (YYZ)": return "Toronto";
                case "Vancouver International Airport (YVR)": return "Vancouver";
                case "Winnipeg International Airport (YWG)": return "Winnipeg";
                default: return airportName;
            }
        }

        private void helpMainBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Upon launching the application, you will be presented with the main interface, which consists of the following components:\n\n" +
                "Flight Search: Use the dropdown menus to select the departure city, destination city, and departure date. Click the 'Search Flights' button to find available flights matching your criteria.\n" +
                "Flight Results: View the list of available flights that match your search criteria. Click on a flight to see detailed information.\n" +
                "Make Purchase: Select a flight and click the 'Make Purchase' button to proceed with booking.\n\n" +
                "To exit the Airline Reservation System, simply close the application window. Your data will be saved automatically for future use.\n\n" +
                "Troubleshooting\n\n" +
                "If you encounter any issues or have questions about using the Airline Reservation System, please refer to the Help section in the application menu or contact our support team for assistance.",
                "Main Interface Help",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void helpFlightsBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Select the departure city, destination city, and departure date from the dropdown menus.\n" +
                "Click the 'Search Flights' button to find available flights.\n" +
                "Review the list of available flights in the results grid.\n\n" +
                "To exit the Airline Reservation System, simply close the application window. Your data will be saved automatically for future use.\n\n" +
                "Troubleshooting\n\n" +
                "If you encounter any issues or have questions about using the Airline Reservation System, please refer to the Help section in the application menu or contact our support team for assistance.",
                "Searching for Flights Help",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void helpPurchaseBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Select a flight from the results grid by clicking on it.\n" +
                "Click the 'Make Purchase' button to proceed with booking.\n" +
                "Enter your personal information, such as name, telephone number, and address.\n" +
                "Select your preferred seating option (if available).\n" +
                "Click the 'Confirm Purchase' button to complete the booking process.\n" +
                "A receipt will be generated for your purchase, containing all relevant details.\n\n" +
                "To exit the Airline Reservation System, simply close the application window. Your data will be saved automatically for future use.\n\n" +
                "Troubleshooting\n\n" +
                "If you encounter any issues or have questions about using the Airline Reservation System, please refer to the Help section in the application menu or contact our support team for assistance.",
                "Making a Purchase Help",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void helpReceiptsBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "After completing a purchase, a receipt will be generated automatically. You can view your receipts by clicking on the 'View Receipts' button in the main interface. This will display a list of all your previous purchases.\n\n" +
                "Exiting the Application\n\n" +
                "To exit the Airline Reservation System, simply close the application window. Your data will be saved automatically for future use.\n\n" +
                "Troubleshooting\n\n" +
                "If you encounter any issues or have questions about using the Airline Reservation System, please refer to the Help section in the application menu or contact our support team for assistance.",
                "Viewing Receipts Help",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }
    }
}