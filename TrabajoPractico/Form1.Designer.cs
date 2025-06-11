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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle25 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle26 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle27 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle28 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle29 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle30 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
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
            this.rb8 = new System.Windows.Forms.RadioButton();
            this.rb10 = new System.Windows.Forms.RadioButton();
            this.txtConcentracionA = new System.Windows.Forms.TextBox();
            this.txtConcentracionB = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPaso = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtRKA = new System.Windows.Forms.TextBox();
            this.txtRKB = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.roundedButton1 = new TrabajoPractico.RoundedButton();
            this.btnTablavehiculo = new TrabajoPractico.RoundedButton();
            this.btnRunge = new TrabajoPractico.RoundedButton();
            this.btnSimular = new TrabajoPractico.RoundedButton();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTipoVehiculo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtIteraciones
            // 
            this.txtIteraciones.Font = new System.Drawing.Font("Miriam CLM", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txtIteraciones.ForeColor = System.Drawing.Color.White;
            this.txtIteraciones.Location = new System.Drawing.Point(198, 31);
            this.txtIteraciones.Name = "txtIteraciones";
            this.txtIteraciones.Size = new System.Drawing.Size(100, 28);
            this.txtIteraciones.TabIndex = 0;
            this.txtIteraciones.Text = "100000";
            // 
            // txtTiempo
            // 
            this.txtTiempo.Font = new System.Drawing.Font("Miriam CLM", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txtTiempo.ForeColor = System.Drawing.Color.White;
            this.txtTiempo.Location = new System.Drawing.Point(198, 65);
            this.txtTiempo.Name = "txtTiempo";
            this.txtTiempo.Size = new System.Drawing.Size(100, 28);
            this.txtTiempo.TabIndex = 1;
            // 
            // txtDesde
            // 
            this.txtDesde.Font = new System.Drawing.Font("Miriam CLM", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txtDesde.ForeColor = System.Drawing.Color.White;
            this.txtDesde.Location = new System.Drawing.Point(424, 50);
            this.txtDesde.Name = "txtDesde";
            this.txtDesde.Size = new System.Drawing.Size(102, 28);
            this.txtDesde.TabIndex = 2;
            this.txtDesde.Text = "0";
            // 
            // txtHasta
            // 
            this.txtHasta.Font = new System.Drawing.Font("Miriam CLM", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txtHasta.ForeColor = System.Drawing.Color.White;
            this.txtHasta.Location = new System.Drawing.Point(424, 84);
            this.txtHasta.Name = "txtHasta";
            this.txtHasta.Size = new System.Drawing.Size(102, 28);
            this.txtHasta.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Miriam CLM", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(106, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 21);
            this.label1.TabIndex = 4;
            this.label1.Text = "Iteraciones:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Miriam CLM", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(128, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 21);
            this.label2.TabIndex = 5;
            this.label2.Text = "Tiempo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Miriam CLM", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(309, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 21);
            this.label3.TabIndex = 6;
            this.label3.Text = "Tiempo desde:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Miriam CLM", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(313, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 21);
            this.label4.TabIndex = 7;
            this.label4.Text = "Tiempo hasta:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Miriam CLM", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(27, 102);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(165, 21);
            this.label5.TabIndex = 9;
            this.label5.Text = "Tiempo entre llegadas:";
            // 
            // txtTllegada
            // 
            this.txtTllegada.Font = new System.Drawing.Font("Miriam CLM", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txtTllegada.ForeColor = System.Drawing.Color.White;
            this.txtTllegada.Location = new System.Drawing.Point(198, 99);
            this.txtTllegada.Name = "txtTllegada";
            this.txtTllegada.Size = new System.Drawing.Size(100, 28);
            this.txtTllegada.TabIndex = 8;
            this.txtTllegada.Text = "13";
            // 
            // dgvTipoVehiculo
            // 
            this.dgvTipoVehiculo.AllowUserToAddRows = false;
            this.dgvTipoVehiculo.AllowUserToDeleteRows = false;
            this.dgvTipoVehiculo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvTipoVehiculo.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvTipoVehiculo.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle25.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle25.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(226)))));
            dataGridViewCellStyle25.Font = new System.Drawing.Font("Miriam CLM", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            dataGridViewCellStyle25.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle25.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(226)))));
            dataGridViewCellStyle25.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle25.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTipoVehiculo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle25;
            this.dgvTipoVehiculo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTipoVehiculo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cTipoVehiculo,
            this.cProbabilidad,
            this.cProbabilidadAcum,
            this.cPrecio});
            dataGridViewCellStyle26.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle26.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(226)))));
            dataGridViewCellStyle26.Font = new System.Drawing.Font("Miriam CLM", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            dataGridViewCellStyle26.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle26.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(172)))), ((int)(((byte)(218)))));
            dataGridViewCellStyle26.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle26.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTipoVehiculo.DefaultCellStyle = dataGridViewCellStyle26;
            this.dgvTipoVehiculo.Location = new System.Drawing.Point(31, 154);
            this.dgvTipoVehiculo.Name = "dgvTipoVehiculo";
            dataGridViewCellStyle27.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle27.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle27.Font = new System.Drawing.Font("Miriam CLM", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            dataGridViewCellStyle27.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle27.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(172)))), ((int)(((byte)(218)))));
            dataGridViewCellStyle27.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle27.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTipoVehiculo.RowHeadersDefaultCellStyle = dataGridViewCellStyle27;
            this.dgvTipoVehiculo.RowHeadersVisible = false;
            this.dgvTipoVehiculo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTipoVehiculo.Size = new System.Drawing.Size(351, 129);
            this.dgvTipoVehiculo.TabIndex = 10;
            // 
            // cTipoVehiculo
            // 
            this.cTipoVehiculo.HeaderText = "Tipo de vehiculo";
            this.cTipoVehiculo.Name = "cTipoVehiculo";
            this.cTipoVehiculo.Width = 148;
            // 
            // cProbabilidad
            // 
            this.cProbabilidad.HeaderText = "P()";
            this.cProbabilidad.Name = "cProbabilidad";
            this.cProbabilidad.Width = 56;
            // 
            // cProbabilidadAcum
            // 
            this.cProbabilidadAcum.HeaderText = "P() Ac";
            this.cProbabilidadAcum.Name = "cProbabilidadAcum";
            this.cProbabilidadAcum.Width = 59;
            // 
            // cPrecio
            // 
            this.cPrecio.HeaderText = "Precio";
            this.cPrecio.Name = "cPrecio";
            this.cPrecio.Width = 84;
            // 
            // rb8
            // 
            this.rb8.AutoSize = true;
            this.rb8.BackColor = System.Drawing.Color.Transparent;
            this.rb8.Font = new System.Drawing.Font("Miriam CLM", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.rb8.Location = new System.Drawing.Point(16, 26);
            this.rb8.Name = "rb8";
            this.rb8.Size = new System.Drawing.Size(166, 25);
            this.rb8.TabIndex = 13;
            this.rb8.TabStop = true;
            this.rb8.Text = "8 Puestos de carga";
            this.rb8.UseVisualStyleBackColor = false;
            // 
            // rb10
            // 
            this.rb10.AutoSize = true;
            this.rb10.BackColor = System.Drawing.Color.Transparent;
            this.rb10.Font = new System.Drawing.Font("Miriam CLM", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.rb10.Location = new System.Drawing.Point(16, 57);
            this.rb10.Name = "rb10";
            this.rb10.Size = new System.Drawing.Size(172, 25);
            this.rb10.TabIndex = 14;
            this.rb10.TabStop = true;
            this.rb10.Text = "10 Puestos de carga";
            this.rb10.UseVisualStyleBackColor = false;
            // 
            // txtConcentracionA
            // 
            this.txtConcentracionA.Font = new System.Drawing.Font("Miriam CLM", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txtConcentracionA.Location = new System.Drawing.Point(76, 26);
            this.txtConcentracionA.Name = "txtConcentracionA";
            this.txtConcentracionA.Size = new System.Drawing.Size(100, 28);
            this.txtConcentracionA.TabIndex = 15;
            this.txtConcentracionA.Text = "5";
            // 
            // txtConcentracionB
            // 
            this.txtConcentracionB.Font = new System.Drawing.Font("Miriam CLM", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txtConcentracionB.Location = new System.Drawing.Point(76, 60);
            this.txtConcentracionB.Name = "txtConcentracionB";
            this.txtConcentracionB.Size = new System.Drawing.Size(100, 28);
            this.txtConcentracionB.TabIndex = 16;
            this.txtConcentracionB.Text = "15";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Miriam CLM", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(1036, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 21);
            this.label6.TabIndex = 18;
            this.label6.Text = "h = ";
            // 
            // txtPaso
            // 
            this.txtPaso.Font = new System.Drawing.Font("Miriam CLM", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txtPaso.ForeColor = System.Drawing.Color.White;
            this.txtPaso.Location = new System.Drawing.Point(1082, 31);
            this.txtPaso.Name = "txtPaso";
            this.txtPaso.Size = new System.Drawing.Size(82, 28);
            this.txtPaso.TabIndex = 19;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle28.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle28.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(226)))));
            dataGridViewCellStyle28.Font = new System.Drawing.Font("Miriam CLM", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            dataGridViewCellStyle28.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle28.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(226)))));
            dataGridViewCellStyle28.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle28.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle28;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle29.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle29.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(226)))));
            dataGridViewCellStyle29.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle29.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle29.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(172)))), ((int)(((byte)(218)))));
            dataGridViewCellStyle29.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle29.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle29;
            this.dataGridView1.Location = new System.Drawing.Point(31, 310);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle30.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle30.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle30.Font = new System.Drawing.Font("Miriam CLM", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            dataGridViewCellStyle30.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle30.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(172)))), ((int)(((byte)(218)))));
            dataGridViewCellStyle30.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle30.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle30;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(862, 150);
            this.dataGridView1.TabIndex = 21;
            // 
            // txtRKA
            // 
            this.txtRKA.Font = new System.Drawing.Font("Miriam CLM", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txtRKA.ForeColor = System.Drawing.Color.White;
            this.txtRKA.Location = new System.Drawing.Point(1082, 65);
            this.txtRKA.Name = "txtRKA";
            this.txtRKA.Size = new System.Drawing.Size(82, 28);
            this.txtRKA.TabIndex = 22;
            this.txtRKA.Text = "2";
            // 
            // txtRKB
            // 
            this.txtRKB.Font = new System.Drawing.Font("Miriam CLM", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txtRKB.ForeColor = System.Drawing.Color.White;
            this.txtRKB.Location = new System.Drawing.Point(1082, 99);
            this.txtRKB.Name = "txtRKB";
            this.txtRKB.Size = new System.Drawing.Size(82, 28);
            this.txtRKB.TabIndex = 23;
            this.txtRKB.Text = "3";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Miriam CLM", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(1014, 68);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 21);
            this.label7.TabIndex = 24;
            this.label7.Text = "RK A =";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Miriam CLM", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(1013, 102);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 21);
            this.label8.TabIndex = 25;
            this.label8.Text = "RK B =";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txtConcentracionB);
            this.groupBox1.Controls.Add(this.txtConcentracionA);
            this.groupBox1.Font = new System.Drawing.Font("Miriam CLM", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(788, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Concentración";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.rb10);
            this.groupBox2.Controls.Add(this.rb8);
            this.groupBox2.Font = new System.Drawing.Font("Miriam CLM", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(555, 27);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 100);
            this.groupBox2.TabIndex = 27;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Puestos de carga";
            // 
            // roundedButton1
            // 
            this.roundedButton1.BackColor = System.Drawing.Color.DodgerBlue;
            this.roundedButton1.BackgroundColor = System.Drawing.Color.DodgerBlue;
            this.roundedButton1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.roundedButton1.BorderRadius = 20;
            this.roundedButton1.BorderSize = 0;
            this.roundedButton1.FlatAppearance.BorderSize = 0;
            this.roundedButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundedButton1.Font = new System.Drawing.Font("Miriam CLM", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.roundedButton1.ForeColor = System.Drawing.Color.White;
            this.roundedButton1.Image = ((System.Drawing.Image)(resources.GetObject("roundedButton1.Image")));
            this.roundedButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.roundedButton1.Location = new System.Drawing.Point(1082, 493);
            this.roundedButton1.Name = "roundedButton1";
            this.roundedButton1.Size = new System.Drawing.Size(82, 50);
            this.roundedButton1.TabIndex = 31;
            this.roundedButton1.Text = "Salir";
            this.roundedButton1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.roundedButton1.TextColor = System.Drawing.Color.White;
            this.roundedButton1.UseVisualStyleBackColor = false;
            this.roundedButton1.Click += new System.EventHandler(this.roundedButton1_Click);
            // 
            // btnTablavehiculo
            // 
            this.btnTablavehiculo.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnTablavehiculo.BackgroundColor = System.Drawing.Color.DodgerBlue;
            this.btnTablavehiculo.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnTablavehiculo.BorderRadius = 30;
            this.btnTablavehiculo.BorderSize = 0;
            this.btnTablavehiculo.FlatAppearance.BorderSize = 0;
            this.btnTablavehiculo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTablavehiculo.Font = new System.Drawing.Font("Miriam CLM", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnTablavehiculo.ForeColor = System.Drawing.Color.White;
            this.btnTablavehiculo.Image = ((System.Drawing.Image)(resources.GetObject("btnTablavehiculo.Image")));
            this.btnTablavehiculo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTablavehiculo.Location = new System.Drawing.Point(402, 154);
            this.btnTablavehiculo.Name = "btnTablavehiculo";
            this.btnTablavehiculo.Size = new System.Drawing.Size(155, 40);
            this.btnTablavehiculo.TabIndex = 30;
            this.btnTablavehiculo.Text = "Recalcular tabla";
            this.btnTablavehiculo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTablavehiculo.TextColor = System.Drawing.Color.White;
            this.btnTablavehiculo.UseVisualStyleBackColor = false;
            // 
            // btnRunge
            // 
            this.btnRunge.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnRunge.BackgroundColor = System.Drawing.Color.DodgerBlue;
            this.btnRunge.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnRunge.BorderRadius = 30;
            this.btnRunge.BorderSize = 0;
            this.btnRunge.FlatAppearance.BorderSize = 0;
            this.btnRunge.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRunge.Font = new System.Drawing.Font("Miriam CLM", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnRunge.ForeColor = System.Drawing.Color.White;
            this.btnRunge.Image = ((System.Drawing.Image)(resources.GetObject("btnRunge.Image")));
            this.btnRunge.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRunge.Location = new System.Drawing.Point(1002, 154);
            this.btnRunge.Name = "btnRunge";
            this.btnRunge.Size = new System.Drawing.Size(162, 40);
            this.btnRunge.TabIndex = 29;
            this.btnRunge.Text = "Ver Runge Kutta";
            this.btnRunge.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRunge.TextColor = System.Drawing.Color.White;
            this.btnRunge.UseVisualStyleBackColor = false;
            // 
            // btnSimular
            // 
            this.btnSimular.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnSimular.BackgroundColor = System.Drawing.Color.DodgerBlue;
            this.btnSimular.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnSimular.BorderRadius = 30;
            this.btnSimular.BorderSize = 0;
            this.btnSimular.FlatAppearance.BorderSize = 0;
            this.btnSimular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSimular.Font = new System.Drawing.Font("Miriam CLM", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnSimular.ForeColor = System.Drawing.Color.White;
            this.btnSimular.Image = ((System.Drawing.Image)(resources.GetObject("btnSimular.Image")));
            this.btnSimular.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSimular.Location = new System.Drawing.Point(893, 154);
            this.btnSimular.Name = "btnSimular";
            this.btnSimular.Size = new System.Drawing.Size(95, 40);
            this.btnSimular.TabIndex = 28;
            this.btnSimular.Text = "Simular";
            this.btnSimular.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSimular.TextColor = System.Drawing.Color.White;
            this.btnSimular.UseVisualStyleBackColor = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Miriam CLM", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(13, 29);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 21);
            this.label9.TabIndex = 32;
            this.label9.Text = "Desde:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Miriam CLM", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(17, 63);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 21);
            this.label10.TabIndex = 33;
            this.label10.Text = "Hasta:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1200, 578);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.roundedButton1);
            this.Controls.Add(this.btnTablavehiculo);
            this.Controls.Add(this.btnRunge);
            this.Controls.Add(this.btnSimular);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtRKB);
            this.Controls.Add(this.txtRKA);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtPaso);
            this.Controls.Add(this.label6);
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
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
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
        private System.Windows.Forms.RadioButton rb8;
        private System.Windows.Forms.RadioButton rb10;
        private System.Windows.Forms.TextBox txtConcentracionA;
        private System.Windows.Forms.TextBox txtConcentracionB;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPaso;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtRKA;
        private System.Windows.Forms.TextBox txtRKB;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private RoundedButton btnSimular;
        private RoundedButton btnRunge;
        private RoundedButton btnTablavehiculo;
        private RoundedButton roundedButton1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
    }
}

