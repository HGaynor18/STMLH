using System; 
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace водка_Drinker
{
    public partial class Form1 : Form
    {
        int Vodkas;
        int VodkasStrength = 1;
        int VodkaRating = 1;
        int DistillerStrength = 1;
        int Distillers = 0;
        int DistillerPrice = 50;
        int VodkasStrengthPrice = 100;
        int DistillerSpeed = 2;
        public Form1()
        {
            InitializeComponent();          
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void DrinkButton_Click(object sender, EventArgs e)
        {
            Vodkas = Vodkas + VodkasStrength;
            VodkaCounter.Text = "Vodkas: " + Vodkas;
            if (Vodkas > 5000)
            {
                MessageBox.Show("Hello Ma Freind, You Make Very Vodka, I Am Putin, You Good Vodka, You Spetsnaz Vodka, You Win!");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void ShopDistiller_Click(object sender, EventArgs e)
        {
            DistillerTimer.Start();
            if (Vodkas < DistillerPrice)
            {
                MessageBox.Show("Not Enough Vodka's");
                DistillerCounterLabel.Text = "Distillers: " + Distillers;
            }
            if (Vodkas > DistillerPrice)
            {
                Vodkas = Vodkas - DistillerPrice;
                DistillerPrice = DistillerPrice * 2;
                Distillers = Distillers + 1;
                DistillerStrength = DistillerStrength * 2;
                DistillerPriceLabel.Text = "Price: " + DistillerPrice;
            }
        }

        private void DistillerTimer_Tick(object sender, EventArgs e)
        {
            Vodkas = Vodkas + DistillerStrength;
            VodkaCounter.Text = "Vodkas: " + Vodkas;
            DistillerCounterLabel.Text = "Distillers: " + Distillers;
        }

        private void VodkaStrength_Click(object sender, EventArgs e)
        {
            if (Vodkas < VodkasStrengthPrice)
            {
                MessageBox.Show("Sorry Ma Fren, You Have Not Got Enpugh Vodkas.");

            }
            if (Vodkas > VodkasStrengthPrice)
            {
                VodkasStrength = VodkasStrength * 2;
                VodkaRating = VodkaRating + 1;
                VodkaStrengthLabel.Text = "Vodka Rating: " + VodkaRating;
                Vodkas = Vodkas - VodkasStrengthPrice;
            }

        }
    }
}
