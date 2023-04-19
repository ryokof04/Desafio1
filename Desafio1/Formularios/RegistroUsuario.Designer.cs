
namespace Desafio1.Formularios
{
    partial class RegistroUsuario
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
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            txtUsuarioRegistro = new System.Windows.Forms.TextBox();
            label3 = new System.Windows.Forms.Label();
            txtContraseniaRegistro = new System.Windows.Forms.TextBox();
            label4 = new System.Windows.Forms.Label();
            txtRepetirContrasenia = new System.Windows.Forms.TextBox();
            btnRegistrar = new System.Windows.Forms.Button();
            btnVolver = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = System.Drawing.Color.Transparent;
            label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(259, 22);
            label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(246, 32);
            label1.TabIndex = 0;
            label1.Text = "Crear nuevo usuario";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = System.Drawing.Color.Transparent;
            label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label2.Location = new System.Drawing.Point(114, 137);
            label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(81, 21);
            label2.TabIndex = 1;
            label2.Text = "Nombre: ";
            // 
            // txtUsuarioRegistro
            // 
            txtUsuarioRegistro.Location = new System.Drawing.Point(272, 127);
            txtUsuarioRegistro.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            txtUsuarioRegistro.Name = "txtUsuarioRegistro";
            txtUsuarioRegistro.Size = new System.Drawing.Size(313, 35);
            txtUsuarioRegistro.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = System.Drawing.Color.Transparent;
            label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label3.Location = new System.Drawing.Point(95, 239);
            label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(100, 21);
            label3.TabIndex = 3;
            label3.Text = "Contraseña:";
            // 
            // txtContraseniaRegistro
            // 
            txtContraseniaRegistro.Location = new System.Drawing.Point(272, 229);
            txtContraseniaRegistro.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            txtContraseniaRegistro.Name = "txtContraseniaRegistro";
            txtContraseniaRegistro.Size = new System.Drawing.Size(313, 35);
            txtContraseniaRegistro.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = System.Drawing.Color.Transparent;
            label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label4.Location = new System.Drawing.Point(38, 337);
            label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(157, 21);
            label4.TabIndex = 5;
            label4.Text = "Repetir contraseña:";
            // 
            // txtRepetirContrasenia
            // 
            txtRepetirContrasenia.Location = new System.Drawing.Point(272, 327);
            txtRepetirContrasenia.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            txtRepetirContrasenia.Name = "txtRepetirContrasenia";
            txtRepetirContrasenia.Size = new System.Drawing.Size(313, 35);
            txtRepetirContrasenia.TabIndex = 6;
            // 
            // btnRegistrar
            // 
            btnRegistrar.BackColor = System.Drawing.Color.DarkRed;
            btnRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            btnRegistrar.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnRegistrar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            btnRegistrar.Location = new System.Drawing.Point(647, 308);
            btnRegistrar.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new System.Drawing.Size(138, 54);
            btnRegistrar.TabIndex = 7;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = false;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // btnVolver
            // 
            btnVolver.BackColor = System.Drawing.Color.DarkRed;
            btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            btnVolver.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnVolver.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            btnVolver.Location = new System.Drawing.Point(647, 127);
            btnVolver.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new System.Drawing.Size(138, 49);
            btnVolver.TabIndex = 8;
            btnVolver.Text = "Inicio";
            btnVolver.UseVisualStyleBackColor = false;
            btnVolver.Click += btnVolver_Click;
            // 
            // RegistroUsuario
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(865, 466);
            Controls.Add(btnVolver);
            Controls.Add(btnRegistrar);
            Controls.Add(txtRepetirContrasenia);
            Controls.Add(label4);
            Controls.Add(txtContraseniaRegistro);
            Controls.Add(label3);
            Controls.Add(txtUsuarioRegistro);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            Name = "RegistroUsuario";
            Text = "RegistroUsuario";
            Load += RegistroUsuario_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUsuarioRegistro;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtContraseniaRegistro;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtRepetirContrasenia;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Button btnVolver;
    }
}