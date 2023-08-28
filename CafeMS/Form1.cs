using System;
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
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
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

            lblTax.Text = Convert.ToString((drinkCosts + foodCosts + svcCharge) * tax);

            lblTotal.Text = Convert.ToString((total));
        }


    }
}
