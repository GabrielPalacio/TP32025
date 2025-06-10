using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrabajoPractico
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dgvTipoVehiculo.Rows.Insert(0, "Compacto", 45);
            dgvTipoVehiculo.Rows.Insert(1, "SUV", 25);
            dgvTipoVehiculo.Rows.Insert(2, "Furgon", 30);
        }
    }
}
