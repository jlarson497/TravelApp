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

        private void btnOk_Click(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

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

        private void frmPayment_Load(object sender, EventArgs e)
        {
            pctBitCoinImage1.Visible = false;
            pctBitCoinImage2.Visible = false;
            txtBitcoinAccountNumber.Visible = false;
            label4.Visible = false;
        }
    }
}
