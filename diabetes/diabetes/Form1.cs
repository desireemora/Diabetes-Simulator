using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Windows.Forms;



namespace diabetes
{
    //string name_input;


    public partial class Form1 : Form
    {

        double val;
        public bool insur;
        double y;

        public Form1()
        {
            InitializeComponent();
            


        }

        private void year_income_label_Click(object sender, EventArgs e)
        {

        }

        private void submit_Click(object sender, EventArgs e)
        {
            //Creating new instance of form 2
            Form2 f = new diabetes.Form2();
            
            //Setting local variables in form1 equal to local variables in form 2
            f.name = name_txt.Text;
            f.age = age_txt.Text;
            f.weight = weight_txt.Text;
            f.day_income = val;
           // int hold = year_income.selectedIndex;

           /* double day_val;
            if (year_income.SelectedItem == "Less than $25,000" ) { day_val = 68.49;}
            else { day_val = 100.000 ; }
            */
           /* int x;
            switch (x)
            {
                case 0:
                    day_val = 68.49;
                    break;
                case 1:
                    day_val = 82.19;
                    break;
                case 2:
                    day_val = 116.44;
                    break;
                case 3:
                    day_val = 171.23;
                    break;
                case 4:
                    day_val = 239.72;
                    break;
                case 5:
                    day_val = 342.46;
                    break;
                case 6:
                    day_val = 410.96;
                    break;
                default:
                    day_val = 68.49;
                    break;


            }

    */

            

            
            f.day_exp = y / 30.0;

            //f.day_exp = Convert.ToDecimal(y);
            f.health_insur = insur;

            
            //Open the 2nd form AKA the simulator
            f.ShowDialog();
            this.Close();
      
        }

        private void rb_yes_Click(object sender, EventArgs e)
        {
            insur = true;
        }

        private void rb_no_CheckedChanged(object sender, EventArgs e)
        {
            insur = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int x = year_income.SelectedIndex;
            
            switch (x)
            {
                case 0:
                    val = 68.49;
                    break;
                case 1:
                    val = 82.19;
                    break;
                case 2:
                    val = 116.44;
                    break;
                case 3:
                    val = 171.23;
                    break;
                case 4:
                    val = 239.72;
                    break;
                case 5:
                    val = 342.46;
                    break;
                case 6:
                    val = 410.96;
                    break;
                default:
                    val = 68.49;
                    break;

            }

            if (Double.TryParse(month_exp_txt.Text, out y) == true)
            {
                y = Convert.ToDouble(month_exp_txt.Text);
            }
            String month = month_exp_txt.Text;



        }
    }
}
