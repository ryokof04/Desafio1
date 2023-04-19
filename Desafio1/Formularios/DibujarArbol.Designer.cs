namespace Desafio1
{
    partial class DibujarArbol
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
            btnRegresar = new System.Windows.Forms.Button();
            lblInformacion = new System.Windows.Forms.Label();
            SuspendLayout();
            // 
            // btnRegresar
            // 
            btnRegresar.BackColor = System.Drawing.Color.DarkRed;
            btnRegresar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            btnRegresar.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnRegresar.ForeColor = System.Drawing.SystemColors.Control;
            btnRegresar.Location = new System.Drawing.Point(450, 11);
            btnRegresar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            btnRegresar.Name = "btnRegresar";
            btnRegresar.Size = new System.Drawing.Size(190, 34);
            btnRegresar.TabIndex = 0;
            btnRegresar.Text = "Dibujar otro paciente";
            btnRegresar.UseVisualStyleBackColor = false;
            btnRegresar.Click += btnRegresar_Click;
            // 
            // lblInformacion
            // 
            lblInformacion.AutoSize = true;
            lblInformacion.Location = new System.Drawing.Point(10, 448);
            lblInformacion.Name = "lblInformacion";
            lblInformacion.Size = new System.Drawing.Size(0, 15);
            lblInformacion.TabIndex = 1;
            // 
            // DibujarArbol
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new System.Drawing.Size(652, 609);
            Controls.Add(lblInformacion);
            Controls.Add(btnRegresar);
            Name = "DibujarArbol";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "DIBUJAR ARBOL";
            Load += DibujarArbol_Load;
            Paint += DibujarArbol_Paint;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.Label lblInformacion;
    }
}