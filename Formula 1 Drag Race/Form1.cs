using Timer = System.Threading.Timer;
using System.Diagnostics;

namespace Formula_1_Drag_Race
{
    public partial class GameForm : Form
    {
        double player1Speed = 0;
        double player2Speed = 0;
        readonly double maxSpeed = 100;
        readonly double maxReverse = -40;

        bool wDown;
        bool sDown;
        bool upDown;
        bool downDown;
        bool gameFinished;
        bool restartGame = false;
        bool firstPress1 = true;
        bool firstPress2 = true;

        Graphics? graphics;
        Rectangle[]? light;

        readonly Stopwatch reaction1 = new();
        readonly Stopwatch reaction2 = new();

        public GameForm()
        {
            InitializeComponent();
        }

        private void RefreshGame(object sender, EventArgs e)
        {
            if (gameFinished == false)
            {
                if (player1.Right >= finishLine1.Left && player1Speed > 0)
                {
                    label1.Text = "Player 1 wins!";
                    gameFinished = true;
                    label2.Visible = true;
                    Invalidate();
                    graphics?.Dispose();
                    label2.Text = "Press Enter to restart...";
                    restartGame = true;
                }
                else if (player1.Left <= finishLine1.Right && player1.Left > 500 && player1Speed < 0)
                {
                    label1.ForeColor = Color.Red;
                    label1.Text = "Player 1 cheated!";
                    gameFinished = true;
                    label2.Visible = true;
                    Invalidate();
                    graphics?.Dispose();
                    label2.Text = "Press Enter to restart...";
                    restartGame = true;
                }

                if (player2.Right >= finishLine1.Left && player2Speed > 0)
                {
                    label1.Text = "Player 2 wins!";
                    gameFinished = true;
                    label2.Visible = true;
                    Invalidate();
                    graphics?.Dispose();
                    label2.Text = "Press Enter to restart...";
                    restartGame = true;
                }
                else if (player2.Left <= finishLine1.Right && player2.Left > 500 && player2Speed < 0)
                {
                    label1.ForeColor = Color.Red;
                    label1.Text = "Player 2 cheated!";
                    gameFinished = true;
                    Invalidate();
                    graphics?.Dispose();
                    label2.Visible = true;
                    label2.Text = "Press Enter to restart...";
                    restartGame = true;
                }
            }

            if (wDown == true)
            {
                if (player1Speed < maxSpeed)
                {
                    player1Speed += 0.3;
                }
                if (player1Speed < 0)
                {
                    player1Speed += 0.6;
                }
            }
            else if (sDown == true)
            {
                if (player1Speed > maxReverse)
                {
                    player1Speed -= 0.15;
                }
                if (player1Speed > 0)
                {
                    player1Speed -= 0.6;
                }
            }

            if (upDown == true)
            {
                if (player2Speed < maxSpeed)
                {
                    player2Speed += 0.3;
                }
                if (player2Speed < 0)
                {
                    player2Speed += 0.6;
                }
            }
            else if (downDown == true)
            {
                if (player2Speed > maxReverse)
                {
                    player2Speed -= 0.15;
                }
                if (player2Speed > 0)
                {
                    player2Speed -= 0.6;
                }
            }
            
            if (player1Speed > 0 && wDown == false)
            {
                player1Speed -= 0.2;
            }
            else if (player1Speed < 0 && sDown == false)
            {
                player1Speed += 0.3;
            }

            if (player2Speed > 0 && upDown == false)
            {
                player2Speed -= 0.2;
            }
            else if (player2Speed < 0 && downDown == false)
            {
                player2Speed += 0.3;
            }

            if (player1.Left >= 1280)
            {
                player1.Left = -200;
            }
            else if (player1.Right <= 0)
            {
                player1.Left = 1280;
            }

            if (player2.Left >= 1280)
            {
                player2.Left = -200;
            }
            else if (player2.Right <= 0)
            {
                player2.Left = 1280;
            }

            if (-1 < player1Speed && player1Speed < 1)
            {
                speedText1.Text = "0 km/h";
            }
            else
            {
                speedText1.Text = Math.Round(player1Speed * 3.6).ToString() + " km/h";
            }
            if (-1 < player2Speed && player2Speed < 1)
            {
                speedText2.Text = "0 km/h";
            }
            else
            {
                speedText2.Text = Math.Round(player2Speed * 3.6).ToString() + "km/h";
            }
            player1.Left += (int)Math.Round(player1Speed);
            player2.Left += (int)Math.Round(player2Speed);
        }

