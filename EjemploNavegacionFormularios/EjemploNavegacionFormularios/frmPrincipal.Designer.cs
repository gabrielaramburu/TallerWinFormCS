namespace EjemploNavegacionFormularios
{
    partial class frmPrincipal
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
            btnAbrirModal = new Button();
            btnNoModal = new Button();
            label1 = new Label();
            cboSeleccion = new ComboBox();
            btnAvanzar = new Button();
            SuspendLayout();
            // 
            // btnAbrirModal
            // 
            btnAbrirModal.Location = new Point(323, 63);
            btnAbrirModal.Name = "btnAbrirModal";
            btnAbrirModal.Size = new Size(316, 54);
            btnAbrirModal.TabIndex = 0;
            btnAbrirModal.Text = "Abrir formulario modal";
            btnAbrirModal.UseVisualStyleBackColor = true;
            btnAbrirModal.Click += btnAbrirModal_Click_1;
            // 
            // btnNoModal
            // 
            btnNoModal.Location = new Point(323, 157);
            btnNoModal.Name = "btnNoModal";
            btnNoModal.Size = new Size(320, 54);
            btnNoModal.TabIndex = 1;
            btnNoModal.Text = "Abrir formulario no modal";
            btnNoModal.UseVisualStyleBackColor = true;
            btnNoModal.Click += btnNoModal_Click_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(27, 314);
            label1.Name = "label1";
            label1.Size = new Size(188, 25);
            label1.TabIndex = 2;
            label1.Text = "Seleccione una opcion";
            // 
            // cboSeleccion
            // 
            cboSeleccion.FormattingEnabled = true;
            cboSeleccion.Items.AddRange(new object[] { "Primera opción", "Segunda opción", "Tercera opción" });
            cboSeleccion.Location = new Point(23, 357);
            cboSeleccion.Name = "cboSeleccion";
            cboSeleccion.Size = new Size(462, 33);
            cboSeleccion.TabIndex = 3;
            // 
            // btnAvanzar
            // 
            btnAvanzar.Location = new Point(530, 357);
            btnAvanzar.Name = "btnAvanzar";
            btnAvanzar.Size = new Size(172, 36);
            btnAvanzar.TabIndex = 4;
            btnAvanzar.Text = "Avanzar";
            btnAvanzar.UseVisualStyleBackColor = true;
            btnAvanzar.Click += btnAvanzar_Click;
            // 
            // frmPrincipal
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnAvanzar);
            Controls.Add(cboSeleccion);
            Controls.Add(label1);
            Controls.Add(btnNoModal);
            Controls.Add(btnAbrirModal);
            Name = "frmPrincipal";
            Text = "Formulario Principal";
            Load += frmPrincipal_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAbrirModal;
        private Button btnNoModal;
        private Label label1;
        private Button btnAvanzar;
        protected ComboBox cboSeleccion;
    }
}
