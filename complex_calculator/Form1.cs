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
                        box_result.Text = Convert.ToString((_a_re + _b_re) + "+i" + (-_a_im + _b_im));
                        break;
                    case 3:
                        box_result.Text = Convert.ToString((_a_re + _b_re) + "+i" + (_a_im - _b_im));
                        break;
                    case 4:
                        MessageBox.Show("The switch function went to case 4", "ERROR",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                }
            }
            //**************************************************************
    

        
    }
}
