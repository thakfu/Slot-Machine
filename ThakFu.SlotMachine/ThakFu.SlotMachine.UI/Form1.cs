using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThakFu.SlotMachine.UI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSpin_Click(object sender, EventArgs e)
        {
            String[] resultPost = new string[15];
            string result = "blank";
            Random random = new Random();

            for (int i = 0; i < resultPost.Length; i++)
            {
                
                int resultNum = random.Next(1, 10);
                
                switch (resultNum)
                {
                    case 1:
                        result = "10";
                        break;
                    case 2:
                        result = "J";
                        break;
                    case 3:
                        result = "Q";
                        break;
                    case 4:
                        result = "K";
                        break;
                    case 5:
                        result = "A";
                        break;
                    case 6:
                        result = "BONUS";
                        break;
                    case 7:
                        result = "BAR";
                        break;
                    case 8:
                        result = "CHERRY";
                        break;
                    case 9:
                        result = "7";
                        break;
                    case 10:
                        result = "777";
                        break;

                }

                resultPost[i] = result;

            }

            lblBox1.Text = resultPost[1];
            lblBox2.Text = resultPost[2];
            lblBox3.Text = resultPost[3];
            lblBox4.Text = resultPost[4];
            lblBox5.Text = resultPost[5];
            lblBox6.Text = resultPost[6];
            lblBox7.Text = resultPost[7];
            lblBox8.Text = resultPost[8];
            lblBox9.Text = resultPost[9];
            lblBox10.Text = resultPost[10];
            lblBox11.Text = resultPost[11];
            lblBox12.Text = resultPost[12];
            lblBox13.Text = resultPost[13];
            lblBox14.Text = resultPost[14];
            lblBox15.Text = resultPost[0];
            lblResult.Text = "";
            lblTest.Text = "";

            string line1 = "null";
            if (resultPost[1] == "CHERRY")
            {
                line1 = resultPost[4];
                if (resultPost[4] == "CHERRY")
                {
                    line1 = resultPost[7];
                    if (resultPost[7] == "CHERRY")
                    {
                        line1 = resultPost[10];
                        if (resultPost[10] == "CHERRY")
                        {
                            line1 = resultPost[13];
                            if (resultPost[13] == "CHERRY")
                            {
                                lblResult.Text += "JACKPOT LINE 1";
                            }
                        }
                    }
                }
            }
            else
            {
                line1 = resultPost[1];
            }
            lblTest.Text = line1;

            string line2 = "null";
            if (resultPost[2] == "CHERRY")
            {
                line2 = resultPost[5];
                if (resultPost[5] == "CHERRY")
                {
                    line2 = resultPost[8];
                    if (resultPost[8] == "CHERRY")
                    {
                        line2 = resultPost[11];
                        if (resultPost[11] == "CHERRY")
                        {
                            line2 = resultPost[14];
                            if (resultPost[14] == "CHERRY")
                            {
                                lblResult.Text += "JACKPOT LINE 2";
                            }
                        }
                    }
                }
            }
            else
            {
                line2 = resultPost[2];
            }
            lblTest.Text += line2;

            string line3 = "null";
            if (resultPost[3] == "CHERRY")
            {
                line3 = resultPost[6];
                if (resultPost[6] == "CHERRY")
                {
                    line3 = resultPost[9];
                    if (resultPost[9] == "CHERRY")
                    {
                        line3 = resultPost[12];
                        if (resultPost[12] == "CHERRY")
                        {
                            line3 = resultPost[15];
                            if (resultPost[15] == "CHERRY")
                            {
                                lblResult.Text += "JACKPOT LINE 3";
                            }
                        }
                    }
                }
            }
            else
            {
                line3 = resultPost[3];
            }
            lblTest.Text += line3;


            if (line1 == resultPost[4] || resultPost[4] == "CHERRY")
            {
                lblResult.Text = "2 of a kind on line 1";
                if (line1 == resultPost[7] || resultPost[7] == "CHERRY")
                {
                    lblResult.Text = "3 of a kind on line 1";
                    if (line1 == resultPost[10] || resultPost[10] == "CHERRY")
                    {
                        lblResult.Text = "4 of a kind on line 1";
                        if (line1 == resultPost[13] || resultPost[13] == "CHERRY")
                        {
                            lblResult.Text = "5 of a kind on line 1";
                        }
                    }
                }
            }
            else
            {
                lblResult.Text = "Spin Again";
            }

        }
    }
}
