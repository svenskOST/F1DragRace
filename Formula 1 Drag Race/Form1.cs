using System.Windows.Forms;

namespace Formula_1_Drag_Race
{
    public partial class Form1 : Form
    {
        double playerSpeed = 0;
        double opponentSpeed = 0;
        double maxSpeed = 100;

        bool wDown;
        bool sDown;
        bool gameFinished;

        public Form1()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void OnTick(object sender, EventArgs e)
        {
            if (player.Right >= finishLine1.Left && gameFinished == false)
            {
                label1.Text = "You win!";
                gameFinished = true;
            }

            if (opponent.Right >= finishLine1.Left && gameFinished == false)
            {
                label1.Text = "You lose!";
                gameFinished = true;
            }

            if (Focused)
            {
                if (wDown == true)
                {
                    if (playerSpeed < maxSpeed)
                    {
                        playerSpeed += 0.1;
                    }
                }
                else if (sDown == true)
                {
                    if (playerSpeed > 0)
                    {
                        playerSpeed -= 0.1;
                    }
                }
            }

            if (opponentSpeed < maxSpeed)
            {
                opponentSpeed += 0.08;
            }

            player.Left += (int)Math.Round(playerSpeed);
            opponent.Left += (int)Math.Round(opponentSpeed);
        }

        private void KD(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.W)
            {
                wDown = true;
            }
            else if (e.KeyCode == Keys.S)
            {
                sDown = true;
            }
        }

        private void KU(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.W)
            {
                wDown = false;
            }
            else if (e.KeyCode == Keys.S)
            {
                sDown = false;
            }
        }
    }
}