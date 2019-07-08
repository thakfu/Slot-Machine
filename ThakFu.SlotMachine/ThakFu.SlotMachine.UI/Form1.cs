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

        public int credits = 0;
        public int bet = 50;
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
        public int spinsWon = 0;
        public int l1on = 0;
        public int l2on = 0;
        public int l3on = 0;
        public int l4on = 0;
        public int l5on = 0;


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
            }
            else
            {
                if (credits >= bet)
                {
                    credits = credits - bet;
                    await NewMethod();
                }
                else
                {
                    lblResult.Text = "GAME OVER";
                }

            }

        }

        private async Task NewMethod()
        {

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
            lblBox1.Text = "---";
            lblBox2.Text = "---";
            lblBox3.Text = "---";
            lblBox4.Text = "---";
            lblBox5.Text = "---";
            lblBox6.Text = "---";
            lblBox7.Text = "---";
            lblBox8.Text = "---";
            lblBox9.Text = "---";
            lblBox10.Text = "---";
            lblBox11.Text = "---";
            lblBox12.Text = "---";
            lblBox13.Text = "---";
            lblBox14.Text = "---";
            lblBox15.Text = "---"; await Task.Delay(100);
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

            //if (resultPost[1] == "BONUS" || resultPost[2] == "BONUS" || resultPost[3] == "BONUS")
            if ((resultPost[1] == "BONUS" || resultPost[2] == "BONUS" || resultPost[3] == "BONUS") & 
                (resultPost[4] == "BONUS" || resultPost[5] == "BONUS" || resultPost[6] == "BONUS") & 
                (resultPost[7] == "BONUS" || resultPost[8] == "BONUS" || resultPost[9] == "BONUS"))
            {
                if (bonusTriggered == 0)
                {
                    lblTest.Text = "BONUS TRIGGERED";
                    total = total + winB;
                    lblResult.Text += "Won " + winB + " on BONUS.  ";
                    bonusTriggered = 1;
                    spinsWon = 10;
                    btnSpin.Text = "START BONUS";
                }
                else
                {
                    lblTest.Text = "BONUS RE-TRIGGERED";
                    total = total + winB;
                    lblResult.Text += "Won " + winB + " on BONUS.  ";
                    spinsWon = spinsWon + 10;
                }
            }


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

            if ((resultPost[1] == line1 || resultPost[1] == "CHERRY") & (resultPost[4] == line1 || resultPost[4] == "CHERRY") & 
                (resultPost[7] == line1 || resultPost[7] == "CHERRY") & (resultPost[10] != line1 & resultPost[10] != "CHERRY"))
            { win1 = 5 * mult1; total = total + win1; lblResult.Text += "Won " + win1 + " on line 1.  "; }

            if ((resultPost[1] == line1 || resultPost[1] == "CHERRY") & (resultPost[4] == line1 || resultPost[4] == "CHERRY") & 
                (resultPost[7] == line1 || resultPost[7] == "CHERRY") & (resultPost[10] == line1 || resultPost[10] == "CHERRY") & 
                (resultPost[13] != line1 & resultPost[13] != "CHERRY"))
            { win1 = 10 * mult1; total = total + win1; lblResult.Text += "Won " + win1 + " on line 1.  "; }

            if ((resultPost[1] == line1 || resultPost[1] == "CHERRY") & (resultPost[4] == line1 || resultPost[4] == "CHERRY") & 
                (resultPost[7] == line1 || resultPost[7] == "CHERRY") & (resultPost[10] == line1 || resultPost[10] == "CHERRY") & 
                (resultPost[13] == line1 || resultPost[13] == "CHERRY"))
            { win1 = 25 * mult1; total = total + win1; lblResult.Text += "Won " + win1 + " on line 1.  "; }



            if ((resultPost[2] == line2 || resultPost[2] == "CHERRY") & (resultPost[5] == line2 || resultPost[5] == "CHERRY") & 
                (resultPost[8] == line2 || resultPost[8] == "CHERRY") & (resultPost[11] != line2 & resultPost[11] != "CHERRY"))
            { win2 = 5 * mult2; total = total + win2; lblResult.Text += "Won " + win2 + " on line 2.  "; }

            if ((resultPost[2] == line2 || resultPost[2] == "CHERRY") & (resultPost[5] == line2 || resultPost[5] == "CHERRY") & 
                (resultPost[8] == line2 || resultPost[8] == "CHERRY") & (resultPost[11] == line2 || resultPost[11] == "CHERRY") & 
                (resultPost[14] != line2 & resultPost[14] != "CHERRY"))
            { win2 = 10 * mult2; total = total + win2; lblResult.Text += "Won " + win2 + " on line 2.  "; }

            if ((resultPost[2] == line2 || resultPost[2] == "CHERRY") & (resultPost[5] == line2 || resultPost[5] == "CHERRY") & 
                (resultPost[8] == line2 || resultPost[8] == "CHERRY") & (resultPost[11] == line2 || resultPost[11] == "CHERRY") & 
                (resultPost[14] == line2 || resultPost[14] == "CHERRY"))
            { win2 = 25 * mult2; total = total + win2; lblResult.Text += "Won " + win2 + " on line 2.  "; }



            if ((resultPost[3] == line3 || resultPost[3] == "CHERRY") & (resultPost[6] == line3 || resultPost[6] == "CHERRY") & 
                (resultPost[9] == line3 || resultPost[9] == "CHERRY") & (resultPost[12] != line3 & resultPost[12] != "CHERRY"))
            { win3 = 5 * mult3; total = total + win3; lblResult.Text += "Won " + win3 + " on line 3.  "; }

            if ((resultPost[3] == line3 || resultPost[3] == "CHERRY") & (resultPost[6] == line3 || resultPost[6] == "CHERRY") & 
                (resultPost[9] == line3 || resultPost[9] == "CHERRY") & (resultPost[12] == line3 || resultPost[12] == "CHERRY") & 
                (resultPost[0] != line3 & resultPost[0] != "CHERRY"))
            { win3 = 10 * mult3; total = total + win3; lblResult.Text += "Won " + win3 + " on line 3.  "; }

            if ((resultPost[3] == line3 || resultPost[3] == "CHERRY") & (resultPost[6] == line3 || resultPost[6] == "CHERRY") & 
                (resultPost[9] == line3 || resultPost[9] == "CHERRY") & (resultPost[12] == line3 || resultPost[12] == "CHERRY") & 
                (resultPost[0] == line3 || resultPost[0] == "CHERRY"))
            { win3 = 25 * mult3; total = total + win3; lblResult.Text += "Won " + win3 + " on line 3.  "; }



            if ((resultPost[1] == line4 || resultPost[1] == "CHERRY") & (resultPost[5] == line4 || resultPost[5] == "CHERRY") & 
                (resultPost[9] == line4 || resultPost[9] == "CHERRY") & (resultPost[11] != line4 & resultPost[11] != "CHERRY"))
            { win4 = 5 * mult4; total = total + win4; lblResult.Text += "Won " + win4 + " on line 4.  "; }

            if ((resultPost[1] == line4 || resultPost[1] == "CHERRY") & (resultPost[5] == line4 || resultPost[5] == "CHERRY") & 
                (resultPost[9] == line4 || resultPost[9] == "CHERRY") & (resultPost[11] == line4 || resultPost[11] == "CHERRY") & 
                (resultPost[13] != line4 & resultPost[13] != "CHERRY"))
            { win4 = 10 * mult4; total = total + win4; lblResult.Text += "Won " + win4 + " on line 4.  "; }

            if ((resultPost[1] == line4 || resultPost[1] == "CHERRY") & (resultPost[5] == line4 || resultPost[5] == "CHERRY") & 
                (resultPost[9] == line4 || resultPost[9] == "CHERRY") & (resultPost[11] == line4 || resultPost[11] == "CHERRY") & 
                (resultPost[13] == line4 || resultPost[13] == "CHERRY"))
            { win4 = 25 * mult4; total = total + win4; lblResult.Text += "Won " + win4 + " on line 4.  "; }



            if ((resultPost[3] == line5 || resultPost[3] == "CHERRY") & (resultPost[5] == line5 || resultPost[5] == "CHERRY") & 
                (resultPost[7] == line5 || resultPost[7] == "CHERRY") & (resultPost[11] != line5 & resultPost[11] != "CHERRY"))
            { win5 = 5 * mult5; total = total + win5; lblResult.Text += "Won " + win5 + " on line 5.  "; }

            if ((resultPost[3] == line5 || resultPost[3] == "CHERRY") & (resultPost[5] == line5 || resultPost[5] == "CHERRY") & 
                (resultPost[7] == line5 || resultPost[7] == "CHERRY") & (resultPost[11] == line5 || resultPost[11] == "CHERRY") & 
                (resultPost[0] != line5 & resultPost[0] != "CHERRY"))
            { win5 = 10 * mult5; total = total + win5; lblResult.Text += "Won " + win5 + " on line 5.  "; }

            if ((resultPost[3] == line5 || resultPost[3] == "CHERRY") & (resultPost[5] == line5 || resultPost[5] == "CHERRY") & 
                (resultPost[7] == line5 || resultPost[7] == "CHERRY") & (resultPost[11] == line5 || resultPost[11] == "CHERRY") & 
                (resultPost[0] == line5 || resultPost[0] == "CHERRY"))
            { win5 = 25 * mult5; total = total + win5; lblResult.Text += "Won " + win5 + " on line 5.  "; }

            lblWin.Text = "Win: " + total.ToString();
            credits = credits + total;
            lblCredits.Text = "Credits: " + credits.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblCredits.Text = "Credits: " + credits.ToString();
            lblBet.Text = "Bet: " + bet.ToString();
        }

        private async void RunBonus()
        {
            for (int i = 1; i <= spinsWon; i++)
            {
                await NewMethod();
                lblTest.Text += " Spin " + i + " of " + spinsWon;
                await Task.Delay(5000);
            }
            lblTest.Text = "Bonus Completed";
            bonusTriggered = 0;
            btnSpin.Text = "SPIN";
        }

        private void btn1Line_Click(object sender, EventArgs e)
        {
            if (l1on == 0)
            {

                l1on = 1;
                btn1Line.BackColor = Color.Lime;
                lblBox1.ForeColor = Color.Red;
                lblBox2.ForeColor = Color.Black;
                lblBox3.ForeColor = Color.Black;
                lblBox4.ForeColor = Color.Red;
                lblBox5.ForeColor = Color.Black;
                lblBox6.ForeColor = Color.Black;
                lblBox7.ForeColor = Color.Red;
                lblBox8.ForeColor = Color.Black;
                lblBox9.ForeColor = Color.Black;
                lblBox10.ForeColor = Color.Red;
                lblBox11.ForeColor = Color.Black;
                lblBox12.ForeColor = Color.Black;
                lblBox13.ForeColor = Color.Red;
                lblBox14.ForeColor = Color.Black;
                lblBox15.ForeColor = Color.Black;
            }
            else
            {
                l1on = 0;
                btn1Line.BackColor = Color.FromArgb(255, 128, 128);
                lblBox1.ForeColor = Color.Black;
                lblBox2.ForeColor = Color.Black;
                lblBox3.ForeColor = Color.Black;
                lblBox4.ForeColor = Color.Black;
                lblBox5.ForeColor = Color.Black;
                lblBox6.ForeColor = Color.Black;
                lblBox7.ForeColor = Color.Black;
                lblBox8.ForeColor = Color.Black;
                lblBox9.ForeColor = Color.Black;
                lblBox10.ForeColor = Color.Black;
                lblBox11.ForeColor = Color.Black;
                lblBox12.ForeColor = Color.Black;
                lblBox13.ForeColor = Color.Black;
                lblBox14.ForeColor = Color.Black;
                lblBox15.ForeColor = Color.Black;
            }

        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            credits = credits + 500;
            lblCredits.Text = "Credits: " + credits.ToString();
        }
    }
}
