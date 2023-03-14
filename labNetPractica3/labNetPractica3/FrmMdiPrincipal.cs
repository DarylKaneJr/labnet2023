using Lab.EF.Entities;
using Lab.EF.Logic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace labNetPractica3
{
    public partial class FrmMdiPrincipal : Form
    {
        public FrmMdiPrincipal()
        {
            InitializeComponent();
        }
        private void shippersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmABMShippers frmABMShippers = new FrmABMShippers();
            frmABMShippers.MdiParent = this;
            frmABMShippers.Show();
        }
        private void customersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Consultas.FrmConsultasCustomers fcc = new Consultas.FrmConsultasCustomers();
            fcc.MdiParent = this;
            fcc.Show();
        }

        private void employeesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Consultas.FrmConsultaEmployees fce = new Consultas.FrmConsultaEmployees();
            fce.MdiParent = this;
            fce.Show();
        }
    }
}
