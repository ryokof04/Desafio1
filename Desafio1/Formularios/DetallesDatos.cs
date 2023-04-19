using Desafio1.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desafio1.Formularios
{
    public partial class DetallesDatos : Form
    {
        public DetallesDatos()
        {
            InitializeComponent();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            DatosPaciente datosPaciente = new DatosPaciente();
            this.Hide();
            datosPaciente.Show();
        }

        private void DetallesDatos_Load(object sender, EventArgs e)
        {
            var pacientes = FlujosListas.pacientes;

            for (int i = 0; i < pacientes.Count; i++)
            {

                if (i >= 7)
                {
                    int numExpediente = pacientes[i].numExpediente;
                    int codigoGenero = pacientes[i].codigoGenero;
                    int codigoPresion = pacientes[i].codigoPresion;
                    int codigoTipo = pacientes[i].codigoTipo;
                    string nombre = pacientes[i].nombre;
                    string genero = pacientes[i].genero;
                    string presion = pacientes[i].presion;
                    string tipo = pacientes[i].tipo;
                    string mensaje = pacientes[i].mensaje;

                    if (genero == "H")
                    {
                        genero = "Hombre";
                    }
                    else
                    {
                        genero = "Mujer";
                    }

                    if (presion == "A")
                    {
                        presion = "Alta";
                    }
                    else if (presion == "M")
                    {
                        presion = "Media";
                    }
                    else
                    {
                        presion = "Baja";
                    }

                   

                    DataGridViewRow fila = new DataGridViewRow();
                    fila.CreateCells(dgvPacientes);

                    fila.Cells[0].Value = numExpediente;
                    fila.Cells[1].Value = nombre;
                    fila.Cells[2].Value = codigoGenero;
                    fila.Cells[3].Value = codigoPresion;
                    fila.Cells[4].Value = genero;
                    fila.Cells[5].Value = presion;
                    fila.Cells[6].Value = mensaje;
                    fila.Cells[7].Value = tipo;

                    dgvPacientes.Rows.Add(fila);

                }

            }
        }

        private void dgvPacientes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int numFilasSeleccionadas = dgvPacientes.SelectedRows.Count;

            if (numFilasSeleccionadas > 1)
            {
                MessageBox.Show("Por favor seleccione solo una fila", "Error ...", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // Obtenemos valores de fila seleccionada
                int numExpediente = int.Parse(dgvPacientes.SelectedCells[0].Value.ToString());
                String nombre = (dgvPacientes.SelectedCells[1].Value.ToString());
                int codigoGenero = int.Parse(dgvPacientes.SelectedCells[2].Value.ToString());
                int codigoPresion = int.Parse(dgvPacientes.SelectedCells[3].Value.ToString());
                String genero = (dgvPacientes.SelectedCells[4].Value.ToString());
                String presion = (dgvPacientes.SelectedCells[5].Value.ToString());
                string mensaje = (dgvPacientes.SelectedCells[6].Value.ToString());
                string tipo = (dgvPacientes.SelectedCells[7].Value.ToString());

                var pacientes = FlujosListas.pacientes;
                List<Paciente> listaDibujo = new List<Paciente>();

                for (int i = 0; i < pacientes.Count; i++)
                {
                    if (i < 8)
                    {
                        int codDib = pacientes[i].codDibujo;
                        string nombreDib = pacientes[i].nombre;
                        string generoDib = pacientes[i].genero;
                        string presionDib = pacientes[i].presion;
                        string mensajeDib = pacientes[i].mensaje;
                        string tipoDib = pacientes[i].tipo;

                        listaDibujo.Add(new Paciente()
                        {
                            codDibujo = codDib,
                            nombre = nombreDib,
                            genero = generoDib,
                            presion = presionDib,
                            mensaje = mensajeDib,
                            tipo = tipoDib,
                        });

                        FlujosListas.pacientesDibujo = listaDibujo;
                    }

                }

                // Agregamos los dos nodos a la lista que se va a dibujar
                FlujosListas.pacientesDibujo.Add(new Paciente()
                {
                    numExpediente = numExpediente,
                    nombre = nombre,
                    codDibujo = codigoGenero,
                    genero = genero,
                    presion = presion,
                    mensaje = mensaje,
                    tipo = tipo,
                });

                FlujosListas.pacientesDibujo.Add(new Paciente()
                {
                    numExpediente = numExpediente,
                    nombre = nombre,
                    codDibujo = codigoPresion,
                    genero = genero,
                    presion = presion,
                    mensaje = mensaje,
                    tipo = tipo,
                });

                // rcfq- 08 - esto viene de Formularios\DibujarArbol.cs
                DibujarArbol dibujarArbol = new DibujarArbol();
                this.Hide();
                dibujarArbol.Show();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int fila = dgvPacientes.SelectedRows.Count;
            int filas = dgvPacientes.Rows.Count;

            if (filas > 0)
            {
                if (fila > 1)
                {
                    MessageBox.Show("Por favor seleccione solo una fila", "Error ...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {

                    string nombre = dgvPacientes.CurrentRow.Cells[1].Value.ToString();

                    foreach (var paciente in FlujosListas.pacientes.ToList())
                    {
                        if (paciente.nombre.Equals(nombre))
                        {
                            dgvPacientes.Rows.Remove(dgvPacientes.CurrentRow);
                            FlujosListas.pacientes.Remove(paciente);
                        }
                    }


                }
            }
            else
            {
                MessageBox.Show("No existen pacientes registrados", "Error ...", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            int filas = dgvPacientes.Rows.Count;
            string nombreBuscar = txtBuscarPaciente.Text.Trim();

            if (filas > 0)
            {
                if (!string.IsNullOrEmpty(nombreBuscar))
                {
                    var pacientes = FlujosListas.pacientes;

                    for (int i = 0; i < pacientes.Count; i++)
                    {
                        if (i >= 8)
                        {
                            if (pacientes[i].nombre.Contains(nombreBuscar))
                            {

                                dgvPacientes.Rows.Clear();

                                DataGridViewRow fila = new DataGridViewRow();
                                fila.CreateCells(dgvPacientes);

                                if (pacientes[i].genero == "H")
                                {
                                    pacientes[i].genero = "Hombre";
                                }
                                else
                                {
                                    pacientes[i].genero = "Mujer";
                                }

                                if (pacientes[i].presion == "A")
                                {
                                    pacientes[i].presion = "Alta";
                                }
                                else if(pacientes[i].presion == "M")
                                {
                                    pacientes[i].presion = "Media";
                                }
                                else
                                {
                                    pacientes[i].presion = "Baja";
                                }
                                


                                fila.Cells[0].Value = pacientes[i].numExpediente;
                                fila.Cells[1].Value = pacientes[i].nombre;
                                fila.Cells[2].Value = pacientes[i].codigoGenero;
                                fila.Cells[3].Value = pacientes[i].codigoPresion;
                                fila.Cells[4].Value = pacientes[i].genero;
                                fila.Cells[5].Value = pacientes[i].presion;
                                fila.Cells[6].Value = pacientes[i].mensaje;
                                fila.Cells[7].Value = pacientes[i].tipo;

                                dgvPacientes.Rows.Add(fila);
                            }
                        }
                    }
                }
                else
                {
                    var pacientes = FlujosListas.pacientes;
                    dgvPacientes.Rows.Clear();

                    for (int i = 0; i < pacientes.Count; i++)
                    {
                        if (i >= 7)
                        {
                            int numExpediente = pacientes[i].numExpediente;
                            int codigoGenero = pacientes[i].codigoGenero;
                            int codigoPresion = pacientes[i].codigoPresion;
                            string nombre = pacientes[i].nombre;
                            string genero = pacientes[i].genero;
                            string presion = pacientes[i].presion;
                            string mensaje = pacientes[i].mensaje;
                            string tipo = pacientes[i].tipo;

                            if (genero == "H")
                            {
                                genero = "Hombre";
                            }
                            else
                            {
                                genero = "Mujer";
                            }

                            if (presion == "A")
                            {
                                presion = "Alta";
                            }
                            else if(presion == "M")
                            {
                                presion = "Media";
                            }
                            else
                            {
                                presion = "Baja";
                            }
                            


                            DataGridViewRow fila = new DataGridViewRow();
                            fila.CreateCells(dgvPacientes);

                            fila.Cells[0].Value = numExpediente;
                            fila.Cells[1].Value = nombre;
                            fila.Cells[2].Value = codigoGenero;
                            fila.Cells[3].Value = codigoPresion;
                            fila.Cells[4].Value = genero;
                            fila.Cells[5].Value = presion;
                            fila.Cells[6].Value = mensaje;
                            fila.Cells[7].Value = tipo;

                            dgvPacientes.Rows.Add(fila);

                        }

                    }
                }
            }
            else
            {
                MessageBox.Show("No existen pacientes registrados", "Error ...", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvPacientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
