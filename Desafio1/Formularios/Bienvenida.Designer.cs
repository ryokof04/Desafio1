using System.Windows.Forms;

namespace Desafio1
{
    partial class frmBienvenida
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblBienvenidos = new Label();
            lblUsuario = new Label();
            lblContrasenia = new Label();
            txtUsuario = new TextBox();
            txtContrasenia = new TextBox();
            btnIngresar = new Button();
            btnSalir = new Button();
            btnRegistrar = new Button();
            SuspendLayout();
            // 
            // lblBienvenidos
            // 
            lblBienvenidos.AutoSize = true;
            lblBienvenidos.BackColor = System.Drawing.Color.Transparent;
            lblBienvenidos.Font = new System.Drawing.Font("Segoe UI Semibold", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblBienvenidos.ForeColor = System.Drawing.Color.Black;
            lblBienvenidos.Location = new System.Drawing.Point(139, 19);
            lblBienvenidos.Name = "lblBienvenidos";
            lblBienvenidos.Size = new System.Drawing.Size(212, 47);
            lblBienvenidos.TabIndex = 0;
            lblBienvenidos.Text = "Bienvenidos";
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.BackColor = System.Drawing.Color.Transparent;
            lblUsuario.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblUsuario.ForeColor = System.Drawing.Color.Black;
            lblUsuario.Location = new System.Drawing.Point(50, 80);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new System.Drawing.Size(87, 25);
            lblUsuario.TabIndex = 1;
            lblUsuario.Text = "Usuario: ";
            // 
            // lblContrasenia
            // 
            lblContrasenia.AutoSize = true;
            lblContrasenia.BackColor = System.Drawing.Color.Transparent;
            lblContrasenia.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblContrasenia.ForeColor = System.Drawing.Color.Black;
            lblContrasenia.Location = new System.Drawing.Point(50, 129);
            lblContrasenia.Name = "lblContrasenia";
            lblContrasenia.Size = new System.Drawing.Size(114, 25);
            lblContrasenia.TabIndex = 2;
            lblContrasenia.Text = "Contraseña:";
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new System.Drawing.Point(184, 80);
            txtUsuario.Margin = new Padding(3, 2, 3, 2);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new System.Drawing.Size(208, 23);
            txtUsuario.TabIndex = 3;
            txtUsuario.TextChanged += txtUsuario_TextChanged;
            // 
            // txtContrasenia
            // 
            txtContrasenia.Location = new System.Drawing.Point(184, 129);
            txtContrasenia.Margin = new Padding(3, 2, 3, 2);
            txtContrasenia.Name = "txtContrasenia";
            txtContrasenia.Size = new System.Drawing.Size(208, 23);
            txtContrasenia.TabIndex = 4;
            // 
            // btnIngresar
            // 
            btnIngresar.BackColor = System.Drawing.Color.DarkRed;
            btnIngresar.FlatStyle = FlatStyle.Popup;
            btnIngresar.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnIngresar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            btnIngresar.Location = new System.Drawing.Point(289, 184);
            btnIngresar.Margin = new Padding(3, 2, 3, 2);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new System.Drawing.Size(127, 41);
            btnIngresar.TabIndex = 5;
            btnIngresar.Text = "Ingresar";
            btnIngresar.UseVisualStyleBackColor = false;
            btnIngresar.Click += btnIngresar_Click;
            // 
            // btnSalir
            // 
            btnSalir.BackColor = System.Drawing.Color.DarkRed;
            btnSalir.FlatStyle = FlatStyle.Popup;
            btnSalir.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnSalir.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            btnSalir.Location = new System.Drawing.Point(184, 248);
            btnSalir.Margin = new Padding(3, 2, 3, 2);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new System.Drawing.Size(127, 41);
            btnSalir.TabIndex = 6;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnRegistrar
            // 
            btnRegistrar.BackColor = System.Drawing.Color.DarkRed;
            btnRegistrar.FlatStyle = FlatStyle.Popup;
            btnRegistrar.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnRegistrar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            btnRegistrar.Location = new System.Drawing.Point(65, 184);
            btnRegistrar.Margin = new Padding(3, 2, 3, 2);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new System.Drawing.Size(127, 41);
            btnRegistrar.TabIndex = 7;
            btnRegistrar.Text = "Nuevo";
            btnRegistrar.UseVisualStyleBackColor = false;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // frmBienvenida
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(490, 321);
            Controls.Add(btnRegistrar);
            Controls.Add(btnSalir);
            Controls.Add(btnIngresar);
            Controls.Add(txtContrasenia);
            Controls.Add(txtUsuario);
            Controls.Add(lblContrasenia);
            Controls.Add(lblUsuario);
            Controls.Add(lblBienvenidos);
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmBienvenida";
            Text = "Bienvenida";
            Load += frmBienvenida_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblBienvenidos;
        private Label lblUsuario;
        private Label lblContrasenia;
        private TextBox txtUsuario;
        private TextBox txtContrasenia;
        private Button btnIngresar;
        private Button btnSalir;
        private Button btnRegistrar;
    }
}