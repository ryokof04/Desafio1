using Desafio1.Clases;
using Desafio1.Formularios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desafio1
{
    public partial class DatosPaciente : Form
    {
        public DatosPaciente()
        {
            InitializeComponent();
        }

        private void btnVerDatos_Click(object sender, EventArgs e)
        {
            // rcfq- 06 - esto viene de Formularios\DetallesDatos.cs
            DetallesDatos detallesDatos = new DetallesDatos();
            this.Hide();
            detallesDatos.Show();

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
          
            var genero = "";
            var presion = "";
            
            if (txtNombre.Text.Equals(""))
            {
                MessageBox.Show("Introduzca nombre", "Error... ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (cmbGeneros.Text.Equals(""))
            {
                MessageBox.Show("Seleccione género", "Error... ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (cmbPresion.Text.Equals(""))
            {
                MessageBox.Show("Seleccione presión", "Error... ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (cmbTipo.Text.Equals(""))
            {
                MessageBox.Show("Seleccione Tipo de Sangre", "Error... ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                var gen =cmbGeneros.Text;
                var nombre = txtNombre.Text;
                var pres = cmbPresion.Text;
                var tipo = cmbTipo.Text;
               
                if (gen == "Hombre")
                {
                    genero = "H";
                }
                else
                {
                    genero = "M";
                }

                if (pres == "Alta")
                {
                    presion = "A";
                }
                else if (pres == "Media")
                { 
                    presion = "M"; 
                }
                else 
                { 
                 presion = "B"; 
                }
               

                // Validando si existe el paciente
                if (ExistePaciente(FlujosListas.pacientes, nombre))
                {
                    MessageBox.Show("El paciente ya se encuentra en nuestro sistema", "Error... ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (genero.Equals("H") && presion.Equals("A") && tipo.Equals("A"))
                    {

                        var pacienteAgregar = new Paciente()
                        {
                            numExpediente = int.Parse(txtNumExpediente.Text),
                            codigoGenero = 4,
                            codigoPresion = 34,
                            nombre = nombre,
                            genero = genero,
                            presion = presion,
                            tipo = tipo,
                            mensaje = "Paciente propenso a desarrollar hipertensión, esto es peligroso ya que hay riesgo de ataque cardíaco."
                        };

                        FlujosListas.pacientes.Add(pacienteAgregar);

                    }
                    else if (genero.Equals("H") && presion.Equals("M") && tipo.Equals("A"))
                    {
                        var pacienteAgregar = new Paciente()
                        {
                            numExpediente = int.Parse(txtNumExpediente.Text),
                            codigoGenero = 4,
                            codigoPresion = 24,
                            nombre = nombre,
                            genero = genero,
                            presion = presion,
                            tipo = tipo,
                            mensaje = "Paciente propenso a mareos, desmayos, fatiga, debilidad, etc... Y esto es más propenso en " +
                            "hombres con un trabajo ágil."
                        };

                        FlujosListas.pacientes.Add(pacienteAgregar);
                    }
                    else if (genero.Equals("H") && presion.Equals("B") && tipo.Equals("A"))
                    {
                        var pacienteAgregar = new Paciente()
                        {
                            numExpediente = int.Parse(txtNumExpediente.Text),
                            codigoGenero = 14,
                            codigoPresion = 34,
                            nombre = nombre,
                            genero = genero,
                            presion = presion,
                            tipo = tipo,
                            mensaje = "Paciente propenso a daño en sus riñones, hígado, cerebro, etc... Y con riesgo a enfermedad cardíaca."
                        };

                        FlujosListas.pacientes.Add(pacienteAgregar);
                    }
                    else if (genero.Equals("H") && presion.Equals("A") && tipo.Equals("B"))
                    {
                        var pacienteAgregar = new Paciente()
                        {
                            numExpediente = int.Parse(txtNumExpediente.Text),
                            codigoGenero = 14,
                            codigoPresion = 34,
                            nombre = nombre,
                            genero = genero,
                            presion = presion,
                            tipo = tipo,
                            mensaje = "Paciente propenso a daño en sus riñones, hígado, cerebro, etc... Y con riesgo a enfermedad cardíaca."
                        };

                        FlujosListas.pacientes.Add(pacienteAgregar);
                    }
                    else if (genero.Equals("H") && presion.Equals("M") && tipo.Equals("B"))
                    {
                        var pacienteAgregar = new Paciente()
                        {
                            numExpediente = int.Parse(txtNumExpediente.Text),
                            codigoGenero = 14,
                            codigoPresion = 34,
                            nombre = nombre,
                            genero = genero,
                            presion = presion,
                            tipo = tipo,
                            mensaje = "Paciente propenso a daño en sus riñones, hígado, cerebro, etc... Y con riesgo a enfermedad cardíaca."
                        };

                        FlujosListas.pacientes.Add(pacienteAgregar);
                    }
                    else if (genero.Equals("H") && presion.Equals("B") && tipo.Equals("B"))
                    {
                        var pacienteAgregar = new Paciente()
                        {
                            numExpediente = int.Parse(txtNumExpediente.Text),
                            codigoGenero = 14,
                            codigoPresion = 34,
                            nombre = nombre,
                            genero = genero,
                            presion = presion,
                            tipo = tipo,
                            mensaje = "Paciente propenso a daño en sus riñones, hígado, cerebro, etc... Y con riesgo a enfermedad cardíaca."
                        };

                        FlujosListas.pacientes.Add(pacienteAgregar);
                    }
                    else if (genero.Equals("H") && presion.Equals("A") && tipo.Equals("AB"))
                    {
                        var pacienteAgregar = new Paciente()
                        {
                            numExpediente = int.Parse(txtNumExpediente.Text),
                            codigoGenero = 14,
                            codigoPresion = 34,
                            nombre = nombre,
                            genero = genero,
                            presion = presion,
                            tipo = tipo,
                            mensaje = "Paciente propenso a daño en sus riñones, hígado, cerebro, etc... Y con riesgo a enfermedad cardíaca."
                        };

                        FlujosListas.pacientes.Add(pacienteAgregar);
                    }
                    else if (genero.Equals("H") && presion.Equals("M") && tipo.Equals("AB"))
                    {
                        var pacienteAgregar = new Paciente()
                        {
                            numExpediente = int.Parse(txtNumExpediente.Text),
                            codigoGenero = 14,
                            codigoPresion = 34,
                            nombre = nombre,
                            genero = genero,
                            presion = presion,
                            tipo = tipo,
                            mensaje = "Paciente propenso a daño en sus riñones, hígado, cerebro, etc... Y con riesgo a enfermedad cardíaca."
                        };

                        FlujosListas.pacientes.Add(pacienteAgregar);
                    }
                    else if (genero.Equals("H") && presion.Equals("B") && tipo.Equals("AB"))
                    {
                        var pacienteAgregar = new Paciente()
                        {
                            numExpediente = int.Parse(txtNumExpediente.Text),
                            codigoGenero = 14,
                            codigoPresion = 34,
                            nombre = nombre,
                            genero = genero,
                            presion = presion,
                            tipo = tipo,
                            mensaje = "Paciente propenso a daño en sus riñones, hígado, cerebro, etc... Y con riesgo a enfermedad cardíaca."
                        };

                        FlujosListas.pacientes.Add(pacienteAgregar);
                    }
                    else if (genero.Equals("H") && presion.Equals("A") && tipo.Equals("O"))
                    {
                        var pacienteAgregar = new Paciente()
                        {
                            numExpediente = int.Parse(txtNumExpediente.Text),
                            codigoGenero = 14,
                            codigoPresion = 34,
                            nombre = nombre,
                            genero = genero,
                            presion = presion,
                            tipo = tipo,
                            mensaje = "Paciente propenso a daño en sus riñones, hígado, cerebro, etc... Y con riesgo a enfermedad cardíaca."
                        };

                        FlujosListas.pacientes.Add(pacienteAgregar);
                    }
                    else if (genero.Equals("H") && presion.Equals("M") && tipo.Equals("O"))
                    {
                        var pacienteAgregar = new Paciente()
                        {
                            numExpediente = int.Parse(txtNumExpediente.Text),
                            codigoGenero = 14,
                            codigoPresion = 34,
                            nombre = nombre,
                            genero = genero,
                            presion = presion,
                            tipo = tipo,
                            mensaje = "Paciente propenso a daño en sus riñones, hígado, cerebro, etc... Y con riesgo a enfermedad cardíaca."
                        };

                        FlujosListas.pacientes.Add(pacienteAgregar);
                    }
                    else if (genero.Equals("H") && presion.Equals("B") && tipo.Equals("O"))
                    {
                        var pacienteAgregar = new Paciente()
                        {
                            numExpediente = int.Parse(txtNumExpediente.Text),
                            codigoGenero = 14,
                            codigoPresion = 34,
                            nombre = nombre,
                            genero = genero,
                            presion = presion,
                            tipo = tipo,
                            mensaje = "Paciente propenso a daño en sus riñones, hígado, cerebro, etc... Y con riesgo a enfermedad cardíaca."
                        };

                        FlujosListas.pacientes.Add(pacienteAgregar);
                    }
                    else if (genero.Equals("M") && presion.Equals("A") && tipo.Equals("A"))
                    {
                        var pacienteAgregar = new Paciente()
                        {
                            numExpediente = int.Parse(txtNumExpediente.Text),
                            codigoGenero = 14,
                            codigoPresion = 34,
                            nombre = nombre,
                            genero = genero,
                            presion = presion,
                            tipo = tipo,
                            mensaje = "Paciente propenso a daño en sus riñones, hígado, cerebro, etc... Y con riesgo a enfermedad cardíaca."
                        };

                        FlujosListas.pacientes.Add(pacienteAgregar);
                    }
                    else if (genero.Equals("M") && presion.Equals("M") && tipo.Equals("A"))
                    {
                        var pacienteAgregar = new Paciente()
                        {
                            numExpediente = int.Parse(txtNumExpediente.Text),
                            codigoGenero = 14,
                            codigoPresion = 34,
                            nombre = nombre,
                            genero = genero,
                            presion = presion,
                            tipo = tipo,
                            mensaje = "Paciente propenso a daño en sus riñones, hígado, cerebro, etc... Y con riesgo a enfermedad cardíaca."
                        };

                        FlujosListas.pacientes.Add(pacienteAgregar);
                    }
                    else if (genero.Equals("M") && presion.Equals("B") && tipo.Equals("A"))
                    {
                        var pacienteAgregar = new Paciente()
                        {
                            numExpediente = int.Parse(txtNumExpediente.Text),
                            codigoGenero = 14,
                            codigoPresion = 34,
                            nombre = nombre,
                            genero = genero,
                            presion = presion,
                            tipo = tipo,
                            mensaje = "Paciente propenso a daño en sus riñones, hígado, cerebro, etc... Y con riesgo a enfermedad cardíaca."
                        };

                        FlujosListas.pacientes.Add(pacienteAgregar);
                    }
                    else if (genero.Equals("M") && presion.Equals("A") && tipo.Equals("B"))
                    {
                        var pacienteAgregar = new Paciente()
                        {
                            numExpediente = int.Parse(txtNumExpediente.Text),
                            codigoGenero = 14,
                            codigoPresion = 34,
                            nombre = nombre,
                            genero = genero,
                            presion = presion,
                            tipo = tipo,
                            mensaje = "Paciente propenso a daño en sus riñones, hígado, cerebro, etc... Y con riesgo a enfermedad cardíaca."
                        };

                        FlujosListas.pacientes.Add(pacienteAgregar);
                    }
                    else if (genero.Equals("M") && presion.Equals("M") && tipo.Equals("B"))
                    {
                        var pacienteAgregar = new Paciente()
                        {
                            numExpediente = int.Parse(txtNumExpediente.Text),
                            codigoGenero = 14,
                            codigoPresion = 34,
                            nombre = nombre,
                            genero = genero,
                            presion = presion,
                            tipo = tipo,
                            mensaje = "Paciente propenso a daño en sus riñones, hígado, cerebro, etc... Y con riesgo a enfermedad cardíaca."
                        };

                        FlujosListas.pacientes.Add(pacienteAgregar);
                    }
                    else if (genero.Equals("M") && presion.Equals("B") && tipo.Equals("B"))
                    {
                        var pacienteAgregar = new Paciente()
                        {
                            numExpediente = int.Parse(txtNumExpediente.Text),
                            codigoGenero = 14,
                            codigoPresion = 34,
                            nombre = nombre,
                            genero = genero,
                            presion = presion,
                            tipo = tipo,
                            mensaje = "Paciente propenso a daño en sus riñones, hígado, cerebro, etc... Y con riesgo a enfermedad cardíaca."
                        };

                        FlujosListas.pacientes.Add(pacienteAgregar);
                    }
                    else if (genero.Equals("M") && presion.Equals("A") && tipo.Equals("AB"))
                    {
                        var pacienteAgregar = new Paciente()
                        {
                            numExpediente = int.Parse(txtNumExpediente.Text),
                            codigoGenero = 14,
                            codigoPresion = 34,
                            nombre = nombre,
                            genero = genero,
                            presion = presion,
                            tipo = tipo,
                            mensaje = "Paciente propenso a daño en sus riñones, hígado, cerebro, etc... Y con riesgo a enfermedad cardíaca."
                        };

                        FlujosListas.pacientes.Add(pacienteAgregar);
                    }
                    else if (genero.Equals("M") && presion.Equals("M") && tipo.Equals("AB"))
                    {
                        var pacienteAgregar = new Paciente()
                        {
                            numExpediente = int.Parse(txtNumExpediente.Text),
                            codigoGenero = 14,
                            codigoPresion = 34,
                            nombre = nombre,
                            genero = genero,
                            presion = presion,
                            tipo = tipo,
                            mensaje = "Paciente propenso a daño en sus riñones, hígado, cerebro, etc... Y con riesgo a enfermedad cardíaca."
                        };

                        FlujosListas.pacientes.Add(pacienteAgregar);
                    }
                    else if (genero.Equals("M") && presion.Equals("B") && tipo.Equals("AB"))
                    {
                        var pacienteAgregar = new Paciente()
                        {
                            numExpediente = int.Parse(txtNumExpediente.Text),
                            codigoGenero = 14,
                            codigoPresion = 34,
                            nombre = nombre,
                            genero = genero,
                            presion = presion,
                            tipo = tipo,
                            mensaje = "Paciente propenso a daño en sus riñones, hígado, cerebro, etc... Y con riesgo a enfermedad cardíaca."
                        };

                        FlujosListas.pacientes.Add(pacienteAgregar);
                    }
                    else if (genero.Equals("M") && presion.Equals("A") && tipo.Equals("O"))
                    {
                        var pacienteAgregar = new Paciente()
                        {
                            numExpediente = int.Parse(txtNumExpediente.Text),
                            codigoGenero = 14,
                            codigoPresion = 34,
                            nombre = nombre,
                            genero = genero,
                            presion = presion,
                            tipo = tipo,
                            mensaje = "Paciente propenso a daño en sus riñones, hígado, cerebro, etc... Y con riesgo a enfermedad cardíaca."
                        };

                        FlujosListas.pacientes.Add(pacienteAgregar);
                    }
                    else if (genero.Equals("M") && presion.Equals("M") && tipo.Equals("O"))
                    {
                        var pacienteAgregar = new Paciente()
                        {
                            numExpediente = int.Parse(txtNumExpediente.Text),
                            codigoGenero = 14,
                            codigoPresion = 34,
                            nombre = nombre,
                            genero = genero,
                            presion = presion,
                            tipo = tipo,
                            mensaje = "Paciente propenso a daño en sus riñones, hígado, cerebro, etc... Y con riesgo a enfermedad cardíaca."
                        };

                        FlujosListas.pacientes.Add(pacienteAgregar);
                    }
                    else if (genero.Equals("M") && presion.Equals("B") && tipo.Equals("O"))
                    {
                        var pacienteAgregar = new Paciente()
                        {
                            numExpediente = int.Parse(txtNumExpediente.Text),
                            codigoGenero = 14,
                            codigoPresion = 34,
                            nombre = nombre,
                            genero = genero,
                            presion = presion,
                            tipo = tipo,
                            mensaje = "Paciente propenso a daño en sus riñones, hígado, cerebro, etc... Y con riesgo a enfermedad cardíaca."
                        };

                        FlujosListas.pacientes.Add(pacienteAgregar);
                    }
  //                  else
  //                  {
  //                      var pacienteAgregar = new Paciente()
  //                      {
  //                          numExpediente = int.Parse(txtNumExpediente.Text),
  //                          codigoGenero = 14,
  //                          codigoPresion = 24,
  //                          nombre = nombre,
   //                         genero = genero,
     //                       presion = presion,
       //                     mensaje = "Paciente propenso a privar el cuerpo del oxígeno suficiente para llevar a cabo las funciones, " +
         //                   "lo que provoca daño en el corazón y el cerebro; Es más común cuando hay descuidos de las mujeres embarazadas."
           //             };
           //
             //           FlujosListas.pacientes.Add(pacienteAgregar);
               //     }


                    MessageBox.Show("Paciente agregado satisfactoriamente", "Success... ", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    List<Paciente> pacientes = FlujosListas.pacientes;

                    // Lógica para Número de expediente
                    txtNumExpediente.Text = (pacientes.Count - 7).ToString();
                    txtNumExpediente.Text = int.Parse(txtNumExpediente.Text) == 0 ? "001" : "00" + (int.Parse(txtNumExpediente.Text) + 1);
                }
            }
        }

        private void DatosPaciente_Load(object sender, EventArgs e)
        {
            List<Paciente> pacientes = FlujosListas.pacientes;

            // Lógica para Número de expediente
            txtNumExpediente.Text = (pacientes.Count - 7).ToString();
            txtNumExpediente.Text = int.Parse(txtNumExpediente.Text) == 0 ? "001" : "00" + (int.Parse(txtNumExpediente.Text) + 1);
        }

        public bool ExistePaciente(List<Paciente> flujoLista, string nombre)
        {
            foreach (var paciente in flujoLista.ToList())
            {
                if (paciente.nombre.Trim().Equals(nombre.Trim()))
                {
                    return true;
                }
            }
            return false;
        }

        private void txtNumExpediente_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbPresion_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
