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
    public partial class frmTravelMain : Form
    {
        public frmTravelMain()
        {
            InitializeComponent();
        }

        List<Segment> Segments = new List<Segment>();

        //Select value from combo box to change Destination combo box
        private void ChangeDestinationCollection(object sender, EventArgs e)
        {
            cmbDestination.Items.Clear();
            string departure = cmbStart.Text;

            switch (departure)
            {
                case "Minneapolis, MN":
                    cmbDestination.Items.Add("Chicago, IL");
                    cmbDestination.Items.Add("Seattle, WA");
                    break;

                case "Chicago, IL":
                    cmbDestination.Items.Add("Minneapolis, MN");
                    cmbDestination.Items.Add("San Francisco, CA");
                    cmbDestination.Items.Add("Fort Worth, TX");
                    break;
                case "Seattle, WA":
                    cmbDestination.Items.Add("Minneapolis, MN");
                    cmbDestination.Items.Add("San Francisco");
                    break;
                case "San Francisco, CA":
                    cmbDestination.Items.Add("Seattle, WA");
                    cmbDestination.Items.Add("Fort Worth, TX");
                    cmbDestination.Items.Add("Chicago, IL");
                    break;
                case "Fort Worth, TX":
                    cmbDestination.Items.Add("San Francisco, CA");
                    cmbDestination.Items.Add("Chicago, IL");
                    break;

            }
        }



        private void label2_Click(object sender, EventArgs e)
        {

        }


        //Click to open payment form
        private void btnMakePayment_Click_1(object sender, EventArgs e)
        {
            Form paymentForm = new frmPayment();
            paymentForm.ShowDialog();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Segment nextSegment = new Segment();
            nextSegment.Departure = cmbStart.Text;
            nextSegment.Destination = cmbDestination.Text;
        }
    }
}
