
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Buscaminas
{
    public partial class Form1 : Form
    {
        private Button[,] mat;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int x = 10;
            int y = 50;
            mat = new Button[10, 10];
            for (int fil = 0; fil < mat.GetLength(0); fil++)
            {
                for (int col = 0; col < mat.GetLength(1); col++)
                {
                    mat[fil, col] = new Button();
                    mat[fil, col].Text = "0";
                    mat[fil, col].Location = new Point(x, y);
                    mat[fil, col].Size = new Size(30, 30);
                    mat[fil, col].Click += Presionado;
                    Controls.Add(mat[fil, col]);
                    x = x + 30;
                }
                y = y + 30;
                x = 10;
            }
            Reiniciar();
        }

        void Reiniciar()
        {
            Text = "";
            for (int f = 0; f < 10; f++)
            {
                for (int c = 0; c < 10; c++)
                {
                    mat[f, c].Text = "0";
                    mat[f, c].Enabled = true; ;
                    mat[f, c].ForeColor = Color.LightGray;
                    mat[f, c].BackColor = Color.LightGray;
                }
            }
            DisponerBombas();
            ContarBombasPerimetro();
        }

        void DisponerBombas()
        {
            int cantidad = 10;
            Random ale = new Random();
            do
            {
                int fila = ale.Next(0, 10);
                int columna = ale.Next(0, 10);
                if (mat[fila, columna].Text != "b")
                {
                    mat[fila, columna].Text = "b";
                    cantidad--;
                }
            }
            while (cantidad != 0);
        }

        void ContarBombasPerimetro()
        {
            for (int f = 0; f < 10; f++)
            {
                for (int c = 0; c < 10; c++)
                {
                    if (mat[f, c].Text == "0")
                    {
                        int cant = ContarCoordenada(f, c);
                        mat[f, c].Text = cant.ToString();
                    }
                }
            }
        }

        int ContarCoordenada(int fila, int columna)
        {
            int total = 0;
            if (fila - 1 >= 0 && columna - 1 >= 0)
            {
                if (mat[fila - 1, columna - 1].Text == "b")
                    total++;
            }
            if (fila - 1 >= 0)
            {
                if (mat[fila - 1, columna].Text == "b")
                    total++;
            }
            if (fila - 1 >= 0 && columna + 1 < 10)
            {
                if (mat[fila - 1, columna + 1].Text == "b")
                    total++;
            }

            if (columna + 1 < 10)
            {
                if (mat[fila, columna + 1].Text == "b")
                    total++;
            }
            if (fila + 1 < 10 && columna + 1 < 10)
            {
                if (mat[fila + 1, columna + 1].Text == "b")
                    total++;
            }
            if (fila + 1 < 10)
            {
                if (mat[fila + 1, columna].Text == "b")
                    total++;
            }
            if (fila + 1 < 10 && columna - 1 >= 0)
            {
                if (mat[fila + 1, columna - 1].Text == "b")
                    total++;
            }
            if (columna - 1 >= 0)
            {
                if (mat[fila, columna - 1].Text == "b")
                    total++;
            }
            return total;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Reiniciar();
        }

        private void Presionado(object sender, EventArgs e)
        {
            for (int f = 0; f < 10; f++)
            {
                for (int c = 0; c < 10; c++)
                {
                    if (sender == mat[f, c])
                    {
                        if (mat[f, c].Text == "b")
                        {
                            Text = "Boooooooooooooomm";
                            DesactivarJuego();
                        }
                        else
                            if (mat[f, c].Text == "0")
                        {
                            Recorrer(f, c);
                        }
                        else
                                if (mat[f, c].Text == "1" ||
                                    mat[f, c].Text == "2" ||
                                    mat[f, c].Text == "3" ||
                                    mat[f, c].Text == "4" ||
                                    mat[f, c].Text == "5" ||
                                    mat[f, c].Text == "6" ||
                                    mat[f, c].Text == "7" ||
                                    mat[f, c].Text == "8")
                        {
                            mat[f, c].BackColor = Color.Yellow;
                            mat[f, c].ForeColor = Color.Black;
                        }
                    }
                }
            }
            VerificarTriunfo();
        }

        void DesactivarJuego()
        {
            for (int f = 0; f < 10; f++)
            {
                for (int c = 0; c < 10; c++)
                {
                    mat[f, c].Enabled = false;
                }
            }
        }

        void VerificarTriunfo()
        {
            int cant = 0;
            for (int f = 0; f < 10; f++)
            {
                for (int c = 0; c < 10; c++)
                {
                    Color col = mat[f, c].BackColor;
                    if (col == Color.Yellow)
                        cant++;
                }
            }
            if (cant == 90)
            {
                Text = "Ganooooooooo";
                DesactivarJuego();
            }
        }

        void Recorrer(int fil, int col)
        {
            if (fil >= 0 && fil < 10 && col >= 0 && col < 10)
            {
                if (mat[fil, col].Text == "0")
                {
                    mat[fil, col].Text = " ";
                    mat[fil, col].BackColor = Color.Yellow;
                    Recorrer(fil, col + 1);
                    Recorrer(fil, col - 1);
                    Recorrer(fil + 1, col);
                    Recorrer(fil - 1, col);
                    Recorrer(fil - 1, col - 1);
                    Recorrer(fil - 1, col + 1);
                    Recorrer(fil + 1, col + 1);
                    Recorrer(fil + 1, col - 1);
                }
                else
                    if (mat[fil, col].Text == "1" ||
                        mat[fil, col].Text == "2" ||
                        mat[fil, col].Text == "3" ||
                        mat[fil, col].Text == "4" ||
                        mat[fil, col].Text == "5" ||
                        mat[fil, col].Text == "6" ||
                        mat[fil, col].Text == "7" ||
                        mat[fil, col].Text == "8")
                {
                    mat[fil, col].BackColor = Color.Yellow;
                    mat[fil, col].ForeColor = Color.Black;
                }
            }
        }
    }
}