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
            dgVehiculos = new DataGridView();
            btnCargarVehiculos = new Button();
            Matricula = new DataGridViewTextBoxColumn();
            Marca = new DataGridViewTextBoxColumn();
            Modelo = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgVehiculos).BeginInit();
            SuspendLayout();
            // 
            // dgVehiculos
            // 
            dgVehiculos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgVehiculos.Columns.AddRange(new DataGridViewColumn[] { Matricula, Marca, Modelo });
            dgVehiculos.Location = new Point(51, 57);
            dgVehiculos.Name = "dgVehiculos";
            dgVehiculos.RowHeadersWidth = 62;
            dgVehiculos.Size = new Size(295, 259);
            dgVehiculos.TabIndex = 0;
            // 
            // btnCargarVehiculos
            // 
            btnCargarVehiculos.Location = new Point(470, 57);
            btnCargarVehiculos.Name = "btnCargarVehiculos";
            btnCargarVehiculos.Size = new Size(179, 52);
            btnCargarVehiculos.TabIndex = 1;
            btnCargarVehiculos.Text = "Cargar Vehiculos";
            btnCargarVehiculos.UseVisualStyleBackColor = true;
            btnCargarVehiculos.Click += btnCargarVehiculos_Click;
            // 
            // Matricula
            // 
            Matricula.HeaderText = "Matricula";
            Matricula.MinimumWidth = 8;
            Matricula.Name = "Matricula";
            Matricula.Width = 150;
            // 
            // Marca
            // 
            Marca.HeaderText = "Marca";
            Marca.MinimumWidth = 8;
            Marca.Name = "Marca";
            Marca.Width = 150;
            // 
            // Modelo
            // 
            Modelo.HeaderText = "Modelo";
            Modelo.MinimumWidth = 8;
            Modelo.Name = "Modelo";
            Modelo.Width = 150;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCargarVehiculos);
            Controls.Add(dgVehiculos);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgVehiculos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgVehiculos;
        private Button btnCargarVehiculos;
        private DataGridViewTextBoxColumn Matricula;
        private DataGridViewTextBoxColumn Marca;
        private DataGridViewTextBoxColumn Modelo;
    }
}
