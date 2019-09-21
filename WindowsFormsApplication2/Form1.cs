using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        Calc C;
        private void CorrectNumber()
        {   //нельзя писать цифры после ∞
            if (labelNumber.Text.IndexOf("∞") != -1)
                labelNumber.Text = labelNumber.Text.Substring(0, labelNumber.Text.Length - 1);
            //удаляет лишний 0
            if (labelNumber.Text[0] == '0' && (labelNumber.Text.IndexOf(",") != 1))
                labelNumber.Text = labelNumber.Text.Remove(0, 1);
            //удаляет лишний -
            if (labelNumber.Text[0] == '-')
                if (labelNumber.Text[1] == '0' && (labelNumber.Text.IndexOf(",") != 2))
                    labelNumber.Text = labelNumber.Text.Remove(1, 1);
        }
           public Form1()
        {
            InitializeComponent();
            C = new Calc();
            labelNumber.Text = "0";
            saveFileDialog1.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            labelNumber.Text = "0";
            C.Clear_A();
                    
        }

        private void buttonChangeSign_Click(object sender, EventArgs e)
        {
            if (labelNumber.Text[0] == '-')
                labelNumber.Text = labelNumber.Text.Remove(0, 1);
            else
                labelNumber.Text = "-" + labelNumber.Text;
        }

        private void buttonPoint_Click(object sender, EventArgs e)
        {
            if ((labelNumber.Text.IndexOf(",") == -1) && (labelNumber.Text.IndexOf("∞") == -1))
                labelNumber.Text += ",";
        }

        private void button0_Click(object sender, EventArgs e)
        {
            labelNumber.Text += "0";

            CorrectNumber();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            labelNumber.Text += "1";

            CorrectNumber();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            labelNumber.Text += "2";

            CorrectNumber();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            labelNumber.Text += "3";

            CorrectNumber();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            labelNumber.Text += "4";

            CorrectNumber();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            labelNumber.Text += "5";

            CorrectNumber();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            labelNumber.Text += "6";

            CorrectNumber();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            labelNumber.Text += "7";

            CorrectNumber();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            labelNumber.Text += "8";

            CorrectNumber();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            labelNumber.Text += "9";

            CorrectNumber();
        }

                private void buttonSin_Click(object sender, EventArgs e)
        {
                C.Put_A(Convert.ToDouble(labelNumber.Text));
                labelNumber.Text = C.siin(Convert.ToDouble(labelNumber.Text)).ToString();
        }

        private void buttonCos_Click(object sender, EventArgs e)
        {
                C.Put_A(Convert.ToDouble(labelNumber.Text));
                labelNumber.Text = C.coos(Convert.ToDouble(labelNumber.Text)).ToString();
                            }

        private void buttonTg_Click(object sender, EventArgs e)
        {
                C.Put_A(Convert.ToDouble(labelNumber.Text));
                labelNumber.Text = C.tan(Convert.ToDouble(labelNumber.Text)).ToString();
        }
        private void buttonCtg_Click(object sender, EventArgs e)
        {
                C.Put_A(Convert.ToDouble(labelNumber.Text));
                labelNumber.Text = C.ctan(Convert.ToDouble(labelNumber.Text)).ToString();
        }
        private void buttonSec_Click(object sender, EventArgs e)
        {
                C.Put_A(Convert.ToDouble(labelNumber.Text));
                labelNumber.Text = C.sec(Convert.ToDouble(labelNumber.Text)).ToString();
            
        }
        private void buttonCosec_Click(object sender, EventArgs e)
        {
            C.Put_A(Convert.ToDouble(labelNumber.Text));
            labelNumber.Text = C.cosec(Convert.ToDouble(labelNumber.Text)).ToString();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
    if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
        return;
        string filename = saveFileDialog1.FileName;
        File.WriteAllText(filename, labelNumber.Text);
        MessageBox.Show("Файл сохранен");
}

        private void buttonDel_Click(object sender, EventArgs e)
        {
            int lenght = labelNumber.Text.Length - 1;
            string text = labelNumber.Text;
            labelNumber.Text = null;
            for (int i = 0; i < lenght; i++)
            {
                labelNumber.Text = labelNumber.Text + text[i];
            }
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char symbol = e.KeyChar;
            switch (symbol)
                {
                case ',':
                case '.':
                    buttonPoint_Click(buttonPoint, null);
                    break;
                case '0':
                    button0_Click(button0, null);
                    break;
                case '1':
                    button1_Click(button1, null);
                    break;
                case '2':
                    button2_Click(button2, null);
                    break;
                case '3':
                    button3_Click(button3, null);
                    break;
                case '4':
                    button4_Click(button4, null);
                    break;
                case '5':
                    button5_Click(button5, null);
                    break;
                case '6':
                    button6_Click(button6, null);
                    break;
                case '7':
                    button7_Click(button7, null);
                    break;
                case '8':
                    button8_Click(button1, null);
                    break;
                case '9':
                    button9_Click(button9, null);
                    break;
                case '-':
                    buttonChangeSign_Click(buttonChangeSign, null);
                    break;
                case 'c':
                    buttonDel_Click(buttonDel, null);
                    break;
                           }
        }
                   }
}
