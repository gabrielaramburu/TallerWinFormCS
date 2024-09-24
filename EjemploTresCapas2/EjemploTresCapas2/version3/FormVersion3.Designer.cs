namespace EjemploTresCapas2.version3
{
    partial class FormVersion3
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
            groupBox1 = new GroupBox();
            cboMarcas = new ComboBox();
            btnNuevo = new Button();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtModelo = new TextBox();
            txtMatricula = new TextBox();
            txtId = new TextBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dgVehiculos).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dgVehiculos
            // 
            dgVehiculos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgVehiculos.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgVehiculos.Location = new Point(23, 276);
            dgVehiculos.Name = "dgVehiculos";
            dgVehiculos.RowHeadersWidth = 62;
            dgVehiculos.Size = new Size(847, 317);
            dgVehiculos.TabIndex = 0;
            dgVehiculos.CellClick += dgVehiculos_CellClick;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cboMarcas);
            groupBox1.Controls.Add(btnNuevo);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtModelo);
            groupBox1.Controls.Add(txtMatricula);
            groupBox1.Controls.Add(txtId);
            groupBox1.Location = new Point(23, 18);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(843, 235);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Vehiculos";
            // 
            // cboMarcas
            // 
            cboMarcas.FormattingEnabled = true;
            cboMarcas.Location = new Point(465, 59);
            cboMarcas.Name = "cboMarcas";
            cboMarcas.Size = new Size(291, 33);
            cboMarcas.TabIndex = 9;
            // 
            // btnNuevo
            // 
            btnNuevo.Location = new Point(704, 186);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(112, 34);
            btnNuevo.TabIndex = 8;
            btnNuevo.Text = "Nuevo";
            btnNuevo.UseVisualStyleBackColor = true;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(465, 93);
            label4.Name = "label4";
            label4.Size = new Size(74, 25);
            label4.TabIndex = 7;
            label4.Text = "Modelo";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(465, 31);
            label3.Name = "label3";
            label3.Size = new Size(60, 25);
            label3.TabIndex = 6;
            label3.Text = "Marca";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(19, 93);
            label2.Name = "label2";
            label2.Size = new Size(84, 25);
            label2.TabIndex = 5;
            label2.Text = "Matrícula";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(19, 31);
            label1.Name = "label1";
            label1.Size = new Size(28, 25);
            label1.TabIndex = 4;
            label1.Text = "Id";
            // 
            // txtModelo
            // 
            txtModelo.Location = new Point(465, 121);
            txtModelo.Name = "txtModelo";
            txtModelo.Size = new Size(291, 31);
            txtModelo.TabIndex = 3;
            // 
            // txtMatricula
            // 
            txtMatricula.Location = new Point(19, 121);
            txtMatricula.Name = "txtMatricula";
            txtMatricula.Size = new Size(291, 31);
            txtMatricula.TabIndex = 1;
            // 
            // txtId
            // 
            txtId.BackColor = SystemColors.ControlLight;
            txtId.Location = new Point(19, 59);
            txtId.Name = "txtId";
            txtId.Size = new Size(291, 31);
            txtId.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.underConstruction;
            pictureBox1.Location = new Point(885, 30);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(293, 250);
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // FormVersion3
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1222, 605);
            Controls.Add(pictureBox1);
            Controls.Add(groupBox1);
            Controls.Add(dgVehiculos);
            Name = "FormVersion3";
            Text = "FormVersion3";
            Load += FormVersion3_Load;
            ((System.ComponentModel.ISupportInitialize)dgVehiculos).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgVehiculos;
        private GroupBox groupBox1;
        private TextBox txtModelo;
        private TextBox txtMatricula;
        private TextBox txtId;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btnNuevo;
        private ComboBox cboMarcas;
        private PictureBox pictureBox1;
    }
}