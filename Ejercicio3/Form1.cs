using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio3
{
    public partial class Form1 : Form
    {
        string password;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnRegistro_Click(object sender, EventArgs e)
        {
            string usuario = user.Text;
            string contra = pass.Text;
            string url = "E:\\HR100621_Actividad\\GUIA1" + usuario + ".txt"; //usted elige ubicación de carpeta,la que hizo en el paso 3, pero esta debe existir
               if (File.Exists(url)) //verifica que el archivo exista
            {
                MessageBox.Show("ERROR. ¡Usuario ya existe!"); //usuario registrado
                txtuser.Clear(); //limpiamos todos los textbox
                txtpass.Clear();
            }
            else
            {
                File.WriteAllText(url, contra); /*Crea un Nuevo archivo con ese nombre y guarda
                    dentro del archivo el valor del segundo parámetro*/
                MessageBox.Show("Usuario Registrado con éxito");
                txtuser.Clear();
                txtpass.Clear();
            }
        }

        private void btningreso_Click(object sender, EventArgs e)
        {
            string usuario = txtuser.Text; //capturamos los valores de usuario y contraseña
            string contra = txtpass.Text;
            string url = "E:\\HR100621_Actividad\\GUIA1" + usuario + ".txt";
            if (File.Exists(url)) //verifica si existe
            {
                password = File.ReadAllText(url); //lee el texto almacenado dentro del archivo
                if (contra.Equals(password)) //verifica si contraseña es igual al archivo
                {
                    MessageBox.Show("¡Ingreso exitoso, bienvenido!"); //login exitoso
                }
                else
                {
                    MessageBox.Show("¡Contraseña incorrecta!  ");//login fallido
                }
            }
            else
            {
                MessageBox.Show("¡Usuario incorrecto! "); //usuario incorrecto
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    } 
}
