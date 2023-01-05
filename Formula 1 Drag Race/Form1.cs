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
        bool gameStarted = false;
        bool firstPress1 = true;
        bool firstPress2 = true;

        Graphics? graphics;

        readonly Stopwatch reaction1 = new();
        readonly Stopwatch reaction2 = new();

        public GameForm()
        {
            InitializeComponent();
        }

        private void RefreshGame(object sender, EventArgs e)
        {
            if (player1.Right >= finishLine1.Left && gameFinished == false)
            {
                label1.Text = "Player 1 wins!";
                gameFinished = true;
                player1Speed = 0;
                player2Speed = 0;
                //timer1.Stop();
                //freeroam or restart
            }

            if (player2.Right >= finishLine1.Left && gameFinished == false)
            {
                label1.Text = "Player 2 wins!";
                gameFinished = true;
                player1Speed = 0;
                player2Speed = 0;
                //timer1.Stop();
                //freeroam or restart
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

            speedText1.Text = Math.Round(player1Speed * 3.6).ToString() + " km/h";
            speedText2.Text = Math.Round(player2Speed * 3.6).ToString() + "km/h";
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
                    if (reaction1.IsRunning == false)
                    {
                        reactionText1.ForeColor = Color.Red;
                        reactionText1.Text = "Player 1 jumpstart!";
                    }
                    firstPress1 = false;
                }
                wDown = true;
            }
            else if (e.KeyCode == Keys.S)
            {
                if (gameStarted == true)
                {
                    sDown = true;
                }
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
                    if (reaction2.IsRunning == false)
                    {
                        reactionText2.ForeColor = Color.Red;
                        reactionText2.Text = "Player 2 jumpstart!";
                    }
                    firstPress2 = false;
                }
                upDown = true;
            }
            else if (e.KeyCode == Keys.Down)
            {
                downDown = true;
            }

            if (e.KeyCode == Keys.Enter)
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
            Random random = new();
            int rand = random.Next(200, 4000);
            Thread.Sleep(rand);

            for (int i = 0; i < light.Length; i++)
            {
                graphics.FillEllipse(Brushes.DarkGray, light[i]);
            }
            reaction1.Start();
            reaction2.Start();
            timer1.Start();
            gameStarted = true;
            Timer timer = new(HideLights, null, 1000, Timeout.Infinite);
        }

        private void HideLights(object? state)
        {
            Invalidate();
            graphics?.Dispose();
        }
    }
}

//fixa så bilarnas movement blir smooth, just nu hackigt för att jag tvingas avrunda uträkningen av positionerna vid varje tick - så de hoppar tillbaka ibland
//lägga till cheating (om man backar)
//lära mig använda olika threads för att kunna göra flera saker samtidigt, t.ex. kolla och initiera jumpstart samtidigt som lights animationen
//göra fönstret och contenten responsiv/anpassningsbar
//när någon vunnit ska det komma upp ett val så man kan reset game eller freeroam (med en paus ikon)
//göra meny som låter en gå direkt till freeroam eller dragrace
//fixa så bilarnas movement blir smooth, just nu hackigt för att jag tvingas avrunda uträkningen av positionerna vid varje tick - så de hoppar tillbaka ibland