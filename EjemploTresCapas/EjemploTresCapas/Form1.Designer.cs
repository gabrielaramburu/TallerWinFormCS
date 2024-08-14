namespace EjemploTresCapas
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
            btnInvocarNegocio = new Button();
            SuspendLayout();
            // 
            // btnInvocarNegocio
            // 
            btnInvocarNegocio.Location = new Point(497, 63);
            btnInvocarNegocio.Name = "btnInvocarNegocio";
            btnInvocarNegocio.Size = new Size(222, 51);
            btnInvocarNegocio.TabIndex = 0;
            btnInvocarNegocio.Text = "Invocar negocio";
            btnInvocarNegocio.UseVisualStyleBackColor = true;
            btnInvocarNegocio.Click += btnInvocarNegocio_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnInvocarNegocio);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button btnInvocarNegocio;
    }
}
