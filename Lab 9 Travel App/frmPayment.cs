using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_9_Travel_App
{
    public partial class frmPayment : Form
    {
        public frmPayment()
        {
            InitializeComponent();
        }

        //Ok button to send data to other form
        private void btnOk_Click(object sender, EventArgs e)
        {

        }

        //Cancel button closes form
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Select radio button to show or hide Bitcoin info
        private void rdoBitcoin_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoBitcoin.Checked)
            {
                pctBitCoinImage1.Visible = true;
                pctBitCoinImage2.Visible = true;
                txtBitcoinAccountNumber.Visible = true;
                label4.Visible = true;
            }
            else 
            {
                pctBitCoinImage1.Visible = false;
                pctBitCoinImage2.Visible = false;
                txtBitcoinAccountNumber.Visible = false;
                label4.Visible = false;
            }
        }

        //Form load
        private void frmPayment_Load(object sender, EventArgs e)
        {
            //Disable Credit Card fields
            Disablecontrols();

            //Hide Bitcoin info on page load
            pctBitCoinImage1.Visible = false;
            pctBitCoinImage2.Visible = false;
            txtBitcoinAccountNumber.Visible = false;
            label4.Visible = false;

            //Add items to list box
            lstCreditCardType.Items.Add("Visa");
            lstCreditCardType.Items.Add("Master Card");
            lstCreditCardType.Items.Add("American Express");
            lstCreditCardType.SelectedIndex = 0;

            //Create array with months for combo box and then add to combo box
            string[] months = {"Choose a month:", "Jan", "Feb", "March",
                                  "April", "May", "June", "July", "Aug", "Sep", "Oct", "Nov", "Dec"};
            foreach (string month in months)
                cboExpirationMonth.Items.Add(month);
            cboExpirationMonth.SelectedIndex = 0;

            //Loop to add the expiration years
            int year = DateTime.Today.Year;
            int endYear = year + 8;
            cboExpirationYear.Items.Add("Choose a year:");
            while (year < endYear)
            {
                cboExpirationYear.Items.Add(year);
                year++;
            }
            cboExpirationYear.SelectedIndex = 0;
        }

        //Enable and disable controls
        private void EnableControls()
        {
            lstCreditCardType.Enabled = true;
            txtCreditCardNumber.Enabled = true;
            cboExpirationMonth.Enabled = true;
            cboExpirationYear.Enabled = true;
        }

        private void Disablecontrols()
        {
            lstCreditCardType.Enabled = false;
            txtCreditCardNumber.Enabled = false;
            cboExpirationMonth.Enabled = false;
            cboExpirationYear.Enabled = false;
        }

        private void rdoCreditCard_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoCreditCard.Checked)
            {
                EnableControls();
            }
            else
                Disablecontrols();

        }
    }
}
