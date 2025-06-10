namespace TrabajoPractico
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtIteraciones = new System.Windows.Forms.TextBox();
            this.txtTiempo = new System.Windows.Forms.TextBox();
            this.txtDesde = new System.Windows.Forms.TextBox();
            this.txtHasta = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTllegada = new System.Windows.Forms.TextBox();
            this.dgvTipoVehiculo = new System.Windows.Forms.DataGridView();
            this.cTipoVehiculo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cProbabilidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cProbabilidadAcum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cPrecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSimular = new System.Windows.Forms.Button();
            this.btnTablavehiculo = new System.Windows.Forms.Button();
            this.rb8 = new System.Windows.Forms.RadioButton();
            this.rb10 = new System.Windows.Forms.RadioButton();
            this.txtConcentracionA = new System.Windows.Forms.TextBox();
            this.txtConcentracionB = new System.Windows.Forms.TextBox();
            this.lbl = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPaso = new System.Windows.Forms.TextBox();
            this.btnRunge = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtRKA = new System.Windows.Forms.TextBox();
            this.txtRKB = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTipoVehiculo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtIteraciones
            // 
            this.txtIteraciones.Location = new System.Drawing.Point(69, 13);
            this.txtIteraciones.Name = "txtIteraciones";
            this.txtIteraciones.Size = new System.Drawing.Size(100, 20);
            this.txtIteraciones.TabIndex = 0;
            this.txtIteraciones.Text = "100000";
            // 
            // txtTiempo
            // 
            this.txtTiempo.Location = new System.Drawing.Point(69, 39);
            this.txtTiempo.Name = "txtTiempo";
            this.txtTiempo.Size = new System.Drawing.Size(100, 20);
            this.txtTiempo.TabIndex = 1;
            // 
            // txtDesde
            // 
            this.txtDesde.Location = new System.Drawing.Point(257, 13);
            this.txtDesde.Name = "txtDesde";
            this.txtDesde.Size = new System.Drawing.Size(100, 20);
            this.txtDesde.TabIndex = 2;
            this.txtDesde.Text = "0";
            // 
            // txtHasta
            // 
            this.txtHasta.Location = new System.Drawing.Point(257, 39);
            this.txtHasta.Name = "txtHasta";
            this.txtHasta.Size = new System.Drawing.Size(100, 20);
            this.txtHasta.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Iteraciones";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Tiempo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(178, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Tiempo desde";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(178, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Tiempo Hasta";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(377, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "T. llegadas";
            // 
            // txtTllegada
            // 
            this.txtTllegada.Location = new System.Drawing.Point(442, 13);
            this.txtTllegada.Name = "txtTllegada";
            this.txtTllegada.Size = new System.Drawing.Size(100, 20);
            this.txtTllegada.TabIndex = 8;
            this.txtTllegada.Text = "13";
            // 
            // dgvTipoVehiculo
            // 
            this.dgvTipoVehiculo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTipoVehiculo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cTipoVehiculo,
            this.cProbabilidad,
            this.cProbabilidadAcum,
            this.cPrecio});
            this.dgvTipoVehiculo.Location = new System.Drawing.Point(11, 96);
            this.dgvTipoVehiculo.Name = "dgvTipoVehiculo";
            this.dgvTipoVehiculo.Size = new System.Drawing.Size(443, 129);
            this.dgvTipoVehiculo.TabIndex = 10;
            // 
            // cTipoVehiculo
            // 
            this.cTipoVehiculo.HeaderText = "Tipo de vehiculo";
            this.cTipoVehiculo.Name = "cTipoVehiculo";
            // 
            // cProbabilidad
            // 
            this.cProbabilidad.HeaderText = "P()";
            this.cProbabilidad.Name = "cProbabilidad";
            // 
            // cProbabilidadAcum
            // 
            this.cProbabilidadAcum.HeaderText = "P() Ac";
            this.cProbabilidadAcum.Name = "cProbabilidadAcum";
            // 
            // cPrecio
            // 
            this.cPrecio.HeaderText = "Precio";
            this.cPrecio.Name = "cPrecio";
            // 
            // btnSimular
            // 
            this.btnSimular.Location = new System.Drawing.Point(836, 10);
            this.btnSimular.Name = "btnSimular";
            this.btnSimular.Size = new System.Drawing.Size(75, 23);
            this.btnSimular.TabIndex = 11;
            this.btnSimular.Text = "Simular";
            this.btnSimular.UseVisualStyleBackColor = true;
            // 
            // btnTablavehiculo
            // 
            this.btnTablavehiculo.Location = new System.Drawing.Point(475, 133);
            this.btnTablavehiculo.Name = "btnTablavehiculo";
            this.btnTablavehiculo.Size = new System.Drawing.Size(82, 37);
            this.btnTablavehiculo.TabIndex = 12;
            this.btnTablavehiculo.Text = "Recalcular tabla";
            this.btnTablavehiculo.UseVisualStyleBackColor = true;
            // 
            // rb8
            // 
            this.rb8.AutoSize = true;
            this.rb8.Location = new System.Drawing.Point(442, 39);
            this.rb8.Name = "rb8";
            this.rb8.Size = new System.Drawing.Size(86, 17);
            this.rb8.TabIndex = 13;
            this.rb8.TabStop = true;
            this.rb8.Text = "8 Estaciones";
            this.rb8.UseVisualStyleBackColor = true;
            // 
            // rb10
            // 
            this.rb10.AutoSize = true;
            this.rb10.Location = new System.Drawing.Point(442, 63);
            this.rb10.Name = "rb10";
            this.rb10.Size = new System.Drawing.Size(92, 17);
            this.rb10.TabIndex = 14;
            this.rb10.TabStop = true;
            this.rb10.Text = "10 Estaciones";
            this.rb10.UseVisualStyleBackColor = true;
            // 
            // txtConcentracionA
            // 
            this.txtConcentracionA.Location = new System.Drawing.Point(573, 25);
            this.txtConcentracionA.Name = "txtConcentracionA";
            this.txtConcentracionA.Size = new System.Drawing.Size(100, 20);
            this.txtConcentracionA.TabIndex = 15;
            this.txtConcentracionA.Text = "5";
            // 
            // txtConcentracionB
            // 
            this.txtConcentracionB.Location = new System.Drawing.Point(573, 51);
            this.txtConcentracionB.Name = "txtConcentracionB";
            this.txtConcentracionB.Size = new System.Drawing.Size(100, 20);
            this.txtConcentracionB.TabIndex = 16;
            this.txtConcentracionB.Text = "15";
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Location = new System.Drawing.Point(584, 9);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(76, 13);
            this.lbl.TabIndex = 17;
            this.lbl.Text = "Concentracion";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(693, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(13, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "h";
            // 
            // txtPaso
            // 
            this.txtPaso.Location = new System.Drawing.Point(713, 25);
            this.txtPaso.Name = "txtPaso";
            this.txtPaso.Size = new System.Drawing.Size(82, 20);
            this.txtPaso.TabIndex = 19;
            // 
            // btnRunge
            // 
            this.btnRunge.Location = new System.Drawing.Point(587, 133);
            this.btnRunge.Name = "btnRunge";
            this.btnRunge.Size = new System.Drawing.Size(75, 23);
            this.btnRunge.TabIndex = 20;
            this.btnRunge.Text = "Mostrar RK";
            this.btnRunge.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(31, 263);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(862, 150);
            this.dataGridView1.TabIndex = 21;
            // 
            // txtRKA
            // 
            this.txtRKA.Location = new System.Drawing.Point(713, 52);
            this.txtRKA.Name = "txtRKA";
            this.txtRKA.Size = new System.Drawing.Size(82, 20);
            this.txtRKA.TabIndex = 22;
            this.txtRKA.Text = "2";
            // 
            // txtRKB
            // 
            this.txtRKB.Location = new System.Drawing.Point(713, 79);
            this.txtRKB.Name = "txtRKB";
            this.txtRKB.Size = new System.Drawing.Size(82, 20);
            this.txtRKB.TabIndex = 23;
            this.txtRKB.Text = "3";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(679, 55);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 13);
            this.label7.TabIndex = 24;
            this.label7.Text = "RK A";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(679, 82);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(32, 13);
            this.label8.TabIndex = 25;
            this.label8.Text = "RK B";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(923, 578);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtRKB);
            this.Controls.Add(this.txtRKA);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnRunge);
            this.Controls.Add(this.txtPaso);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.txtConcentracionB);
            this.Controls.Add(this.txtConcentracionA);
            this.Controls.Add(this.rb10);
            this.Controls.Add(this.rb8);
            this.Controls.Add(this.btnTablavehiculo);
            this.Controls.Add(this.btnSimular);
            this.Controls.Add(this.dgvTipoVehiculo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtTllegada);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtHasta);
            this.Controls.Add(this.txtDesde);
            this.Controls.Add(this.txtTiempo);
            this.Controls.Add(this.txtIteraciones);
            this.Name = "Form1";
            this.Text = "Estacion de Carga Urbana";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTipoVehiculo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtIteraciones;
        private System.Windows.Forms.TextBox txtTiempo;
        private System.Windows.Forms.TextBox txtDesde;
        private System.Windows.Forms.TextBox txtHasta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTllegada;
        private System.Windows.Forms.DataGridView dgvTipoVehiculo;
        private System.Windows.Forms.DataGridViewTextBoxColumn cTipoVehiculo;
        private System.Windows.Forms.DataGridViewTextBoxColumn cProbabilidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn cProbabilidadAcum;
        private System.Windows.Forms.DataGridViewTextBoxColumn cPrecio;
        private System.Windows.Forms.Button btnSimular;
        private System.Windows.Forms.Button btnTablavehiculo;
        private System.Windows.Forms.RadioButton rb8;
        private System.Windows.Forms.RadioButton rb10;
        private System.Windows.Forms.TextBox txtConcentracionA;
        private System.Windows.Forms.TextBox txtConcentracionB;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPaso;
        private System.Windows.Forms.Button btnRunge;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtRKA;
        private System.Windows.Forms.TextBox txtRKB;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}

