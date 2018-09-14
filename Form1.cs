using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Calculate_Click(object sender, EventArgs e)
        {
            int result = 0;
            //Write the code
            int nr1 = 0; //int.Parse(textBox1.Text);
            int nr2 = 0; //int.Parse(textBox2.Text);
            try
            {
                nr1 = int.Parse(textBox1.Text);
                nr2 = int.Parse(textBox2.Text);
            }
            catch { }

            //this "try" makes sure that if no operator is chosen, the default is "Add" and we avoid an error/crash
            string option = "Add";
            try
            {
                option = comboBox1.SelectedItem.ToString();
            }
            catch { }

            switch (comboBox1.SelectedItem.ToString())
            {
                case "Add":
                    result = nr1 + nr2;
                    break;
                case "Subtract":
                    result = nr1 - nr2;
                    break;
                case "Divide":
                    result = nr1 / nr2;
                    break;
                case "Multiply":
                    result = nr1 * nr2;
                    break;
                default:
                    Console.WriteLine("Default case");
                    break;
            }

            if (result == 0)
                label1.Text = "That is not a number";
            else
                label1.Text = "The result is " + result;

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
  
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
