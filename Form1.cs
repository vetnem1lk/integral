using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace integral
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        double dotA, dotB, y;
        int precision;

        private void EmptyString()
        {
            if (txtot.TextLength == 0)
                txtot.BackColor = Color.Snow;

            if (txtdo.TextLength == 0)
                txtdo.BackColor = Color.Snow;
            if (textBox1.TextLength == 0)
                textBox1.BackColor = Color.Snow;
        }

        private void txtdo_TextChanged(object sender, EventArgs e)
        {
            EmptyString();

            if (txtdo.TextLength > 0)
            {
                try
                {
                    dotB = Convert.ToDouble(txtdo.Text);
                    txtdo.BackColor = Color.White;
                }
                catch
                {
                    txtdo.BackColor = Color.IndianRed;
                }

                if (txtot.BackColor == Color.White && txtdo.BackColor == Color.White && textBox1.BackColor == Color.White)
                    btnReady.Enabled = true;
                else
                    btnReady.Enabled = false;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            EmptyString();

            if (textBox1.TextLength > 0)
            {
                try
                {
                    precision = Convert.ToInt32(textBox1.Text);
                    textBox1.BackColor = Color.White;
                }
                catch
                {
                    textBox1.BackColor = Color.IndianRed;
                }

                if (txtot.BackColor == Color.White && txtdo.BackColor == Color.White && textBox1.BackColor == Color.White)
                    btnReady.Enabled = true;
                else
                    btnReady.Enabled = false;
            }
        }

        static double myRound(double x, int precision)
        {
            return ((int)(x * Math.Pow(10.0, precision)) / Math.Pow(10.0, precision));
        }

        private void txtot_TextChanged(object sender, EventArgs e)
        {
            EmptyString();

            if (txtot.TextLength > 0)
            {
                try
                {
                    dotA = Convert.ToDouble(txtot.Text);
                    txtot.BackColor = Color.White;
                }
                catch
                {
                    txtot.BackColor = Color.IndianRed;
                }

                if (txtot.BackColor == Color.White && txtdo.BackColor == Color.White && textBox1.BackColor == Color.White)
                    btnReady.Enabled = true;
                else
                    btnReady.Enabled = false;
            }

        }

        private void btnReady_Click(object sender, EventArgs e)
        {            
            txtOut.Text = string.Empty;

            y = ((Math.Pow(dotB, 3)) / 3) - ((Math.Pow(dotA, 3)) / 3);
            y = myRound(y, precision);
            txtOut.Text = Convert.ToString(y); 

        }
    }
}
