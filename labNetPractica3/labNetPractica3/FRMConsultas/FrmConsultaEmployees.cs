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

namespace labNetPractica3.Consultas
{
    public partial class FrmConsultaEmployees : Form
    {
        public FrmConsultaEmployees()
        {
            InitializeComponent();
        }
        private void btnlistar_Click(object sender, EventArgs e)
        {
            EmployeesLogic el = new EmployeesLogic();
            foreach (var item in el.GetAll())
            {
                lstnombrescustomer.Items.Add(item.FirstName + " " +item.LastName);
                lstcustomersdireccion.Items.Add(item.Address);
            }
            btnlistar.Enabled = false;
            MessageBox.Show("Consulta realizada correctamente");
        }
    }
}
