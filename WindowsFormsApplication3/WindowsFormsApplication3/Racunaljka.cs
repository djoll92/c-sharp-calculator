using System;
using System.Drawing;
using System.Windows.Forms;

namespace Racunaljka
{
    public partial class Racunaljka : Form
    {
        public Racunaljka()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MaximizeBox = false;
            textBox1.Text = "0";
            menuStrip1.Select();
            this.KeyUp += new KeyEventHandler(Form1_KeyUp);
        }

        double i, j, x;
        char c = ' ';
        String tekst;

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            switch(e.KeyCode)
            {
                case Keys.D1:
                case Keys.NumPad1:
                    button1.PerformClick();
                    break;
                case Keys.D2:
                case Keys.NumPad2:
                    button2.PerformClick();
                    break;
                case Keys.Enter:
                    button4.PerformClick();
                    break;
                case Keys.D3:
                case Keys.NumPad3:
                    button7.PerformClick();
                    break;
                case Keys.D0:
                case Keys.NumPad0:
                    button6.PerformClick();
                    break;
                case Keys.D5:
                case Keys.NumPad5:
                    button8.PerformClick();
                    break;
                case Keys.D4:
                case Keys.NumPad4:
                    button9.PerformClick();
                    break;
                case Keys.D7:
                case Keys.NumPad7:
                    button12.PerformClick();
                    break;
                case Keys.D6:
                case Keys.NumPad6:
                    button10.PerformClick();
                    break;
                case Keys.D8:
                case Keys.NumPad8:
                    button11.PerformClick();
                    break;
                case Keys.D9:
                case Keys.NumPad9:
                    button13.PerformClick();
                    break;
                case Keys.Subtract:
                    button14.PerformClick();
                    break;
                case Keys.Multiply:
                    button15.PerformClick();
                    break;
                case Keys.Divide:
                    button16.PerformClick();
                    break;
                case Keys.Back:
                    button18.PerformClick();
                    break;
                case Keys.Decimal:
                    button19.PerformClick();
                    break;
                case Keys.Add:
                    button3.PerformClick();
                    break;
                case Keys.Delete:
                    button17.PerformClick();
                    break;
                default:
                    break;
            }
        }

        //dugme 1
        private void button1_Click(object sender, EventArgs e)
        {
            broj("1");
        }

        //dugme 2
        private void button2_Click(object sender, EventArgs e)
        {
            broj("2");
        }

        //dugme '='
        private void button4_Click(object sender, EventArgs e)
        {
            if (c != ' ')
            {
                if (c == '+')
                {
                    j = Convert.ToDouble(textBox1.Text);
                    x = ClassLibrary1.Digitron.saberi(i, j);
                    textBox1.Text = x.ToString();
                    c = ' ';
                }
                else if (c == '-')
                {
                    j = Convert.ToDouble(textBox1.Text);
                    x = ClassLibrary1.Digitron.oduzmi(i, j);
                    textBox1.Text = x.ToString();
                    c = ' ';
                }
                else if (c == '/')
                {
                    j = Convert.ToDouble(textBox1.Text);
                    if (j == 0)
                    {
                        if (i == 0)
                        {
                            tekst = "Rezultat nije definisan!!!";
                        }
                        else
                        {
                            tekst = "Deljenje s nulom nije moguće!!!";
                        }
                        textBox1.Text = tekst;
                        c = ' ';
                    }
                    else
                    {
                        x = ClassLibrary1.Digitron.podeli(i, j);
                        textBox1.Text = x.ToString();
                        c = ' ';
                    }
                }
                else if (c == '*')
                {
                    j = Convert.ToDouble(textBox1.Text);
                    x = ClassLibrary1.Digitron.pomnozi(i, j);
                    textBox1.Text = x.ToString();
                    c = ' ';
                }
                if ((c == '/' && j != 0) || c != '/')
                {
                    if (j < 0)
                    {
                        textBox2.Text = textBox2.Text + "(" + Convert.ToString(j) + ") = ";
                    }
                    else
                    {
                        textBox2.Text = textBox2.Text + Convert.ToString(j) + " = "; 
                    }
                }
            }
        }

        //dugme C
        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            textBox2.Text = String.Empty;
            c = ' ';
        }

        //dugme 3
        private void button7_Click(object sender, EventArgs e)
        {
            broj("3");
        }

        //dugme 0
        private void button6_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "0" && textBox1.Text != tekst)
            {
                textBox1.Text = textBox1.Text + "0";
            }
            else
            {
                textBox1.Text = "0";
            }
        }

        //dugme 6
        private void button10_Click(object sender, EventArgs e)
        {
            broj("6");
        }

        //dugme 5
        private void button8_Click(object sender, EventArgs e)
        {
            broj("5");
        }

        //dugme 4
        private void button9_Click(object sender, EventArgs e)
        {
            broj("4");
        }

        //dugme 7
        private void button12_Click(object sender, EventArgs e)
        {
            broj("7");
        }

        //dugme 8
        private void button11_Click(object sender, EventArgs e)
        {
            broj("8");
        }

        //dugme 9
        private void button13_Click(object sender, EventArgs e)
        {
            broj("9");
        }

        //dugme '-'
        private void button14_Click(object sender, EventArgs e)
        {
            operacija('-');
        }

        //dugme '*'
        private void button15_Click(object sender, EventArgs e)
        {
            operacija('*');
        }

        //dugme '/'
        private void button16_Click(object sender, EventArgs e)
        {
            operacija('/');
        }

        //dugme Bspace
        private void button18_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != tekst)
            {
                textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 1);
                if (textBox1.Text == String.Empty)
                {
                    textBox1.Text = "0";
                }
            }
        }

        //dugme CE
        private void button17_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
        }

        //dugme '.'
        private void button19_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != tekst)
            {
                if (!textBox1.Text.Contains("."))
                {
                    textBox1.Text = textBox1.Text + ".";
                }
            }
        }

        //dugme 'sign'
        private void button20_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != tekst)
            {
                double pom = Convert.ToDouble(textBox1.Text);
                textBox1.Text = Convert.ToString(ClassLibrary1.Digitron.negiraj(pom));
                if (textBox2.Text.Contains("="))
                {
                    textBox2.Text = String.Empty;
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text == tekst)
            {
                textBox1.Font = new Font("Calibri", 16, FontStyle.Bold);
                textBox1.TextAlign = HorizontalAlignment.Center;
            }
            else
            {
                textBox1.Font = new Font("Calibri", 22);
                textBox1.TextAlign = HorizontalAlignment.Right;
            }

            if (textBox1.Text.Length > 16 && textBox1.Text != tekst)
            {
                textBox1.Text = x.ToString("E9");
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text == tekst)
            {
                textBox2.Text = String.Empty;
            }
        }

        //dugme '+'
        private void button3_Click(object sender, EventArgs e)
        {
            operacija('+');
        }

        void operacija (char op)
        {
            if (c == ' ' && textBox1.Text != tekst)
            {
                i = Convert.ToDouble(textBox1.Text);
                textBox1.Text = "0";
                c = op;
                textBox2.Text = Convert.ToString(i) + " " + op + " ";
            }
        }

        void broj(string br)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = String.Empty;
            }
            if (textBox1.Text != tekst && j == 0.0D)
            {
                textBox1.Text = textBox1.Text + br;
            }
            else
            {
                textBox1.Text = br;
                j = 0.0D;
                textBox2.Text = String.Empty;
            }
        }
    }
}
