namespace EjemploNavegacionFormularios
{
    partial class frmSecundario
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
            lblTipoFormulario = new Label();
            lblDescripcion = new Label();
            SuspendLayout();
            // 
            // lblTipoFormulario
            // 
            lblTipoFormulario.AutoSize = true;
            lblTipoFormulario.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTipoFormulario.Location = new Point(107, 142);
            lblTipoFormulario.Name = "lblTipoFormulario";
            lblTipoFormulario.Size = new Size(234, 45);
            lblTipoFormulario.TabIndex = 0;
            lblTipoFormulario.Text = "tipo formulario";
            // 
            // lblDescripcion
            // 
            lblDescripcion.AutoSize = true;
            lblDescripcion.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDescripcion.Location = new Point(107, 208);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(183, 45);
            lblDescripcion.TabIndex = 1;
            lblDescripcion.Text = "descripcion";
            // 
            // frmSecundario
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1303, 390);
            Controls.Add(lblDescripcion);
            Controls.Add(lblTipoFormulario);
            Name = "frmSecundario";
            Text = "frmSecundario";
            Load += frmSecundario_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTipoFormulario;
        private Label lblDescripcion;
    }
}