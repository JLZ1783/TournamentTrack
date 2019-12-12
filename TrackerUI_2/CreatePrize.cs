using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrackerLibrary;
using TrackerLibrary.DataAccess;
using TrackerLibrary.Models;

namespace TrackerUI_2
{
    public partial class CreatePrize : Form
    {
        IPrizeRequester callingForm;
        public CreatePrize(IPrizeRequester caller)
         {
            InitializeComponent();

            callingForm = caller;
        }
        private void CreatePrizeButton_Click(object sender, EventArgs e)
        {
             if (ValidateForm())
            {

                PrizeModel model = new PrizeModel(
                    PlaceNameTextbox.Text,
                    PlaceNumberTextbox.Text,
                    PrizeAmountTextBox.Text,
                    PrizePercentageTextbox.Text);

                GlobalConfig.Connection.CreatePrize(model);

                callingForm.PrizeComplete(model);

                this.Close();

                //PlaceNameTextbox.Text = "";
                //PlaceNumberTextbox.Text = "";
                //PrizeAmountTextBox.Text = "0";
                //PrizePercentageTextbox.Text = "0";

            }
            else
            {
                MessageBox.Show("Invalid entry");
            }
        }
        private bool ValidateForm()
        {
            bool output = true;
            int placeNumber = 0;
            bool placeNumberValidNumber = int.TryParse(PlaceNumberTextbox.Text, out placeNumber);

            if(placeNumberValidNumber == false)
            {
                output = false;
            }
             
            if(placeNumber < 1)
            {
                output = false;
            }

            if (PlaceNameTextbox.Text.Length == 0)

            {
                output = false;
            }

            decimal prizeAmount = 0;
            double prizePercentage = 0;
            
            bool prizeAmountValid = decimal.TryParse(PrizeAmountTextBox.Text, out prizeAmount);
            bool prizePercentageValid = double.TryParse(PrizePercentageTextbox.Text, out prizePercentage);

            if(prizeAmountValid== false || prizePercentageValid == false)
            {
                output = false;
            }
            if (prizeAmount <= 0 && prizePercentage <= 0)
            {
                output = false;
            }
            if (prizeAmount < 0 || prizePercentage > 100)
            {
                output = false;

            }


            return output;
        }

        private void PrizeAmountTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void CreatePrize_Load_1(object sender, EventArgs e)
        {

        }
    }   
}