        private void IsKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.W)
            {
                if (firstPress1 == true)
                {
                    if (reaction1.IsRunning == true)
                    {
                        reaction1.Stop();
                        reactionText1.Text = "Reaction: " + reaction1.ElapsedMilliseconds.ToString() + " ms";
                    }
                    else if (reaction1.IsRunning == false && gameFinished == false)
                    {
                        reactionText1.ForeColor = Color.Red;
                        reactionText1.Text = "Jumpstart!";
                        label1.ForeColor = Color.Red;
                        label1.Text = "Player 1 jumpstart!";
                        gameFinished = true;
                        Invalidate();
                        graphics?.Dispose();
                        label2.Visible = true;
                        label2.Text = "Press Enter to restart...";
                        restartGame = true;
                    }
                    firstPress1 = false;
                }
                wDown = true;
            }
            else if (e.KeyCode == Keys.S)
            {
                sDown = true;
            }

            if (e.KeyCode == Keys.Up)
            {
                if (firstPress2 == true)
                {
                    if (reaction2.IsRunning == true)
                    {
                        reaction2.Stop();
                        reactionText2.Text = "Reaction: " + reaction2.ElapsedMilliseconds.ToString() + " ms";
                    }
                    else if (reaction2.IsRunning == false && gameFinished == false)
                    {
                        reactionText2.ForeColor = Color.Red;
                        reactionText2.Text = "Jumpstart!";
                        label1.ForeColor = Color.Red;
                        label1.Text = "Player 2 jumpstart!";
                        gameFinished = true;
                        Invalidate();
                        graphics?.Dispose();
                        label2.Visible = true;
                        label2.Text = "Press Enter to restart...";
                        restartGame = true;
                    }
                    firstPress2 = false;
                }
                upDown = true;
            }
            else if (e.KeyCode == Keys.Down)
            {
                downDown = true;
            }

            if (e.KeyCode == Keys.Enter && restartGame == true)
            {
                Application.Restart();
            }
            else if (e.KeyCode == Keys.Enter && timer1.Enabled == false)
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

            if (e.KeyCode == Keys.Up)
            {
                upDown = false;
            }
            else if (e.KeyCode == Keys.Down)
            {
                downDown = false;
            }
        }

        private void LightsOut()
        {
            label2.Visible = false;

            graphics = CreateGraphics();

            Rectangle container = new(377, 270, 525, 100);
            graphics.FillRectangle(Brushes.Black, container);

            light = new Rectangle[5];

            for (int i = 0; i < light.Length; i++)
            {
                light[i] = new(398 + i * 101, 280, 80, 80);
                graphics.FillEllipse(Brushes.DarkGray, light[i]);
            }

            Timer timer3 = new(Light1On, null, 1000, Timeout.Infinite);
            Timer timer4 = new(Light2On, null, 2000, Timeout.Infinite);
            Timer timer5 = new(Light3On, null, 3000, Timeout.Infinite);
            Timer timer6 = new(Light4On, null, 4000, Timeout.Infinite);
            Timer timer7 = new(Light5On, null, 5000, Timeout.Infinite);

            Random random = new();
            int rand = random.Next(200, 4000);
            Timer timer8 = new(LightsOff, null, 5000 + rand, Timeout.Infinite);

            Timer timer2 = new(HideLights, null, 5000 + rand + 1000, Timeout.Infinite);
            timer1.Start();
        }

        private void HideLights(object? state)
        {
            Invalidate();
            graphics?.Dispose();
        }

        private void Light1On(object? state)
        {
            if (!gameFinished && light is not null)
            {
                graphics?.FillEllipse(Brushes.Red, light[0]);
            }
        }

        private void Light2On(object? state)
        {
            if (!gameFinished && light is not null)
            {
                graphics?.FillEllipse(Brushes.Red, light[1]);
            }
        }

        private void Light3On(object? state)
        {
            if (!gameFinished && light is not null)
            {
                graphics?.FillEllipse(Brushes.Red, light[2]);
            }
        }

        private void Light4On(object? state)
        {
            if (!gameFinished && light is not null)
            {
                graphics?.FillEllipse(Brushes.Red, light[3]);
            }
        }

        private void Light5On(object? state)
        {
            if (!gameFinished && light is not null)
            {
                graphics?.FillEllipse(Brushes.Red, light[4]);
            }
        }

        private void LightsOff(object? state)
        {
            if (!gameFinished && light is not null)
            {
                for (int i = 0; i < light.Length; i++)
                {
                    graphics?.FillEllipse(Brushes.DarkGray, light[i]);
                }
                reaction1.Start();
                reaction2.Start();
            }
        }
    }
}