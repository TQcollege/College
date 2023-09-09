using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form_Button_Testing
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string selectedOperation = comboBox1.SelectedItem.ToString();

            if (selectedOperation != null)
            {
                double value1, value2;

                if (double.TryParse(textBox1.Text, out value1) &&
                    double.TryParse(textBox2.Text, out value2))
                {
                    double result = 0;

                    switch (selectedOperation)
                    {
                        case "Add":
                            result = value1 + value2;
                            break;
                        case "Subtract":
                            result = value1 - value2;
                            break;
                        case "Multiply":
                            result = value1 * value2;
                            break;
                        case "Divide":
                            if (value2 != 0)
                            {
                                result = value1 / value2;
                            }
                            else
                            {
                                MessageBox.Show("Cannot divide by zero", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                            break;
                        case "Percentage Increase":
                            result = (value2 - value1) / value1 * 100;
                            break;
                        case "Percentage Decrease":
                            result = (value1 - value2) / value1 * 100;
                            break;

                    }
                    textBox3.Text = result.ToString();
                }

            }    
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Clears drop down box, value 1, value 2 and result text boxes
            comboBox1.Text = string.Empty;
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
            textBox3.Text = string.Empty;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
