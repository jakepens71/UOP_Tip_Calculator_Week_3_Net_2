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


                double.TryParse(bill, out dblBill);

                double.TryParse(tip, out dblTip);

                if (dblBill == 0 || dblTip == 0)
                {
                    MessageBox.Show("Bill has to be in a dollar amount. Example: 28.50");
                }
                else
                {
                    double totalTipAmount = dblBill * dblTip;

                    dblTotalAmount = totalTipAmount + dblBill;

                    lblAnswer.Text = String.Format("{0:C}", dblTotalAmount);



                }
            }



        }
    }
}
