namespace TrabajoPractico
{
    partial class FormTablaRK
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cK1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cK2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cK3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cK4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cX,
            this.cY,
            this.cK1,
            this.cK2,
            this.cK3,
            this.cK4});
            this.dataGridView1.Location = new System.Drawing.Point(2, 29);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(786, 409);
            this.dataGridView1.TabIndex = 0;
            // 
            // cX
            // 
            this.cX.HeaderText = "X";
            this.cX.Name = "cX";
            // 
            // cY
            // 
            this.cY.HeaderText = "Y";
            this.cY.Name = "cY";
            // 
            // cK1
            // 
            this.cK1.HeaderText = "K1";
            this.cK1.Name = "cK1";
            // 
            // cK2
            // 
            this.cK2.HeaderText = "K2";
            this.cK2.Name = "cK2";
            // 
            // cK3
            // 
            this.cK3.HeaderText = "K3";
            this.cK3.Name = "cK3";
            // 
            // cK4
            // 
            this.cK4.HeaderText = "K4";
            this.cK4.Name = "cK4";
            // 
            // FormTablaRK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormTablaRK";
            this.Text = "Tabla RK";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cX;
        private System.Windows.Forms.DataGridViewTextBoxColumn cY;
        private System.Windows.Forms.DataGridViewTextBoxColumn cK1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cK2;
        private System.Windows.Forms.DataGridViewTextBoxColumn cK3;
        private System.Windows.Forms.DataGridViewTextBoxColumn cK4;
    }
}