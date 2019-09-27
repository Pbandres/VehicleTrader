using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vehicle__Trader
{
    public partial class Form2 : Form
    {
        String OrderDetails ="{0,-20}{1,-20}{2, -20}{3, -20}{4, -20}{5, -20}{6, -20}";
        private Stream sPath;

        public Form2()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult iExit;
            iExit = MessageBox.Show("Confirm if you want to exit", "Inventory System",MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (iExit == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtCustomerID.Clear();
            txtFirstName.Clear();
            txtSurname.Clear();
            chkStereo.Checked = false;
            chkGPS.Checked = false;
            chkTired.Checked = false;
            chkColor.Checked = false;
            chkFullSet.Checked = false;

            rbOne.Checked = false;
            rbTwo.Checked = false;
            rbFour.Checked = false;
            rbEight.Checked = false;

            lstBrand.SelectedItems.Clear();
            lstOutput.Items.Clear();
            lstOutput.Items.Add(String.Format(OrderDetails,"Customer ID","Firstname","Surname","Order Made","Method of Payment","Date of Order","Price"));

            cmbOrderMade.Text = "Select Order";
            cmbPayment.Text = "Select Type";
        }

        private void btnAddmore_Click(object sender, EventArgs e)
        {
            txtCustomerID.Clear();
            txtFirstName.Clear();
            txtSurname.Clear();
            chkStereo.Checked = false;
            chkGPS.Checked = false;
            chkTired.Checked = false;
            chkColor.Checked = false;
            chkFullSet.Checked = false;

            rbOne.Checked = false;
            rbTwo.Checked = false;
            rbFour.Checked = false;
            rbEight.Checked = false;

            lstBrand.SelectedItems.Clear();

            cmbOrderMade.Text = "Select Order";
            cmbPayment.Text = "Select Type";
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            String ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price;
            double Acura_Price = 20.000;
            double Alfa_Romeo_Price = 10.000;
            double Aston_Martin_Price = 150.000;
            double Audi_Price = 55.000;
            double Bentley_Price = 120.000;
            double BMW_Price = 65.000;
            double Bugatti_Price = 75.000;
            double Buick_Price = 22.000;
            double Cadillac_Price = 45.000;
            double Chevrolet_Price = 35.000;
            double Chryler_Price = 44.000;
            double Citroen_Price = 14.000;
            double Dodge_Price = 25.000;
            double Ferrari_Price = 220.000;
            double Fiat_Price = 35.000;
            double Ford_Price = 25.000;
            double Geely_Price = 13.000;
            double General_Motors_Price = 26.000;
            double GMC_Price = 40.000;
            double Honda_Price = 30.000;
            double Hyundai_Price = 21.000;
            double Infiniti_Price = 50.000;
            double Jaguar_Price = 75.000;
            double Jeep_Price = 44.000;
            double KIA_Price = 22.000;
            double Koenigsegg_Price = 11.000;
            double Lamborghini_Price = 250.000;
            double Land_Rover_Price = 230.000;
            double Lexus_Price = 70.000;
            double Maserati_Price = 280.000;
            double Mazda_Price = 34.000;
            double Mclaren_Price = 300.000;
            double Mercedes_Benz_Price = 85.000;
            double Mini_Price = 33.000;
            double Mitsubishi_Price = 47.000;
            double Mustang_Price = 36.000;
            double Nissan_Price = 17.000;
            double Pagani_Price = 14.000;
            double Peugeot_Price = 26.000;
            double Porsche_Price = 170.000;
            double Ram_Price = 33.000;
            double Renault_Price = 41.000;
            double Rolls_Royce_Price = 90.000;
            double Saab_Price = 22.000;
            double Subaru_Price = 66.000;
            double Suzuki_Price = 55.000;
            double Tata_Motors_Price = 19.000;
            double Tesla_Price = 28.000;
            double Toyota_Price = 27.000;
            double Volkswagen_Price = 23.000;
            double Volvo_Price = 37.000;



            ID = txtCustomerID.Text;
            Firstname = txtFirstName.Text;
            Surname = txtSurname.Text;
            SelectOrder = cmbOrderMade.Text;
            SelectType = cmbPayment.Text;
            SelectDate = DateTimePicker1.Text;

            if (lstBrand.Text == "")
            {
                MessageBox.Show("You must select a brand of a car", "Brands", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if ((chkStereo.Checked == false) && (chkGPS.Checked == false) && (chkTired.Checked == false) && (chkColor.Checked == false))
            {
                MessageBox.Show("You must select an option", "Options", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else if ((rbOne.Checked == false) && (rbTwo.Checked == false) && (rbFour.Checked == false) && (rbEight.Checked == false))
            {
                MessageBox.Show("You must select quantity", "Quantity", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }

            //--------------------------------------------------------------------------------------------------------------------------------
            //ACURA// PART1
            if(lstBrand.Text == "Acura" && chkStereo.Checked == true && rbOne.Checked == true)
            {
                Price = String.Format(("{0:C}"),(Acura_Price *1));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate ,Price));
            }
            else if (lstBrand.Text == "Acura" && chkStereo.Checked == true && rbTwo.Checked == true)
            {
                Price = String.Format(("{0:C}"),(Acura_Price * 2));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate ,Price));

            }
            else if (lstBrand.Text == "Acura" && chkStereo.Checked == true && rbFour.Checked == true)
            {
                Price = String.Format(("{0:C}"),(Acura_Price * 4));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate ,Price));
            }
            else if (lstBrand.Text == "Acura" && chkStereo.Checked == true && rbEight.Checked == true)
            {
                Price = String.Format(("{0:C}"),(Acura_Price * 8));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate ,Price));
            }

            //-----------------------------------------------------------------------------------------------------------------------
            //ACURA// PART2
            if (lstBrand.Text == "Acura" && chkStereo.Checked == true && rbOne.Checked == true)
            {
                Price = String.Format(("{0:C}"),(Acura_Price * 1.1));
                lstOutput.Items.Add(String.Format(OrderDetails,ID,Firstname,Surname,SelectOrder,SelectType, SelectDate ,Price));
            }
            else if (lstBrand.Text == "Acura" && chkStereo.Checked == true && rbTwo.Checked == true)
            {
                Price = String.Format(("{0:C}"),(Acura_Price * 2.1));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate ,Price));

            }
            else if (lstBrand.Text == "Acura" && chkStereo.Checked == true && rbFour.Checked == true)
            {
                Price = String.Format(("{0:C}"),(Acura_Price * 4.1));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate ,Price));
            }
            else if (lstBrand.Text == "Acura" && chkStereo.Checked == true && rbEight.Checked == true)
            {
                Price = String.Format(("{0:C}"),(Acura_Price * 8.1));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate ,Price));
            }

            //-----------------------------------------------------------------------------------------------------------------------
            //ACURA// PART3
            if (lstBrand.Text == "Acura" && chkStereo.Checked == true && rbOne.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Acura_Price * 1.2));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }
            else if (lstBrand.Text == "Acura" && chkStereo.Checked == true && rbTwo.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Acura_Price * 2.2));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));

            }
            else if (lstBrand.Text == "Acura" && chkStereo.Checked == true && rbFour.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Acura_Price * 4.2));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }
            else if (lstBrand.Text == "Acura" && chkStereo.Checked == true && rbEight.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Acura_Price * 8.2));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }

            //--------------------------------------------------------------------------------------------------------------------------------
            //ALFA ROMEO// PART1
            if (lstBrand.Text == "Alfa Romeo" && chkStereo.Checked == true && rbOne.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Alfa_Romeo_Price * 1));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }
            else if (lstBrand.Text == "Alfa Romeo" && chkStereo.Checked == true && rbTwo.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Alfa_Romeo_Price * 2));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));

            }
            else if (lstBrand.Text == "Alfa Romeo" && chkStereo.Checked == true && rbFour.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Alfa_Romeo_Price * 4));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }
            else if (lstBrand.Text == "Alfa Romeo" && chkStereo.Checked == true && rbEight.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Alfa_Romeo_Price * 8));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }

            //-----------------------------------------------------------------------------------------------------------------------
            //ALFA ROMEO// PART2
            if (lstBrand.Text == "Alfa Romeo" && chkStereo.Checked == true && rbOne.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Alfa_Romeo_Price * 1.1));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }
            else if (lstBrand.Text == "Alfa Romeo" && chkStereo.Checked == true && rbTwo.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Alfa_Romeo_Price * 2.1));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));

            }
            else if (lstBrand.Text == "Alfa Romeo" && chkStereo.Checked == true && rbFour.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Alfa_Romeo_Price * 4.1));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }
            else if (lstBrand.Text == "Alfa Romeo" && chkStereo.Checked == true && rbEight.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Alfa_Romeo_Price * 8.1));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }

            //-----------------------------------------------------------------------------------------------------------------------
            //ALFA ROMEO// PART3
            if (lstBrand.Text == "Alfa Romeo" && chkStereo.Checked == true && rbOne.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Alfa_Romeo_Price * 1.2));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }
            else if (lstBrand.Text == "Alfa Romeo" && chkStereo.Checked == true && rbTwo.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Alfa_Romeo_Price * 2.2));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));

            }
            else if (lstBrand.Text == "Alfa Romeo" && chkStereo.Checked == true && rbFour.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Alfa_Romeo_Price * 4.2));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }
            else if (lstBrand.Text == "Alfa Romeo" && chkStereo.Checked == true && rbEight.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Alfa_Romeo_Price * 8.2));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }

            //--------------------------------------------------------------------------------------------------------------------------------
            //ASTON MARTIN// PART1
            if (lstBrand.Text == "Aston Martin" && chkStereo.Checked == true && rbOne.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Aston_Martin_Price * 1));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }
            else if (lstBrand.Text == "Aston Martin" && chkStereo.Checked == true && rbTwo.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Aston_Martin_Price * 2));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));

            }
            else if (lstBrand.Text == "Aston Martin" && chkStereo.Checked == true && rbFour.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Aston_Martin_Price * 4));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }
            else if (lstBrand.Text == "Aston Martin" && chkStereo.Checked == true && rbEight.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Aston_Martin_Price * 8));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }

            //-----------------------------------------------------------------------------------------------------------------------
            //ASTON MARTIN// PART2
            if (lstBrand.Text == "Aston Martin" && chkStereo.Checked == true && rbOne.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Aston_Martin_Price * 1.1));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }
            else if (lstBrand.Text == "Aston Martin" && chkStereo.Checked == true && rbTwo.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Aston_Martin_Price * 2.1));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));

            }
            else if (lstBrand.Text == "Aston Martin" && chkStereo.Checked == true && rbFour.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Aston_Martin_Price * 4.1));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }
            else if (lstBrand.Text == "Aston Martin" && chkStereo.Checked == true && rbEight.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Aston_Martin_Price * 8.1));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }

            //-----------------------------------------------------------------------------------------------------------------------
            //ASTON MARTIN// PART3
            if (lstBrand.Text == "Aston Martin" && chkStereo.Checked == true && rbOne.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Aston_Martin_Price * 1.2));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }
            else if (lstBrand.Text == "Aston Martin" && chkStereo.Checked == true && rbTwo.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Aston_Martin_Price * 2.2));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));

            }
            else if (lstBrand.Text == "Aston Martin" && chkStereo.Checked == true && rbFour.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Aston_Martin_Price * 4.2));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }
            else if (lstBrand.Text == "Aston Martin" && chkStereo.Checked == true && rbEight.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Aston_Martin_Price * 8.2));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }

            //--------------------------------------------------------------------------------------------------------------------------------
            //BMW// PART1
            if (lstBrand.Text == "BMW" && chkStereo.Checked == true && rbOne.Checked == true)
            {
                Price = String.Format(("{0:C}"), (BMW_Price * 1));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }
            else if (lstBrand.Text == "BMW" && chkStereo.Checked == true && rbTwo.Checked == true)
            {
                Price = String.Format(("{0:C}"), (BMW_Price * 2));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));

            }
            else if (lstBrand.Text == "BMW" && chkStereo.Checked == true && rbFour.Checked == true)
            {
                Price = String.Format(("{0:C}"), (BMW_Price * 4));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }
            else if (lstBrand.Text == "BMW" && chkStereo.Checked == true && rbEight.Checked == true)
            {
                Price = String.Format(("{0:C}"), (BMW_Price * 8));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }


            //-----------------------------------------------------------------------------------------------------------------------
            //AUDI// PART2
            if (lstBrand.Text == "Audi" && chkStereo.Checked == true && rbOne.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Audi_Price * 1.1));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }
            else if (lstBrand.Text == "Audi" && chkStereo.Checked == true && rbTwo.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Audi_Price * 2.1));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));

            }
            else if (lstBrand.Text == "Audi" && chkStereo.Checked == true && rbFour.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Audi_Price * 4.1));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }
            else if (lstBrand.Text == "Audi" && chkStereo.Checked == true && rbEight.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Audi_Price * 8.1));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }


            //-----------------------------------------------------------------------------------------------------------------------
            //AUDI// PART3
            if (lstBrand.Text == "Audi" && chkStereo.Checked == true && rbOne.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Audi_Price * 1.2));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }
            else if (lstBrand.Text == "Audi" && chkStereo.Checked == true && rbTwo.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Audi_Price * 2.2));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));

            }
            else if (lstBrand.Text == "Audi" && chkStereo.Checked == true && rbFour.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Audi_Price * 4.2));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }
            else if (lstBrand.Text == "Audi" && chkStereo.Checked == true && rbEight.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Audi_Price * 8.2));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }

            //--------------------------------------------------------------------------------------------------------------------------------
            //BENTLEY// PART1
            if (lstBrand.Text == "Bentley" && chkStereo.Checked == true && rbOne.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Bentley_Price * 1));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }
            else if (lstBrand.Text == "Bentley" && chkStereo.Checked == true && rbTwo.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Bentley_Price * 2));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));

            }
            else if (lstBrand.Text == "Bentley" && chkStereo.Checked == true && rbFour.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Bentley_Price * 4));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }
            else if (lstBrand.Text == "Bentley" && chkStereo.Checked == true && rbEight.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Bentley_Price * 8));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }

            //-----------------------------------------------------------------------------------------------------------------------
            //BENTLEY// PART2
            if (lstBrand.Text == "Bentley" && chkStereo.Checked == true && rbOne.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Bentley_Price * 1.1));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }
            else if (lstBrand.Text == "Bentley" && chkStereo.Checked == true && rbTwo.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Bentley_Price * 2.1));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));

            }
            else if (lstBrand.Text == "Bentley" && chkStereo.Checked == true && rbFour.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Bentley_Price * 4.1));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }
            else if (lstBrand.Text == "Bentley" && chkStereo.Checked == true && rbEight.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Bentley_Price * 8.1));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }

            //-----------------------------------------------------------------------------------------------------------------------
            //BENTLY// PART3
            if (lstBrand.Text == "Bentley" && chkStereo.Checked == true && rbOne.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Bentley_Price * 1.2));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }
            else if (lstBrand.Text == "Bentley" && chkStereo.Checked == true && rbTwo.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Bentley_Price * 2.2));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));

            }
            else if (lstBrand.Text == "Bentley" && chkStereo.Checked == true && rbFour.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Bentley_Price * 4.2));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }
            else if (lstBrand.Text == "Bently" && chkStereo.Checked == true && rbEight.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Bentley_Price * 8.2));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }

            //--------------------------------------------------------------------------------------------------------------------------------
            //BUGATTI// PART1
            if (lstBrand.Text == "Bugatti" && chkStereo.Checked == true && rbOne.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Bugatti_Price * 1));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }
            else if (lstBrand.Text == "Bugatti" && chkStereo.Checked == true && rbTwo.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Bugatti_Price * 2));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));

            }
            else if (lstBrand.Text == "Bugatti" && chkStereo.Checked == true && rbFour.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Bugatti_Price * 4));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }
            else if (lstBrand.Text == "Bugatti" && chkStereo.Checked == true && rbEight.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Bugatti_Price * 8));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }

            //-----------------------------------------------------------------------------------------------------------------------
            //BUGATTI// PART2
            if (lstBrand.Text == "Bugatti" && chkStereo.Checked == true && rbOne.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Bugatti_Price * 1.1));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }
            else if (lstBrand.Text == "Bugatti" && chkStereo.Checked == true && rbTwo.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Bugatti_Price * 2.1));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));

            }
            else if (lstBrand.Text == "Bugatti" && chkStereo.Checked == true && rbFour.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Bugatti_Price * 4.1));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }
            else if (lstBrand.Text == "Bugatti" && chkStereo.Checked == true && rbEight.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Bugatti_Price * 8.1));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }

            //-----------------------------------------------------------------------------------------------------------------------
            //BUGATTI// PART3
            if (lstBrand.Text == "Bugatti" && chkStereo.Checked == true && rbOne.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Bugatti_Price * 1.2));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }
            else if (lstBrand.Text == "Bugatti" && chkStereo.Checked == true && rbTwo.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Bugatti_Price * 2.2));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));

            }
            else if (lstBrand.Text == "Bugatti" && chkStereo.Checked == true && rbFour.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Bugatti_Price * 4.2));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }
            else if (lstBrand.Text == "Bugatti" && chkStereo.Checked == true && rbEight.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Bugatti_Price * 8.2));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }

            //--------------------------------------------------------------------------------------------------------------------------------
            //BUICK// PART1
            if (lstBrand.Text == "Buick" && chkStereo.Checked == true && rbOne.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Buick_Price * 1));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }
            else if (lstBrand.Text == "Buick" && chkStereo.Checked == true && rbTwo.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Buick_Price * 2));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));

            }
            else if (lstBrand.Text == "Buick" && chkStereo.Checked == true && rbFour.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Buick_Price * 4));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }
            else if (lstBrand.Text == "Buick" && chkStereo.Checked == true && rbEight.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Buick_Price * 8));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }

            //-----------------------------------------------------------------------------------------------------------------------
            //BUICK// PART2
            if (lstBrand.Text == "Buick" && chkStereo.Checked == true && rbOne.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Buick_Price * 1.1));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }
            else if (lstBrand.Text == "Buick" && chkStereo.Checked == true && rbTwo.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Buick_Price * 2.1));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));

            }
            else if (lstBrand.Text == "Buick" && chkStereo.Checked == true && rbFour.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Buick_Price * 4.1));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }
            else if (lstBrand.Text == "Buick" && chkStereo.Checked == true && rbEight.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Buick_Price * 8.1));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }

            //-----------------------------------------------------------------------------------------------------------------------
            //BUICK// PART3
            if (lstBrand.Text == "Buick" && chkStereo.Checked == true && rbOne.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Buick_Price * 1.2));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }
            else if (lstBrand.Text == "Buick" && chkStereo.Checked == true && rbTwo.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Buick_Price * 2.2));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));

            }
            else if (lstBrand.Text == "Buick" && chkStereo.Checked == true && rbFour.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Buick_Price * 4.2));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }
            else if (lstBrand.Text == "Buick" && chkStereo.Checked == true && rbEight.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Buick_Price * 8.2));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }


            //--------------------------------------------------------------------------------------------------------------------------------
            //CADILLAC// PART1
            if (lstBrand.Text == "Cadillac" && chkStereo.Checked == true && rbOne.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Cadillac_Price * 1));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }
            else if (lstBrand.Text == "Cadillac" && chkStereo.Checked == true && rbTwo.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Cadillac_Price * 2));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));

            }
            else if (lstBrand.Text == "Cadillac" && chkStereo.Checked == true && rbFour.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Cadillac_Price * 4));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }
            else if (lstBrand.Text == "Cadillac" && chkStereo.Checked == true && rbEight.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Cadillac_Price * 8));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }

            //-----------------------------------------------------------------------------------------------------------------------
            //CADILLAC// PART2
            if (lstBrand.Text == "Cadillac" && chkStereo.Checked == true && rbOne.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Cadillac_Price * 1.1));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }
            else if (lstBrand.Text == "Cadillac" && chkStereo.Checked == true && rbTwo.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Cadillac_Price * 2.1));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));

            }
            else if (lstBrand.Text == "Cadillac" && chkStereo.Checked == true && rbFour.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Cadillac_Price * 4.1));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }
            else if (lstBrand.Text == "Cadillac" && chkStereo.Checked == true && rbEight.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Cadillac_Price * 8.1));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }

            //-----------------------------------------------------------------------------------------------------------------------
            //CADILLAC// PART3
            if (lstBrand.Text == "Cadillac" && chkStereo.Checked == true && rbOne.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Cadillac_Price * 1.2));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }
            else if (lstBrand.Text == "Cadillac" && chkStereo.Checked == true && rbTwo.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Cadillac_Price * 2.2));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));

            }
            else if (lstBrand.Text == "Cadillac" && chkStereo.Checked == true && rbFour.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Cadillac_Price * 4.2));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }
            else if (lstBrand.Text == "Cadillac" && chkStereo.Checked == true && rbEight.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Cadillac_Price * 8.2));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }


            //--------------------------------------------------------------------------------------------------------------------------------
            //CHEVROLET// PART1
            if (lstBrand.Text == "Chevrolet" && chkStereo.Checked == true && rbOne.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Chevrolet_Price * 1));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }
            else if (lstBrand.Text == "Chevrolet" && chkStereo.Checked == true && rbTwo.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Chevrolet_Price * 2));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));

            }
            else if (lstBrand.Text == "Chevrolet" && chkStereo.Checked == true && rbFour.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Chevrolet_Price * 4));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }
            else if (lstBrand.Text == "Chevrolet" && chkStereo.Checked == true && rbEight.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Chevrolet_Price * 8));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }

            //-----------------------------------------------------------------------------------------------------------------------
            //CHEVROLET// PART2
            if (lstBrand.Text == "Chevrolet" && chkStereo.Checked == true && rbOne.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Chevrolet_Price * 1.1));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }
            else if (lstBrand.Text == "Chevrolet" && chkStereo.Checked == true && rbTwo.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Chevrolet_Price * 2.1));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));

            }
            else if (lstBrand.Text == "Chevrolet" && chkStereo.Checked == true && rbFour.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Chevrolet_Price * 4.1));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }
            else if (lstBrand.Text == "Chevrolet" && chkStereo.Checked == true && rbEight.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Chevrolet_Price * 8.1));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }

            //-----------------------------------------------------------------------------------------------------------------------
            //CHEVROLET// PART3
            if (lstBrand.Text == "Chevrolet" && chkStereo.Checked == true && rbOne.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Chevrolet_Price * 1.2));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }
            else if (lstBrand.Text == "Chevrolet" && chkStereo.Checked == true && rbTwo.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Chevrolet_Price * 2.2));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));

            }
            else if (lstBrand.Text == "Chevrolet" && chkStereo.Checked == true && rbFour.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Chevrolet_Price * 4.2));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }
            else if (lstBrand.Text == "Chevrolet" && chkStereo.Checked == true && rbEight.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Chevrolet_Price * 8.2));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }

            //--------------------------------------------------------------------------------------------------------------------------------
            //CHRYLER// PART1
            if (lstBrand.Text == "Chryler" && chkStereo.Checked == true && rbOne.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Chryler_Price * 1));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }
            else if (lstBrand.Text == "Chryler" && chkStereo.Checked == true && rbTwo.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Chryler_Price * 2));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));

            }
            else if (lstBrand.Text == "Chryler" && chkStereo.Checked == true && rbFour.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Chryler_Price * 4));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }
            else if (lstBrand.Text == "Chryler" && chkStereo.Checked == true && rbEight.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Chryler_Price * 8));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }


            //-----------------------------------------------------------------------------------------------------------------------
            //CHRYLER// PART2
            if (lstBrand.Text == "Chryler" && chkStereo.Checked == true && rbOne.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Chryler_Price * 1.1));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }
            else if (lstBrand.Text == "Chryler" && chkStereo.Checked == true && rbTwo.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Chryler_Price * 2.1));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));

            }
            else if (lstBrand.Text == "Chryler" && chkStereo.Checked == true && rbFour.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Chryler_Price * 4.1));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }
            else if (lstBrand.Text == "Chryler" && chkStereo.Checked == true && rbEight.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Chryler_Price * 8.1));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }

            //-----------------------------------------------------------------------------------------------------------------------
            //CHRYLER// PART3
            if (lstBrand.Text == "Chryler" && chkStereo.Checked == true && rbOne.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Chryler_Price * 1.2));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }
            else if (lstBrand.Text == "Chryler" && chkStereo.Checked == true && rbTwo.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Chryler_Price * 2.2));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));

            }
            else if (lstBrand.Text == "Chryler" && chkStereo.Checked == true && rbFour.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Chryler_Price * 4.2));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }
            else if (lstBrand.Text == "Chryler" && chkStereo.Checked == true && rbEight.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Chryler_Price * 8.2));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }

            //--------------------------------------------------------------------------------------------------------------------------------
            //CITROEN// PART1
            if (lstBrand.Text == "Citroen" && chkStereo.Checked == true && rbOne.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Citroen_Price * 1));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }
            else if (lstBrand.Text == "Citroen" && chkStereo.Checked == true && rbTwo.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Citroen_Price * 2));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));

            }
            else if (lstBrand.Text == "Citroen" && chkStereo.Checked == true && rbFour.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Citroen_Price * 4));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }
            else if (lstBrand.Text == "Citroen" && chkStereo.Checked == true && rbEight.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Citroen_Price * 8));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }

            //-----------------------------------------------------------------------------------------------------------------------
            //CITROEN// PART2
            if (lstBrand.Text == "Citroen" && chkStereo.Checked == true && rbOne.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Citroen_Price * 1.1));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }
            else if (lstBrand.Text == "Citroen" && chkStereo.Checked == true && rbTwo.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Citroen_Price * 2.1));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));

            }
            else if (lstBrand.Text == "Citroen" && chkStereo.Checked == true && rbFour.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Citroen_Price * 4.1));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }
            else if (lstBrand.Text == "Citroen" && chkStereo.Checked == true && rbEight.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Citroen_Price * 8.1));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }

            //-----------------------------------------------------------------------------------------------------------------------
            //CITROEN// PART3
            if (lstBrand.Text == "Citroen" && chkStereo.Checked == true && rbOne.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Citroen_Price * 1.2));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }
            else if (lstBrand.Text == "Citroen" && chkStereo.Checked == true && rbTwo.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Citroen_Price * 2.2));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));

            }
            else if (lstBrand.Text == "Citroen" && chkStereo.Checked == true && rbFour.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Citroen_Price * 4.2));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }
            else if (lstBrand.Text == "Citroen" && chkStereo.Checked == true && rbEight.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Citroen_Price * 8.2));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }

            //--------------------------------------------------------------------------------------------------------------------------------
            //DODGE// PART1
            if (lstBrand.Text == "Dodge" && chkStereo.Checked == true && rbOne.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Dodge_Price * 1));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }
            else if (lstBrand.Text == "Dodge" && chkStereo.Checked == true && rbTwo.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Dodge_Price * 2));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));

            }
            else if (lstBrand.Text == "Dodge" && chkStereo.Checked == true && rbFour.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Dodge_Price * 4));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }
            else if (lstBrand.Text == "Dodge" && chkStereo.Checked == true && rbEight.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Dodge_Price * 8));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }

            //-----------------------------------------------------------------------------------------------------------------------
            //DODGE// PART2
            if (lstBrand.Text == "Dodge" && chkStereo.Checked == true && rbOne.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Dodge_Price * 1.1));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }
            else if (lstBrand.Text == "Dodge" && chkStereo.Checked == true && rbTwo.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Dodge_Price * 2.1));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));

            }
            else if (lstBrand.Text == "Dodge" && chkStereo.Checked == true && rbFour.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Dodge_Price * 4.1));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }
            else if (lstBrand.Text == "Dodge" && chkStereo.Checked == true && rbEight.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Dodge_Price * 8.1));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }


            //-----------------------------------------------------------------------------------------------------------------------
            //DODGE// PART3
            if (lstBrand.Text == "Dodge" && chkStereo.Checked == true && rbOne.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Dodge_Price * 1.2));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }
            else if (lstBrand.Text == "Dodge" && chkStereo.Checked == true && rbTwo.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Dodge_Price * 2.2));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));

            }
            else if (lstBrand.Text == "Dodge" && chkStereo.Checked == true && rbFour.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Dodge_Price * 4.2));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }
            else if (lstBrand.Text == "Dodge" && chkStereo.Checked == true && rbEight.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Dodge_Price * 8.2));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }

            //--------------------------------------------------------------------------------------------------------------------------------
            //FERRARI// PART1
            if (lstBrand.Text == "Ferrari" && chkStereo.Checked == true && rbOne.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Ferrari_Price * 1));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }
            else if (lstBrand.Text == "Ferrari" && chkStereo.Checked == true && rbTwo.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Ferrari_Price * 2));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));

            }
            else if (lstBrand.Text == "Ferrari" && chkStereo.Checked == true && rbFour.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Ferrari_Price * 4));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }
            else if (lstBrand.Text == "Ferrari" && chkStereo.Checked == true && rbEight.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Ferrari_Price * 8));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }

            //-----------------------------------------------------------------------------------------------------------------------
            //FERRARI// PART2
            if (lstBrand.Text == "Ferrari" && chkStereo.Checked == true && rbOne.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Ferrari_Price * 1.1));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }
            else if (lstBrand.Text == "Ferrari" && chkStereo.Checked == true && rbTwo.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Ferrari_Price * 2.1));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));

            }
            else if (lstBrand.Text == "Ferrari" && chkStereo.Checked == true && rbFour.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Ferrari_Price * 4.1));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }
            else if (lstBrand.Text == "Ferrari" && chkStereo.Checked == true && rbEight.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Ferrari_Price * 8.1));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }

            //-----------------------------------------------------------------------------------------------------------------------
            //FERRARI// PART3
            if (lstBrand.Text == "Ferrari" && chkStereo.Checked == true && rbOne.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Ferrari_Price * 1.2));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }
            else if (lstBrand.Text == "Ferrari" && chkStereo.Checked == true && rbTwo.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Ferrari_Price * 2.2));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));

            }
            else if (lstBrand.Text == "Ferrari" && chkStereo.Checked == true && rbFour.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Ferrari_Price * 4.2));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }
            else if (lstBrand.Text == "Ferrari" && chkStereo.Checked == true && rbEight.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Ferrari_Price * 8.2));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }


            //--------------------------------------------------------------------------------------------------------------------------------
            //FIAT// PART1
            if (lstBrand.Text == "Fiat" && chkStereo.Checked == true && rbOne.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Fiat_Price * 1));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }
            else if (lstBrand.Text == "Fiat" && chkStereo.Checked == true && rbTwo.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Fiat_Price * 2));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));

            }
            else if (lstBrand.Text == "Fiat" && chkStereo.Checked == true && rbFour.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Fiat_Price * 4));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }
            else if (lstBrand.Text == "Fiat" && chkStereo.Checked == true && rbEight.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Fiat_Price * 8));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }

            //-----------------------------------------------------------------------------------------------------------------------
            //FIAT// PART2
            if (lstBrand.Text == "Fiat" && chkStereo.Checked == true && rbOne.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Fiat_Price * 1.1));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }
            else if (lstBrand.Text == "Fiat" && chkStereo.Checked == true && rbTwo.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Fiat_Price * 2.1));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));

            }
            else if (lstBrand.Text == "Fiat" && chkStereo.Checked == true && rbFour.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Fiat_Price * 4.1));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }
            else if (lstBrand.Text == "Fiat" && chkStereo.Checked == true && rbEight.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Fiat_Price * 8.1));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }


            //-----------------------------------------------------------------------------------------------------------------------
            //FIAT// PART3
            if (lstBrand.Text == "Fiat" && chkStereo.Checked == true && rbOne.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Fiat_Price * 1.2));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }
            else if (lstBrand.Text == "Fiat" && chkStereo.Checked == true && rbTwo.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Fiat_Price * 2.2));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));

            }
            else if (lstBrand.Text == "Fiat" && chkStereo.Checked == true && rbFour.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Fiat_Price * 4.2));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }
            else if (lstBrand.Text == "Fiat" && chkStereo.Checked == true && rbEight.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Fiat_Price * 8.2));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }

            //--------------------------------------------------------------------------------------------------------------------------------
            //FORD// PART1
            if (lstBrand.Text == "Ford" && chkStereo.Checked == true && rbOne.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Ford_Price * 1));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }
            else if (lstBrand.Text == "Ford" && chkStereo.Checked == true && rbTwo.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Ford_Price * 2));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));

            }
            else if (lstBrand.Text == "Ford" && chkStereo.Checked == true && rbFour.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Ford_Price * 4));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }
            else if (lstBrand.Text == "Ford" && chkStereo.Checked == true && rbEight.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Ford_Price * 8));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }


            //-----------------------------------------------------------------------------------------------------------------------
            //FORD// PART2
            if (lstBrand.Text == "Ford" && chkStereo.Checked == true && rbOne.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Ford_Price * 1.1));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }
            else if (lstBrand.Text == "Ford" && chkStereo.Checked == true && rbTwo.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Ford_Price * 2.1));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));

            }
            else if (lstBrand.Text == "Ford" && chkStereo.Checked == true && rbFour.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Ford_Price * 4.1));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }
            else if (lstBrand.Text == "Ford" && chkStereo.Checked == true && rbEight.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Ford_Price * 8.1));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }


            //-----------------------------------------------------------------------------------------------------------------------
            //FORD// PART3
            if (lstBrand.Text == "Ford" && chkStereo.Checked == true && rbOne.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Ford_Price * 1.2));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }
            else if (lstBrand.Text == "Ford" && chkStereo.Checked == true && rbTwo.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Ford_Price * 2.2));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));

            }
            else if (lstBrand.Text == "Ford" && chkStereo.Checked == true && rbFour.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Ford_Price * 4.2));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }
            else if (lstBrand.Text == "Ford" && chkStereo.Checked == true && rbEight.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Ford_Price * 8.2));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }


            //--------------------------------------------------------------------------------------------------------------------------------
            //GEELY// PART1
            if (lstBrand.Text == "Geely" && chkStereo.Checked == true && rbOne.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Geely_Price * 1));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }
            else if (lstBrand.Text == "Geely" && chkStereo.Checked == true && rbTwo.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Geely_Price * 2));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));

            }
            else if (lstBrand.Text == "Geely" && chkStereo.Checked == true && rbFour.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Geely_Price * 4));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }
            else if (lstBrand.Text == "Geely" && chkStereo.Checked == true && rbEight.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Geely_Price * 8));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }

            //-----------------------------------------------------------------------------------------------------------------------
            //GEELY// PART2
            if (lstBrand.Text == "Geely" && chkStereo.Checked == true && rbOne.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Geely_Price * 1.1));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }
            else if (lstBrand.Text == "Geely" && chkStereo.Checked == true && rbTwo.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Geely_Price * 2.1));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));

            }
            else if (lstBrand.Text == "Geely" && chkStereo.Checked == true && rbFour.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Geely_Price * 4.1));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }
            else if (lstBrand.Text == "Geely" && chkStereo.Checked == true && rbEight.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Geely_Price * 8.1));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }

            //-----------------------------------------------------------------------------------------------------------------------
            //GEELY// PART3
            if (lstBrand.Text == "Geely" && chkStereo.Checked == true && rbOne.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Geely_Price * 1.2));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }
            else if (lstBrand.Text == "Geely" && chkStereo.Checked == true && rbTwo.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Geely_Price * 2.2));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));

            }
            else if (lstBrand.Text == "Geely" && chkStereo.Checked == true && rbFour.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Geely_Price * 4.2));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }
            else if (lstBrand.Text == "Geely" && chkStereo.Checked == true && rbEight.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Geely_Price * 8.2));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }

            //--------------------------------------------------------------------------------------------------------------------------------
            //GENERAL MOTORS// PART1
            if (lstBrand.Text == "General Motors" && chkStereo.Checked == true && rbOne.Checked == true)
            {
                Price = String.Format(("{0:C}"), (General_Motors_Price * 1));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }
            else if (lstBrand.Text == "General Motors" && chkStereo.Checked == true && rbTwo.Checked == true)
            {
                Price = String.Format(("{0:C}"), (General_Motors_Price * 2));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));

            }
            else if (lstBrand.Text == "General Motors" && chkStereo.Checked == true && rbFour.Checked == true)
            {
                Price = String.Format(("{0:C}"), (General_Motors_Price * 4));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }
            else if (lstBrand.Text == "General Motors" && chkStereo.Checked == true && rbEight.Checked == true)
            {
                Price = String.Format(("{0:C}"), (General_Motors_Price * 8));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }

            //-----------------------------------------------------------------------------------------------------------------------
            //GENERAL MOTORS// PART2
            if (lstBrand.Text == "General Motors" && chkStereo.Checked == true && rbOne.Checked == true)
            {
                Price = String.Format(("{0:C}"), (General_Motors_Price * 1.1));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }
            else if (lstBrand.Text == "General Motors" && chkStereo.Checked == true && rbTwo.Checked == true)
            {
                Price = String.Format(("{0:C}"), (General_Motors_Price * 2.1));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));

            }
            else if (lstBrand.Text == "General Motors" && chkStereo.Checked == true && rbFour.Checked == true)
            {
                Price = String.Format(("{0:C}"), (General_Motors_Price * 4.1));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }
            else if (lstBrand.Text == "General Motors" && chkStereo.Checked == true && rbEight.Checked == true)
            {
                Price = String.Format(("{0:C}"), (General_Motors_Price * 8.1));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }

            //-----------------------------------------------------------------------------------------------------------------------
            //GENERAL MOTORS// PART3
            if (lstBrand.Text == "General Motors" && chkStereo.Checked == true && rbOne.Checked == true)
            {
                Price = String.Format(("{0:C}"), (General_Motors_Price * 1.2));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }
            else if (lstBrand.Text == "General Motors" && chkStereo.Checked == true && rbTwo.Checked == true)
            {
                Price = String.Format(("{0:C}"), (General_Motors_Price * 2.2));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));

            }
            else if (lstBrand.Text == "General Motors" && chkStereo.Checked == true && rbFour.Checked == true)
            {
                Price = String.Format(("{0:C}"), (General_Motors_Price * 4.2));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }
            else if (lstBrand.Text == "General Motors" && chkStereo.Checked == true && rbEight.Checked == true)
            {
                Price = String.Format(("{0:C}"), (General_Motors_Price * 8.2));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }


            //--------------------------------------------------------------------------------------------------------------------------------
            //GMC// PART1
            if (lstBrand.Text == "GMC" && chkStereo.Checked == true && rbOne.Checked == true)
            {
                Price = String.Format(("{0:C}"), (GMC_Price * 1));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }
            else if (lstBrand.Text == "GMC" && chkStereo.Checked == true && rbTwo.Checked == true)
            {
                Price = String.Format(("{0:C}"), (GMC_Price * 2));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));

            }
            else if (lstBrand.Text == "GMC" && chkStereo.Checked == true && rbFour.Checked == true)
            {
                Price = String.Format(("{0:C}"), (GMC_Price * 4));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }
            else if (lstBrand.Text == "GMC" && chkStereo.Checked == true && rbEight.Checked == true)
            {
                Price = String.Format(("{0:C}"), (GMC_Price * 8));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }


            //-----------------------------------------------------------------------------------------------------------------------
            //GMC// PART2
            if (lstBrand.Text == "GMC" && chkStereo.Checked == true && rbOne.Checked == true)
            {
                Price = String.Format(("{0:C}"), (GMC_Price * 1.1));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }
            else if (lstBrand.Text == "GMC" && chkStereo.Checked == true && rbTwo.Checked == true)
            {
                Price = String.Format(("{0:C}"), (GMC_Price * 2.1));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));

            }
            else if (lstBrand.Text == "GMC" && chkStereo.Checked == true && rbFour.Checked == true)
            {
                Price = String.Format(("{0:C}"), (GMC_Price * 4.1));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }
            else if (lstBrand.Text == "GMC" && chkStereo.Checked == true && rbEight.Checked == true)
            {
                Price = String.Format(("{0:C}"), (GMC_Price * 8.1));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }


            //-----------------------------------------------------------------------------------------------------------------------
            //GMC// PART3
            if (lstBrand.Text == "GMC" && chkStereo.Checked == true && rbOne.Checked == true)
            {
                Price = String.Format(("{0:C}"), (GMC_Price * 1.2));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }
            else if (lstBrand.Text == "GMC" && chkStereo.Checked == true && rbTwo.Checked == true)
            {
                Price = String.Format(("{0:C}"), (GMC_Price * 2.2));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));

            }
            else if (lstBrand.Text == "GMC" && chkStereo.Checked == true && rbFour.Checked == true)
            {
                Price = String.Format(("{0:C}"), (GMC_Price * 4.2));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }
            else if (lstBrand.Text == "GMC" && chkStereo.Checked == true && rbEight.Checked == true)
            {
                Price = String.Format(("{0:C}"), (GMC_Price * 8.2));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }

            //--------------------------------------------------------------------------------------------------------------------------------
            //HONDA// PART1
            if (lstBrand.Text == "Honda" && chkStereo.Checked == true && rbOne.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Honda_Price * 1));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }
            else if (lstBrand.Text == "Honda" && chkStereo.Checked == true && rbTwo.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Honda_Price * 2));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));

            }
            else if (lstBrand.Text == "Honda" && chkStereo.Checked == true && rbFour.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Honda_Price * 4));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }
            else if (lstBrand.Text == "Honda" && chkStereo.Checked == true && rbEight.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Honda_Price * 8));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }

            //-----------------------------------------------------------------------------------------------------------------------
            //HONDA// PART2
            if (lstBrand.Text == "Honda" && chkStereo.Checked == true && rbOne.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Honda_Price * 1.1));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }
            else if (lstBrand.Text == "Honda" && chkStereo.Checked == true && rbTwo.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Honda_Price * 2.1));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));

            }
            else if (lstBrand.Text == "Honda" && chkStereo.Checked == true && rbFour.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Honda_Price * 4.1));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }
            else if (lstBrand.Text == "Honda" && chkStereo.Checked == true && rbEight.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Honda_Price * 8.1));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }


            //-----------------------------------------------------------------------------------------------------------------------
            //HONDA// PART3
            if (lstBrand.Text == "Honda" && chkStereo.Checked == true && rbOne.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Honda_Price * 1.2));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }
            else if (lstBrand.Text == "Honda" && chkStereo.Checked == true && rbTwo.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Honda_Price * 2.2));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));

            }
            else if (lstBrand.Text == "Honda" && chkStereo.Checked == true && rbFour.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Honda_Price * 4.2));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }
            else if (lstBrand.Text == "Honda" && chkStereo.Checked == true && rbEight.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Honda_Price * 8.2));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }

            //--------------------------------------------------------------------------------------------------------------------------------
            //HYUNDAI// PART1
            if (lstBrand.Text == "Hyundai" && chkStereo.Checked == true && rbOne.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Hyundai_Price * 1));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }
            else if (lstBrand.Text == "Hyundai" && chkStereo.Checked == true && rbTwo.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Hyundai_Price * 2));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));

            }
            else if (lstBrand.Text == "Hyundai" && chkStereo.Checked == true && rbFour.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Hyundai_Price * 4));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }
            else if (lstBrand.Text == "Hyundai" && chkStereo.Checked == true && rbEight.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Hyundai_Price * 8));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }


            //-----------------------------------------------------------------------------------------------------------------------
            //HYUNDAI// PART2
            if (lstBrand.Text == "Hyundai" && chkStereo.Checked == true && rbOne.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Hyundai_Price * 1.1));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }
            else if (lstBrand.Text == "Hyundai" && chkStereo.Checked == true && rbTwo.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Hyundai_Price * 2.1));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));

            }
            else if (lstBrand.Text == "Hyundai" && chkStereo.Checked == true && rbFour.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Hyundai_Price * 4.1));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }
            else if (lstBrand.Text == "Hyundai" && chkStereo.Checked == true && rbEight.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Hyundai_Price * 8.1));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }


            //-----------------------------------------------------------------------------------------------------------------------
            //HYUNDAI// PART3
            if (lstBrand.Text == "Hyundai" && chkStereo.Checked == true && rbOne.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Hyundai_Price * 1.2));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }
            else if (lstBrand.Text == "Hyundai" && chkStereo.Checked == true && rbTwo.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Hyundai_Price * 2.2));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));

            }
            else if (lstBrand.Text == "Hyundai" && chkStereo.Checked == true && rbFour.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Hyundai_Price * 4.2));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }
            else if (lstBrand.Text == "Hyundai" && chkStereo.Checked == true && rbEight.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Hyundai_Price * 8.2));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }

            //--------------------------------------------------------------------------------------------------------------------------------
            //IFINITI// PART1
            if (lstBrand.Text == "Infiniti" && chkStereo.Checked == true && rbOne.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Infiniti_Price * 1));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }
            else if (lstBrand.Text == "Infiniti" && chkStereo.Checked == true && rbTwo.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Infiniti_Price * 2));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));

            }
            else if (lstBrand.Text == "Infiniti" && chkStereo.Checked == true && rbFour.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Infiniti_Price * 4));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }
            else if (lstBrand.Text == "Infiniti" && chkStereo.Checked == true && rbEight.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Infiniti_Price * 8));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }

            //-----------------------------------------------------------------------------------------------------------------------
            //IFINITI// PART2
            if (lstBrand.Text == "Infiniti" && chkStereo.Checked == true && rbOne.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Infiniti_Price * 1.1));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }
            else if (lstBrand.Text == "Infiniti" && chkStereo.Checked == true && rbTwo.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Infiniti_Price * 2.1));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));

            }
            else if (lstBrand.Text == "Infiniti" && chkStereo.Checked == true && rbFour.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Infiniti_Price * 4.1));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }
            else if (lstBrand.Text == "Infiniti" && chkStereo.Checked == true && rbEight.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Infiniti_Price * 8.1));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }


            //-----------------------------------------------------------------------------------------------------------------------
            //IFINITI// PART3
            if (lstBrand.Text == "Infiniti" && chkStereo.Checked == true && rbOne.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Infiniti_Price * 1.2));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }
            else if (lstBrand.Text == "Infiniti" && chkStereo.Checked == true && rbTwo.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Infiniti_Price * 2.2));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));

            }
            else if (lstBrand.Text == "Infiniti" && chkStereo.Checked == true && rbFour.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Infiniti_Price * 4.2));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }
            else if (lstBrand.Text == "Infiniti" && chkStereo.Checked == true && rbEight.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Infiniti_Price * 8.2));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }

            //--------------------------------------------------------------------------------------------------------------------------------
            //JAGUAR// PART1
            if (lstBrand.Text == "Jaguar" && chkStereo.Checked == true && rbOne.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Jaguar_Price * 1));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }
            else if (lstBrand.Text == "Jaguar" && chkStereo.Checked == true && rbTwo.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Jaguar_Price * 2));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));

            }
            else if (lstBrand.Text == "Jaguar" && chkStereo.Checked == true && rbFour.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Jaguar_Price * 4));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }
            else if (lstBrand.Text == "Jaguar" && chkStereo.Checked == true && rbEight.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Jaguar_Price * 8));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }


            //-----------------------------------------------------------------------------------------------------------------------
            //JAGUAR// PART2
            if (lstBrand.Text == "Jaguar" && chkStereo.Checked == true && rbOne.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Jaguar_Price * 1.1));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }
            else if (lstBrand.Text == "Jaguar" && chkStereo.Checked == true && rbTwo.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Jaguar_Price * 2.1));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));

            }
            else if (lstBrand.Text == "Jaguar" && chkStereo.Checked == true && rbFour.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Jaguar_Price * 4.1));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }
            else if (lstBrand.Text == "Jaguar" && chkStereo.Checked == true && rbEight.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Jaguar_Price * 8.1));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }

            //-----------------------------------------------------------------------------------------------------------------------
            //JAGUAR// PART3
            if (lstBrand.Text == "Jaguar" && chkStereo.Checked == true && rbOne.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Jaguar_Price * 1.2));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }
            else if (lstBrand.Text == "Jaguar" && chkStereo.Checked == true && rbTwo.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Jaguar_Price * 2.2));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));

            }
            else if (lstBrand.Text == "Jaguar" && chkStereo.Checked == true && rbFour.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Jaguar_Price * 4.2));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }
            else if (lstBrand.Text == "Jaguar" && chkStereo.Checked == true && rbEight.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Jaguar_Price * 8.2));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }

            //--------------------------------------------------------------------------------------------------------------------------------
            //JEEP// PART1
            if (lstBrand.Text == "Jeep" && chkStereo.Checked == true && rbOne.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Jeep_Price * 1));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }
            else if (lstBrand.Text == "Jeep" && chkStereo.Checked == true && rbTwo.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Jeep_Price * 2));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));

            }
            else if (lstBrand.Text == "Jeep" && chkStereo.Checked == true && rbFour.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Jeep_Price * 4));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }
            else if (lstBrand.Text == "Jeep" && chkStereo.Checked == true && rbEight.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Jeep_Price * 8));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }

            //-----------------------------------------------------------------------------------------------------------------------
            //JEEP// PART2
            if (lstBrand.Text == "Jeep" && chkStereo.Checked == true && rbOne.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Jeep_Price * 1.1));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }
            else if (lstBrand.Text == "Jeep" && chkStereo.Checked == true && rbTwo.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Jeep_Price * 2.1));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));

            }
            else if (lstBrand.Text == "Jeep" && chkStereo.Checked == true && rbFour.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Jeep_Price * 4.1));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }
            else if (lstBrand.Text == "Jeep" && chkStereo.Checked == true && rbEight.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Jeep_Price * 8.1));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }

            //-----------------------------------------------------------------------------------------------------------------------
            //JEEP// PART3
            if (lstBrand.Text == "Jeep" && chkStereo.Checked == true && rbOne.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Jeep_Price * 1.2));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }
            else if (lstBrand.Text == "Jeep" && chkStereo.Checked == true && rbTwo.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Jeep_Price * 2.2));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));

            }
            else if (lstBrand.Text == "Jeep" && chkStereo.Checked == true && rbFour.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Jeep_Price * 4.2));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }
            else if (lstBrand.Text == "Jeep" && chkStereo.Checked == true && rbEight.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Jeep_Price * 8.2));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }

            //--------------------------------------------------------------------------------------------------------------------------------
            //KIA// PART1
            if (lstBrand.Text == "KIA" && chkStereo.Checked == true && rbOne.Checked == true)
            {
                Price = String.Format(("{0:C}"), (KIA_Price * 1));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }
            else if (lstBrand.Text == "KIA" && chkStereo.Checked == true && rbTwo.Checked == true)
            {
                Price = String.Format(("{0:C}"), (KIA_Price * 2));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));

            }
            else if (lstBrand.Text == "KIA" && chkStereo.Checked == true && rbFour.Checked == true)
            {
                Price = String.Format(("{0:C}"), (KIA_Price * 4));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }
            else if (lstBrand.Text == "KIA" && chkStereo.Checked == true && rbEight.Checked == true)
            {
                Price = String.Format(("{0:C}"), (KIA_Price * 8));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }

            //-----------------------------------------------------------------------------------------------------------------------
            //KIA// PART2
            if (lstBrand.Text == "KIA" && chkStereo.Checked == true && rbOne.Checked == true)
            {
                Price = String.Format(("{0:C}"), (KIA_Price * 1.1));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }
            else if (lstBrand.Text == "KIA" && chkStereo.Checked == true && rbTwo.Checked == true)
            {
                Price = String.Format(("{0:C}"), (KIA_Price * 2.1));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));

            }
            else if (lstBrand.Text == "KIA" && chkStereo.Checked == true && rbFour.Checked == true)
            {
                Price = String.Format(("{0:C}"), (KIA_Price * 4.1));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }
            else if (lstBrand.Text == "KIA" && chkStereo.Checked == true && rbEight.Checked == true)
            {
                Price = String.Format(("{0:C}"), (KIA_Price * 8.1));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }

            //-----------------------------------------------------------------------------------------------------------------------
            //KIA// PART3
            if (lstBrand.Text == "KIA" && chkStereo.Checked == true && rbOne.Checked == true)
            {
                Price = String.Format(("{0:C}"), (KIA_Price * 1.2));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }
            else if (lstBrand.Text == "KIA" && chkStereo.Checked == true && rbTwo.Checked == true)
            {
                Price = String.Format(("{0:C}"), (KIA_Price * 2.2));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));

            }
            else if (lstBrand.Text == "KIA" && chkStereo.Checked == true && rbFour.Checked == true)
            {
                Price = String.Format(("{0:C}"), (KIA_Price * 4.2));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }
            else if (lstBrand.Text == "KIA" && chkStereo.Checked == true && rbEight.Checked == true)
            {
                Price = String.Format(("{0:C}"), (KIA_Price * 8.2));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }

            //--------------------------------------------------------------------------------------------------------------------------------
            //KOENIGSEGG// PART1
            if (lstBrand.Text == "Koenigsegg" && chkStereo.Checked == true && rbOne.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Koenigsegg_Price * 1));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }
            else if (lstBrand.Text == "Koenigsegg" && chkStereo.Checked == true && rbTwo.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Koenigsegg_Price * 2));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));

            }
            else if (lstBrand.Text == "Koenigsegg" && chkStereo.Checked == true && rbFour.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Koenigsegg_Price * 4));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }
            else if (lstBrand.Text == "Koenigsegg" && chkStereo.Checked == true && rbEight.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Koenigsegg_Price * 8));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }

            //-----------------------------------------------------------------------------------------------------------------------
            //KOENIGSEGG// PART2
            if (lstBrand.Text == "Koenigsegg" && chkStereo.Checked == true && rbOne.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Koenigsegg_Price * 1.1));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }
            else if (lstBrand.Text == "Koenigsegg" && chkStereo.Checked == true && rbTwo.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Koenigsegg_Price * 2.1));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));

            }
            else if (lstBrand.Text == "Koenigsegg" && chkStereo.Checked == true && rbFour.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Koenigsegg_Price * 4.1));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }
            else if (lstBrand.Text == "Koenigsegg" && chkStereo.Checked == true && rbEight.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Koenigsegg_Price * 8.1));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }

            //-----------------------------------------------------------------------------------------------------------------------
            //KOENIGSEGG// PART3
            if (lstBrand.Text == "Koenigsegg" && chkStereo.Checked == true && rbOne.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Koenigsegg_Price * 1.2));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }
            else if (lstBrand.Text == "Koenigsegg" && chkStereo.Checked == true && rbTwo.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Koenigsegg_Price * 2.2));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));

            }
            else if (lstBrand.Text == "Koenigsegg" && chkStereo.Checked == true && rbFour.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Koenigsegg_Price * 4.2));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }
            else if (lstBrand.Text == "Koenigsegg" && chkStereo.Checked == true && rbEight.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Koenigsegg_Price * 8.2));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }

            //--------------------------------------------------------------------------------------------------------------------------------
            //LAMBORGHINI// PART1
            if (lstBrand.Text == "Lamborghini" && chkStereo.Checked == true && rbOne.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Lamborghini_Price * 1));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }
            else if (lstBrand.Text == "Lamborghini" && chkStereo.Checked == true && rbTwo.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Lamborghini_Price * 2));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));

            }
            else if (lstBrand.Text == "Lamborghini" && chkStereo.Checked == true && rbFour.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Lamborghini_Price * 4));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }
            else if (lstBrand.Text == "Lamborghini" && chkStereo.Checked == true && rbEight.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Lamborghini_Price * 8));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }

            //-----------------------------------------------------------------------------------------------------------------------
            //LAMBORGHINI// PART2
            if (lstBrand.Text == "Lamborghini" && chkStereo.Checked == true && rbOne.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Lamborghini_Price * 1.1));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }
            else if (lstBrand.Text == "Lamborghini" && chkStereo.Checked == true && rbTwo.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Lamborghini_Price * 2.1));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));

            }
            else if (lstBrand.Text == "Lamborghini" && chkStereo.Checked == true && rbFour.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Lamborghini_Price * 4.1));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }
            else if (lstBrand.Text == "Lamborghini" && chkStereo.Checked == true && rbEight.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Lamborghini_Price * 8.1));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }

            //-----------------------------------------------------------------------------------------------------------------------
            //LAMBORGHINI// PART3
            if (lstBrand.Text == "Lamborghini" && chkStereo.Checked == true && rbOne.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Lamborghini_Price * 1.2));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }
            else if (lstBrand.Text == "Lamborghini" && chkStereo.Checked == true && rbTwo.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Lamborghini_Price * 2.2));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));

            }
            else if (lstBrand.Text == "Lamborghini" && chkStereo.Checked == true && rbFour.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Lamborghini_Price * 4.2));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }
            else if (lstBrand.Text == "Lamborghini" && chkStereo.Checked == true && rbEight.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Lamborghini_Price * 8.2));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }

            //--------------------------------------------------------------------------------------------------------------------------------
            //LAND ROVER// PART1
            if (lstBrand.Text == "Land Rover" && chkStereo.Checked == true && rbOne.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Land_Rover_Price * 1));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }
            else if (lstBrand.Text == "Land Rover" && chkStereo.Checked == true && rbTwo.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Land_Rover_Price * 2));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));

            }
            else if (lstBrand.Text == "Land Rover" && chkStereo.Checked == true && rbFour.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Land_Rover_Price * 4));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }
            else if (lstBrand.Text == "Land Rover" && chkStereo.Checked == true && rbEight.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Land_Rover_Price * 8));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }

            //-----------------------------------------------------------------------------------------------------------------------
            //LAND ROVER// PART2
            if (lstBrand.Text == "Land Rover" && chkStereo.Checked == true && rbOne.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Land_Rover_Price * 1.1));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }
            else if (lstBrand.Text == "Land Rover" && chkStereo.Checked == true && rbTwo.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Land_Rover_Price * 2.1));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));

            }
            else if (lstBrand.Text == "Land Rover" && chkStereo.Checked == true && rbFour.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Land_Rover_Price * 4.1));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }
            else if (lstBrand.Text == "Land Rover" && chkStereo.Checked == true && rbEight.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Land_Rover_Price * 8.1));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }

            //-----------------------------------------------------------------------------------------------------------------------
            //LAND ROVER// PART3
            if (lstBrand.Text == "Land Rover" && chkStereo.Checked == true && rbOne.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Land_Rover_Price * 1.2));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }
            else if (lstBrand.Text == "Land Rover" && chkStereo.Checked == true && rbTwo.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Land_Rover_Price * 2.2));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));

            }
            else if (lstBrand.Text == "Land Rover" && chkStereo.Checked == true && rbFour.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Land_Rover_Price * 4.2));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }
            else if (lstBrand.Text == "Land Rover" && chkStereo.Checked == true && rbEight.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Land_Rover_Price * 8.2));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }

            //--------------------------------------------------------------------------------------------------------------------------------
            //LEXUS// PART1
            if (lstBrand.Text == "Lexus" && chkStereo.Checked == true && rbOne.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Lexus_Price * 1));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }
            else if (lstBrand.Text == "Lexus" && chkStereo.Checked == true && rbTwo.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Lexus_Price * 2));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));

            }
            else if (lstBrand.Text == "Lexus" && chkStereo.Checked == true && rbFour.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Lexus_Price * 4));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }
            else if (lstBrand.Text == "Lexus" && chkStereo.Checked == true && rbEight.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Lexus_Price * 8));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }

            //-----------------------------------------------------------------------------------------------------------------------
            //LEXUS// PART2
            if (lstBrand.Text == "Lexus" && chkStereo.Checked == true && rbOne.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Lexus_Price * 1.1));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }
            else if (lstBrand.Text == "Lexus" && chkStereo.Checked == true && rbTwo.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Lexus_Price * 2.1));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));

            }
            else if (lstBrand.Text == "Lexus" && chkStereo.Checked == true && rbFour.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Lexus_Price * 4.1));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }
            else if (lstBrand.Text == "Lexus" && chkStereo.Checked == true && rbEight.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Lexus_Price * 8.1));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }

            //-----------------------------------------------------------------------------------------------------------------------
            //LEXUS// PART3
            if (lstBrand.Text == "Lexus" && chkStereo.Checked == true && rbOne.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Lexus_Price * 1.2));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }
            else if (lstBrand.Text == "Lexus" && chkStereo.Checked == true && rbTwo.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Lexus_Price * 2.2));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));

            }
            else if (lstBrand.Text == "Lexus" && chkStereo.Checked == true && rbFour.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Lexus_Price * 4.2));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }
            else if (lstBrand.Text == "Lexus" && chkStereo.Checked == true && rbEight.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Lexus_Price * 8.2));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }

            //--------------------------------------------------------------------------------------------------------------------------------
            //MASERATI// PART1
            if (lstBrand.Text == "Maserati" && chkStereo.Checked == true && rbOne.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Maserati_Price * 1));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }
            else if (lstBrand.Text == "Maserati" && chkStereo.Checked == true && rbTwo.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Maserati_Price * 2));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));

            }
            else if (lstBrand.Text == "Maserati" && chkStereo.Checked == true && rbFour.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Maserati_Price * 4));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }
            else if (lstBrand.Text == "Maserati" && chkStereo.Checked == true && rbEight.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Maserati_Price * 8));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }

            //-----------------------------------------------------------------------------------------------------------------------
            //MASERATI// PART2
            if (lstBrand.Text == "Maserati" && chkStereo.Checked == true && rbOne.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Maserati_Price * 1.1));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }
            else if (lstBrand.Text == "Maserati" && chkStereo.Checked == true && rbTwo.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Maserati_Price * 2.1));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));

            }
            else if (lstBrand.Text == "Maserati" && chkStereo.Checked == true && rbFour.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Maserati_Price * 4.1));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }
            else if (lstBrand.Text == "Maserati" && chkStereo.Checked == true && rbEight.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Maserati_Price * 8.1));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }

            //-----------------------------------------------------------------------------------------------------------------------
            //MASERATI// PART3
            if (lstBrand.Text == "Maserati" && chkStereo.Checked == true && rbOne.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Maserati_Price * 1.2));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }
            else if (lstBrand.Text == "Maserati" && chkStereo.Checked == true && rbTwo.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Maserati_Price * 2.2));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));

            }
            else if (lstBrand.Text == "Maserati" && chkStereo.Checked == true && rbFour.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Maserati_Price * 4.2));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }
            else if (lstBrand.Text == "Maserati" && chkStereo.Checked == true && rbEight.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Maserati_Price * 8.2));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }

            //--------------------------------------------------------------------------------------------------------------------------------
            //MAZDA// PART1
            if (lstBrand.Text == "Mazda" && chkStereo.Checked == true && rbOne.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Mazda_Price * 1));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }
            else if (lstBrand.Text == "Mazda" && chkStereo.Checked == true && rbTwo.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Mazda_Price * 2));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));

            }
            else if (lstBrand.Text == "Mazda" && chkStereo.Checked == true && rbFour.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Mazda_Price * 4));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }
            else if (lstBrand.Text == "Mazda" && chkStereo.Checked == true && rbEight.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Mazda_Price * 8));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }

            //-----------------------------------------------------------------------------------------------------------------------
            //MAZDA// PART2
            if (lstBrand.Text == "Mazda" && chkStereo.Checked == true && rbOne.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Mazda_Price * 1.1));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }
            else if (lstBrand.Text == "Mazda" && chkStereo.Checked == true && rbTwo.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Mazda_Price * 2.1));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));

            }
            else if (lstBrand.Text == "Mazda" && chkStereo.Checked == true && rbFour.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Mazda_Price * 4.1));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }
            else if (lstBrand.Text == "Mazda" && chkStereo.Checked == true && rbEight.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Mazda_Price * 8.1));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }

            //-----------------------------------------------------------------------------------------------------------------------
            //MAZDA// PART3
            if (lstBrand.Text == "Mazda" && chkStereo.Checked == true && rbOne.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Mazda_Price * 1.2));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }
            else if (lstBrand.Text == "Mazda" && chkStereo.Checked == true && rbTwo.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Mazda_Price * 2.2));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));

            }
            else if (lstBrand.Text == "Mazda" && chkStereo.Checked == true && rbFour.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Mazda_Price * 4.2));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }
            else if (lstBrand.Text == "Mazda" && chkStereo.Checked == true && rbEight.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Mazda_Price * 8.2));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }

            //--------------------------------------------------------------------------------------------------------------------------------
            //MCLAREN// PART1
            if (lstBrand.Text == "Mclaren" && chkStereo.Checked == true && rbOne.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Mclaren_Price * 1));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }
            else if (lstBrand.Text == "Mclaren" && chkStereo.Checked == true && rbTwo.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Mclaren_Price * 2));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));

            }
            else if (lstBrand.Text == "Mclaren" && chkStereo.Checked == true && rbFour.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Mclaren_Price * 4));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }
            else if (lstBrand.Text == "Mclaren" && chkStereo.Checked == true && rbEight.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Mclaren_Price * 8));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }

            //-----------------------------------------------------------------------------------------------------------------------
            //MCLAREN// PART2
            if (lstBrand.Text == "Mclaren" && chkStereo.Checked == true && rbOne.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Mclaren_Price * 1.1));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }
            else if (lstBrand.Text == "Mclaren" && chkStereo.Checked == true && rbTwo.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Mclaren_Price * 2.1));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));

            }
            else if (lstBrand.Text == "Mclaren" && chkStereo.Checked == true && rbFour.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Mclaren_Price * 4.1));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }
            else if (lstBrand.Text == "Mclaren" && chkStereo.Checked == true && rbEight.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Mclaren_Price * 8.1));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }

            //-----------------------------------------------------------------------------------------------------------------------
            //MCLAREN// PART3
            if (lstBrand.Text == "Mclaren" && chkStereo.Checked == true && rbOne.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Mclaren_Price * 1.2));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }
            else if (lstBrand.Text == "Mclaren" && chkStereo.Checked == true && rbTwo.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Mclaren_Price * 2.2));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));

            }
            else if (lstBrand.Text == "Mclaren" && chkStereo.Checked == true && rbFour.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Mclaren_Price * 4.2));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }
            else if (lstBrand.Text == "Mclaren" && chkStereo.Checked == true && rbEight.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Mclaren_Price * 8.2));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }

            //--------------------------------------------------------------------------------------------------------------------------------
            //MERCEDES-BENZ// PART1
            if (lstBrand.Text == "Mercedes-Benz" && chkStereo.Checked == true && rbOne.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Mercedes_Benz_Price * 1));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }
            else if (lstBrand.Text == "Mercedes-Benz" && chkStereo.Checked == true && rbTwo.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Mercedes_Benz_Price * 2));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));

            }
            else if (lstBrand.Text == "Mercedes-Benz" && chkStereo.Checked == true && rbFour.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Mercedes_Benz_Price * 4));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }
            else if (lstBrand.Text == "Mercedes-Benz" && chkStereo.Checked == true && rbEight.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Mercedes_Benz_Price * 8));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }

            //-----------------------------------------------------------------------------------------------------------------------
            //MERCEDES-BENZ// PART2
            if (lstBrand.Text == "Mercedes-Benz" && chkStereo.Checked == true && rbOne.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Mercedes_Benz_Price * 1.1));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }
            else if (lstBrand.Text == "Mercedes-Benz" && chkStereo.Checked == true && rbTwo.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Mercedes_Benz_Price * 2.1));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));

            }
            else if (lstBrand.Text == "Mercedes-Benz" && chkStereo.Checked == true && rbFour.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Mercedes_Benz_Price * 4.1));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }
            else if (lstBrand.Text == "Mercedes-Benz" && chkStereo.Checked == true && rbEight.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Mercedes_Benz_Price * 8.1));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }

            //-----------------------------------------------------------------------------------------------------------------------
            //MERCEDES-BENZ// PART3
            if (lstBrand.Text == "Mercedes-Benz" && chkStereo.Checked == true && rbOne.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Mercedes_Benz_Price * 1.2));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }
            else if (lstBrand.Text == "Mercedes-Benz" && chkStereo.Checked == true && rbTwo.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Mercedes_Benz_Price * 2.2));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));

            }
            else if (lstBrand.Text == "Mercedes-Benz" && chkStereo.Checked == true && rbFour.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Mercedes_Benz_Price * 4.2));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }
            else if (lstBrand.Text == "Mercedes-Benz" && chkStereo.Checked == true && rbEight.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Mercedes_Benz_Price * 8.2));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }

            //--------------------------------------------------------------------------------------------------------------------------------
            //MINI// PART1
            if (lstBrand.Text == "Mini" && chkStereo.Checked == true && rbOne.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Mini_Price * 1));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }
            else if (lstBrand.Text == "Mini" && chkStereo.Checked == true && rbTwo.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Mini_Price * 2));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));

            }
            else if (lstBrand.Text == "Mini" && chkStereo.Checked == true && rbFour.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Mini_Price * 4));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }
            else if (lstBrand.Text == "Mini" && chkStereo.Checked == true && rbEight.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Mini_Price * 8));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }

            //-----------------------------------------------------------------------------------------------------------------------
            //MINI// PART2
            if (lstBrand.Text == "Mini" && chkStereo.Checked == true && rbOne.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Mini_Price * 1.1));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }
            else if (lstBrand.Text == "Mini" && chkStereo.Checked == true && rbTwo.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Mini_Price * 2.1));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));

            }
            else if (lstBrand.Text == "Mini" && chkStereo.Checked == true && rbFour.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Mini_Price * 4.1));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }
            else if (lstBrand.Text == "Mini" && chkStereo.Checked == true && rbEight.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Mini_Price * 8.1));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }

            //-----------------------------------------------------------------------------------------------------------------------
            //MINI// PART3
            if (lstBrand.Text == "Mini" && chkStereo.Checked == true && rbOne.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Mini_Price * 1.2));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }
            else if (lstBrand.Text == "Mini" && chkStereo.Checked == true && rbTwo.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Mini_Price * 2.2));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));

            }
            else if (lstBrand.Text == "Mini" && chkStereo.Checked == true && rbFour.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Mini_Price * 4.2));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }
            else if (lstBrand.Text == "Mini" && chkStereo.Checked == true && rbEight.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Mini_Price * 8.2));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }

            //--------------------------------------------------------------------------------------------------------------------------------
            //MITSUBISHI// PART1
            if (lstBrand.Text == "Mitsubishi" && chkStereo.Checked == true && rbOne.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Mitsubishi_Price * 1));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }
            else if (lstBrand.Text == "Mitsubishi" && chkStereo.Checked == true && rbTwo.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Mitsubishi_Price * 2));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));

            }
            else if (lstBrand.Text == "Mitsubishi" && chkStereo.Checked == true && rbFour.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Mitsubishi_Price * 4));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }
            else if (lstBrand.Text == "Mitsubishi" && chkStereo.Checked == true && rbEight.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Mitsubishi_Price * 8));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }

            //-----------------------------------------------------------------------------------------------------------------------
            //MITSUBISHI// PART2
            if (lstBrand.Text == "Mitsubishi" && chkStereo.Checked == true && rbOne.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Mitsubishi_Price * 1.1));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }
            else if (lstBrand.Text == "Mitsubishi" && chkStereo.Checked == true && rbTwo.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Mitsubishi_Price * 2.1));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));

            }
            else if (lstBrand.Text == "Mitsubishi" && chkStereo.Checked == true && rbFour.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Mitsubishi_Price * 4.1));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }
            else if (lstBrand.Text == "Mitsubishi" && chkStereo.Checked == true && rbEight.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Mitsubishi_Price * 8.1));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }

            //-----------------------------------------------------------------------------------------------------------------------
            //MITSUBISHI// PART3
            if (lstBrand.Text == "Mitsubishi" && chkStereo.Checked == true && rbOne.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Mitsubishi_Price * 1.2));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }
            else if (lstBrand.Text == "Mitsubishi" && chkStereo.Checked == true && rbTwo.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Mitsubishi_Price * 2.2));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));

            }
            else if (lstBrand.Text == "Mitsubishi" && chkStereo.Checked == true && rbFour.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Mitsubishi_Price * 4.2));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }
            else if (lstBrand.Text == "Mitsubishi" && chkStereo.Checked == true && rbEight.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Mitsubishi_Price * 8.2));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }

            //--------------------------------------------------------------------------------------------------------------------------------
            //MUSTANG// PART1
            if (lstBrand.Text == "Mustang" && chkStereo.Checked == true && rbOne.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Mustang_Price * 1));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }
            else if (lstBrand.Text == "Mustang" && chkStereo.Checked == true && rbTwo.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Mustang_Price * 2));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));

            }
            else if (lstBrand.Text == "Mustang" && chkStereo.Checked == true && rbFour.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Mustang_Price * 4));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }
            else if (lstBrand.Text == "Mustang" && chkStereo.Checked == true && rbEight.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Mustang_Price * 8));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }

            //-----------------------------------------------------------------------------------------------------------------------
            //MUSTANG// PART2
            if (lstBrand.Text == "Mustang" && chkStereo.Checked == true && rbOne.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Mustang_Price * 1.1));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }
            else if (lstBrand.Text == "Mustang" && chkStereo.Checked == true && rbTwo.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Mustang_Price * 2.1));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));

            }
            else if (lstBrand.Text == "Mustang" && chkStereo.Checked == true && rbFour.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Mustang_Price * 4.1));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }
            else if (lstBrand.Text == "Mustang" && chkStereo.Checked == true && rbEight.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Mustang_Price * 8.1));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }

            //-----------------------------------------------------------------------------------------------------------------------
            //MUSTANG// PART3
            if (lstBrand.Text == "Mustang" && chkStereo.Checked == true && rbOne.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Mustang_Price * 1.2));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }
            else if (lstBrand.Text == "Mustang" && chkStereo.Checked == true && rbTwo.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Mustang_Price * 2.2));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));

            }
            else if (lstBrand.Text == "Mustang" && chkStereo.Checked == true && rbFour.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Mustang_Price * 4.2));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }
            else if (lstBrand.Text == "Mustang" && chkStereo.Checked == true && rbEight.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Mustang_Price * 8.2));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }

            //--------------------------------------------------------------------------------------------------------------------------------
            //NISSAN// PART1
            if (lstBrand.Text == "Nissan" && chkStereo.Checked == true && rbOne.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Nissan_Price * 1));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }
            else if (lstBrand.Text == "Nissan" && chkStereo.Checked == true && rbTwo.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Nissan_Price * 2));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));

            }
            else if (lstBrand.Text == "Nissan" && chkStereo.Checked == true && rbFour.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Nissan_Price * 4));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }
            else if (lstBrand.Text == "Nissan" && chkStereo.Checked == true && rbEight.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Nissan_Price * 8));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }

            //-----------------------------------------------------------------------------------------------------------------------
            //NISSAN// PART2
            if (lstBrand.Text == "Nissan" && chkStereo.Checked == true && rbOne.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Nissan_Price * 1.1));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }
            else if (lstBrand.Text == "Nissan" && chkStereo.Checked == true && rbTwo.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Nissan_Price * 2.1));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));

            }
            else if (lstBrand.Text == "Nissan" && chkStereo.Checked == true && rbFour.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Nissan_Price * 4.1));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }
            else if (lstBrand.Text == "Nissan" && chkStereo.Checked == true && rbEight.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Nissan_Price * 8.1));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }

            //-----------------------------------------------------------------------------------------------------------------------
            //NISSAN// PART3
            if (lstBrand.Text == "Nissan" && chkStereo.Checked == true && rbOne.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Nissan_Price * 1.2));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }
            else if (lstBrand.Text == "Nissan" && chkStereo.Checked == true && rbTwo.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Nissan_Price * 2.2));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));

            }
            else if (lstBrand.Text == "Nissan" && chkStereo.Checked == true && rbFour.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Nissan_Price * 4.2));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }
            else if (lstBrand.Text == "Nissan" && chkStereo.Checked == true && rbEight.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Nissan_Price * 8.2));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }

            //--------------------------------------------------------------------------------------------------------------------------------
            //PAGANI// PART1
            if (lstBrand.Text == "Pagani" && chkStereo.Checked == true && rbOne.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Pagani_Price * 1));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }
            else if (lstBrand.Text == "Pagani" && chkStereo.Checked == true && rbTwo.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Pagani_Price * 2));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));

            }
            else if (lstBrand.Text == "Pagani" && chkStereo.Checked == true && rbFour.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Pagani_Price * 4));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }
            else if (lstBrand.Text == "Pagani" && chkStereo.Checked == true && rbEight.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Pagani_Price * 8));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }

            //-----------------------------------------------------------------------------------------------------------------------
            //PAGANI// PART2
            if (lstBrand.Text == "Pagani" && chkStereo.Checked == true && rbOne.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Pagani_Price * 1.1));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }
            else if (lstBrand.Text == "Pagani" && chkStereo.Checked == true && rbTwo.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Pagani_Price * 2.1));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));

            }
            else if (lstBrand.Text == "Pagani" && chkStereo.Checked == true && rbFour.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Pagani_Price * 4.1));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }
            else if (lstBrand.Text == "Pagani" && chkStereo.Checked == true && rbEight.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Pagani_Price * 8.1));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }

            //-----------------------------------------------------------------------------------------------------------------------
            //PAGANI// PART3
            if (lstBrand.Text == "Pagani" && chkStereo.Checked == true && rbOne.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Pagani_Price * 1.2));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }
            else if (lstBrand.Text == "Pagani" && chkStereo.Checked == true && rbTwo.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Pagani_Price * 2.2));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));

            }
            else if (lstBrand.Text == "Pagani" && chkStereo.Checked == true && rbFour.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Pagani_Price * 4.2));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }
            else if (lstBrand.Text == "Pagani" && chkStereo.Checked == true && rbEight.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Pagani_Price * 8.2));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }

            //--------------------------------------------------------------------------------------------------------------------------------
            //PEUGEOT// PART1
            if (lstBrand.Text == "Peugeot" && chkStereo.Checked == true && rbOne.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Peugeot_Price * 1));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }
            else if (lstBrand.Text == "Peugeot" && chkStereo.Checked == true && rbTwo.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Peugeot_Price * 2));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));

            }
            else if (lstBrand.Text == "Peugeot" && chkStereo.Checked == true && rbFour.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Peugeot_Price * 4));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }
            else if (lstBrand.Text == "Peugeot" && chkStereo.Checked == true && rbEight.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Peugeot_Price * 8));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }

            //-----------------------------------------------------------------------------------------------------------------------
            //PEUGEOT// PART2
            if (lstBrand.Text == "Peugeot" && chkStereo.Checked == true && rbOne.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Peugeot_Price * 1.1));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }
            else if (lstBrand.Text == "Peugeot" && chkStereo.Checked == true && rbTwo.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Peugeot_Price * 2.1));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));

            }
            else if (lstBrand.Text == "Peugeot" && chkStereo.Checked == true && rbFour.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Peugeot_Price * 4.1));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }
            else if (lstBrand.Text == "Peugeot" && chkStereo.Checked == true && rbEight.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Peugeot_Price * 8.1));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }

            //-----------------------------------------------------------------------------------------------------------------------
            //PEUGEOT// PART3
            if (lstBrand.Text == "Peugeot" && chkStereo.Checked == true && rbOne.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Peugeot_Price * 1.2));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }
            else if (lstBrand.Text == "Peugeot" && chkStereo.Checked == true && rbTwo.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Peugeot_Price * 2.2));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));

            }
            else if (lstBrand.Text == "Peugeot" && chkStereo.Checked == true && rbFour.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Peugeot_Price * 4.2));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }
            else if (lstBrand.Text == "Peugeot" && chkStereo.Checked == true && rbEight.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Peugeot_Price * 8.2));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }

            //--------------------------------------------------------------------------------------------------------------------------------
            //PORSCHE// PART1
            if (lstBrand.Text == "Porsche" && chkStereo.Checked == true && rbOne.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Porsche_Price * 1));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }
            else if (lstBrand.Text == "Porsche" && chkStereo.Checked == true && rbTwo.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Porsche_Price * 2));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));

            }
            else if (lstBrand.Text == "Porsche" && chkStereo.Checked == true && rbFour.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Porsche_Price * 4));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }
            else if (lstBrand.Text == "Porsche" && chkStereo.Checked == true && rbEight.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Porsche_Price * 8));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }

            //-----------------------------------------------------------------------------------------------------------------------
            //PORSCHE// PART2
            if (lstBrand.Text == "Porsche" && chkStereo.Checked == true && rbOne.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Porsche_Price * 1.1));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }
            else if (lstBrand.Text == "Porsche" && chkStereo.Checked == true && rbTwo.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Porsche_Price * 2.1));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));

            }
            else if (lstBrand.Text == "Porsche" && chkStereo.Checked == true && rbFour.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Porsche_Price * 4.1));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }
            else if (lstBrand.Text == "Porsche" && chkStereo.Checked == true && rbEight.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Porsche_Price * 8.1));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }

            //-----------------------------------------------------------------------------------------------------------------------
            //PORSCHE// PART3
            if (lstBrand.Text == "Porsche" && chkStereo.Checked == true && rbOne.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Porsche_Price * 1.2));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }
            else if (lstBrand.Text == "Porsche" && chkStereo.Checked == true && rbTwo.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Porsche_Price * 2.2));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));

            }
            else if (lstBrand.Text == "Porsche" && chkStereo.Checked == true && rbFour.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Porsche_Price * 4.2));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }
            else if (lstBrand.Text == "Porsche" && chkStereo.Checked == true && rbEight.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Porsche_Price * 8.2));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }

            //--------------------------------------------------------------------------------------------------------------------------------
            //RAM// PART1
            if (lstBrand.Text == "Ram" && chkStereo.Checked == true && rbOne.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Ram_Price * 1));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }
            else if (lstBrand.Text == "Ram" && chkStereo.Checked == true && rbTwo.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Ram_Price * 2));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));

            }
            else if (lstBrand.Text == "Ram" && chkStereo.Checked == true && rbFour.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Ram_Price * 4));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }
            else if (lstBrand.Text == "Ram" && chkStereo.Checked == true && rbEight.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Ram_Price * 8));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }

            //-----------------------------------------------------------------------------------------------------------------------
            //RAM// PART2
            if (lstBrand.Text == "Ram" && chkStereo.Checked == true && rbOne.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Ram_Price * 1.1));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }
            else if (lstBrand.Text == "Ram" && chkStereo.Checked == true && rbTwo.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Ram_Price * 2.1));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));

            }
            else if (lstBrand.Text == "Ram" && chkStereo.Checked == true && rbFour.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Ram_Price * 4.1));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }
            else if (lstBrand.Text == "Ram" && chkStereo.Checked == true && rbEight.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Ram_Price * 8.1));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }

            //-----------------------------------------------------------------------------------------------------------------------
            //RAM// PART3
            if (lstBrand.Text == "Ram" && chkStereo.Checked == true && rbOne.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Ram_Price * 1.2));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }
            else if (lstBrand.Text == "Ram" && chkStereo.Checked == true && rbTwo.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Ram_Price * 2.2));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));

            }
            else if (lstBrand.Text == "Ram" && chkStereo.Checked == true && rbFour.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Ram_Price * 4.2));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }
            else if (lstBrand.Text == "Ram" && chkStereo.Checked == true && rbEight.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Ram_Price * 8.2));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }

            //--------------------------------------------------------------------------------------------------------------------------------
            //RENAULT// PART1
            if (lstBrand.Text == "Renault" && chkStereo.Checked == true && rbOne.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Renault_Price * 1));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }
            else if (lstBrand.Text == "Renault" && chkStereo.Checked == true && rbTwo.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Renault_Price * 2));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));

            }
           else if (lstBrand.Text == "Renault" && chkStereo.Checked == true && rbFour.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Renault_Price * 4));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }
            else if (lstBrand.Text == "Renault" && chkStereo.Checked == true && rbEight.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Renault_Price * 8));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }

            //-----------------------------------------------------------------------------------------------------------------------
            //RENAULT// PART2
            if (lstBrand.Text == "Renault" && chkStereo.Checked == true && rbOne.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Renault_Price * 1.1));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }
            else if (lstBrand.Text == "Renault" && chkStereo.Checked == true && rbTwo.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Renault_Price * 2.1));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));

            }
            else if (lstBrand.Text == "Renault" && chkStereo.Checked == true && rbFour.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Renault_Price * 4.1));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }
            else if (lstBrand.Text == "Renault" && chkStereo.Checked == true && rbEight.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Renault_Price * 8.1));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }

            //-----------------------------------------------------------------------------------------------------------------------
            //RENAULT// PART3
            if (lstBrand.Text == "Renault" && chkStereo.Checked == true && rbOne.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Renault_Price * 1.2));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }
            else if (lstBrand.Text == "Renault" && chkStereo.Checked == true && rbTwo.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Renault_Price * 2.2));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));

            }
            else if (lstBrand.Text == "Renault" && chkStereo.Checked == true && rbFour.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Renault_Price * 4.2));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }
            else if (lstBrand.Text == "Renault" && chkStereo.Checked == true && rbEight.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Renault_Price * 8.2));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }

            //--------------------------------------------------------------------------------------------------------------------------------
            //ROLS ROYCE// PART1
            if (lstBrand.Text == "Rolls Royce" && chkStereo.Checked == true && rbOne.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Rolls_Royce_Price * 1));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }
            else if (lstBrand.Text == "Rolls Royce" && chkStereo.Checked == true && rbTwo.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Rolls_Royce_Price * 2));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));

            }
            else if (lstBrand.Text == "Rolls Royce" && chkStereo.Checked == true && rbFour.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Rolls_Royce_Price * 4));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }
            else if (lstBrand.Text == "Rolls Royce" && chkStereo.Checked == true && rbEight.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Rolls_Royce_Price * 8));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }

            //-----------------------------------------------------------------------------------------------------------------------
            //ROLS ROYCE// PART2
            if (lstBrand.Text == "Rolls Royce" && chkStereo.Checked == true && rbOne.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Rolls_Royce_Price * 1.1));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }
            else if (lstBrand.Text == "Rolls Royce" && chkStereo.Checked == true && rbTwo.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Rolls_Royce_Price * 2.1));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));

            }
            else if (lstBrand.Text == "Rolls Royce" && chkStereo.Checked == true && rbFour.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Rolls_Royce_Price * 4.1));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }
            else if (lstBrand.Text == "Rolls Royce" && chkStereo.Checked == true && rbEight.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Rolls_Royce_Price * 8.1));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }

            //-----------------------------------------------------------------------------------------------------------------------
            //ROLS ROYCE// PART3
            if (lstBrand.Text == "Rolls Royce" && chkStereo.Checked == true && rbOne.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Rolls_Royce_Price * 1.2));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }
            else if (lstBrand.Text == "Rolls Royce" && chkStereo.Checked == true && rbTwo.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Rolls_Royce_Price * 2.2));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));

            }
            else if (lstBrand.Text == "Rolls Royce" && chkStereo.Checked == true && rbFour.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Rolls_Royce_Price * 4.2));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }
            else if (lstBrand.Text == "Rolls Royce" && chkStereo.Checked == true && rbEight.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Rolls_Royce_Price * 8.2));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }

            //--------------------------------------------------------------------------------------------------------------------------------
            //SAAB// PART1
            if (lstBrand.Text == "Saab" && chkStereo.Checked == true && rbOne.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Saab_Price * 1));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }
            else if (lstBrand.Text == "Saab" && chkStereo.Checked == true && rbTwo.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Saab_Price * 2));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));

            }
            else if (lstBrand.Text == "Saab" && chkStereo.Checked == true && rbFour.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Saab_Price * 4));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }
            else if (lstBrand.Text == "Saab" && chkStereo.Checked == true && rbEight.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Saab_Price * 8));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }

            //-----------------------------------------------------------------------------------------------------------------------
            //SAAB// PART2
            if (lstBrand.Text == "Saab" && chkStereo.Checked == true && rbOne.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Saab_Price * 1.1));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }
            else if (lstBrand.Text == "Saab" && chkStereo.Checked == true && rbTwo.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Saab_Price * 2.1));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));

            }
            else if (lstBrand.Text == "Saab" && chkStereo.Checked == true && rbFour.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Saab_Price * 4.1));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }
            else if (lstBrand.Text == "Saab" && chkStereo.Checked == true && rbEight.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Saab_Price * 8.1));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }

            //-----------------------------------------------------------------------------------------------------------------------
            //SAAB// PART3
            if (lstBrand.Text == "Saab" && chkStereo.Checked == true && rbOne.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Saab_Price * 1.2));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }
            else if (lstBrand.Text == "Saab" && chkStereo.Checked == true && rbTwo.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Saab_Price * 2.2));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));

            }
            else if (lstBrand.Text == "Saab" && chkStereo.Checked == true && rbFour.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Saab_Price * 4.2));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }
            else if (lstBrand.Text == "Saab" && chkStereo.Checked == true && rbEight.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Saab_Price * 8.2));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }

            //--------------------------------------------------------------------------------------------------------------------------------
            //SUBARU// PART1
            if (lstBrand.Text == "Subaru" && chkStereo.Checked == true && rbOne.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Subaru_Price * 1));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }
            else if (lstBrand.Text == "Subaru" && chkStereo.Checked == true && rbTwo.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Subaru_Price * 2));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));

            }
            else if (lstBrand.Text == "Subaru" && chkStereo.Checked == true && rbFour.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Subaru_Price * 4));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }
            else if (lstBrand.Text == "Subaru" && chkStereo.Checked == true && rbEight.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Subaru_Price * 8));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }


            //-----------------------------------------------------------------------------------------------------------------------
            //SUBARU// PART2
            if (lstBrand.Text == "Subaru" && chkStereo.Checked == true && rbOne.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Subaru_Price * 1.1));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }
            else if (lstBrand.Text == "Subaru" && chkStereo.Checked == true && rbTwo.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Subaru_Price * 2.1));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));

            }
            else if (lstBrand.Text == "Subaru" && chkStereo.Checked == true && rbFour.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Subaru_Price * 4.1));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }
            else if (lstBrand.Text == "Subaru" && chkStereo.Checked == true && rbEight.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Subaru_Price * 8.1));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }

            //-----------------------------------------------------------------------------------------------------------------------
            //SUBARU// PART3
            if (lstBrand.Text == "Subaru" && chkStereo.Checked == true && rbOne.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Subaru_Price * 1.2));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }
            else if (lstBrand.Text == "Subaru" && chkStereo.Checked == true && rbTwo.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Subaru_Price * 2.2));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));

            }
            else if (lstBrand.Text == "Subaru" && chkStereo.Checked == true && rbFour.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Subaru_Price * 4.2));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }
            else if (lstBrand.Text == "Subaru" && chkStereo.Checked == true && rbEight.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Subaru_Price * 8.2));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }

            //--------------------------------------------------------------------------------------------------------------------------------
            //SUZUKI// PART1
            if (lstBrand.Text == "Suzuki" && chkStereo.Checked == true && rbOne.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Suzuki_Price * 1));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }
            else if (lstBrand.Text == "Suzuki" && chkStereo.Checked == true && rbTwo.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Suzuki_Price * 2));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));

            }
            else if (lstBrand.Text == "Suzuki" && chkStereo.Checked == true && rbFour.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Suzuki_Price * 4));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }
            else if (lstBrand.Text == "Suzuki" && chkStereo.Checked == true && rbEight.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Suzuki_Price * 8));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }

            //-----------------------------------------------------------------------------------------------------------------------
            //SUZUKI// PART2
            if (lstBrand.Text == "Suzuki" && chkStereo.Checked == true && rbOne.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Suzuki_Price * 1.1));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }
            else if (lstBrand.Text == "Suzuki" && chkStereo.Checked == true && rbTwo.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Suzuki_Price * 2.1));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));

            }
            else if (lstBrand.Text == "Suzuki" && chkStereo.Checked == true && rbFour.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Suzuki_Price * 4.1));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }
            else if (lstBrand.Text == "Suzuki" && chkStereo.Checked == true && rbEight.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Suzuki_Price * 8.1));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }

            //-----------------------------------------------------------------------------------------------------------------------
            //SUZUKI// PART3
            if (lstBrand.Text == "Suzuki" && chkStereo.Checked == true && rbOne.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Suzuki_Price * 1.2));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }
            else if (lstBrand.Text == "Suzuki" && chkStereo.Checked == true && rbTwo.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Suzuki_Price * 2.2));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));

            }
            else if (lstBrand.Text == "Suzuki" && chkStereo.Checked == true && rbFour.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Suzuki_Price * 4.2));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }
            else if (lstBrand.Text == "Suzuki" && chkStereo.Checked == true && rbEight.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Suzuki_Price * 8.2));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }

            //--------------------------------------------------------------------------------------------------------------------------------
            //TATA MOTORS// PART1
            if (lstBrand.Text == "Tata Motors" && chkStereo.Checked == true && rbOne.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Tata_Motors_Price * 1));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }
            else if (lstBrand.Text == "Tata Motors" && chkStereo.Checked == true && rbTwo.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Tata_Motors_Price * 2));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));

            }
            else if (lstBrand.Text == "Tata Motors" && chkStereo.Checked == true && rbFour.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Tata_Motors_Price * 4));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }
            else if (lstBrand.Text == "Tata Motors" && chkStereo.Checked == true && rbEight.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Tata_Motors_Price * 8));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }

            //-----------------------------------------------------------------------------------------------------------------------
            //TATA MOTORS// PART2
            if (lstBrand.Text == "Tata Motors" && chkStereo.Checked == true && rbOne.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Tata_Motors_Price * 1.1));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }
            else if (lstBrand.Text == "Tata Motors" && chkStereo.Checked == true && rbTwo.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Tata_Motors_Price * 2.1));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));

            }
            else if (lstBrand.Text == "Tata Motors" && chkStereo.Checked == true && rbFour.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Tata_Motors_Price * 4.1));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }
            else if (lstBrand.Text == "Tata Motors" && chkStereo.Checked == true && rbEight.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Tata_Motors_Price * 8.1));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }

            //-----------------------------------------------------------------------------------------------------------------------
            //TATA MOTORS// PART3
            if (lstBrand.Text == "Tata Motors" && chkStereo.Checked == true && rbOne.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Tata_Motors_Price * 1.2));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }
            else if (lstBrand.Text == "Tata Motors" && chkStereo.Checked == true && rbTwo.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Tata_Motors_Price * 2.2));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));

            }
            else if (lstBrand.Text == "Tata Motors" && chkStereo.Checked == true && rbFour.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Tata_Motors_Price * 4.2));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }
            else if (lstBrand.Text == "Tata Motors" && chkStereo.Checked == true && rbEight.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Tata_Motors_Price * 8.2));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }

            //--------------------------------------------------------------------------------------------------------------------------------
            //TESLA// PART1
            if (lstBrand.Text == "Tesla" && chkStereo.Checked == true && rbOne.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Tesla_Price * 1));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }
            else if (lstBrand.Text == "Tesla" && chkStereo.Checked == true && rbTwo.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Tesla_Price * 2));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));

            }
            else if (lstBrand.Text == "Tesla" && chkStereo.Checked == true && rbFour.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Tesla_Price * 4));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }
            else if (lstBrand.Text == "Tesla" && chkStereo.Checked == true && rbEight.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Tesla_Price * 8));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }

            //-----------------------------------------------------------------------------------------------------------------------
            //TESLA// PART2
            if (lstBrand.Text == "Tesla" && chkStereo.Checked == true && rbOne.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Tesla_Price * 1.1));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }
            else if (lstBrand.Text == "Tesla" && chkStereo.Checked == true && rbTwo.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Tesla_Price * 2.1));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));

            }
            else if (lstBrand.Text == "Tesla" && chkStereo.Checked == true && rbFour.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Tesla_Price * 4.1));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }
            else if (lstBrand.Text == "Tesla" && chkStereo.Checked == true && rbEight.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Tesla_Price * 8.1));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }

            //-----------------------------------------------------------------------------------------------------------------------
            //TESLA// PART3
            if (lstBrand.Text == "Tesla" && chkStereo.Checked == true && rbOne.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Tesla_Price * 1.2));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }
            else if (lstBrand.Text == "Tesla" && chkStereo.Checked == true && rbTwo.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Tesla_Price * 2.2));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));

            }
            else if (lstBrand.Text == "Tesla" && chkStereo.Checked == true && rbFour.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Tesla_Price * 4.2));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }
            else if (lstBrand.Text == "Tesla" && chkStereo.Checked == true && rbEight.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Tesla_Price * 8.2));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }

            //--------------------------------------------------------------------------------------------------------------------------------
            //TOYOTA// PART1
            if (lstBrand.Text == "Toyota" && chkStereo.Checked == true && rbOne.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Toyota_Price * 1));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }
            else if (lstBrand.Text == "Toyota" && chkStereo.Checked == true && rbTwo.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Toyota_Price * 2));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));

            }
            else if (lstBrand.Text == "Toyota" && chkStereo.Checked == true && rbFour.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Toyota_Price * 4));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }
            else if (lstBrand.Text == "Toyota" && chkStereo.Checked == true && rbEight.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Toyota_Price * 8));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }

            //-----------------------------------------------------------------------------------------------------------------------
            //TOYOTA// PART2
            if (lstBrand.Text == "Toyota" && chkStereo.Checked == true && rbOne.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Toyota_Price * 1.1));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }
            else if (lstBrand.Text == "Toyota" && chkStereo.Checked == true && rbTwo.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Toyota_Price * 2.1));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));

            }
            else if (lstBrand.Text == "Toyota" && chkStereo.Checked == true && rbFour.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Toyota_Price * 4.1));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }
            else if (lstBrand.Text == "Toyota" && chkStereo.Checked == true && rbEight.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Toyota_Price * 8.1));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }

            //-----------------------------------------------------------------------------------------------------------------------
            //TOYOTA// PART3
            if (lstBrand.Text == "Toyota" && chkStereo.Checked == true && rbOne.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Toyota_Price * 1.2));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }
            else if (lstBrand.Text == "Toyota" && chkStereo.Checked == true && rbTwo.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Toyota_Price * 2.2));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));

            }
            else if (lstBrand.Text == "Toyota" && chkStereo.Checked == true && rbFour.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Toyota_Price * 4.2));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }
            else if (lstBrand.Text == "Toyota" && chkStereo.Checked == true && rbEight.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Toyota_Price * 8.2));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }

            //--------------------------------------------------------------------------------------------------------------------------------
            //VOLKSWAGEN// PART1
            if (lstBrand.Text == "Volkswagen" && chkStereo.Checked == true && rbOne.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Volkswagen_Price * 1));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }
            else if (lstBrand.Text == "Volkswagen" && chkStereo.Checked == true && rbTwo.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Volkswagen_Price * 2));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));

            }
            else if (lstBrand.Text == "Volkswagen" && chkStereo.Checked == true && rbFour.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Volkswagen_Price * 4));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }
            else if (lstBrand.Text == "Volkswagen" && chkStereo.Checked == true && rbEight.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Volkswagen_Price * 8));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }

            //-----------------------------------------------------------------------------------------------------------------------
            //VOLKSWAGEN// PART2
            if (lstBrand.Text == "Volkswagen" && chkStereo.Checked == true && rbOne.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Volkswagen_Price * 1.1));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }
            else if (lstBrand.Text == "Volkswagen" && chkStereo.Checked == true && rbTwo.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Volkswagen_Price * 2.1));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));

            }
            else if (lstBrand.Text == "Volkswagen" && chkStereo.Checked == true && rbFour.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Volkswagen_Price * 4.1));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }
            else if (lstBrand.Text == "Volkswagen" && chkStereo.Checked == true && rbEight.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Volkswagen_Price * 8.1));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }

            //-----------------------------------------------------------------------------------------------------------------------
            //VOLKSWAGEN// PART3
            if (lstBrand.Text == "Volkswagen" && chkStereo.Checked == true && rbOne.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Volkswagen_Price * 1.2));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }
            else if (lstBrand.Text == "Volkswagen" && chkStereo.Checked == true && rbTwo.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Volkswagen_Price * 2.2));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));

            }
            else if (lstBrand.Text == "Volkswagen" && chkStereo.Checked == true && rbFour.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Volkswagen_Price * 4.2));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }
            else if (lstBrand.Text == "Volkswagen" && chkStereo.Checked == true && rbEight.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Volkswagen_Price * 8.2));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }

            //--------------------------------------------------------------------------------------------------------------------------------
            //VOLVO// PART1
            if (lstBrand.Text == "Volvo" && chkStereo.Checked == true && rbOne.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Volvo_Price * 1));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }
            else if (lstBrand.Text == "Volvo" && chkStereo.Checked == true && rbTwo.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Volvo_Price * 2));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));

            }
            else if (lstBrand.Text == "Volvo" && chkStereo.Checked == true && rbFour.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Volvo_Price * 4));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }
            else if (lstBrand.Text == "Volvo" && chkStereo.Checked == true && rbEight.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Volvo_Price * 8));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }

            //-----------------------------------------------------------------------------------------------------------------------
            //VOLVO// PART2
            if (lstBrand.Text == "Volvo" && chkStereo.Checked == true && rbOne.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Volvo_Price * 1.1));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }
            else if (lstBrand.Text == "Volvo" && chkStereo.Checked == true && rbTwo.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Volvo_Price * 2.1));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));

            }
            else if (lstBrand.Text == "Volvo" && chkStereo.Checked == true && rbFour.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Volvo_Price * 4.1));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }
            else if (lstBrand.Text == "Volvo" && chkStereo.Checked == true && rbEight.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Volvo_Price * 8.1));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }

            //-----------------------------------------------------------------------------------------------------------------------
            //VOLVO// PART3
            if (lstBrand.Text == "Volvo" && chkStereo.Checked == true && rbOne.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Volvo_Price * 1.2));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }
            else if (lstBrand.Text == "Volvo" && chkStereo.Checked == true && rbTwo.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Volvo_Price * 2.2));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));

            }
            else if (lstBrand.Text == "Volvo" && chkStereo.Checked == true && rbFour.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Volvo_Price * 4.2));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }
            else if (lstBrand.Text == "Volvo" && chkStereo.Checked == true && rbEight.Checked == true)
            {
                Price = String.Format(("{0:C}"), (Volvo_Price * 8.2));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }

        }

        private void chkFullSet_CheckedChanged(object sender, EventArgs e)
        {
            if (chkFullSet.Checked)
            {
                chkStereo.Checked = true;
                chkGPS.Checked = true;
                chkTired.Checked = true;
                chkColor.Checked = true;
            }
            else
            {
                chkStereo.Checked = false;
                chkGPS.Checked = false;
                chkTired.Checked = false;
                chkColor.Checked = false;
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            lstOutput.Items.Add(String.Format(OrderDetails, "Customer ID", "Firstname", "Surname", "Order Made", "Method of Payment", "Date of Order", "Price"));

            cmbOrderMade.Items.Add("Select Order");
            cmbOrderMade.Items.Add("Account");
            cmbOrderMade.Items.Add("Telephone");
            cmbOrderMade.Items.Add("Instore Order");
            cmbOrderMade.Items.Add("Online Order");


            cmbPayment.Items.Add("Select Type");
            cmbPayment.Items.Add("Cash");
            cmbPayment.Items.Add("Master Card");
            cmbPayment.Items.Add("Visa Card");
            cmbPayment.Items.Add("Direct Debit");

            lstBrand.Items.Add("Acura");
            lstBrand.Items.Add("Alfa Romeo");
            lstBrand.Items.Add("Aston Martin");
            lstBrand.Items.Add("Audi");
            lstBrand.Items.Add("Bentley");
            lstBrand.Items.Add("BMW");
            lstBrand.Items.Add("Bugatti");
            lstBrand.Items.Add("Buick");
            lstBrand.Items.Add("Cadillac");
            lstBrand.Items.Add("Chevrolet");
            lstBrand.Items.Add("Chryler");
            lstBrand.Items.Add("Citroen");
            lstBrand.Items.Add("Dodge");
            lstBrand.Items.Add("Ferrari");
            lstBrand.Items.Add("Fiat");
            lstBrand.Items.Add("Ford");
            lstBrand.Items.Add("Geely");
            lstBrand.Items.Add("General Motors");
            lstBrand.Items.Add("GMC");
            lstBrand.Items.Add("Honda");
            lstBrand.Items.Add("Hyundai");
            lstBrand.Items.Add("Infiniti");
            lstBrand.Items.Add("Jaguar");
            lstBrand.Items.Add("Jeep");
            lstBrand.Items.Add("KIA");
            lstBrand.Items.Add("Koenigsegg");
            lstBrand.Items.Add("Lamborghini");
            lstBrand.Items.Add("Land Rover");
            lstBrand.Items.Add("Lexus");
            lstBrand.Items.Add("Maserati");
            lstBrand.Items.Add("Mazda");
            lstBrand.Items.Add("Mclaren");
            lstBrand.Items.Add("Mercedes-Benz");
            lstBrand.Items.Add("Mini");
            lstBrand.Items.Add("Mitsubishi");
            lstBrand.Items.Add("Mustang");
            lstBrand.Items.Add("Nissan");
            lstBrand.Items.Add("Pagani");
            lstBrand.Items.Add("Peugeot");
            lstBrand.Items.Add("Porsche");
            lstBrand.Items.Add("Ram");
            lstBrand.Items.Add("Renault");
            lstBrand.Items.Add("Rolls Royce");
            lstBrand.Items.Add("Saab");
            lstBrand.Items.Add("Subaru");
            lstBrand.Items.Add("Suzuki");
            lstBrand.Items.Add("Tata Motors");
            lstBrand.Items.Add("Tesla");
            lstBrand.Items.Add("Toyota");
            lstBrand.Items.Add("Volkswagen");
            lstBrand.Items.Add("Volvo");


            chkStereo.Checked = false;
            chkGPS.Checked = false;
            chkTired.Checked = false;
            chkColor.Checked = false;
            chkFullSet.Checked = false;

            rbOne.Checked = false;
            rbTwo.Checked = false;
            rbFour.Checked = false;
            rbEight.Checked = false;
        }

        private void btnSaveFile_Click(object sender, EventArgs e)
        {
           if (lstOutput.Items.Count > 0)
            {
                using (TextWriter TW = new StreamWriter("list.text"))
                {
                    foreach (string itemText in lstOutput.Items)
                    {
                        TW.WriteLine(itemText);
                    }
                }
                Process.Start("list.text");
            }
        }

        private void saveFileToolStripMenuItem_Click(object sender, EventArgs e)

        {
            if (lstOutput.Items.Count > 0)
            {
                using (TextWriter TW = new StreamWriter("list.text"))
                {
                    foreach (string itemText in lstOutput.Items)
                    {
                        TW.WriteLine(itemText);
                    }
                }
                Process.Start("list.text");
            }

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("BY Pablo , This is Vechicle Inventory. It gives the user options to choice a car they like");
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtCustomerID.Clear();
            txtFirstName.Clear();
            txtSurname.Clear();
            chkStereo.Checked = false;
            chkGPS.Checked = false;
            chkTired.Checked = false;
            chkColor.Checked = false;
            chkFullSet.Checked = false;

            rbOne.Checked = false;
            rbTwo.Checked = false;
            rbFour.Checked = false;
            rbEight.Checked = false;

            lstBrand.SelectedItems.Clear();
            lstOutput.Items.Clear();
            lstOutput.Items.Add(String.Format(OrderDetails, "Customer ID", "Firstname", "Surname", "Order Made", "Method of Payment", "Date of Order", "Price"));

            cmbOrderMade.Text = "Select Order";
            cmbPayment.Text = "Select Type";
        }
    }
}
