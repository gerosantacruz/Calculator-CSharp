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
            if(result.Text == "0")
            {
                result.Clear();
            }

            Button b = (Button)sender;
            result.Text = result.Text + b.Text;
        }

        private void ButtonC_Click(object sender, EventArgs e)
        {
            result.Text = "0";
        }

        private void Operator (object sender, EventArgs e)
        {

        }
    }
}
