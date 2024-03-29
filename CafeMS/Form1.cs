﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace CafeMS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Load += Form1_Load;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Set the default value for the TextBox
            txtLatte.Text = "0";
            txtBlackCoffee.Text ="0";
            txtExpresso.Text = "0";
            txtOrangeJuice.Text = "0";
            txtGreenTea.Text = "0";
            txtMilkTea.Text = "0";
            txtCappuchino.Text = "0";
            txtHotChocolate.Text = "0";
            txtWater.Text = "0";
            txtMacchiato.Text = "0";
            txtFries.Text = "0";
            txtEggBites.Text = "0";
            txtFishnChips.Text = "0";
            txtOmmelette.Text = "0";
            txtInstantNoodles.Text = "0";
            txtCrssant.Text = "0";
            txtCheeseCake.Text = "0";
            txtRainbowCake.Text = "0";
            txtChocolateCake.Text = "0";
            txtRedVelvetCake.Text = "0";

            lblDrinkCost.Text = "0";
            lblFoodCost.Text = "0";
            lblSvcCharge.Text = "1.75";
            lblSubTotal.Text = "0";
            lblTax.Text = "0";
            lblTotal.Text = "0";

            txtLatte.Enabled = false;
            txtExpresso.Enabled = false;
            txtBlackCoffee.Enabled = false;
            txtOrangeJuice.Enabled = false;
            txtGreenTea.Enabled = false;
            txtMilkTea.Enabled = false;
            txtCappuchino.Enabled = false;
            txtHotChocolate.Enabled = false;
            txtWater.Enabled = false;
            txtMacchiato.Enabled = false;  
            txtFries.Enabled = false;
            txtEggBites.Enabled = false;
            txtFishnChips.Enabled = false;
            txtOmmelette.Enabled = false;
            txtInstantNoodles.Enabled = false;
            txtCrssant.Enabled = false;
            txtCheeseCake.Enabled = false;
            txtRainbowCake.Enabled = false;
            txtChocolateCake.Enabled = false;
            txtRedVelvetCake.Enabled = false;

            




        }
    

        private void btnTotal_Click(object sender, EventArgs e)
        {

            // declaration of food and drink prices
            double taxRate = 0.11;
            double LattePrice = 1.20;
            double BlackCoffeePrice = 1.0;
            double ExpressoPrice = 1.0;
            double OrangeJuicePrice = 1.5; 
            double GreenTeaPrice = 1.0;
            double MilkTeaPrice = 1.5;
            double CappuchinoPrice = 2;
            double HotChocolatePrice = 1.5;
            double WaterPrice = 1;
            double MacchiatoPrice = 1.5;
            double FriesPrice = 2.35;
            double EggBitesPrice = 3;
            double FishnChipsPrice = 4.5;
            double OmmelettePrice = 3;
            double InstantNoodlesPrice = 2.5;
            double CrssantPrice = 2.25; 
            double CheeseCakePrice = 1.5;
            double RainbowCakePrice = 1.5;
            double ChocolateCakePrice = 1.5;
            double RedVelvetCakePrice = 1.5;


            //convert into 
            int LatteQty = Convert.ToInt32(txtLatte.Text);
            int BlackCoffeeQty = Convert.ToInt32(txtBlackCoffee.Text);
            int ExpressoQty = Convert.ToInt32(txtExpresso.Text);
            int OrangeJuiceQty = Convert.ToInt32(txtOrangeJuice.Text);
            int GreenTeaQty = Convert.ToInt32(txtGreenTea.Text);
            int MilkTeaQty = Convert.ToInt32(txtMilkTea.Text);
            int CappuchinoQty = Convert.ToInt32(txtCappuchino.Text);
            int HotChocolateQty = Convert.ToInt32(txtHotChocolate.Text);
            int WaterQty = Convert.ToInt32(txtWater.Text);
            int MacchiatoQty = Convert.ToInt32(txtMacchiato.Text);
            int FriesQty = Convert.ToInt32(txtFries.Text);
            int EggBitesQty = Convert.ToInt32(txtEggBites.Text);
            int FishnChipsQty = Convert.ToInt32(txtFishnChips.Text);
            int OmmeletteQty = Convert.ToInt32(txtOmmelette.Text);
            int InstantNoodlesQty = Convert.ToInt32(txtInstantNoodles.Text);
            int CrssantQty = Convert.ToInt32(txtCrssant.Text);
            int CheeseCakeQty = Convert.ToInt32(txtCheeseCake.Text);
            int RainbowQty = Convert.ToInt32(txtRainbowCake.Text);
            int ChocolateCakeQty = Convert.ToInt32(txtChocolateCake.Text);
            int RedVelvetCakeQty = Convert.ToInt32(txtRedVelvetCake.Text);

            Cafe cafe = new Cafe();

            double drinkCosts = (LatteQty * LattePrice) + (BlackCoffeeQty * BlackCoffeePrice) + (ExpressoQty * ExpressoPrice)
                            + (OrangeJuiceQty * OrangeJuicePrice) + GreenTeaQty * GreenTeaPrice + MilkTeaQty * GreenTeaPrice
                            + MilkTeaQty * MilkTeaPrice + CappuchinoQty * CappuchinoPrice + HotChocolateQty * HotChocolatePrice
                            + WaterQty * WaterPrice + MacchiatoQty * MacchiatoPrice ;

            lblDrinkCost.Text = Convert.ToString(drinkCosts);

            double foodCosts = FriesQty * FriesPrice + EggBitesQty * EggBitesPrice
                            + FishnChipsPrice * FishnChipsQty + OmmeletteQty * OmmelettePrice + InstantNoodlesPrice * InstantNoodlesQty
                            + CrssantPrice * CrssantQty + CheeseCakeQty * CheeseCakePrice
                            + RainbowCakePrice * RainbowQty + ChocolateCakePrice * ChocolateCakeQty + RedVelvetCakePrice * RedVelvetCakeQty;

            lblFoodCost.Text = Convert.ToString(foodCosts);


            double svcCharge = Convert.ToDouble(lblSvcCharge.Text);

            double subTotal = drinkCosts + foodCosts + svcCharge;

            double tax = taxRate * subTotal;

            double total = subTotal + tax;

            lblSubTotal.Text = Convert.ToString(drinkCosts + foodCosts + svcCharge);

            lblTax.Text = Convert.ToString(tax);

            lblTotal.Text = Convert.ToString((total));

            //lblSvcCharge.Text = String.Format("{0:C}", svcCharge);
            lblSubTotal.Text = String.Format("{0:C}", subTotal);
            lblTotal.Text = String.Format("{0:C}", total);
            lblDrinkCost.Text = String.Format("{0:C}", drinkCosts);
            lblFoodCost.Text = String.Format("{0:C}", foodCosts);
            lblTax.Text = String.Format("{0:C}", tax);


        }

        private void chkLatte_CheckedChanged(object sender, EventArgs e)
        {
            if (chkLatte.Checked == true)
            {
                txtLatte.Enabled = true;
            }
            else
            {
                txtLatte.Enabled = false;
                txtLatte.Text = "0";
            }
        }

        private void chkBlackCoffee_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBlackCoffee.Checked == true)
            {
                txtBlackCoffee.Enabled = true;
            }
            else
            {
                txtBlackCoffee.Enabled = false;
                txtBlackCoffee.Text = "0";
            }

        }

        private void chkExpresso_CheckedChanged(object sender, EventArgs e)
        {
            if (chkExpresso.Checked == true)
            {
                txtExpresso.Enabled = true;
            }
            else
            {
                txtExpresso.Enabled = false;
                txtExpresso.Text = "0";
            }
        }

        private void chkOrangeJuice_CheckedChanged(object sender, EventArgs e)
        {
            if (chkOrangeJuice.Checked == true)
            {
                txtOrangeJuice.Enabled = true;
            }
            else
            {
                txtOrangeJuice.Enabled = false;
                txtOrangeJuice.Text = "0";
            }
        }

        private void chkGreenTea_CheckedChanged(object sender, EventArgs e)
        {
            if (chkGreenTea.Checked == true)
            {
                txtGreenTea.Enabled = true;
            }
            else
            {
                txtGreenTea.Enabled = false;
                txtGreenTea.Text = "0";
            }
        }

        private void chkMilkTea_CheckedChanged(object sender, EventArgs e)
        {
            if (chkMilkTea.Checked == true)
            {
                txtMilkTea.Enabled = true;
            }
            else
            {
                txtMilkTea.Enabled = false;
                txtMilkTea.Text = "0";
            }
        }

        private void chkCappuchino_CheckedChanged(object sender, EventArgs e)
        {
            if (chkCappuchino.Checked == true)
            {
                txtCappuchino.Enabled = true;
            }
            else
            {
                txtCappuchino.Enabled = false;
                txtCappuchino.Text = "0";
            }
        }

        private void chkHotChocolate_CheckedChanged(object sender, EventArgs e)
        {
            if (chkHotChocolate.Checked == true)
            {
                txtHotChocolate.Enabled = true;
            }
            else
            {
                txtHotChocolate.Enabled = false;
                txtHotChocolate.Text = "0";
            }
        }

        private void chkWater_CheckedChanged(object sender, EventArgs e)
        {
            if (chkWater.Checked == true)
            {
                txtWater.Enabled = true;
            }
            else
            {
                txtWater.Enabled = false;
                txtWater.Text = "0";
            }
        }

        private void chkMacchiato_CheckedChanged(object sender, EventArgs e)
        {
            if (chkMacchiato.Checked == true)
            {
                txtMacchiato.Enabled = true;
            }
            else
            {
                txtMacchiato.Enabled = false;
                txtMacchiato.Text = "0";
            }
        }

        private void chkFries_CheckedChanged(object sender, EventArgs e)
        {
            if (chkFries.Checked == true)
            {
                txtFries.Enabled = true;
            }
            else
            {
                txtFries.Enabled = false;
                txtFries.Text = "0";
            }
        }

        private void chkEggBites_CheckedChanged(object sender, EventArgs e)
        {
            if (chkEggBites.Checked == true)
            {
                txtEggBites.Enabled = true;
            }
            else
            {
                txtEggBites.Enabled = false;
                txtEggBites.Text = "0";
            }
        }

        private void chkFishnChips_CheckedChanged(object sender, EventArgs e)
        {
            if (chkFishnChips.Checked == true)
            {
                txtFishnChips.Enabled = true;
            }
            else
            {
                txtFishnChips.Enabled = false;
                txtFishnChips.Text = "0";
            }
        }

        private void chkOmmelette_CheckedChanged(object sender, EventArgs e)
        {
            if (chkOmmelette.Checked == true)
            {
                txtOmmelette.Enabled = true;
            }
            else
            {
                txtOmmelette.Enabled = false;
                txtOmmelette.Text = "0";
            }
        }

        private void chkInstantNoodles_CheckedChanged(object sender, EventArgs e)
        {
            if (chkInstantNoodles.Checked == true)
            {
                txtInstantNoodles.Enabled = true;
            }
            else
            {
                txtInstantNoodles.Enabled = false;
                txtInstantNoodles.Text = "0";
            }
        }

        private void chkCrssant_CheckedChanged(object sender, EventArgs e)
        {
            if (chkCrssant.Checked == true)
            {
                txtCrssant.Enabled = true;
            }
            else
            {
                txtCrssant.Enabled = false;
                txtCrssant.Text = "0";
            }
        }

        private void chkCheeseCake_CheckedChanged(object sender, EventArgs e)
        {
            if (chkCheeseCake.Checked == true)
            {
                txtCheeseCake.Enabled = true;
            }
            else
            {
                txtCheeseCake.Enabled = false;
                txtCheeseCake.Text = "0";
            }
        }

        private void chkRainbowCake_CheckedChanged(object sender, EventArgs e)
        {
            if (chkRainbowCake.Checked == true)
            {
                txtRainbowCake.Enabled = true;
            }
            else
            {
                txtRainbowCake.Enabled = false;
                txtRainbowCake.Text = "0";
            }
        }

        private void chkChocolateCake_CheckedChanged(object sender, EventArgs e)
        {
            if (chkChocolateCake.Checked == true)
            {
                txtChocolateCake.Enabled = true;
            }
            else
            {
                txtChocolateCake.Enabled = false;
                txtChocolateCake.Text = "0";
            }
        }

        private void chkRedVelvetCake_CheckedChanged(object sender, EventArgs e)
        {
            if (chkRedVelvetCake.Checked == true)
            {
                txtRedVelvetCake.Enabled = true;
            }
            else
            {
                txtRedVelvetCake.Enabled = false;
                txtRedVelvetCake.Text = "0";
            }
        }

        private void btnReceipt_Click(object sender, EventArgs e)
        {
            rtbReceipt.Clear();

            rtbReceipt.AppendText("---------------------------------------------------------------" + Environment.NewLine);
            rtbReceipt.AppendText("\t\t\t" + "My Cafe" + Environment.NewLine);
            rtbReceipt.AppendText("---------------------------------------------------------------" + Environment.NewLine);

            if (txtLatte.Text != "0")
            {
                rtbReceipt.AppendText("   Latte \t\t\t\t\t" + txtLatte.Text + Environment.NewLine);
            }
            if (txtBlackCoffee.Text != "0")
            {
                rtbReceipt.AppendText("   BlackCoffee \t\t\t\t" + txtBlackCoffee.Text + Environment.NewLine);
            }
            if (txtExpresso.Text != "0")
            {
                rtbReceipt.AppendText("   Expresso \t\t\t\t" + txtExpresso.Text + Environment.NewLine);
            }
            if (txtOrangeJuice.Text != "0")
            {
                rtbReceipt.AppendText("   Orange Juice \t\t\t\t" + txtOrangeJuice.Text + Environment.NewLine);
            }
            if (txtGreenTea.Text != "0")
            {
                rtbReceipt.AppendText("   Green Tea \t\t\t\t" + txtGreenTea.Text + Environment.NewLine);
            }
            if (txtMilkTea.Text != "0")
            {
                rtbReceipt.AppendText("   Milk Tea \t\t\t\t" + txtMilkTea.Text + Environment.NewLine);
            }
            if (txtWater.Text != "0")
            {
                rtbReceipt.AppendText("   Water \t\t\t\t" + txtWater.Text + Environment.NewLine);
            }
            if (txtHotChocolate.Text != "0")
            {
                rtbReceipt.AppendText("   Hot Chocolate \t\t\t\t" + txtHotChocolate.Text + Environment.NewLine);
            }

            if (txtMacchiato.Text != "0")
            {
                rtbReceipt.AppendText("   Macchiato \t\t\t\t" + txtMacchiato.Text + Environment.NewLine);
            }

            if (txtCappuchino.Text != "0")
            {
                rtbReceipt.AppendText("   Cappuchino \t\t\t\t" + txtCappuchino.Text + Environment.NewLine);
            }

            if (txtFries.Text != "0")
            {
                rtbReceipt.AppendText("   Fries \t\t\t\t" + txtFries.Text + Environment.NewLine);
            }    
            
            if (txtEggBites.Text != "0")
            {
                rtbReceipt.AppendText("   Egg Bites \t\t\t\t" + txtEggBites.Text + Environment.NewLine);
            }
            
            if (txtFishnChips.Text != "0")
            {
                rtbReceipt.AppendText("   Fish and Chips \t\t\t\t" + txtFishnChips.Text + Environment.NewLine);
            }
            
            if (txtOmmelette.Text != "0")
            {
                rtbReceipt.AppendText("   Ommelette \t\t\t\t" + txtOmmelette.Text + Environment.NewLine);
            }
            
            if (txtInstantNoodles.Text != "0")
            {
                rtbReceipt.AppendText("   Instant Noodles \t\t\t\t" + txtInstantNoodles.Text + Environment.NewLine);
            }

            if (txtCrssant.Text != "0")
            {

                rtbReceipt.AppendText("   Crssant \t\t\t\t" + txtCrssant.Text + Environment.NewLine);
            }
            
            if (txtCheeseCake.Text != "0")
            {
                rtbReceipt.AppendText("   Cheese Cake \t\t\t\t" + txtCheeseCake.Text + Environment.NewLine);
            }

            if (txtRainbowCake.Text != "0")
            {
                rtbReceipt.AppendText("   Rainbow Cake \t\t\t\t" + txtRainbowCake.Text + Environment.NewLine);
            }
            
            if (txtChocolateCake.Text != "0")
            {
                rtbReceipt.AppendText("   Chocolate Cake \t\t\t\t" + txtChocolateCake.Text + Environment.NewLine);
            }
           
            if (txtRedVelvetCake.Text != "0")
            {
                rtbReceipt.AppendText("   Red Velvet Cake \t\t\t\t" + txtRedVelvetCake.Text + Environment.NewLine);
            }
            
            rtbReceipt.AppendText("--------------------------------------------------------------" + Environment.NewLine);
            rtbReceipt.AppendText("   Service Charge \t\t\t\t" + lblSvcCharge.Text + Environment.NewLine);
            rtbReceipt.AppendText("--------------------------------------------------------------" + Environment.NewLine);
            rtbReceipt.AppendText("   Sub Total \t\t\t\t" + lblSubTotal.Text + Environment.NewLine);
            rtbReceipt.AppendText("   Tax \t\t\t\t\t" + lblTax.Text + Environment.NewLine);
            rtbReceipt.AppendText("   Total Cost \t\t\t\t" + lblTotal.Text + Environment.NewLine);
            rtbReceipt.AppendText("--------------------------------------------------------------" + Environment.NewLine);
            // rtbReceipt.AppendText(lblTimer.Text + "\t" + lblDate.Text);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            // Set the default value for the TextBox
            txtLatte.Text = "0";
            txtBlackCoffee.Text = "0";
            txtExpresso.Text = "0";
            txtOrangeJuice.Text = "0";
            txtGreenTea.Text = "0";
            txtMilkTea.Text = "0";
            txtCappuchino.Text = "0";
            txtHotChocolate.Text = "0";
            txtWater.Text = "0";
            txtMacchiato.Text = "0";
            txtFries.Text = "0";
            txtEggBites.Text = "0";
            txtFishnChips.Text = "0";
            txtOmmelette.Text = "0";
            txtInstantNoodles.Text = "0";
            txtCrssant.Text = "0";
            txtCheeseCake.Text = "0";
            txtRainbowCake.Text = "0";
            txtChocolateCake.Text = "0";
            txtRedVelvetCake.Text = "0";

            lblDrinkCost.Text = "0";
            lblFoodCost.Text = "0";
            lblSvcCharge.Text = "1.75";
            lblSubTotal.Text = "0";
            lblTax.Text = "0";
            lblTotal.Text = "0";

            txtLatte.Enabled = false;
            txtExpresso.Enabled = false;
            txtBlackCoffee.Enabled = false;
            txtOrangeJuice.Enabled = false;
            txtGreenTea.Enabled = false;
            txtMilkTea.Enabled = false;
            txtCappuchino.Enabled = false;
            txtHotChocolate.Enabled = false;
            txtWater.Enabled = false;
            txtMacchiato.Enabled = false;
            txtFries.Enabled = false;
            txtEggBites.Enabled = false;
            txtFishnChips.Enabled = false;
            txtOmmelette.Enabled = false;
            txtInstantNoodles.Enabled = false;
            txtCrssant.Enabled = false;
            txtCheeseCake.Enabled = false;
            txtRainbowCake.Enabled = false;
            txtChocolateCake.Enabled = false;
            txtRedVelvetCake.Enabled = false;

            chkLatte.Checked = false;
            chkExpresso.Checked = false;
            chkBlackCoffee.Checked = false;
            chkOrangeJuice.Checked = false;
            chkGreenTea.Checked = false;
            chkMilkTea.Checked = false;
            chkCappuchino.Checked = false;
            chkHotChocolate.Checked = false;
            chkWater.Checked = false;
            chkMacchiato.Checked = false;
            chkFries.Checked = false;
            chkEggBites.Checked = false;
            chkFishnChips.Checked = false;
            chkOmmelette.Checked = false;
            chkInstantNoodles.Checked = false;
            chkCrssant.Checked = false;
            chkCheeseCake.Checked = false;
            chkRainbowCake.Checked = false;
            chkChocolateCake.Checked = false;
            chkRedVelvetCake.Checked = false;


        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void rtbReceipt_TextChanged(object sender, EventArgs e)
        {

        }

        private void toolBtnPrint_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {


            if (e.Graphics != null)
            {
                e.Graphics.DrawString(rtbReceipt.Text, new Font("Arial", 14, FontStyle.Regular), Brushes.Black, 120, 120);
            }
        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            rtbReceipt.Clear();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();

            openFile.Filter = "Text Files (*.txt)|*.txt|All files (*.*)|*.*";
            if (openFile.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                rtbReceipt.LoadFile(openFile.FileName, RichTextBoxStreamType.PlainText);
            }
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFile = new SaveFileDialog();

            saveFile.FileName = "Notepad Text";
            saveFile.Filter = "Text Files (*.txt)|*.txt|All files (*.*)|*.*";

            if (saveFile.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                using (System.IO.StreamWriter sw = new System.IO.StreamWriter(saveFile.FileName))
                    sw.WriteLine(rtbReceipt.Text);
            }
        }

        private void toolStripButton8_Click(object sender, EventArgs e)
        {
            MessageBox.Show("For enquiry, please send an email to nhatha22@gmail.com", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
