using Desafio1.ArbolGenerico; //rcfq_01_crear_folder
using Desafio1.Clases; //rcfq_01_crear_folder
using Desafio1.Formularios; //rcfq_01_crear_folder
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace Desafio1
{
    public partial class frmBienvenida : Form
    {
        string user_verificar;
        string contra_verificar;

        // rcfq- 02 - esto viene de la calse /clases/paciente.cs
        List<Paciente> pacientes = new List<Paciente>();

        public frmBienvenida()
        {
            InitializeComponent();
        }

        public void DatosP()
        {
            // rcfq- 03 -esto viene de la calse /Formularios/DatosPaciente.cs
            DatosPaciente dp = new DatosPaciente();
            dp.Show();
            this.Hide();
        }
        private void btnIngresar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtUsuario.Text.Equals(""))
                {

                    MessageBox.Show("Por favor ingresar el usuario", "Error...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (txtContrasenia.Text.Equals(""))
                {
                    MessageBox.Show("Por favor ingresar la contraseña", "Error...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    user_verificar = txtUsuario.Text.Trim();
                    contra_verificar = txtContrasenia.Text.Trim();

                    StreamReader leer;
                    leer = File.OpenText("datos_usuarios2.txt");
                    string cadena;
                    string[] arreglo = new string[2];
                    char[] separador = { '-' };
                    bool autorizado = false;
                    cadena = leer.ReadLine();
                    while (cadena != null && autorizado == false)
                    {
                        arreglo = cadena.Split(separador);
                        if (arreglo[0].Trim().Equals(user_verificar) && arreglo[1].Trim().Equals(contra_verificar))
                        {

                            DatosP();
                            autorizado = true;
                        }
                        else
                        {
                            cadena = leer.ReadLine();
                        }
                    }
                    if (autorizado == false)
                    {
                        MessageBox.Show("Usuario y/o contraseña incorrectos", "Login Incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception error)
            {
                MessageBox.Show("Error: " + error);
            }
        }

        private void frmBienvenida_Load(object sender, EventArgs e)
        {
            // Lista quemada de datos de pacientes
            Paciente paciente1 = new Paciente();
            Paciente paciente2 = new Paciente();
            Paciente paciente3 = new Paciente();
            Paciente paciente4 = new Paciente();
            Paciente paciente5 = new Paciente();
            Paciente paciente6 = new Paciente();
            Paciente paciente7 = new Paciente();

            paciente1.codDibujo = 20;
            paciente1.nombre = "Pacientes";
            paciente1.genero = "";
            paciente1.presion = "";

            paciente2.codDibujo = 10;
            paciente2.nombre = "Género";
            paciente2.genero = "";
            paciente2.presion = "";

            paciente3.codDibujo = 30;
            paciente3.nombre = "Presión";
            paciente3.genero = "";
            paciente3.presion = "";

            paciente4.codDibujo = 5;
            paciente4.nombre = "Hombre";
            paciente4.genero = "";
            paciente4.presion = "";

            paciente5.codDibujo = 15;
            paciente5.nombre = "Mujer";
            paciente5.genero = "";
            paciente5.presion = "";

            paciente6.codDibujo = 35;
            paciente6.nombre = "Alta";
            paciente6.genero = "";
            paciente6.presion = "";

            paciente7.codDibujo = 25;
            paciente7.nombre = "Baja";
            paciente7.genero = "";
            paciente7.presion = "";

            pacientes.Add(paciente1);
            pacientes.Add(paciente2);
            pacientes.Add(paciente3);
            pacientes.Add(paciente4);
            pacientes.Add(paciente5);
            pacientes.Add(paciente6);
            pacientes.Add(paciente7);

            // rcfq- 04 - esto viene de Clases\FlujosListas.cs
            // Seteamos la lista para que se mantenga en sesion
            FlujosListas.pacientes = pacientes;

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            // rcfq- 05 - esto viene de Formularios\RegistroUsuario.cs
            RegistroUsuario registroUsuario = new RegistroUsuario();

            this.Hide();
            registroUsuario.Show();
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }
    }
}