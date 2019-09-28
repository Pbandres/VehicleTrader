/*****************************

Form1 class

*****************************/

// Notes:
  // Program created by pablo and jhoset.


﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vehicle__Trader
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbCar.Text = "Select a Car";
            cmbCar.Items.Add("Lamborghini");
            cmbCar.Items.Add("Rolls Royce");
            cmbCar.Items.Add("Buggati Veyron");
            cmbCar.Items.Add("Mercedes");
            cmbCar.Items.Add("BMW");
            cmbCar.Items.Add("Audi");
            cmbCar.Items.Add("Honda");
            cmbCar.Items.Add("Toyota");
            cmbCar.Items.Add("Nissan");
            cmbCar.Items.Add("Ford");

            cmbTrading.Text = "Select Mileage";
            cmbTrading.Items.Add("none");
            cmbTrading.Items.Add("100-5000");
            cmbTrading.Items.Add("6000-10000");
            cmbTrading.Items.Add("11000-20000");
        }

        private void cmbCar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCar.Text=="Lamborghini")
            {
                lblCarSales.Text = "95000";
            }

            if (cmbCar.Text == "Rolls Royce")
            {
                lblCarSales.Text = "55000";
            }

            if (cmbCar.Text == "Buggati Veyron")
            {
                lblCarSales.Text = "57000";
            }

            if (cmbCar.Text == "Mercedes")
            {
                lblCarSales.Text = "75000";
            }

            if (cmbCar.Text == "BMW")
            {
                lblCarSales.Text = "65000";
            }

            if (cmbCar.Text == "Audi")
            {
                lblCarSales.Text = "72000";
            }

            if (cmbCar.Text == "Honda")
            {
                lblCarSales.Text = "40000";
            }

            if (cmbCar.Text == "Toyota")
            {
                lblCarSales.Text = "35000";
            }

            if (cmbCar.Text == "Nissan")
            {
                lblCarSales.Text = "30000";
            }

            if (cmbCar.Text == "Ford")
            {
                lblCarSales.Text = "25000";
            }
        }

        private void cmbTrading_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTrading.Text == "none")
            {
                lblTrade.Text = "20000";
            }

            if (cmbTrading.Text == "100-5000")
            {
                lblTrade.Text = "13000";
            }

            if (cmbTrading.Text == "6000-10000")
            {
                lblTrade.Text = "6852";
            }

            if (cmbTrading.Text == "11000-20000")
            {
                lblTrade.Text = "4005";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult iExit;
            iExit = MessageBox.Show("Confirm if you want to exit", "Car Sales", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (iExit == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            lblTax.Text = "";
            lblSubTotal.Text = "";
            lblTotal.Text = "";
            rtReceipt.Text = "";
            txtName.Text = "";
            txtAddress.Text = "";
            txtPostCode.Text = "";
            txtTelephone.Text = "";

            lblModified.Text = "0";
            lblCustomised.Text = "0";
            lblGlobal.Text = "0";
            lblLeather.Text = "0";
            lblStereo.Text = "0";
            lblCarSales.Text = "0";
            lblTrade.Text = "0";

            cmbCar.Text = "Select a Car";
            cmbTrading.Text = "Select Mileage";

            chkModified.Checked = false;
            chkCustomised.Checked = false;
            chkGlobal.Checked = false;
            chkLeather.Checked = false;
            chkStereo.Checked = false;

        }

        private void btnReceipt_Click(object sender, EventArgs e)
        {
            rtReceipt.AppendText("====Vehicle Sales & Tradig======");
            rtReceipt.AppendText("\n=============================");
            rtReceipt.AppendText("Name\t\t\t" + txtName.Text + "\n");
            rtReceipt.AppendText("Address\t\t\t" + txtAddress.Text + "\n");
            rtReceipt.AppendText("Post Code\t\t" + txtPostCode.Text + "\n");
            rtReceipt.AppendText("Telephone\t\t" + txtTelephone.Text + "\n");
            rtReceipt.AppendText("\n==============================");
            rtReceipt.AppendText("\nTax\t\t\t\t" + lblTax.Text + "\n");
            rtReceipt.AppendText("\nSub Total\t\t\t" + lblSubTotal.Text + "\n");
            rtReceipt.AppendText("\nTotal\t\t\t\t" + lblTotal.Text + "\n");
        }

        private void chkModified_CheckedChanged(object sender, EventArgs e)
        {
            if (chkModified.Checked == true)
            {
                lblModified.Text = "550";
                lblModified.Enabled = true;
            }
            else if(chkModified.Checked == false)
            {
                lblModified.Text = "0";
                lblModified.Enabled = false;
            }
        }

        private void chkStereo_CheckedChanged(object sender, EventArgs e)
        {
            if (chkStereo.Checked == true)
            {
                lblStereo.Text = "1670";
                lblStereo.Enabled = true;
            }
            else if (chkStereo.Checked == false)
            {
                lblStereo.Text = "0";
                lblStereo.Enabled = false;
            }
        }

        private void chkCustomised_CheckedChanged(object sender, EventArgs e)
        {
            if (chkCustomised.Checked == true)
            {
                lblCustomised.Text = "1257.99";
                lblCustomised.Enabled = true;
            }
            else if (chkCustomised.Checked == false)
            {
                lblCustomised.Text = "0";
                lblCustomised.Enabled = false;
            }
        }

        private void chkLeather_CheckedChanged(object sender, EventArgs e)
        {
            if (chkLeather.Checked == true)
            {
                lblLeather.Text = "530.99";
                lblLeather.Enabled = true;
            }
            else if (chkLeather.Checked == false)
            {
                lblLeather.Text = "0";
                lblLeather.Enabled = false;
            }
        }

        private void chkGlobal_CheckedChanged(object sender, EventArgs e)
        {
            if (chkGlobal.Checked == true)
            {
                lblGlobal.Text = "301.90";
                lblGlobal.Enabled = true;
            }
            else if (chkGlobal.Checked == false)
            {
                lblGlobal.Text = "0";
                lblGlobal.Enabled = false;
            }
        }

        private void btnTotal_Click(object sender, EventArgs e)
        {
            double[] CarCost = new double[12];

            CarCost[0] = Convert.ToDouble(lblModified.Text);
            CarCost[1] = Convert.ToDouble(lblStereo.Text);
            CarCost[2] = Convert.ToDouble(lblCustomised.Text);
            CarCost[3] = Convert.ToDouble(lblLeather.Text);
            CarCost[4] = Convert.ToDouble(lblGlobal.Text);
            CarCost[5] = Convert.ToDouble(lblTrade.Text);
            CarCost[6] = Convert.ToDouble(lblCarSales.Text);

            CarCost[7] = CarCost[0] + CarCost[1] + CarCost[2] + CarCost[3] + CarCost[4] + CarCost[5] + CarCost[6];
            CarCost[8] = (CarCost[7] * 0.45) / 100;

            lblSubTotal.Text = String.Format("{0:C2}", CarCost[7]);
            lblTax.Text = String.Format("{0:C2}", CarCost[8]);
            lblTotal.Text = String.Format("{0:C2}", (CarCost[7] + CarCost[8]));

        }

        private void Databutton_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.ShowDialog(); // Shows Form2
        }
    }
}
