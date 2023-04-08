using System.Collections;

namespace Ejercitacion_POO
{
    public partial class FormPrincipal : Form
    {
        private ArrayList clientes = new ArrayList();
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void btnSaludar_Click(object sender, EventArgs e)
        {
            string nombre = textNombre.Text;
            string apellido = textApellido.Text;
            string dni = textDni.Text;
            MessageBox.Show($"Hola {nombre} {apellido}, bienvenido al programa", "Bienvenido!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            bool agregar = true;
            foreach (Cliente cliente in clientes)
            {
                if (dni == cliente.Dni)
                {
                    agregar = false;
                }
            }
            if (agregar) clientes.Add(new Cliente(nombre, apellido, dni));
        }

        private void btnMostrarLista_Click(object sender, EventArgs e)
        {
            labelMostrarLista.Text = null;
            foreach (Cliente cliente in clientes)
            {
                labelMostrarLista.Text += $"Nombre: {cliente.Nombre} Apellido: {cliente.Apellido} DNI: {cliente.Dni}\n";
            }
        }
    }
}