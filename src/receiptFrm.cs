using System;
using System.Windows.Forms;

namespace jlu119_PRG455D_FP
{
    public partial class receiptFrm : Form
    {
        private int purchaseID;
        private string flightID;
        private string departureCity;
        private string destinationCity;
        private string departureDate;
        private double totalAmountPaid;
        private int customerID;

        public receiptFrm(int purchaseID, string flightID, string departureCity, string destinationCity, string departureDate, double totalAmountPaid, int customerID)
        {
            InitializeComponent();
            this.purchaseID = purchaseID;
            this.flightID = flightID;
            this.departureCity = departureCity;
            this.destinationCity = destinationCity;
            this.departureDate = departureDate;
            this.totalAmountPaid = totalAmountPaid;
            this.customerID = customerID;

            recPID.Text = purchaseID.ToString();
            recFID.Text = flightID;
            recDEPC.Text = departureCity;
            recDESC.Text = destinationCity;
            recDEPD.Text = departureDate;
            recAP.Text = $"${totalAmountPaid.ToString("F2")}";
            recCID.Text = customerID.ToString();
        }

        private void mainMenuBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            mainFrm mainForm = new mainFrm();
            mainForm.Show();
        }
    }
}