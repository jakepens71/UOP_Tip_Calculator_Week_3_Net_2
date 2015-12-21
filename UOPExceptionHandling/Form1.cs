using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace UOPExceptionHandling
{
    public partial class Form1 : Form
    {
        string bill = "";
        string tip = "";
        string totalAmount = "";

        public Form1()
        {
            InitializeComponent();
        }

        /*
        *On button click event that calculates the tip.
        *
        */
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            //Initalize the variables
            bill = txtBill.Text.ToString();
            tip = comboTip.Text.ToString();

            //If bill is equal to blank or tip is blank then all requirements are not met.
            if (bill == "" || tip == "")
            {
                MessageBox.Show("All Requirements are not met.");
            }
            else
            {
                double dblBill = 0;
                double dblTotalAmount = 0;
                double dblTip = 0;

                //If the user inputs a dollar sign then we can easily take that out.
                if (bill.Contains("$"))
                {
                    bill = bill.Replace("$", "");
                }

                //Attempt to parse the string 'bill' into a double
                try
                {
                   dblBill = double.Parse(bill);
                }
                catch (Exception ex)
                {
                    //If the parse fails then throw our exception
                   throw new  InvalidDoubleException("The values entered was invalid for this type of calculation. Please use double format values such as '26.12'");
                }

                //Attemp to parse the string 'tip' into a double
                try {
                 dblTip = double.Parse(tip);

                }
                catch (Exception ex)
                {
                    //If the parse fails then throw our exception
                    throw new InvalidDoubleException("The values entered was invalid for this type of calculation. Please use double format values such as '.15'");
                }


                    //get the tip amount frorm the bill entered times the percentage of tip.
                    double totalTipAmount = dblBill * dblTip;

                    //Make sure the lbl for the tip contains the information for the totalTipAmount
                    lblTipAmount.Text = String.Format("{0:C}", totalTipAmount);

                    //Add the total bill
                    dblTotalAmount = totalTipAmount + dblBill;

                    //Output the total bill answer.
                    lblAnswer.Text = String.Format("{0:C}", dblTotalAmount);
            }
        }
    }
}
