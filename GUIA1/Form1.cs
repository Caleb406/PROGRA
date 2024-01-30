using System;
using System.Windows.Forms;

namespace GUIA1
{
    public partial class frmventana : Form
    {
        public frmventana()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit(); //termina la aplicación
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            string texto = txtnombre.Text;
            string mensaje = string.Format("Bienvenido al segundo formulario " + texto);
            Form2 frmrecibe = new Form2(mensaje); /* creo un objeto del segundo formulario,
            adonde mando información*/

            frmrecibe.Visible = true; // muestra el nuevo formulario
            this.Visible = false; // esconde el formulario actual

        }
    }
}
