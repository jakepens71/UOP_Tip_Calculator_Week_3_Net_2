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


        InvalidDoubleException dblExeception = new InvalidDoubleException();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            //Initalize the variables
            bill = txtBill.Text.ToString();
            tip = comboTip.Text.ToString();

            if (bill == "" || tip == "")
            {
                MessageBox.Show("All Requirements are not met.");
            }
            else
            {
                double dblBill = 0;
                double dblTotalAmount = 0;
                double dblTip = 0;

                if (bill.Contains("$"))
                {
                    bill = bill.Replace("$", "");
                }


                try
                {
                   dblBill = double.Parse(bill);
                }
                catch (Exception ex)
                {
                   throw new  InvalidDoubleException("The values entered was invalid for this type of calculation. Please use double format values such as '26.12'");
                }


                try {
                 dblTip = double.Parse(tip);

                }
                catch (Exception ex)
                {
                    throw new InvalidDoubleException("The values entered was invalid for this type of calculation. Please use double format values such as '.15'");
                }


               
                    double totalTipAmount = dblBill * dblTip;

                    lblTipAmount.Text = String.Format("{0:C}", totalTipAmount);


                    dblTotalAmount = totalTipAmount + dblBill;

                    lblAnswer.Text = String.Format("{0:C}", dblTotalAmount);



                
            }



        }
    }
}
