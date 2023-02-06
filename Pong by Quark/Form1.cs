using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pong
{
    public partial class Form1 : Form
    {
        // Los valores de puntuación iniciales
        private int leftScore = 0;
        private int rightScore = 0;

        // La pelota y las palas
        private Ball ball;
        private Paddle leftPaddle;
        private Paddle rightPaddle;

        // La velocidad de la pelota
        private int ballSpeedX = 5;
        private int ballSpeedY = 5;

        public Form1()
        {
            InitializeComponent();

            // Crear la pelota y las palas
            ball = new Ball(this.Width / 2, this.Height / 2);
            leftPaddle = new Paddle(50, this.Height / 2);
            rightPaddle = new Paddle(this.Width - 50, this.Height / 2);
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            // Dibujar la pelota y las palas
            e.Graphics.FillEllipse(Brushes.White, ball.X, ball.Y, 20, 20);
            e.Graphics.FillRectangle(Brushes.White, leftPaddle.X, leftPaddle.Y, 10, 50);
            e.Graphics.FillRectangle(Brushes.White, rightPaddle.X, rightPaddle.Y, 10, 50);

            // Dibujar la puntuación
            e.Graphics.DrawString(leftScore.ToString(), new Font("Arial", 16), Brushes.White, new Point(this.Width / 2 - 30, 10));
            e.Graphics.DrawString(rightScore.ToString(), new Font("Arial", 16), Brushes.White, new Point(this.Width / 2 + 10, 10));
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // Mover la pelota
            ball.X += ballSpeedX;
            ball.Y += ballSpeedY;

            // Comprobar si la pelota choca con una pala o con un borde de la pantalla
            if (ball.X <= leftPaddle.X + 10)
            {
                if (ball.Y >= leftPaddle.Y && ball.Y <= leftPaddle.Y + 50)
                {
                    ballSpeedX = -ballSpeedX;
                }
                else
                {
                    // El jugador derecho ha anotado un punto
                    rightScore++;
                    ball.X = this.Width / 2;
                    ball.Y = this.Height / 2;
                }
            }
            else if (ball.X >= rightPaddle.X - 20)
            {
                if (ball.Y >= rightPaddle.Y && ball.Y <= rightPaddle.Y + 50)
                {
                    ballSpeedX = -ballSpeedX;
                }
                else
                {
                    // El jugador izquierdo ha anotado un punto
                    leftScore++;
                    ball.X = this.Width / 2;
                    ball.Y = this.Height / 2;
                }
            }

            // Comprobar si la pelota choca con los bordes superior e inferior de la pantalla
            if (ball.Y <= 0 || ball.Y >= this.Height - 20)
            {
                ballSpeedY = -ballSpeedY;
            }

            // Repintar la pantalla
            this.Invalidate();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Iniciar el juego
            timer1.Interval = 10; // 10 milisegundos
            timer1.Start();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            // Mover la pala del jugador izquierdo hacia arriba o hacia abajo
            if (e.KeyCode == Keys.W)
            {
                leftPaddle.Y -= 5;
            }
            else if (e.KeyCode == Keys.S)
            {
                leftPaddle.Y += 5;
            }

            // Mover la pala del jugador derecho hacia arriba o hacia abajo
            if (e.KeyCode == Keys.Up)
            {
                rightPaddle.Y -= 5;
            }
            else if (e.KeyCode == Keys.Down)
            {
                rightPaddle.Y += 5;
            }
        }
    }
}
