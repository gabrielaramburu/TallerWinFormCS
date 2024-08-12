namespace EjemploHabilitarBoton
{
    partial class Form1
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
            txtValor1 = new TextBox();
            txtValor2 = new TextBox();
            txtValor3 = new TextBox();
            btnContinuar = new Button();
            SuspendLayout();
            // 
            // txtValor1
            // 
            txtValor1.Location = new Point(29, 56);
            txtValor1.Name = "txtValor1";
            txtValor1.Size = new Size(410, 31);
            txtValor1.TabIndex = 0;
            txtValor1.TextChanged += txtValor1_TextChanged;
            // 
            // txtValor2
            // 
            txtValor2.Location = new Point(30, 117);
            txtValor2.Name = "txtValor2";
            txtValor2.Size = new Size(409, 31);
            txtValor2.TabIndex = 1;
            txtValor2.TextChanged += txtValor2_TextChanged;
            // 
            // txtValor3
            // 
            txtValor3.Location = new Point(25, 187);
            txtValor3.Name = "txtValor3";
            txtValor3.Size = new Size(414, 31);
            txtValor3.TabIndex = 2;
            txtValor3.TextChanged += txtValor3_TextChanged;
            // 
            // btnContinuar
            // 
            btnContinuar.Enabled = false;
            btnContinuar.Location = new Point(592, 387);
            btnContinuar.Name = "btnContinuar";
            btnContinuar.Size = new Size(160, 36);
            btnContinuar.TabIndex = 3;
            btnContinuar.Text = "Continuar";
            btnContinuar.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnContinuar);
            Controls.Add(txtValor3);
            Controls.Add(txtValor2);
            Controls.Add(txtValor1);
            Name = "Form1";
            Text = "Habilitar botón en base a ingreso de datos";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtValor1;
        private TextBox txtValor2;
        private TextBox txtValor3;
        
        private Button btnContinuar;
    }
}
