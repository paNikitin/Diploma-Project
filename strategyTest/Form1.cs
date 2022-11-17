using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace strategyTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void button17_Click(object sender, EventArgs e)
        {
            int _val1 = 0;
            int.TryParse(textBox1.Text, out _val1);
            int _val2 = 0;
            int.TryParse(textBox2.Text, out _val2);
            if ((_val1 > 0) & (_val1 % 2 == 0))
            {
                if (_val2 > 0)
                {
                    if ((radioButton1.Checked) & (radioButton3.Checked))
                    {
                        Evolution evolution = new Evolution();
                        evolution.Run(int.Parse(textBox1.Text), int.Parse(textBox2.Text), 1, 1);
                    }
                    else if ((radioButton2.Checked) & (radioButton4.Checked))
                    {
                        Evolution evolution = new Evolution();
                        evolution.Run(int.Parse(textBox1.Text), int.Parse(textBox2.Text), 1, 1);
                    }
                    
                }
                else
                {
                    PopUpForm popup = new PopUpForm();
                    DialogResult dialogresult = popup.ShowDialog();
                    if (dialogresult == DialogResult.OK)
                    {
                        popup.Dispose();
                    }
                }
            }
            else
            {
                PopUpForm popup = new PopUpForm();
                DialogResult dialogresult = popup.ShowDialog();
                if (dialogresult == DialogResult.OK)
                {
                    popup.Dispose();
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            RecognizeAction action = new RecognizeAction();
            TrainingSet trainingSet = new TrainingSet();
            if (InputPixels.Sum() != 0)
            {
                label3.Text = action.Action(InputPixels).ToString();
                label3.ForeColor = Color.YellowGreen;
                label3.Visible = true;
            }
            else
            {
                PopUpForm popup = new PopUpForm();
                DialogResult dialogresult = popup.ShowDialog();
                if (dialogresult == DialogResult.OK)
                {
                    popup.Dispose();
                }  
            }
            
        }

        private int[] _inputPixels = new int[15] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        public int[] InputPixels { get => _inputPixels; }
        private void ChangeState(Button b, int index)
        {
            if (b.BackColor == Color.Black)
            {
                b.BackColor = Color.YellowGreen;
                _inputPixels[index] = 1;
            }
            else if (b.BackColor == Color.YellowGreen)
            {
                b.BackColor = Color.Black;
                _inputPixels[index] = 0;
            }
        }
        private void button9_Click(object sender, EventArgs e) => ChangeState(button9, 0);

        private void button2_Click(object sender, EventArgs e) => ChangeState(button2, 1);

        private void button3_Click(object sender, EventArgs e) => ChangeState(button3, 2);

        private void button6_Click(object sender, EventArgs e) => ChangeState(button6, 3);

        private void button5_Click(object sender, EventArgs e) => ChangeState(button5, 4);

        private void button4_Click(object sender, EventArgs e) => ChangeState(button4, 5);

        private void button10_Click(object sender, EventArgs e) => ChangeState(button10, 6);

        private void button8_Click(object sender, EventArgs e) => ChangeState(button8, 7);

        private void button7_Click(object sender, EventArgs e) => ChangeState(button7, 8);
        private void button13_Click(object sender, EventArgs e) => ChangeState(button13, 9);
        private void button12_Click(object sender, EventArgs e) => ChangeState(button12, 10);

        private void button11_Click(object sender, EventArgs e) => ChangeState(button11, 11);

        private void button16_Click(object sender, EventArgs e) => ChangeState(button16, 12);

        private void button15_Click(object sender, EventArgs e) => ChangeState(button15, 13);

        private void button14_Click(object sender, EventArgs e) => ChangeState(button14, 14);

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            radioButton2.Checked =false;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            radioButton1.Checked = false;
        }

        private void radioButton1_Click(object sender, EventArgs e)
        {
            radioButton1.Checked = true;
            radioButton2.Checked = false;
        }

        private void radioButton2_Click(object sender, EventArgs e)
        {
            radioButton1.Checked = false;
            radioButton2.Checked = true;
        }

        private void radioButton4_Click(object sender, EventArgs e)
        {
            radioButton3.Checked = false;
            radioButton4.Checked = true;
        }

        private void radioButton3_Click(object sender, EventArgs e)
        {
            radioButton3.Checked = true;
            radioButton4.Checked = false;
        }
    }
}
