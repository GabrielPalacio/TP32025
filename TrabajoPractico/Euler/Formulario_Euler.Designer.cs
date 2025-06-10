namespace Laboratorio.Metodo
{
    partial class Formulario_Euler
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
            dgvSector1000 = new DataGridView();
            label1 = new Label();
            dgvSector1500 = new DataGridView();
            dgvSector2000 = new DataGridView();
            label2 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvSector1000).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvSector1500).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvSector2000).BeginInit();
            SuspendLayout();
            // 
            // dgvSector1000
            // 
            dgvSector1000.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSector1000.Location = new Point(12, 45);
            dgvSector1000.Name = "dgvSector1000";
            dgvSector1000.RowHeadersVisible = false;
            dgvSector1000.RowTemplate.Height = 25;
            dgvSector1000.Size = new Size(315, 301);
            dgvSector1000.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 23);
            label1.Name = "label1";
            label1.Size = new Size(67, 15);
            label1.TabIndex = 1;
            label1.Text = "Sector 1000";
            // 
            // dgvSector1500
            // 
            dgvSector1500.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSector1500.Location = new Point(333, 45);
            dgvSector1500.Name = "dgvSector1500";
            dgvSector1500.RowHeadersVisible = false;
            dgvSector1500.RowTemplate.Height = 25;
            dgvSector1500.Size = new Size(329, 301);
            dgvSector1500.TabIndex = 2;
            // 
            // dgvSector2000
            // 
            dgvSector2000.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSector2000.Location = new Point(668, 45);
            dgvSector2000.Name = "dgvSector2000";
            dgvSector2000.RowHeadersVisible = false;
            dgvSector2000.RowTemplate.Height = 25;
            dgvSector2000.Size = new Size(338, 301);
            dgvSector2000.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(353, 23);
            label2.Name = "label2";
            label2.Size = new Size(67, 15);
            label2.TabIndex = 4;
            label2.Text = "Sector 1500";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(721, 23);
            label3.Name = "label3";
            label3.Size = new Size(67, 15);
            label3.TabIndex = 5;
            label3.Text = "Sector 2000";
            // 
            // Formulario_Euler
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1028, 450);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(dgvSector2000);
            Controls.Add(dgvSector1500);
            Controls.Add(label1);
            Controls.Add(dgvSector1000);
            Name = "Formulario_Euler";
            Text = "Euler";
            ((System.ComponentModel.ISupportInitialize)dgvSector1000).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvSector1500).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvSector2000).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvSector1000;
        private Label label1;
        private DataGridView dgvSector1500;
        private DataGridView dgvSector2000;
        private Label label2;
        private Label label3;
    }
}