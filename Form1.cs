using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorApp
{
    public partial class Form1 : Form
    {
        Double resultValue = 0;
        String operationPerformed = "";
        bool isOperationPerformed = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if(textBox_Result.Text == Double.NaN.ToString())
            {
                textBox_Result.Text = resultValue.ToString();
            }
        }

        private void Digit2_Click(object sender, EventArgs e)
        {
            
        }

        private void Digit3_Click(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {
            
        }

        private void Digit5_Click(object sender, EventArgs e)
        {

        }

        private void Digit6_Click(object sender, EventArgs e)
        {
           
        }

        private void Digit7_Click(object sender, EventArgs e)
        {
            
        }

        private void Digit9_Click(object sender, EventArgs e)
        {
          
        }

        private void Digit0_Click(object sender, EventArgs e)
        {
            
        }

        private void Dot_Click(object sender, EventArgs e)
        {
           
        }

        private void button_Click(object sender, EventArgs e)
        {
            if (textBox_Result.Text == "0"||(isOperationPerformed))
            {
                textBox_Result.Clear();
            }
            isOperationPerformed = false;
            Button button = (Button)sender;
            if (button.Text == ".")
            {
                if (!textBox_Result.Text.Contains("."))
                {
                    textBox_Result.Text = textBox_Result.Text + button.Text;
                }
            }
            else
            {
                textBox_Result.Text = textBox_Result.Text + button.Text;
            }
        }

        private void operator_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            operationPerformed = button.Text;
            resultValue = Double.Parse(textBox_Result.Text);
            labelResult.Text = resultValue + " " + operationPerformed;
            isOperationPerformed = true;
        }

        private void ClearEntry_Click(object sender, EventArgs e)
        {
            textBox_Result.Text = "0";
            labelResult.Text = "";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox_Result.Text = "0";
            resultValue = 0;
        }

        private void Equal_Click(object sender, EventArgs e)
        {
            switch(operationPerformed)
            {
                case "+":
                    textBox_Result.Text = (resultValue + Double.Parse(textBox_Result.Text)).ToString();
                    break;
                case "-":
                    textBox_Result.Text = (resultValue - Double.Parse(textBox_Result.Text)).ToString();
                    break;
                case "*":
                    textBox_Result.Text = (resultValue * Double.Parse(textBox_Result.Text)).ToString();
                    break;
                case "/":
                    textBox_Result.Text = (resultValue / Double.Parse(textBox_Result.Text)).ToString();
                    break;
                default:
                    break;
            }
            resultValue = Double.Parse(textBox_Result.Text);
            labelResult.Text = resultValue.ToString();
        }

        private void textBox_Result_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void domainUpDown1_SelectedItemChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text.ToString() == "Binary" && comboBox2.Text.ToString() == "Decimal")
            {
                    ConvertNum.Clear();
                    int binaryNum = int.Parse(enterNum.Text);
                    System.Text.RegularExpressions.Regex r = new System.Text.RegularExpressions.Regex("^[0-1]+$");
                    int decimalNum = 0;
                    int initialNum = 1;
                    int temp = binaryNum;
                    while (temp > 0 && r.Match(binaryNum.ToString()).Success)
                    {
                        int last_digit = temp % 10;
                        temp = temp / 10;

                        decimalNum += last_digit * initialNum;

                        initialNum = initialNum * 2;
                    }
                    ConvertNum.Text = decimalNum.ToString();
                    enterNum.Clear();
            }

            else if (comboBox1.Text.ToString() == "Decimal" && comboBox2.Text.ToString() == "Binary")
            {
                ConvertNum.Clear();
                int num = Convert.ToInt32(enterNum.Text);
                int val;
                string result = "";
                while (num != 0)
                {
                    val = num / 2;
                    result += (num % 2).ToString();
                    num = val;
                }
                string binValue = Convert.ToString(num, 2);
                for (int i = result.Length - 1; i >= 0; i--)
                {
                    binValue = binValue + result[i];
                }
                ConvertNum.Text = binValue.ToString();
                enterNum.Clear();
            }
            else
            {
                MessageBox.Show("Please Select Correct Fields!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Binary_Key_Press(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (comboBox1.Text.ToString() == "Binary" && comboBox2.Text.ToString() == "Decimal")
            {
                if (ch == 48 || ch == 49)
                {
                    e.Handled = false;
                }
                else
                {
                    MessageBox.Show("Please Enter Correct Values!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
