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

        public int credits = 100;
        public int bet = 5;
        public int total = 0;
        public int win1 = 0;
        public int win2 = 0;
        public int win3 = 0;
        public int win4 = 0;
        public int win5 = 0;
        public int winB = 100;
        public int mult1 = 1;
        public int mult2 = 1;
        public int mult3 = 1;
        public int mult4 = 1;
        public int mult5 = 1;
        public int bonusTriggered = 0;


        string line1 = "null";
        string line2 = "null";
        string line3 = "null";
        string line4 = "null";
        string line5 = "null";




        private async void btnSpin_Click(object sender, EventArgs e)
        {

            if (bonusTriggered == 1)
            {
                RunBonus();
                bonusTriggered = 0;
            }
            else
                await NewMethod();
        }

        private async Task NewMethod()
        {
            if (credits >= bet)
            {
                credits = credits - bet;
                lblCredits.Text = "Credits: " + credits.ToString();

                String[] resultPost = new string[15];
                string result = "blank";
                Random random = new Random();

                for (int i = 0; i < resultPost.Length; i++)
                {

                    int resultNum = random.Next(1, 11);

                    switch (resultNum)
                    {
                        case 1:
                            result = "10";
                            break;
                        case 2:
                            result = "10";
                            break;
                        case 3:
                            result = "J";
                            break;
                        case 4:
                            result = "J";
                            break;
                        case 5:
                            result = "Q";
                            break;
                        case 6:
                            result = "K";
                            break;
                        case 7:
                            result = "A";
                            break;
                        case 8:
                            result = "CHERRY";
                            break;
                        case 9:
                            result = "BONUS";
                            break;
                        case 10:
                            result = "777";
                            break;

                    }

                    resultPost[i] = result;

                }
                lblResult.Text = "";
                lblTest.Text = "";
                lblBox1.Text = resultPost[1]; await Task.Delay(100);
                lblBox2.Text = resultPost[2]; await Task.Delay(100);
                lblBox3.Text = resultPost[3]; await Task.Delay(100);
                lblBox4.Text = resultPost[4]; await Task.Delay(100);
                lblBox5.Text = resultPost[5]; await Task.Delay(100);
                lblBox6.Text = resultPost[6]; await Task.Delay(100);
                lblBox7.Text = resultPost[7]; await Task.Delay(100);
                lblBox8.Text = resultPost[8]; await Task.Delay(100);
                lblBox9.Text = resultPost[9]; await Task.Delay(100);
                lblBox10.Text = resultPost[10]; await Task.Delay(100);
                lblBox11.Text = resultPost[11]; await Task.Delay(100);
                lblBox12.Text = resultPost[12]; await Task.Delay(100);
                lblBox13.Text = resultPost[13]; await Task.Delay(100);
                lblBox14.Text = resultPost[14]; await Task.Delay(100);
                lblBox15.Text = resultPost[0];


                total = 0;

                line1 = resultPost[1];
                line2 = resultPost[2];
                line3 = resultPost[3];
                line4 = resultPost[1];
                line5 = resultPost[3];

                // if ((resultPost[1] == "BONUS" || resultPost[2] == "BONUS" || resultPost[3] == "BONUS") & (resultPost[4] == "BONUS" || resultPost[5] == "BONUS" || resultPost[6] == "BONUS") & (resultPost[7] == "BONUS" || resultPost[8] == "BONUS" || resultPost[9] == "BONUS")) { lblTest.Text = "BONUS TRIGGERED"; total = total + winB; lblResult.Text += "Won " + winB + " on BONUS.  "; bonusTriggered = 1; }
                if ((resultPost[1] == "BONUS" || resultPost[2] == "BONUS" || resultPost[3] == "BONUS")) { lblTest.Text = "BONUS TRIGGERED"; total = total + winB; lblResult.Text += "Won " + winB + " on BONUS.  "; bonusTriggered = 1; }

                if (resultPost[1] == "CHERRY") { line1 = resultPost[4].ToString(); line4 = resultPost[5].ToString(); }
                if (resultPost[2] == "CHERRY") { line2 = resultPost[5].ToString(); }
                if (resultPost[3] == "CHERRY") { line3 = resultPost[6].ToString(); line5 = resultPost[5].ToString(); }

                if (line1 == "CHERRY") { line1 = resultPost[7]; }
                if (line2 == "CHERRY") { line2 = resultPost[8]; }
                if (line3 == "CHERRY") { line3 = resultPost[9]; }
                if (line4 == "CHERRY") { line4 = resultPost[9]; }
                if (line5 == "CHERRY") { line5 = resultPost[7]; }

                if (line1 == "CHERRY" & resultPost[7] == "CHERRY") { line1 = resultPost[10]; }
                if (line2 == "CHERRY" & resultPost[8] == "CHERRY") { line2 = resultPost[11]; }
                if (line3 == "CHERRY" & resultPost[9] == "CHERRY") { line3 = resultPost[12]; }
                if (line4 == "CHERRY" & resultPost[9] == "CHERRY") { line4 = resultPost[11]; }
                if (line5 == "CHERRY" & resultPost[7] == "CHERRY") { line5 = resultPost[11]; }

                if (line1 == "CHERRY" & resultPost[10] == "CHERRY") { line1 = resultPost[13]; }
                if (line2 == "CHERRY" & resultPost[11] == "CHERRY") { line2 = resultPost[14]; }
                if (line3 == "CHERRY" & resultPost[12] == "CHERRY") { line3 = resultPost[15]; }
                if (line4 == "CHERRY" & resultPost[11] == "CHERRY") { line4 = resultPost[13]; }
                if (line5 == "CHERRY" & resultPost[11] == "CHERRY") { line5 = resultPost[15]; }

                if (line1 == "CHERRY") { total = total + 200; lblResult.Text += "JACKPOT Won " + total + " on line 1.  "; }
                if (line2 == "CHERRY") { total = total + 200; lblResult.Text += "JACKPOT Won " + total + " on line 2.  "; }
                if (line3 == "CHERRY") { total = total + 200; lblResult.Text += "JACKPOT Won " + total + " on line 3.  "; }
                if (line4 == "CHERRY") { total = total + 200; lblResult.Text += "JACKPOT Won " + total + " on line 4.  "; }
                if (line5 == "CHERRY") { total = total + 200; lblResult.Text += "JACKPOT Won " + total + " on line 5.  "; }

                if (line1 == "10") { mult1 = 1; }
                if (line1 == "J") { mult1 = 2; }
                if (line1 == "Q") { mult1 = 3; }
                if (line1 == "K") { mult1 = 4; }
                if (line1 == "A") { mult1 = 5; }
                if (line1 == "777") { mult1 = 10; }
                if (line1 == "BONUS") { mult1 = 0; }

                if (line2 == "10") { mult2 = 1; }
                if (line2 == "J") { mult2 = 2; }
                if (line2 == "Q") { mult2 = 3; }
                if (line2 == "K") { mult2 = 4; }
                if (line2 == "A") { mult2 = 5; }
                if (line2 == "777") { mult2 = 10; }
                if (line2 == "BONUS") { mult2 = 0; }

                if (line3 == "10") { mult3 = 1; }
                if (line3 == "J") { mult3 = 2; }
                if (line3 == "Q") { mult3 = 3; }
                if (line3 == "K") { mult3 = 4; }
                if (line3 == "A") { mult3 = 5; }
                if (line3 == "777") { mult3 = 10; }
                if (line3 == "BONUS") { mult3 = 0; }

                if (line4 == "10") { mult4 = 1; }
                if (line4 == "J") { mult4 = 2; }
                if (line4 == "Q") { mult4 = 3; }
                if (line4 == "K") { mult4 = 4; }
                if (line4 == "A") { mult4 = 5; }
                if (line4 == "777") { mult4 = 10; }
                if (line4 == "BONUS") { mult4 = 0; }

                if (line5 == "10") { mult5 = 1; }
                if (line5 == "J") { mult5 = 2; }
                if (line5 == "Q") { mult5 = 3; }
                if (line5 == "K") { mult5 = 4; }
                if (line5 == "A") { mult5 = 5; }
                if (line5 == "777") { mult5 = 10; }
                if (line5 == "BONUS") { mult5 = 0; }

                if ((resultPost[1] == line1 || resultPost[1] == "CHERRY") & (resultPost[4] == line1 || resultPost[4] == "CHERRY") & (resultPost[7] == line1 || resultPost[7] == "CHERRY") & (resultPost[10] != line1 & resultPost[10] != "CHERRY")) { win1 = 5 * mult1; total = total + win1; lblResult.Text += "Won " + win1 + " on line 1.  "; }
                if ((resultPost[1] == line1 || resultPost[1] == "CHERRY") & (resultPost[4] == line1 || resultPost[4] == "CHERRY") & (resultPost[7] == line1 || resultPost[7] == "CHERRY") & (resultPost[10] == line1 || resultPost[10] == "CHERRY") & (resultPost[13] != line1 & resultPost[13] != "CHERRY")) { win1 = 10 * mult1; total = total + win1; lblResult.Text += "Won " + win1 + " on line 1.  "; }
                if ((resultPost[1] == line1 || resultPost[1] == "CHERRY") & (resultPost[4] == line1 || resultPost[4] == "CHERRY") & (resultPost[7] == line1 || resultPost[7] == "CHERRY") & (resultPost[10] == line1 || resultPost[10] == "CHERRY") & (resultPost[13] == line1 || resultPost[13] == "CHERRY")) { win1 = 25 * mult1; total = total + win1; lblResult.Text += "Won " + win1 + " on line 1.  "; }

                if ((resultPost[2] == line2 || resultPost[2] == "CHERRY") & (resultPost[5] == line2 || resultPost[5] == "CHERRY") & (resultPost[8] == line2 || resultPost[8] == "CHERRY") & (resultPost[11] != line2 & resultPost[11] != "CHERRY")) { win2 = 5 * mult2; total = total + win2; lblResult.Text += "Won " + win2 + " on line 2.  "; }
                if ((resultPost[2] == line2 || resultPost[2] == "CHERRY") & (resultPost[5] == line2 || resultPost[5] == "CHERRY") & (resultPost[8] == line2 || resultPost[8] == "CHERRY") & (resultPost[11] == line2 || resultPost[11] == "CHERRY") & (resultPost[14] != line2 & resultPost[14] != "CHERRY")) { win2 = 10 * mult2; total = total + win2; lblResult.Text += "Won " + win2 + " on line 2.  "; }
                if ((resultPost[2] == line2 || resultPost[2] == "CHERRY") & (resultPost[5] == line2 || resultPost[5] == "CHERRY") & (resultPost[8] == line2 || resultPost[8] == "CHERRY") & (resultPost[11] == line2 || resultPost[11] == "CHERRY") & (resultPost[14] == line2 || resultPost[14] == "CHERRY")) { win2 = 25 * mult2; total = total + win2; lblResult.Text += "Won " + win2 + " on line 2.  "; }

                if ((resultPost[3] == line3 || resultPost[3] == "CHERRY") & (resultPost[6] == line3 || resultPost[6] == "CHERRY") & (resultPost[9] == line3 || resultPost[9] == "CHERRY") & (resultPost[12] != line3 & resultPost[12] != "CHERRY")) { win3 = 5 * mult3; total = total + win3; lblResult.Text += "Won " + win3 + " on line 3.  "; }
                if ((resultPost[3] == line3 || resultPost[3] == "CHERRY") & (resultPost[6] == line3 || resultPost[6] == "CHERRY") & (resultPost[9] == line3 || resultPost[9] == "CHERRY") & (resultPost[12] == line3 || resultPost[12] == "CHERRY") & (resultPost[0] != line3 & resultPost[0] != "CHERRY")) { win3 = 10 * mult3; total = total + win3; lblResult.Text += "Won " + win3 + " on line 3.  "; }
                if ((resultPost[3] == line3 || resultPost[3] == "CHERRY") & (resultPost[6] == line3 || resultPost[6] == "CHERRY") & (resultPost[9] == line3 || resultPost[9] == "CHERRY") & (resultPost[12] == line3 || resultPost[12] == "CHERRY") & (resultPost[0] == line3 || resultPost[0] == "CHERRY")) { win3 = 25 * mult3; total = total + win3; lblResult.Text += "Won " + win3 + " on line 3.  "; }

                if ((resultPost[1] == line4 || resultPost[1] == "CHERRY") & (resultPost[5] == line4 || resultPost[5] == "CHERRY") & (resultPost[9] == line4 || resultPost[9] == "CHERRY") & (resultPost[11] != line4 & resultPost[11] != "CHERRY")) { win4 = 5 * mult4; total = total + win4; lblResult.Text += "Won " + win4 + " on line 4.  "; }
                if ((resultPost[1] == line4 || resultPost[1] == "CHERRY") & (resultPost[5] == line4 || resultPost[5] == "CHERRY") & (resultPost[9] == line4 || resultPost[9] == "CHERRY") & (resultPost[11] == line4 || resultPost[11] == "CHERRY") & (resultPost[13] != line4 & resultPost[13] != "CHERRY")) { win4 = 10 * mult4; total = total + win4; lblResult.Text += "Won " + win4 + " on line 4.  "; }
                if ((resultPost[1] == line4 || resultPost[1] == "CHERRY") & (resultPost[5] == line4 || resultPost[5] == "CHERRY") & (resultPost[9] == line4 || resultPost[9] == "CHERRY") & (resultPost[11] == line4 || resultPost[11] == "CHERRY") & (resultPost[13] == line4 || resultPost[13] == "CHERRY")) { win4 = 25 * mult4; total = total + win4; lblResult.Text += "Won " + win4 + " on line 4.  "; }

                if ((resultPost[3] == line5 || resultPost[3] == "CHERRY") & (resultPost[5] == line5 || resultPost[5] == "CHERRY") & (resultPost[7] == line5 || resultPost[7] == "CHERRY") & (resultPost[11] != line5 & resultPost[11] != "CHERRY")) { win5 = 5 * mult5; total = total + win5; lblResult.Text += "Won " + win5 + " on line 5.  "; }
                if ((resultPost[3] == line5 || resultPost[3] == "CHERRY") & (resultPost[5] == line5 || resultPost[5] == "CHERRY") & (resultPost[7] == line5 || resultPost[7] == "CHERRY") & (resultPost[11] == line5 || resultPost[11] == "CHERRY") & (resultPost[0] != line5 & resultPost[0] != "CHERRY")) { win5 = 10 * mult5; total = total + win5; lblResult.Text += "Won " + win5 + " on line 5.  "; }
                if ((resultPost[3] == line5 || resultPost[3] == "CHERRY") & (resultPost[5] == line5 || resultPost[5] == "CHERRY") & (resultPost[7] == line5 || resultPost[7] == "CHERRY") & (resultPost[11] == line5 || resultPost[11] == "CHERRY") & (resultPost[0] == line5 || resultPost[0] == "CHERRY")) { win5 = 25 * mult5; total = total + win5; lblResult.Text += "Won " + win5 + " on line 5.  "; }


                lblWin.Text = "Win: " + total.ToString();
                credits = credits + total;
                lblCredits.Text = "Credits: " + credits.ToString();

            }
            else
            {
                lblResult.Text = "GAME OVER";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblCredits.Text = "Credits: " + credits.ToString();
            lblBet.Text = "Bet: " + bet.ToString();
        }

        private async void RunBonus()
        {
            await NewMethod(); lblTest.Text = "Spin 1 of 10"; await Task.Delay(5000);
            await NewMethod(); lblTest.Text = "Spin 2 of 10"; await Task.Delay(5000);
            await NewMethod(); lblTest.Text = "Spin 3 of 10"; await Task.Delay(5000);
            await NewMethod(); lblTest.Text = "Spin 4 of 10"; await Task.Delay(5000);
            await NewMethod(); lblTest.Text = "Spin 5 of 10"; await Task.Delay(5000);
            await NewMethod(); lblTest.Text = "Spin 6 of 10"; await Task.Delay(5000);
            await NewMethod(); lblTest.Text = "Spin 7 of 10"; await Task.Delay(5000);
            await NewMethod(); lblTest.Text = "Spin 8 of 10"; await Task.Delay(5000);
            await NewMethod(); lblTest.Text = "Spin 9 of 10"; await Task.Delay(5000);
            await NewMethod(); lblTest.Text = "Spin 10 of 10"; await Task.Delay(5000);
            lblTest.Text = "Bonus Completed";
        }


    }
}
