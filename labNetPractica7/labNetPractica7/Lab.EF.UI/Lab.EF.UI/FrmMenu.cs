using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab.EF.UI
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void methodSintaxToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void de7A13ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmSegundaParte fp2 = new FrmSegundaParte();
            fp2.MdiParent = this;
            fp2.Show();
        }

        private void del1Al6ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPrimerParte fp1 = new FrmPrimerParte();
            fp1.MdiParent = this;
            fp1.Show();
        }
    }
}
