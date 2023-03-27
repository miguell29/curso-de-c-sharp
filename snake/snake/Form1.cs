using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace snake
{
    public partial class Form1 : Form
    {
        private enum Tdireccion { izquierda,derecha,arriba,abajo };
        private Tdireccion Direccion { get; set; } = Tdireccion.derecha;
        private LinkedList<Punto> cuerpoVivora = new LinkedList<Punto>();
        private Punto Comida { get; set; } = new Punto(10, 10);
        private int Crecimiento = 0;
        public Form1()
        {
            InitializeComponent();
            cuerpoVivora.AddFirst(new Punto(0,0));
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Direccion == Tdireccion.derecha) cuerpoVivora.AddFirst(new Punto(cuerpoVivora.First.Value.X + 1, cuerpoVivora.First.Value.Y));
            if (Direccion == Tdireccion.izquierda) cuerpoVivora.AddFirst(new Punto(cuerpoVivora.First.Value.X - 1, cuerpoVivora.First.Value.Y));
            if (Direccion == Tdireccion.arriba) cuerpoVivora.AddFirst(new Punto(cuerpoVivora.First.Value.X, cuerpoVivora.First.Value.Y - 1));
            if (Direccion == Tdireccion.abajo) cuerpoVivora.AddFirst(new Punto(cuerpoVivora.First.Value.X, cuerpoVivora.First.Value.Y + 1));

            FueraDeMapa();
            SePisa();
            ComerComida();
            EliminarCola();
            Invalidate();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right || e.KeyCode == Keys.D) Direccion = Tdireccion.derecha;
            if (e.KeyCode == Keys.Left || e.KeyCode == Keys.A) Direccion = Tdireccion.izquierda;
            if (e.KeyCode == Keys.Down || e.KeyCode == Keys.S) Direccion = Tdireccion.abajo;
            if (e.KeyCode == Keys.Up || e.KeyCode == Keys.W) Direccion = Tdireccion.arriba;
        }

        public void FueraDeMapa()
        {
            if (cuerpoVivora.First.Value.X == -1 || cuerpoVivora.First.Value.X == 40 
                || cuerpoVivora.First.Value.Y == -1 || cuerpoVivora.First.Value.Y == 40)
            {
                timer1.Enabled = false;
                MessageBox.Show("PERDISTE :-(");
            }
        }
        public void SePisa()
        {
            foreach (var parte in cuerpoVivora)
            {
                if (cuerpoVivora.First.Value != parte)
                {
                    if (cuerpoVivora.First.Value.X == parte.X && cuerpoVivora.First.Value.Y == parte.Y)
                    {
                        timer1.Enabled = false;
                        MessageBox.Show("PERDISTE :-(");
                    }
                }
            }
        }
        public void ComerComida() 
        {
            if (cuerpoVivora.First.Value.X == Comida.X && cuerpoVivora.First.Value.Y == Comida.Y)
            {
                Crecimiento = 5;
                Comida.X = new Random().Next(0, 40);
                Comida.Y = new Random().Next(0, 40);
            }
        }

        public void EliminarCola()
        {
            if (Crecimiento == 0)
            {
                cuerpoVivora.RemoveLast();
            }
            else
            {
                Crecimiento--;
            }
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            foreach (var parte in cuerpoVivora)
            {
                e.Graphics.FillRectangle(new SolidBrush(Color.LightGreen), parte.X * 10, parte.Y * 10, 9, 9);
                e.Graphics.FillRectangle(new SolidBrush(Color.Red), Comida.X * 10, Comida.Y * 10, 9, 9);
            }
            e.Graphics.DrawRectangle(new Pen(Color.Black),0, 0, 400, 400);
        }
    }

    class Punto
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Punto(int x, int y)
        {
            X = x;
            Y = y;
        }
    }
}
