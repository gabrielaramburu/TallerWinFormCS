namespace EjemploNavegacionFormularios
{
    partial class frmAccederPropiedadesOtroFormulario
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
            btnMostrar = new Button();
            SuspendLayout();
            // 
            // btnMostrar
            // 
            btnMostrar.Location = new Point(73, 54);
            btnMostrar.Name = "btnMostrar";
            btnMostrar.Size = new Size(666, 55);
            btnMostrar.TabIndex = 0;
            btnMostrar.Text = "Mostrar selección formulario anterior";
            btnMostrar.UseVisualStyleBackColor = true;
            btnMostrar.Click += btnMostrar_Click;
            // 
            // frmAccederPropiedadesOtroFormulario
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(810, 432);
            Controls.Add(btnMostrar);
            Name = "frmAccederPropiedadesOtroFormulario";
            Text = "frmAccederPropiedadesOtroFormulario";
            Load += frmAccederPropiedadesOtroFormulario_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnMostrar;
    }
}