namespace EjemploTresCapas2.version1
{
    partial class FormVersion1
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
            dgVehiculos = new DataGridView();
            btnCargar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgVehiculos).BeginInit();
            SuspendLayout();
            // 
            // dgVehiculos
            // 
            dgVehiculos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgVehiculos.Location = new Point(35, 30);
            dgVehiculos.Name = "dgVehiculos";
            dgVehiculos.RowHeadersWidth = 62;
            dgVehiculos.Size = new Size(680, 272);
            dgVehiculos.TabIndex = 0;
            // 
            // btnCargar
            // 
            btnCargar.Location = new Point(449, 325);
            btnCargar.Name = "btnCargar";
            btnCargar.Size = new Size(268, 54);
            btnCargar.TabIndex = 1;
            btnCargar.Text = "Cargar";
            btnCargar.UseVisualStyleBackColor = true;
            btnCargar.Click += btnCargar_Click;
            // 
            // FormVersion1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCargar);
            Controls.Add(dgVehiculos);
            Name = "FormVersion1";
            Text = "FormVersion1";
            ((System.ComponentModel.ISupportInitialize)dgVehiculos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgVehiculos;
        private Button btnCargar;
    }
}