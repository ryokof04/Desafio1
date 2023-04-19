
namespace Desafio1.Formularios
{
    partial class DetallesDatos
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
            lblMenuPrincipal = new System.Windows.Forms.Label();
            dgvPacientes = new System.Windows.Forms.DataGridView();
            txtNumExpediente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            txtNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            txtCodigoGenero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            txtCodigoPresion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            txtGénero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            txtPresión = new System.Windows.Forms.DataGridViewTextBoxColumn();
            txtMensaje = new System.Windows.Forms.DataGridViewTextBoxColumn();
            btnRegresar = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            btnEliminar = new System.Windows.Forms.Button();
            label2 = new System.Windows.Forms.Label();
            txtBuscarPaciente = new System.Windows.Forms.TextBox();
            btnBuscar = new System.Windows.Forms.Button();
            tiposan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvPacientes).BeginInit();
            SuspendLayout();
            // 
            // lblMenuPrincipal
            // 
            lblMenuPrincipal.AutoSize = true;
            lblMenuPrincipal.BackColor = System.Drawing.Color.Transparent;
            lblMenuPrincipal.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblMenuPrincipal.Location = new System.Drawing.Point(237, 18);
            lblMenuPrincipal.Name = "lblMenuPrincipal";
            lblMenuPrincipal.Size = new System.Drawing.Size(231, 29);
            lblMenuPrincipal.TabIndex = 3;
            lblMenuPrincipal.Text = "Datos del paciente";
            // 
            // dgvPacientes
            // 
            dgvPacientes.AllowUserToAddRows = false;
            dgvPacientes.AllowUserToDeleteRows = false;
            dgvPacientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPacientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { txtNumExpediente, txtNombre, txtCodigoGenero, txtCodigoPresion, txtGénero, txtPresión, txtMensaje, tiposan });
            dgvPacientes.Location = new System.Drawing.Point(45, 106);
            dgvPacientes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            dgvPacientes.MultiSelect = false;
            dgvPacientes.Name = "dgvPacientes";
            dgvPacientes.ReadOnly = true;
            dgvPacientes.RowHeadersWidth = 51;
            dgvPacientes.RowTemplate.Height = 29;
            dgvPacientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgvPacientes.Size = new System.Drawing.Size(643, 230);
            dgvPacientes.TabIndex = 4;
            dgvPacientes.CellContentClick += dgvPacientes_CellContentClick;
            dgvPacientes.CellDoubleClick += dgvPacientes_CellDoubleClick;
            // 
            // txtNumExpediente
            // 
            txtNumExpediente.HeaderText = "Expediente";
            txtNumExpediente.MinimumWidth = 6;
            txtNumExpediente.Name = "txtNumExpediente";
            txtNumExpediente.ReadOnly = true;
            txtNumExpediente.Width = 125;
            // 
            // txtNombre
            // 
            txtNombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            txtNombre.HeaderText = "Nombre";
            txtNombre.MinimumWidth = 6;
            txtNombre.Name = "txtNombre";
            txtNombre.ReadOnly = true;
            // 
            // txtCodigoGenero
            // 
            txtCodigoGenero.HeaderText = "Código Género";
            txtCodigoGenero.MinimumWidth = 6;
            txtCodigoGenero.Name = "txtCodigoGenero";
            txtCodigoGenero.ReadOnly = true;
            txtCodigoGenero.Visible = false;
            txtCodigoGenero.Width = 125;
            // 
            // txtCodigoPresion
            // 
            txtCodigoPresion.HeaderText = "Código Presión";
            txtCodigoPresion.MinimumWidth = 6;
            txtCodigoPresion.Name = "txtCodigoPresion";
            txtCodigoPresion.ReadOnly = true;
            txtCodigoPresion.Visible = false;
            txtCodigoPresion.Width = 125;
            // 
            // txtGénero
            // 
            txtGénero.HeaderText = "Genero";
            txtGénero.MinimumWidth = 6;
            txtGénero.Name = "txtGénero";
            txtGénero.ReadOnly = true;
            txtGénero.Width = 125;
            // 
            // txtPresión
            // 
            txtPresión.HeaderText = "Presión";
            txtPresión.MinimumWidth = 6;
            txtPresión.Name = "txtPresión";
            txtPresión.ReadOnly = true;
            txtPresión.Width = 125;
            // 
            // txtMensaje
            // 
            txtMensaje.HeaderText = "Mensaje";
            txtMensaje.MinimumWidth = 6;
            txtMensaje.Name = "txtMensaje";
            txtMensaje.ReadOnly = true;
            txtMensaje.Visible = false;
            txtMensaje.Width = 125;
            // 
            // btnRegresar
            // 
            btnRegresar.BackColor = System.Drawing.Color.DarkRed;
            btnRegresar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            btnRegresar.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnRegresar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            btnRegresar.Location = new System.Drawing.Point(489, 388);
            btnRegresar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            btnRegresar.Name = "btnRegresar";
            btnRegresar.Size = new System.Drawing.Size(174, 33);
            btnRegresar.TabIndex = 5;
            btnRegresar.Text = "Nuevo paciente";
            btnRegresar.UseVisualStyleBackColor = false;
            btnRegresar.Click += btnRegresar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = System.Drawing.Color.Transparent;
            label1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(45, 353);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(378, 20);
            label1.TabIndex = 6;
            label1.Text = "Presione doble sobre el paciente para dibujar el arbol";
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = System.Drawing.Color.DarkRed;
            btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            btnEliminar.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnEliminar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            btnEliminar.Location = new System.Drawing.Point(45, 388);
            btnEliminar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new System.Drawing.Size(211, 33);
            btnEliminar.TabIndex = 7;
            btnEliminar.Text = "Eliminar paciente";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = System.Drawing.Color.Transparent;
            label2.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label2.Location = new System.Drawing.Point(45, 60);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(61, 20);
            label2.TabIndex = 8;
            label2.Text = "Buscar:";
            // 
            // txtBuscarPaciente
            // 
            txtBuscarPaciente.Location = new System.Drawing.Point(119, 60);
            txtBuscarPaciente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            txtBuscarPaciente.Name = "txtBuscarPaciente";
            txtBuscarPaciente.Size = new System.Drawing.Size(409, 23);
            txtBuscarPaciente.TabIndex = 9;
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = System.Drawing.Color.DarkRed;
            btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            btnBuscar.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnBuscar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            btnBuscar.Location = new System.Drawing.Point(547, 51);
            btnBuscar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new System.Drawing.Size(141, 33);
            btnBuscar.TabIndex = 10;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // tiposan
            // 
            tiposan.HeaderText = "Tipo Sanguineo";
            tiposan.Name = "tiposan";
            tiposan.ReadOnly = true;
            // 
            // DetallesDatos
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(765, 432);
            Controls.Add(btnBuscar);
            Controls.Add(txtBuscarPaciente);
            Controls.Add(label2);
            Controls.Add(btnEliminar);
            Controls.Add(label1);
            Controls.Add(btnRegresar);
            Controls.Add(dgvPacientes);
            Controls.Add(lblMenuPrincipal);
            Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            Name = "DetallesDatos";
            Text = "DetallesDatos";
            Load += DetallesDatos_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPacientes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblMenuPrincipal;
        private System.Windows.Forms.DataGridView dgvPacientes;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBuscarPaciente;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtNumExpediente;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtCodigoGenero;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtCodigoPresion;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtGénero;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtPresión;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtMensaje;
        private System.Windows.Forms.DataGridViewTextBoxColumn tiposan;
    }
}