using Desafio1.Clases;
using Desafio1.Formularios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desafio1
{
    public partial class DibujarArbol : Form
    {
        // rcfq- 09 - esto viene de Clases\DibujaAVL.cs
        DibujaAVL arbolAVL = new DibujaAVL(null);
        Paciente paciente = new Paciente();
        Graphics g;

        List<Paciente> pacientes = new List<Paciente>();

        public DibujarArbol()
        {
            InitializeComponent();
        }

        private void DibujarArbol_Load(object sender, EventArgs e)
        {
            // Obteniendo lista de pacientes de sesion
            pacientes = FlujosListas.pacientesDibujo;

            try
            {
                for (var i = 0; i < pacientes.Count; i++)
                {
                    arbolAVL.Insertar(pacientes[i]);
                    
                    Refresh();
                  //  lblInformacion.Text = "Mensaje informativo: \n " + pacientes[i].mensaje;

                }
            }
            catch (Exception ex)
            {
                Trace.WriteLine("Error: " + ex.Message);
            }
        }

        private void DibujarArbol_Paint(object sender, PaintEventArgs en)
        {
            for (var i = 0; i < pacientes.Count; i++)
            {
                en.Graphics.Clear(this.BackColor);
                en.Graphics.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
                en.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                g = en.Graphics;

                arbolAVL.DibujarArbol(g, this.Font, Brushes.White, Brushes.Red, Pens.Black, pacientes[i], Brushes.Red);
                paciente = null;
            }


        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            DetallesDatos detallesDatos = new DetallesDatos();
            this.Hide();
            detallesDatos.Show();
        }
    }
}
