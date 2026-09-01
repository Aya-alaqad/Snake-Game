using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Snake_Game
{
    public partial class Form1 : Form
    {
        enum enLosingCause { hitBoundries=1,hitItSelf=2}
        clsSnake snake;
        bool isStopped = false;
        int foodSize = 40;
        Point food;
        int score;
        Random r = new Random();
        public Form1()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
        }

        private void resetGameToDefault()
        {
            isStopped = false;
            food = new Point(400, 400);
            snake = new clsSnake();
            snake.body.Add(new Point(500, 500));
            score = 0;

            lblScore.Text =score.ToString();
            pbStop.Enabled = true;
            timer1.Start();

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            resetGameToDefault();
          
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(Properties.Resources.apple,food.X,food.Y,foodSize,foodSize);

            foreach(Point p in snake.body)
            {
                e.Graphics.FillRectangle(Brushes.Brown, p.X, p.Y, snake.partSize,snake.partSize);
            }
        }

        private void changeFoodPosition()
        {
           food.X= r.Next(0,this.ClientSize.Width-foodSize);
           food.Y= r.Next(topPanel.ClientSize.Height, this.ClientSize.Height-foodSize);
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (isStopped)
                return true;

            switch(keyData)
            {
                case (Keys.Up):
                    if (snake.direction != clsSnake.enDirection.down)
                        snake.direction = clsSnake.enDirection.up;
                    return true;
                case Keys.Down:
                    if (snake.direction != clsSnake.enDirection.up)
                        snake.direction = clsSnake.enDirection.down;
                    return true;
                case Keys.Right:
                    if (snake.direction != clsSnake.enDirection.left)
                        snake.direction = clsSnake.enDirection.right;
                    return true;
                case Keys.Left:
                    if (snake.direction != clsSnake.enDirection.right)
                        snake.direction = clsSnake.enDirection.left;
                    return true;
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }
        private void playerLose(enLosingCause cause)
        {
            timer1.Stop();
            pbStop.Enabled = false;       
            string message = (cause == enLosingCause.hitItSelf ? "Snake hit it self" : "Snake hit the wall");
            message += "         ";
            MessageBox.Show(message, "Game Over");

        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            snake.move();
            Invalidate();

            if (snake.isSnakeBreakBoundries(0, this.ClientSize.Width, topPanel.ClientSize.Height, this.ClientSize.Height))
            {
                playerLose(enLosingCause.hitBoundries);
                return;
            }
            if (snake.isThereCollission())
            {
                playerLose(enLosingCause.hitItSelf);
                return;
            }

            if (snake.isFoodHitted(food, foodSize))
            {
                snake.addPart();
                changeFoodPosition();
                score += 1;
                lblScore.Text = score.ToString();
            }
           
        }

        private void pbRestart_Click(object sender, EventArgs e)
        {
            resetGameToDefault();
        }

        private void pbStop_Click(object sender, EventArgs e)
        {
            isStopped = !isStopped;
            if (isStopped)
            {
                timer1.Stop();
                pbStop.Image = Properties.Resources.stop;
            }
            else
            {
                timer1.Start();
                pbStop.Image = Properties.Resources.play;
            }

        }
    }
}
