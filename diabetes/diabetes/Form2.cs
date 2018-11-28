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
    public partial class Form2 : Form
    {
        public String name;
        public bool health_insur;
        public String age;
        public String weight;
        public bool cgm_purchase;
        public bool pump_purchase;

        public double day_income;
        public double day_exp;

        public int hunger_count;
        public int wellness_count;
        public double wallet_count;
        public int bg_val;
        public int secs;

        public String[] actions =
        {

            "Go out to coffee with friends",
            "Go to the gym",
            "Go for a run",
            "Go to the movie theater",
            "Write in a journal",
            "Go out for coffee",
            "Watch a movie",
            "Watch the sunrise",
            "Watch the sunset",
            "Go stargazing",
            "Go swimming",
            "Go rock climbing",
            "Go to the beach",
            "Do a puzzle",
            "Draw or paint",
            "Play a sport",
            "Play an instrument",
            "Cook a meal",
            "Go to the library",
            "Work in a garden",
            "Go to a play",
            "Visit neighbors",
            "Listen to the radio",
            "Listen to a podcast",
            "Go to a concert",
            "Call a friend",
            "Bake a dessert",
            "Visit a friend",
            "Volunteer",
            "Visit a tourist attraction",
            "Start a blog",
            "Explore somewhere new",
            "Play a board game",
            "Research an unfamiliar topic online",
            "Paint a picture",
            "Rearrange your furniture",
            "Make origami",
            "Read a book",
            "Visit a museum",
            "Go for a bike ride",
            "Take photos",
            "Knit",
            "Visit a park",
            "Do yoga",
            "Write a poem",
            "Search for new music to listen to",
            "Exercise",
            "Hike on a nature trail",
            "Care for a pet",
            "Go for a walk",
            "Play cards",
            "Write a letter",
            "Meditate",
            "Have a picnic",
            "Try a new food"
        };

        public int index;
        public int action_count;







        public Form2()
        {
            InitializeComponent();
            hunger_count = 100;
            hunger.Value = hunger_count;

            wellness_count = 100;
            wellness.Value = wellness_count;

            

            timer1.Start();
            timer2.Start();
            timer3.Start();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            secs = 0;
            wallet_count = day_income - day_exp;
            wallet_value.Text = wallet_count.ToString("C");

            if (health_insur == true)
            {
                pump_price.Text = "Covered by\ninsurance";
                insulin_price_label.Text = "Covered by insurance";
            }

            bg_val = 120;
            cgm_purchase = false;
            pump_purchase = false;

            unit_txt_box.Focus();

            //Values for actions in array
            Random randomAction = new Random();
            index = randomAction.Next(0, 54);

            action_count = 1;

            action_text.Text = actions[index];





    }

    private void hunger_Click(object sender, EventArgs e)
        {

        }

        private void easter_egg_Click(object sender, EventArgs e)
        {
            //Creating new instance of form 2
            Form3 f = new diabetes.Form3();

            //Open the 2nd form AKA the simulator
            f.ShowDialog();
        }

        private void gm_picture_Click(object sender, EventArgs e)
        {
            bg_monitor.Text = Convert.ToString(bg_val);
            if ((wellness.Value - 5) >= 0)
            {
                wellness.Value = wellness.Value - 5;
            }
            else
                wellness.Value = 0;



        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            if(secs == 180)
            {
                timer1.Enabled = false;
                timer2.Enabled = false;
                timer3.Enabled = false;
                Form6 f = new diabetes.Form6();
                f.ShowDialog();
            }
            else
            {
                secs++;
            }
            
            if(hunger.Value == 0)
            {
                if ((wellness.Value - 3) >= 0)
                {
                    wellness.Value = wellness.Value - 3;
                }
            }

            //Hunger constantly decreses
            if ((hunger.Value - 1) >= 0) {
                hunger.Value = hunger.Value - 1;

                if (hunger.Value < 60)
                {
                    if((wellness.Value - 1) >= 0)
                    {
                        wellness.Value = wellness.Value - 1;
                    }
                }

                if (hunger.Value >= 60)
                {
                    if ((wellness.Value + 1) <= 100)
                    {
                        wellness.Value = wellness.Value + 1;
                    }
                }

            }


            if(bg_val < 80 || bg_val > 160)
            {
                if ((wellness.Value - 1) >= 0)
                {
                    wellness.Value = wellness.Value - 1;
                }
            }

            if(bg_val < 20 || bg_val > 400)
            {
                if ((wellness.Value - 1) >= 0)
                {
                    wellness.Value = wellness.Value - 1;
                }
            }

           /* if (bg_val >= 80 && bg_val <= 160)
            {
                if ((wellness.Value + 1) <= 100)
                {
                    wellness.Value = wellness.Value + 1;
                }
                else
                {
                    wellness.Value = 100;
                }
            }*/





        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            //Color indications for hunger label
            if (hunger.Value >= 80) { hunger_label.ForeColor = Color.Black; }
            else if (hunger.Value >= 60 && hunger.Value < 80) { hunger_label.ForeColor = Color.Yellow; }
            else { hunger_label.ForeColor = Color.Red; }

            //Color indications for wellness label
            if (wellness.Value >= 80) { wellness_label.ForeColor = Color.Black; }
            else if (wellness.Value >= 60 && wellness.Value < 80) { wellness_label.ForeColor = Color.Yellow; }
            else { wellness_label.ForeColor = Color.Red; }

            //Updates wallet label with wallet_count
            wallet_value.Text = wallet_count.ToString("C");

            //Updates blood glucose label with bg_val constantly if cgm was purchased
            if (cgm_purchase == true)
            {
                
                bg_monitor.Text = Convert.ToString(bg_val);
            }
            
            if(bg_val >= 500 || bg_val <= 20)
            {

                timer2.Enabled = false;
                Form5 f = new diabetes.Form5();
                f.ShowDialog();
            }

            if (wellness.Value == 0)
            {

                timer2.Enabled = false;
                Form5 f = new diabetes.Form5();
                f.ShowDialog();
            }

        }

        private void pasta_Click(object sender, EventArgs e)
        {

            if ((wallet_count - 10) < 0)
            {
                MessageBox.Show("You don't have enough money!", "Insufficient Funds");
            }
            else
            {
                wallet_count -= 10;
                bg_val += (120 * 3);

                if ((hunger.Value + 25) > 100)
                {
                    hunger.Value = 100;


                    if ((wellness.Value - 2) >= 0)
                    {
                        wellness.Value = wellness.Value - 2;
                    }
                    else
                        wellness.Value = 0;



                }
                else
                {
                    hunger.Value += 25;
                }

            }

            



            

        }

        private void burger_Click(object sender, EventArgs e)
        {


            if ((wallet_count - 3) < 0)
            {
                MessageBox.Show("You don't have enough money!", "Insufficient Funds");
            }
            else
            {
                wallet_count -= 3;
                bg_val += (46 * 3);

                if ((hunger.Value + 15) > 100)
                {
                    hunger.Value = 100;
                    if ((wellness.Value - 2) >= 0)
                    {
                        wellness.Value = wellness.Value - 2;
                    }
                    else
                        wellness.Value = 0;
                }
                else
                {
                    hunger.Value += 15;
                }
            }

           

        }

        private void pizza_Click(object sender, EventArgs e)
        {

            if ((wallet_count - 2) < 0)
            {
                MessageBox.Show("You don't have enough money!", "Insufficient Funds");
            }
            else
            {
                wallet_count -= 2;
                bg_val += (25 * 3);

                if ((hunger.Value + 10) > 100)
                {
                    hunger.Value = 100;
                    if ((wellness.Value - 2) >= 0)
                    {
                        wellness.Value = wellness.Value - 2;
                    }
                    else
                        wellness.Value = 0;
                }
                else
                {
                    hunger.Value += 10;
                }
            }

           

        }

        private void rice_beans_Click(object sender, EventArgs e)
        {

            if ((wallet_count - 4) < 0)
            {
                MessageBox.Show("You don't have enough money!", "Insufficient Funds");
            }
            else
            {
                wallet_count -= 4;
                bg_val += (54 * 3);

                if ((hunger.Value + 25) > 100)
                {
                    hunger.Value = 100;
                    if ((wellness.Value - 2) >= 0)
                    {
                        wellness.Value = wellness.Value - 2;
                    }
                    else
                        wellness.Value = 0;
                }
                else
                {
                    hunger.Value += 25;
                }
            }

            

        }

        private void salad_Click(object sender, EventArgs e)
        {


            if ((wallet_count - 5) < 0)
            {
                MessageBox.Show("You don't have enough money!", "Insufficient Funds");
            }
            else
            {
                wallet_count -= 5;
                bg_val += (35 * 3);

                if ((hunger.Value + 15) > 100)
                {
                    hunger.Value = 100;
                    if ((wellness.Value - 2) >= 0)
                    {
                        wellness.Value = wellness.Value - 2;
                    }
                    else
                        wellness.Value = 0;
                }
                else
                {
                    hunger.Value += 15;
                }
            }

           

        }

        private void candy_Click(object sender, EventArgs e)
        {

            if ((wallet_count - 0.12) < 0)
            {
                MessageBox.Show("You don't have enough money!", "Insufficient Funds");
            }
            else
            {
                wallet_count -= 0.12;
                bg_val += (4 * 3);

                if ((hunger.Value + 1) > 100)
                {
                    hunger.Value = 100;
                    if ((wellness.Value - 2) >= 0)
                    {
                        wellness.Value = wellness.Value - 2;
                    }
                    else
                        wellness.Value = 0;
                }
                else
                {
                    hunger.Value += 1;
                }
            }

           

        }

        private void grapes_Click(object sender, EventArgs e)
        {
            if ((wallet_count - 0.50) < 0)
            {
                MessageBox.Show("You don't have enough money!", "Insufficient Funds");
            }
            else
            {
                wallet_count -= 0.50;
                bg_val += (15 * 3);

                if ((hunger.Value + 2) > 100)
                {
                    hunger.Value = 100;
                    if ((wellness.Value - 2) >= 0)
                    {
                        wellness.Value = wellness.Value - 2;
                    }
                    else
                        wellness.Value = 0;
                }
                else
                {
                    hunger.Value += 2;
                }
            }

            

        }

        private void ice_cream_Click(object sender, EventArgs e)
        {
            if ((wallet_count - 1) < 0)
            {
                MessageBox.Show("You don't have enough money!", "Insufficient Funds");
            }
            else
            {
                wallet_count -= 1;
                bg_val += (30 * 3);

                if ((hunger.Value + 5) > 100)
                {
                    hunger.Value = 100;
                    if ((wellness.Value - 2) >= 0)
                    {
                        wellness.Value = wellness.Value - 2;
                    }
                    else
                        wellness.Value = 0;
                }
                else
                {
                    hunger.Value += 5;
                }
            }

            

        }

        private void soda_Click(object sender, EventArgs e)
        {
            if ((wallet_count - 1) < 0)
            {
                MessageBox.Show("You don't have enough money!", "Insufficient Funds");
            }
            else
            {
                wallet_count -= 1;
                bg_val += (23 * 3);
            }

            
        }

        private void coffee_Click(object sender, EventArgs e)
        {
            if ((wallet_count - 1) < 0)
            {
                MessageBox.Show("You don't have enough money!", "Insufficient Funds");
            }
            else
            {
                wallet_count -= 1;
                bg_val += (6 * 3);
            }

        }

        private void orange_juice_Click(object sender, EventArgs e)
        {
            if ((wallet_count - 2) < 0)
            {
                MessageBox.Show("You don't have enough money!", "Insufficient Funds");
            }
            else
            {
                wallet_count -= 2;
                bg_val += (13 * 3);
            }
            
        }

        private void admin_btn_Click(object sender, EventArgs e)
        {
            double y;
            if (Double.TryParse(unit_txt_box.Text, out y) == true)
            {
                y = Convert.ToDouble(unit_txt_box.Text);
                bg_val -= (int)(y * 15);

                if(health_insur == false) {
                    if((wallet_count - .30) < 0)
                    {
                        MessageBox.Show("You don't have enough money!", "Insufficient Funds");
                    }
                    else
                        wallet_count -= (y * .30);
                }

                
                
            }

            else
            {
                MessageBox.Show("Please try again.", "Invalid Input");
            }
        }

        private void gcm_buy_Click(object sender, EventArgs e)
        {
            if ((wallet_count - 1100) < 0)
            {
                MessageBox.Show("You don't have enough money!", "Insufficient Funds");
            }
            else
            {
                wallet_count -= 1100;
                gmc_price.Text = "Owned";
                gcm_buy.Enabled = false;
            }
        }

        private void pump_buy_Click(object sender, EventArgs e)
        {
            if ((wallet_count - 5500) < 0)
            {
                MessageBox.Show("You don't have enough money!", "Insufficient Funds");
            }
            else
            {
                wallet_count -= 5500;
                pump_price.Text = "Owned";
                pump_buy.Enabled = false;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form4 f = new diabetes.Form4();
            f.Show();
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            if(pump_purchase == false)
            {
                Random random = new Random();
                int randomNumber = random.Next(0, 1);

                if(randomNumber == 0)
                {
                    Random randomUp = new Random();
                    int randomNumberUp = randomUp.Next(0, 5);
                    bg_val += randomNumberUp;
                }
                else if(randomNumber == 1)
                {
                    Random randomDown = new Random();
                    int randomNumberDown = randomDown.Next(0, 5);
                    bg_val -= randomNumberDown;
                }

            }
        }

        private void Form2_Leave(object sender, EventArgs e)
        {
            
        }

        private void ok_btn_Click(object sender, EventArgs e)
        {

           if(index == 1 || index == 2 || index == 10 || index == 11 || index == 12 || index == 15 || 
              index == 31 || index == 35 || index == 39 || index == 43 || index == 46 || index == 47 ||
              index == 49)
            {

                bg_val -= 15;

                if(wellness.Value + 15 > 100)
                {
                    wellness.Value = 100;
                }
                else
                {
                    wellness.Value += 15;
                }

                if(hunger.Value - 20 < 0)
                {
                    hunger.Value = 0;
                }
                else
                {
                    hunger.Value -= 20;
                }


                if(index == 1)
                {
                    if ((wallet_count - 10) < 0)
                    {
                        MessageBox.Show("You don't have enough money!", "Insufficient Funds");
                    }
                    else
                    {
                        wallet_count -= 10;
                    }

                }

                if (index == 12)
                {
                        if ((wallet_count - 5) < 0)
                        {
                            MessageBox.Show("You don't have enough money!", "Insufficient Funds");
                        }
                        else
                        {
                            wallet_count -= 5;
                        }
                }

                if (index == 31)
                {
                            if ((wallet_count - 20) < 0)
                            {
                                MessageBox.Show("You don't have enough money!", "Insufficient Funds");
                            }
                            else
                            {

                                wallet_count -= 20;
                            }
                }


            }

           if(index == 17 || index == 26 || index == 53 || index == 54)
            {
                bg_val += 50;

                if(hunger.Value + 15 > 100)
                {
                    hunger.Value = 100;
                }
                else
                {
                    hunger.Value += 15;
                }

                if (wellness.Value + 10 > 100)
                {
                    wellness.Value = 100;
                }
                else
                {
                    wellness.Value += 10;
                }


            }

            if (index == 0 || index == 5)
            {
                
                if ((wallet_count - 5) < 0)
                  {
                      MessageBox.Show("You don't have enough money!", "Insufficient Funds");
                   }
                 else
                   {
                        bg_val += (6 * 3);
                        wallet_count -= 5;

                    if (wellness.Value + 5 > 100)
                    {
                        wellness.Value = 100;
                    }
                    else
                    {
                        wellness.Value += 5;
                    }


                }

             


            }

            if(index == 3 || index == 38)
            {
                if ((wallet_count - 10) < 0)
                {
                    MessageBox.Show("You don't have enough money!", "Insufficient Funds");
                }
                else
                {
                   
                    wallet_count -= 10;

                    if (wellness.Value + 5 > 100)
                    {
                        wellness.Value = 100;
                    }
                    else
                    {
                        wellness.Value += 5;
                    }


                }

            }



            if (index == 20 || index == 30 || index == 15)
            {
                if ((wallet_count - 20) < 0)
                {
                    MessageBox.Show("You don't have enough money!", "Insufficient Funds");
                }
                else
                {

                    wallet_count -= 20;

                    if (wellness.Value + 5 > 100)
                    {
                        wellness.Value = 100;
                    }
                    else
                    {
                        wellness.Value += 5;
                    }


                }

            }









            Random randomAction = new Random();
            index = randomAction.Next(0, 54);

            action_count++;

            if(action_count == 24)
            {
                action_count = 1;
                wallet_count += (day_income - day_exp);
            }


            action_text.Text = actions[index];




        }

        private void nah_btn_Click(object sender, EventArgs e)
        {


            if (wellness.Value - 1 < 0)
            {
                wellness.Value = 0;
            }
            else
            {
                wellness.Value -= 1;
            }

            Random randomAction = new Random();
            index = randomAction.Next(0, 54);

            action_count++;

            if (action_count == 24)
            {
                action_count = 1;
                wallet_count += (day_income - day_exp);
            }

            action_text.Text = actions[index];






        }

        private void action_text_Click(object sender, EventArgs e)
        {

        }
    }
}
