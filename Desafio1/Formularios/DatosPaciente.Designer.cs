using System.Windows.Forms;

namespace Desafio1
{
    partial class DatosPaciente
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblMenuPrincipal = new Label();
            btnVerDatos = new Button();
            btnGuardar = new Button();
            btnSalir = new Button();
            cmbPresion = new ComboBox();
            cmbGeneros = new ComboBox();
            txtNombre = new TextBox();
            txtNumExpediente = new TextBox();
            lblPresion = new Label();
            label2 = new Label();
            label1 = new Label();
            lblNombre = new Label();
            lblCodigoDePaciente = new Label();
            label3 = new Label();
            cmbTipo = new ComboBox();
            SuspendLayout();
            // 
            // lblMenuPrincipal
            // 
            lblMenuPrincipal.AutoSize = true;
            lblMenuPrincipal.BackColor = System.Drawing.Color.Transparent;
            lblMenuPrincipal.Font = new System.Drawing.Font("Segoe UI Semibold", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblMenuPrincipal.Location = new System.Drawing.Point(250, 47);
            lblMenuPrincipal.Margin = new Padding(5, 0, 5, 0);
            lblMenuPrincipal.Name = "lblMenuPrincipal";
            lblMenuPrincipal.Size = new System.Drawing.Size(316, 47);
            lblMenuPrincipal.TabIndex = 2;
            lblMenuPrincipal.Text = "Datos del paciente";
            // 
            // btnVerDatos
            // 
            btnVerDatos.BackColor = System.Drawing.Color.DarkRed;
            btnVerDatos.FlatStyle = FlatStyle.Popup;
            btnVerDatos.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnVerDatos.ForeColor = System.Drawing.SystemColors.Control;
            btnVerDatos.Location = new System.Drawing.Point(612, 107);
            btnVerDatos.Margin = new Padding(5, 6, 5, 6);
            btnVerDatos.Name = "btnVerDatos";
            btnVerDatos.Size = new System.Drawing.Size(148, 44);
            btnVerDatos.TabIndex = 14;
            btnVerDatos.Text = "Ver pacientes";
            btnVerDatos.UseVisualStyleBackColor = false;
            btnVerDatos.Click += btnVerDatos_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = System.Drawing.Color.DarkRed;
            btnGuardar.FlatStyle = FlatStyle.Popup;
            btnGuardar.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnGuardar.ForeColor = System.Drawing.SystemColors.Control;
            btnGuardar.Location = new System.Drawing.Point(612, 432);
            btnGuardar.Margin = new Padding(5, 6, 5, 6);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new System.Drawing.Size(148, 44);
            btnGuardar.TabIndex = 9;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnSalir
            // 
            btnSalir.BackColor = System.Drawing.Color.DarkRed;
            btnSalir.FlatStyle = FlatStyle.Popup;
            btnSalir.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnSalir.ForeColor = System.Drawing.SystemColors.Control;
            btnSalir.Location = new System.Drawing.Point(612, 191);
            btnSalir.Margin = new Padding(5, 6, 5, 6);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new System.Drawing.Size(148, 44);
            btnSalir.TabIndex = 11;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // cmbPresion
            // 
            cmbPresion.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPresion.FormattingEnabled = true;
            cmbPresion.Items.AddRange(new object[] { "Alta", "Media", "Baja" });
            cmbPresion.Location = new System.Drawing.Point(305, 418);
            cmbPresion.Margin = new Padding(5, 6, 5, 6);
            cmbPresion.Name = "cmbPresion";
            cmbPresion.Size = new System.Drawing.Size(261, 38);
            cmbPresion.TabIndex = 8;
            cmbPresion.SelectedIndexChanged += cmbPresion_SelectedIndexChanged;
            // 
            // cmbGeneros
            // 
            cmbGeneros.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbGeneros.FormattingEnabled = true;
            cmbGeneros.Items.AddRange(new object[] { "Hombre", "Mujer" });
            cmbGeneros.Location = new System.Drawing.Point(305, 357);
            cmbGeneros.Margin = new Padding(5, 6, 5, 6);
            cmbGeneros.Name = "cmbGeneros";
            cmbGeneros.Size = new System.Drawing.Size(261, 38);
            cmbGeneros.TabIndex = 1;
            // 
            // txtNombre
            // 
            txtNombre.Location = new System.Drawing.Point(305, 228);
            txtNombre.Margin = new Padding(5, 6, 5, 6);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new System.Drawing.Size(261, 35);
            txtNombre.TabIndex = 4;
            txtNombre.TextChanged += txtNombre_TextChanged;
            // 
            // txtNumExpediente
            // 
            txtNumExpediente.Location = new System.Drawing.Point(305, 152);
            txtNumExpediente.Margin = new Padding(5, 6, 5, 6);
            txtNumExpediente.Name = "txtNumExpediente";
            txtNumExpediente.ReadOnly = true;
            txtNumExpediente.Size = new System.Drawing.Size(139, 35);
            txtNumExpediente.TabIndex = 13;
            txtNumExpediente.TextChanged += txtNumExpediente_TextChanged;
            // 
            // lblPresion
            // 
            lblPresion.AutoSize = true;
            lblPresion.BackColor = System.Drawing.Color.Transparent;
            lblPresion.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblPresion.Location = new System.Drawing.Point(51, 426);
            lblPresion.Margin = new Padding(5, 0, 5, 0);
            lblPresion.Name = "lblPresion";
            lblPresion.Size = new System.Drawing.Size(138, 30);
            lblPresion.TabIndex = 7;
            lblPresion.Text = "Tipo presion:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label2.Location = new System.Drawing.Point(74, 508);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(0, 17);
            label2.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = System.Drawing.Color.Transparent;
            label1.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(51, 360);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(83, 30);
            label1.TabIndex = 0;
            label1.Text = "Genero";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.BackColor = System.Drawing.Color.Transparent;
            lblNombre.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblNombre.Location = new System.Drawing.Point(51, 233);
            lblNombre.Margin = new Padding(5, 0, 5, 0);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new System.Drawing.Size(98, 30);
            lblNombre.TabIndex = 3;
            lblNombre.Text = "Nombre:";
            // 
            // lblCodigoDePaciente
            // 
            lblCodigoDePaciente.AutoSize = true;
            lblCodigoDePaciente.BackColor = System.Drawing.Color.Transparent;
            lblCodigoDePaciente.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblCodigoDePaciente.Location = new System.Drawing.Point(51, 156);
            lblCodigoDePaciente.Margin = new Padding(5, 0, 5, 0);
            lblCodigoDePaciente.Name = "lblCodigoDePaciente";
            lblCodigoDePaciente.Size = new System.Drawing.Size(146, 30);
            lblCodigoDePaciente.TabIndex = 12;
            lblCodigoDePaciente.Text = "N expediente:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(51, 299);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(158, 30);
            label3.TabIndex = 16;
            label3.Text = "Tipo de Sangre";
            // 
            // cmbTipo
            // 
            cmbTipo.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTipo.FormattingEnabled = true;
            cmbTipo.Items.AddRange(new object[] { "A", "B", "AB", "O" });
            cmbTipo.Location = new System.Drawing.Point(305, 299);
            cmbTipo.Name = "cmbTipo";
            cmbTipo.Size = new System.Drawing.Size(261, 38);
            cmbTipo.TabIndex = 17;
            // 
            // DatosPaciente
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(867, 524);
            Controls.Add(cmbTipo);
            Controls.Add(label3);
            Controls.Add(btnVerDatos);
            Controls.Add(txtNumExpediente);
            Controls.Add(lblCodigoDePaciente);
            Controls.Add(btnSalir);
            Controls.Add(btnGuardar);
            Controls.Add(cmbPresion);
            Controls.Add(lblPresion);
            Controls.Add(label2);
            Controls.Add(txtNombre);
            Controls.Add(lblNombre);
            Controls.Add(lblMenuPrincipal);
            Controls.Add(label1);
            Controls.Add(cmbGeneros);
            Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            ForeColor = System.Drawing.SystemColors.ControlText;
            Margin = new Padding(5, 6, 5, 6);
            Name = "DatosPaciente";
            Text = "MenuPrincipal";
            Load += DatosPaciente_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblMenuPrincipal;
        private Button btnVerDatos;
        private Button btnGuardar;
        private Button btnSalir;
        private ComboBox cmbPresion;
        private ComboBox cmbGeneros;
        private TextBox txtNombre;
        private TextBox txtNumExpediente;
        private Label lblPresion;
        private Label label2;
        private Label label1;
        private Label lblNombre;
        private Label lblCodigoDePaciente;
        private Label label3;
        private ComboBox cmbTipo;
    }
}