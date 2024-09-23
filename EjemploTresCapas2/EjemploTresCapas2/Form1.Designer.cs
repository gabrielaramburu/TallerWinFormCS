namespace EjemploTresCapas2
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
            btnVersion1 = new Button();
            lblVersion1 = new Label();
            btnVersion2 = new Button();
            lblVersion2 = new Label();
            btnVersion3 = new Button();
            lblVersion3 = new Label();
            SuspendLayout();
            // 
            // btnVersion1
            // 
            btnVersion1.Location = new Point(45, 38);
            btnVersion1.Name = "btnVersion1";
            btnVersion1.Size = new Size(287, 54);
            btnVersion1.TabIndex = 0;
            btnVersion1.Text = "Versión 1";
            btnVersion1.UseVisualStyleBackColor = true;
            btnVersion1.Click += btnVersion1_Click;
            // 
            // lblVersion1
            // 
            lblVersion1.Location = new Point(375, 41);
            lblVersion1.Name = "lblVersion1";
            lblVersion1.Size = new Size(681, 51);
            lblVersion1.TabIndex = 1;
            lblVersion1.Text = "label1";
            // 
            // btnVersion2
            // 
            btnVersion2.Location = new Point(46, 119);
            btnVersion2.Name = "btnVersion2";
            btnVersion2.Size = new Size(286, 51);
            btnVersion2.TabIndex = 2;
            btnVersion2.Text = "Versión 2";
            btnVersion2.UseVisualStyleBackColor = true;
            btnVersion2.Click += btnVersion2_Click;
            // 
            // lblVersion2
            // 
            lblVersion2.Location = new Point(377, 118);
            lblVersion2.Name = "lblVersion2";
            lblVersion2.Size = new Size(702, 52);
            lblVersion2.TabIndex = 3;
            lblVersion2.Text = "label2";
            // 
            // btnVersion3
            // 
            btnVersion3.Location = new Point(45, 197);
            btnVersion3.Name = "btnVersion3";
            btnVersion3.Size = new Size(288, 50);
            btnVersion3.TabIndex = 4;
            btnVersion3.Text = "Versión 3";
            btnVersion3.UseVisualStyleBackColor = true;
            btnVersion3.Click += btnVersion3_Click;
            // 
            // lblVersion3
            // 
            lblVersion3.Location = new Point(377, 197);
            lblVersion3.Name = "lblVersion3";
            lblVersion3.Size = new Size(691, 56);
            lblVersion3.TabIndex = 5;
            lblVersion3.Text = "label1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1134, 450);
            Controls.Add(lblVersion3);
            Controls.Add(btnVersion3);
            Controls.Add(lblVersion2);
            Controls.Add(btnVersion2);
            Controls.Add(lblVersion1);
            Controls.Add(btnVersion1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnVersion1;
        private Label lblVersion1;
        private Button btnVersion2;
        private Label lblVersion2;
        private Button btnVersion3;
        private Label lblVersion3;
    }
}
