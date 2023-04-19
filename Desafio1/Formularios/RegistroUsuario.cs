using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desafio1.Formularios
{
    public partial class RegistroUsuario : Form
    {
        public RegistroUsuario()
        {
            InitializeComponent();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            frmBienvenida bienvenida = new frmBienvenida();

            this.Hide();
            bienvenida.Show();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (txtContraseniaRegistro.Text == txtRepetirContrasenia.Text) CuentasRepetidas();
            else
            {
                MessageBox.Show("Contraseñas no coinciden", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void CuentasRepetidas()
        {
            string userReg = txtUsuarioRegistro.Text;
            StreamReader leer;
            leer = File.OpenText("datos_usuarios2.txt");
            string cadena;
            string[] arreglos = new string[1]; // Crea arreglos (secciones)
            char[] separador = { '-' }; // Crea el separador entre user y password
            bool repetido = false;
            cadena = leer.ReadLine();
            while (cadena != null && repetido == false)
            {
                arreglos = cadena.Split(separador);
                if (arreglos[0].Trim().Equals(userReg))
                {
                    MessageBox.Show("Usuario ya registrado. Ingrese otro", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    leer.Close();
                    repetido = true;
                }
                else
                {
                    cadena = leer.ReadLine();
                }
            }
            if (repetido == false)
            {
                leer.Close();
                RegistroCuenta();
            }
        }

        public void RegistroCuenta()
        {
            string userReg = txtUsuarioRegistro.Text;
            string passReg = txtContraseniaRegistro.Text;
            StreamWriter registrar = new StreamWriter("datos_usuarios2.txt", true);
            registrar.WriteLine(userReg + "-" + passReg + "\n");
            registrar.Close();
            MessageBox.Show("Usuario registrado correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void RegistroUsuario_Load(object sender, EventArgs e)
        {

        }
    }
}
