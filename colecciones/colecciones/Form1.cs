using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace colecciones
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Stack <char> simbolo = new Stack<char>();
            string formula = textBox1.Text;

            for (int i = 0; i < formula.Length; i++)
            {
                if (formula.ElementAt(i) == '(' || formula.ElementAt(i) == '{' || formula.ElementAt(i) == '[')
                {
                    simbolo.Push(formula.ElementAt(i));
                }
                else
                {
                    if (formula.ElementAt(i) == ')')
                    {
                        if (simbolo.Count == 0 || simbolo.Pop() != '(')
                        {
                            Text = "Incorrecta";
                            return;
                        }
                    }
                    else
                    {
                        if (formula.ElementAt(i) == ']')
                        {
                            if (simbolo.Count == 0 || simbolo.Pop() != '[')
                            {
                                Text = "Incorrecta";
                                return;
                            }
                        }
                        else
                        {
                            if (formula.ElementAt(i) == '}')
                            {
                                if (simbolo.Count == 0 || simbolo.Pop() != '{')
                                {
                                    Text = "Incorrecta";
                                    return;
                                }
                            }
                        }
                    }
                }
            }
            if (simbolo.Count == 0)
            {
                Text = "Correcta";
            }
            else
            {
                Text = "Incorrecta";
            }
        }
    }
}
