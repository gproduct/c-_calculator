using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace complex_calculator
{

    //en itt levezetett matek kepletet hasznalok de lehet a System.Numerics

    public partial class Form1 : Form
    {
        //variables
            //usage for + - 
                private string method_a;
                private string method_b;

        public Form1()
        {
            InitializeComponent();

            
            
        }
            //basic error function
            private void errorz()
            {
                MessageBox.Show("You didn't choose + or -", "ERROR",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //**************************************************************
            //functions for returning methods state
            //**************************************************************
            private int get_methods()
            {
                if ((method_a == "+") && (method_b == "+"))
                {
                    return 0;
                }
                else if ((method_a == "-") && (method_b == "-"))
                {
                    return 1;
                }
                else if ((method_a == "-") && (method_b == "+"))
                {
                    return 2;
                }
                else if ((method_a == "+") && (method_b == "-"))
                {
                    return 3;
                }
                else
                {
                    return 4;
                }
            }
            //**************************************************************

            //**************************************************************
            //functions for handling the users options for + or - in complex
            //**************************************************************
            private void combo_a_SelectedIndexChanged(object sender, EventArgs e)
            {
                method_a = Convert.ToString(combo_a.Text);
            }

            private void combo_b_SelectedIndexChanged(object sender, EventArgs e)
            {
                method_b = Convert.ToString(combo_b.Text);
                
            }
            //**************************************************************
            private void button1_Click(object sender, EventArgs e)
            {
                //box_result.Text = Convert.ToString(method_a) + " " + Convert.ToString(method_b);
            }


            //**************************************************************
            //functions for button handling
            //**************************************************************
            private void sum_Click(object sender, EventArgs e)
            {
                //making it easier for the eyes
                int _a_re = Convert.ToInt32(box_a_re.Text);
                int _b_re = Convert.ToInt32(box_b_re.Text);
                int _a_im = Convert.ToInt32(box_a_im.Text);
                int _b_im = Convert.ToInt32(box_b_im.Text);

                //gets the methods
                int method = get_methods();
                switch (method)
                {
                    case 0:
                        box_result.Text = Convert.ToString((_a_re + _b_re) + "+i" + (_a_im + _b_im));
                        break;
                    case 1:
                        box_result.Text = Convert.ToString((_a_re + _b_re) + "" + (-_a_im - _b_im) + "i" );
                        break;
                    case 2:
                        if ((-_a_im + _b_im) < 0)
                        {
                            box_result.Text = Convert.ToString((_a_re + _b_re) + "" + (-_a_im + _b_im) + "i");
                        }
                        else
                        {
                            box_result.Text = Convert.ToString((_a_re + _b_re) + "+i" + (-_a_im + _b_im));
                        }
                        break;
                    case 3:
                        if ((_a_im - _b_im) < 0)
                        {
                            box_result.Text = Convert.ToString((_a_re + _b_re) + "" + (_a_im - _b_im) + "i");
                        }
                        else
                        {
                            box_result.Text = Convert.ToString((_a_re + _b_re) + "+i" + (_a_im - _b_im));
                        }
                        break;
                    case 4:
                        errorz();
                        break;
                }
            }

            private void subs_Click(object sender, EventArgs e)
            {
                //making it easier for the eyes
                int _a_re = Convert.ToInt32(box_a_re.Text);
                int _b_re = Convert.ToInt32(box_b_re.Text);
                int _a_im = Convert.ToInt32(box_a_im.Text);
                int _b_im = Convert.ToInt32(box_b_im.Text);

                //gets the methods
                int method = get_methods();
                switch (method)
                {
                  
                    case 0:
                        if ((_a_im - _b_im) < 0)
                        {
                            box_result.Text = Convert.ToString((_a_re - _b_re) + "" + (_a_im - _b_im) + "i");
                        }else{
                            box_result.Text = Convert.ToString((_a_re - _b_re) + "+i" + (_a_im - _b_im));
                        }
                        break;
                    
                    case 1:  
                        if ((-_a_im + _b_im) > 0)
                        {
                            box_result.Text = Convert.ToString((_a_re - _b_re) + "+i" + (-_a_im + _b_im));
                        }
                        else
                        {
                            box_result.Text = Convert.ToString((_a_re - _b_re) + "" + (-_a_im + _b_im) + "i");
                        }
                        
                        break;
                    
                    case 2:
                        if ((-_a_im + _b_im) > 0)
                        {
                            box_result.Text = Convert.ToString((_a_re - _b_re) + "+i" + (-_a_im + _b_im));
                        }
                        else
                        {
                            box_result.Text = Convert.ToString((_a_re - _b_re) + "" + (-_a_im + _b_im) + "i");
                        }       
                        break;
                    
                    case 3:
                        box_result.Text = Convert.ToString((_a_re - _b_re) + "+i" + (_a_im + _b_im));
                        break;
                    case 4:
                        errorz();
                        break;
                }
            }

            private void multi_Click(object sender, EventArgs e)
            {
                string re, im;

                //making it easier for the eyes
                int x1 = Convert.ToInt32(box_a_re.Text);//x1
                int x2 = Convert.ToInt32(box_b_re.Text);//x2
                int y1 = Convert.ToInt32(box_a_im.Text);//y1
                int y2 = Convert.ToInt32(box_b_im.Text);//y2

                //gets the methods
                int method = get_methods();
                switch (method)
                {
                    //++
                    case 0:
                        //(x1+y1i)*(x2+y2i)
                        //Re: x1*x2 - y1*y2
                        //Im: (x1*y2 + y1*x2)i
                        re = Convert.ToString((x1 * x2) - (y1 * y2));
                        im = Convert.ToString(((x1*y2) + (y1*x2)));
                        if (Convert.ToInt32(im) > 0)
                        {
                            box_result.Text = Convert.ToString(re + "+i" + im);
                        }
                        else
                        {
                            box_result.Text = Convert.ToString(re + im + "i");
                        }
                        
                        break;
                    //--
                    case 1:
                        //(x1-y1i)*(x2-y2i)
                        //Re: x1*x2 - y1*y2
                        //Im: (-x1y2 - y1x2)i
                        re = Convert.ToString((x1 * x2) - (y1 * y2));
                        im = Convert.ToString(((-x1 * y2) - (y1 * x2)));
                        if (Convert.ToInt32(im) > 0)
                        {
                            box_result.Text = Convert.ToString(re + "+i" + im);
                        }
                        else
                        {
                            box_result.Text = Convert.ToString(re + im + "i");
                        }

                        break;
                    //-+
                    case 2:
                        //(x1-y1i)*(x2+y2i)
                        //Re: x1*x2 + y1*y2
                        //Im: (-x1y2 - y1x2)i
                        re = Convert.ToString((x1 * x2) + (y1 * y2));
                        im = Convert.ToString(((x1 * y2) - (y1 * x2)));
                        if (Convert.ToInt32(im) > 0)
                        {
                            box_result.Text = Convert.ToString(re + "+i" + im);
                        }
                        else
                        {
                            box_result.Text = Convert.ToString(re + im + "i");
                        }
                        break;
                    //+-
                    case 3:
                        //(x1+y1i)*(x2-y2i)
                        //Re: x1*x2 - y1*y2
                        //Im: (x1y2 + y1x2)i
                        re = Convert.ToString((x1 * x2) - (y1 * y2));
                        im = Convert.ToString(((x1 * y2) + (y1 * x2)));
                        if (Convert.ToInt32(im) > 0)
                        {
                            box_result.Text = Convert.ToString(re + "+i" + im);
                        }
                        else
                        {
                            box_result.Text = Convert.ToString(re + im + "i");
                        }
                        break;
                    case 4:
                        errorz();
                        break;
                }
            }

            private void divide_Click(object sender, EventArgs e)
            {
                //Math.Truncate(Convert.ToDouble(re) * 1000) / 1000) <- is used for making the decimal point only 3 characters

                string re, im;

                //making it easier for the eyes
                double x1 = Convert.ToDouble(box_a_re.Text);//x1
                double x2 = Convert.ToDouble(box_b_re.Text);//x2
                double y1 = Convert.ToDouble(box_a_im.Text);//y1
                double y2 = Convert.ToDouble(box_b_im.Text);//y2

                double below = ((x2 * x2) + (y2 * y2));

                //gets the methods
                int method = get_methods();
                switch (method)
                {
                    //++
                    case 0:
                        re = Convert.ToString(((x1*x2)+(y1*y2)) / below);
                        im = Convert.ToString(((-x1*y2) + (y1*x2)) / below);
                        if (Convert.ToDouble(im) > 0)
                        {
                            box_result.Text = Convert.ToString((Math.Truncate(Convert.ToDouble(re) * 1000) / 1000) + "+i" + (Math.Truncate(Convert.ToDouble(im) * 1000) / 1000));
                        }
                        else
                        {
                            box_result.Text = Convert.ToString((Math.Truncate(Convert.ToDouble(re) * 1000) / 1000) + "" + (Math.Truncate(Convert.ToDouble(im) * 1000) / 1000) + "i");
                        }

                        
                        break;
                    //--
                    case 1:
                        re = Convert.ToString(((x1*x2)+(y1*y2)) / below);
                        im = Convert.ToString(((x1*y2) - (y1*x2)) / below);
                        if (Convert.ToDouble(im) > 0)
                        {
                            box_result.Text = Convert.ToString((Math.Truncate(Convert.ToDouble(re) * 1000) / 1000) + "+i" + (Convert.ToDouble(im) * 1000) / 1000);
                        }
                        else
                        {
                            box_result.Text = Convert.ToString((Math.Truncate(Convert.ToDouble(re) * 1000) / 1000) + "" + (Math.Truncate(Convert.ToDouble(im) * 1000) / 1000) + "i");
                        }

                        break;
                    //-+
                    case 2:
                        re = Convert.ToString(((x1 * x2) - (y1 * y2)) / below);
                        im = Convert.ToString(((-x1 * y2) - (y1 * x2)) / below);
                        if (Convert.ToDouble(im) > 0)
                        {
                            box_result.Text = Convert.ToString((Math.Truncate(Convert.ToDouble(re) * 1000) / 1000) + "+i" + (Convert.ToDouble(im) * 1000) / 1000);
                        }
                        else
                        {
                            box_result.Text = Convert.ToString((Math.Truncate(Convert.ToDouble(re) * 1000) / 1000) + "" + (Math.Truncate(Convert.ToDouble(im) * 1000) / 1000) + "i");
                        }

                        break;
                    //+-
                    case 3:
                        re = Convert.ToString(((x1*x2)-(y1*y2)) / below);
                        im = Convert.ToString(((x1*y2) + (y1*x2)) / below);
                        if (Convert.ToDouble(im) > 0)
                        {
                            box_result.Text = Convert.ToString((Math.Truncate(Convert.ToDouble(re) * 1000) / 1000) + "+i" + (Math.Truncate(Convert.ToDouble(im) * 1000) / 1000));
                        }
                        else
                        {
                            box_result.Text = Convert.ToString((Math.Truncate(Convert.ToDouble(re) * 1000) / 1000) + "" + (Math.Truncate(Convert.ToDouble(im) * 1000) / 1000) + "i");
                        }

                        break;
                    case 4:
                        errorz();
                        break;
                }
            }


            //**************************************************************
    

        
    }
}
