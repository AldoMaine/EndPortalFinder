using System;
using System.IO;
using System.Diagnostics;
using System.Windows.Forms;

namespace EnderPortalFinder
{
    public partial class Form1 : Form
    {

        string path;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            input_TextChanged(this, null);

            path = Application.StartupPath;

            byte[] myfile = Properties.Resources.How_To_Use_the_End_Portal_Finder;
            File.WriteAllBytes(path + "\\instructions.mht", myfile);
        }


        private void input_TextChanged(object sender, EventArgs e)
        {
                  
            //translate weird Minecraft coordinates into normal frame of reference as follows:
            // Minecraft     Normal
            //     X            Y
            //     Z            X
            //    Heading    (360 - Heading)
            double y1 = ValidateAndConvert(txtP1X, "Point 1 X");
            double x1 = ValidateAndConvert(txtP1Z, "Point 1 Z");
            double brg1 = 360 - ValidateAndConvert(txtP1Brg, "Point 1 Bearing");
            double y2 = ValidateAndConvert(txtP2X, "Point 2 X");
            double x2 = ValidateAndConvert(txtP2Z, "Point 2 Z");
            double brg2 = 360 - ValidateAndConvert(txtP2Brg, "Point 2 Bearing");

            // find slope of each line (the m in z = mx + b)
            double slope1 = Math.Tan(brg1 * Math.PI/180);
            double slope2 = Math.Tan(brg2 * Math.PI/180);
            
            //find the z intercept (the b in z = mx + b)
            double yIntercept1 = y1 - slope1 * x1;
            double yIntercept2 = y2 - slope2 * x2;

            //find the portal by solving simultaneous equations to find the intersection of the 2 lines
            double x = (yIntercept2-yIntercept1)/(slope1 - slope2); 
            double y = slope1 * x + yIntercept1;                  

            txtEPX.Text = y.ToString("F1");
            txtEPZ.Text = x.ToString("F1");

        }


        private double ValidateAndConvert(TextBox textBox, string name)
        {
            try
            {
                if (textBox.Text == "")
                {
                    MessageBox.Show(name + " is a required field.", "Entry Error");
                    textBox.Focus();
                    return 0;
                }
                return Convert.ToDouble(textBox.Text);                
            }
            catch (Exception)
            {
                MessageBox.Show(name + " must be a decimal value.", "Entry Error");
                textBox.Focus();
                return 0;
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(path + "\\instructions.mht");           
        }

    }

    

}
