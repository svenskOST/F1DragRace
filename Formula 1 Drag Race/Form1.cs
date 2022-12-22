namespace Formula_1_Drag_Race
{
    public partial class GameForm : Form
    {
        double playerSpeed = 0;
        double opponentSpeed = 0;
        double maxSpeed = 100;

        bool wDown;
        bool sDown;
        bool gameFinished;

        Graphics? graphics;

        public GameForm()
        {
            InitializeComponent();
        }

        private void RefreshGame(object sender, EventArgs e)
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
                        playerSpeed += 0.3;
                    }
                }
                else if (sDown == true)
                {
                    if (playerSpeed > 0)
                    {
                        playerSpeed -= 0.3;
                    }
                }
            }

            if (opponentSpeed < maxSpeed)
            {
                opponentSpeed += 0.4;
            }

            player.Left += (int)Math.Round(playerSpeed);
            opponent.Left += (int)Math.Round(opponentSpeed);
        }

        private void IsKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.W)
            {
                wDown = true;
            }
            else if (e.KeyCode == Keys.S)
            {
                sDown = true;
            }
            else if (e.KeyCode == Keys.Enter)
            {
                LightsOut();
            }
        }

        private void IsKeyUp(object sender, KeyEventArgs e)
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

        private void LightsOut()
        {
            label2.Visible = false;

            graphics = CreateGraphics();

            Rectangle container = new(377, 270, 525, 100);
            graphics.FillRectangle(Brushes.Black, container);

            Rectangle[] light = new Rectangle[5];

            for (int i = 0; i < light.Length; i++)
            {
                light[i] = new(398 + i * 101, 280, 80, 80);
                graphics.FillEllipse(Brushes.DarkGray, light[i]);
            }

            for (int i = 0; i < light.Length; i++)
            {
                Thread.Sleep(1000);
                graphics.FillEllipse(Brushes.Red, light[i]);
            }
            Random random = new Random();
            int rand = random.Next(200, 4000);
            Thread.Sleep(rand);

            for (int i = 0; i < light.Length; i++)
            {
                graphics.FillEllipse(Brushes.DarkGray, light[i]);
            }
            timer1.Start();
        }
    }
}

//göra opponent till player2 som styrs med piltangenterna
//göra om player variables till objekt (player1) med egenskaper (maxspeed) och metoder (Drive eller accelerate osv)