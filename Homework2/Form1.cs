using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ECommerce;

namespace Homework2
{
    public partial class Form1 : Form
    {
        private Timer diceTimer = new Timer();
        private Dice dice;
        
        private int diceStopCounter;

        public Form1()
        {
            InitializeComponent();
        }

        private void onTextBox1Changed(object sender, EventArgs e)
        {
            int inputNumber;
            // TextBox is empty
            if (textBox1.Text.Equals(""))
            {
                ansLabel1.Text = "=";
            }
            // TextBox contains a number
            else if (int.TryParse(textBox1.Text, out inputNumber))
            {
                int ans = MathUtil.AddFromOneTo(inputNumber);
                ansLabel1.Text = String.Format("= {0}", ans);
            }
            // TextBox is not number
            else
            {
                ansLabel1.Text = "請輸入數字";
            }
        }

        private void onTextBox2Changed(object sender, EventArgs e)
        {
            int inputNumber;
            // TextBox contains a number
            if (int.TryParse(textBox2.Text, out inputNumber))
            {
                bool isPrime = MathUtil.IsPrime(inputNumber);
                ansLabel2.Text = String.Format("-> {0}", isPrime ? "是質數" : "不是質數");
            }
            else
            {
                ansLabel2.Text = "請輸入數字";
            }
        }
        
        private void RandomDice(object sender, EventArgs e)
        {
            //pictureBox1.Image = Properties.Resources.dice2;
            int diceNuber = dice.roll();
            pictureBox1.Image = (Image) Properties.Resources.ResourceManager.GetObject(String.Format("dice{0}", diceNuber));

            if (diceStopCounter != 0)
            {
                if (diceStopCounter == 1)
                {
                    diceTimer.Enabled = false;
                    diceButton.Enabled = true;
                    diceButton.Text = "按住以骰骰子";
                }
                diceStopCounter -= 1;
            }
        }
        
        private void onStartRandomDice(object sender, MouseEventArgs e)
        {
            dice = new Dice();

            diceStopCounter = 0;
            diceTimer.Tick += new EventHandler(RandomDice);
            diceTimer.Interval = 100;
            diceTimer.Enabled = true;

            diceButton.Text = "下好離手~";
        }

        // 慢慢變慢，不馬上停止
        private void onStopRandomDice(object sender, MouseEventArgs e)
        {
            diceStopCounter = 5;
            diceTimer.Interval = 500;

            diceButton.Enabled = false;
            diceButton.Text = "等骰子停下...";
        }
    }
}
