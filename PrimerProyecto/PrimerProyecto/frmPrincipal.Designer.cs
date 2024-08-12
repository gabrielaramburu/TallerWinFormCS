namespace PrimerProyecto
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
            txtNombre = new TextBox();
            label1 = new Label();
            Apellido = new Label();
            txtApellido = new TextBox();
            btnConfirmar = new Button();
            dateTimeFechaNacimiento = new DateTimePicker();
            numericUpDownEdad = new NumericUpDown();
            label2 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)numericUpDownEdad).BeginInit();
            SuspendLayout();
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(29, 48);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(604, 31);
            txtNombre.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(29, 20);
            label1.Name = "label1";
            label1.Size = new Size(82, 25);
            label1.TabIndex = 1;
            label1.Text = "Nombre:";
            // 
            // Apellido
            // 
            Apellido.AutoSize = true;
            Apellido.Location = new Point(31, 94);
            Apellido.Name = "Apellido";
            Apellido.Size = new Size(78, 25);
            Apellido.TabIndex = 2;
            Apellido.Text = "Apellido";
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(32, 119);
            txtApellido.Name = "txtApellido";
            txtApellido.PasswordChar = '*';
            txtApellido.Size = new Size(601, 31);
            txtApellido.TabIndex = 3;
            // 
            // btnConfirmar
            // 
            btnConfirmar.Location = new Point(506, 302);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(112, 34);
            btnConfirmar.TabIndex = 4;
            btnConfirmar.Text = "Confirmar";
            btnConfirmar.UseVisualStyleBackColor = true;
            btnConfirmar.Click += btnConfirmar_Click;
            // 
            // dateTimeFechaNacimiento
            // 
            dateTimeFechaNacimiento.Location = new Point(32, 193);
            dateTimeFechaNacimiento.Name = "dateTimeFechaNacimiento";
            dateTimeFechaNacimiento.Size = new Size(300, 31);
            dateTimeFechaNacimiento.TabIndex = 5;
            // 
            // numericUpDownEdad
            // 
            numericUpDownEdad.Location = new Point(33, 276);
            numericUpDownEdad.Name = "numericUpDownEdad";
            numericUpDownEdad.Size = new Size(113, 31);
            numericUpDownEdad.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(29, 165);
            label2.Name = "label2";
            label2.Size = new Size(177, 25);
            label2.TabIndex = 7;
            label2.Text = "Fecha de Nacimiento";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(29, 248);
            label3.Name = "label3";
            label3.Size = new Size(52, 25);
            label3.TabIndex = 8;
            label3.Text = "Edad";
            // 
            // frmPrincipal
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(666, 365);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(numericUpDownEdad);
            Controls.Add(dateTimeFechaNacimiento);
            Controls.Add(btnConfirmar);
            Controls.Add(txtApellido);
            Controls.Add(Apellido);
            Controls.Add(label1);
            Controls.Add(txtNombre);
            Name = "frmPrincipal";
            Text = "Primer formulario";
            ((System.ComponentModel.ISupportInitialize)numericUpDownEdad).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNombre;
        private Label label1;
        private Label Apellido;
        private TextBox txtApellido;
        private Button btnConfirmar;
        private DateTimePicker dateTimeFechaNacimiento;
        private NumericUpDown numericUpDownEdad;
        private Label label2;
        private Label label3;
    }
}
