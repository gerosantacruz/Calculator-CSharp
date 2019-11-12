using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator
{
    public partial class Form1 : Form
    {
        Double value = 0;
        String opera = "";
        bool opera_click = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void Button4_Click(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void ButtonClick(object sender, EventArgs e)
        {
            if((result.Text == "0") || (opera_click))
            {
                result.Clear();
            }
            opera_click = false;
            Button b = (Button)sender;

            if(b.Text == ".")
            {
                if (!result.Text.Contains("."))
                {
                    result.Text = result.Text + b.Text;
                }
            }
            else
            {
                result.Text = result.Text + b.Text;
            }
            
        }

        private void ButtonCE_Click(object sender, EventArgs e)
        {
            result.Text = "0";
        }

        private void Operator(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            opera = b.Text;
            value = Double.Parse(result.Text);
            opera_click = true;
            equation.Text = value + " " + opera;
        }

        private void Equal_button_Click(object sender, EventArgs e)
        {
            equation.Text = "";
            switch(opera)
            {
                case "+":
                    result.Text = ( value + Double.Parse(result.Text)).ToString();
                    break;
                case "-":
                    result.Text = (value - Double.Parse(result.Text)).ToString();
                    break;
                case "/":
                    result.Text = (value / Double.Parse(result.Text)).ToString();
                    break;
                case "*":
                    result.Text = (value * Double.Parse(result.Text)).ToString();
                    break;
                default:
                    break;
            }
            
        }

        private void CButton(object sender, EventArgs e)
        {
            result.Clear();
            value = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
