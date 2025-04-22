using System;§
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMI_Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       
       

        private double BMIcal(double dcm, double dkg)
        {
            // bmi = weight / ( height(meter) * height(meter) )
            double dRet = dkg / (dcm * dcm);
            return Math.Round(dRet,1); //rounding the decimal number
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                //get the value
                double dcm = double.Parse(height_textbox.Text) / 100; //convert to meter
                double dkg = double.Parse(weight_textbox.Text);

                //calculate the values
                double dRet = BMIcal(dcm, dkg);

                //move the track bar
                int iRet = (int)(dRet * 10);

                // when range of trackbar is exceeded
                if(iRet < 150)
                {
                    iRet= 150;
                }
                else if (280<iRet)
                {
                    iRet= 280;
                }
                trackBar1.Value = iRet;

                //display value on message
                string strRet = fCalResult(dRet);
                resulttext.Text = $"Your BMI ratio is [{dRet}]. It is [{strRet}]";
            }
            catch (Exception ex)
            {
                resulttext.Text = ex.ToString();
            }
        }
        //display result
        private string fCalResult(double dRet)
        {
            string strRet = string.Empty;

            if (dRet < 18.5)
            {
                strRet = "Underweight";
            }
            else if (dRet>= 18.5 && dRet < 23 )
            {
                strRet = "Normal";
            }
            else if (dRet >= 23 && dRet < 25)
            {
                strRet = "Overweight";
            }
            else if (dRet>=25)
            {
                strRet = "Obesity";
            }
            return strRet;

        }
    }
}
