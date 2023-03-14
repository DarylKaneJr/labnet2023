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
    public partial class FrmConsultasCustomers : Form
    {   
        public FrmConsultasCustomers()
        {
            InitializeComponent();
            CustomersLogic cl = new CustomersLogic();
            foreach (var item in cl.GetAll())
            {
                cmbNombres.Items.Add(item.ContactName);
            }
        }
        private void txtconsulta_Click(object sender, EventArgs e)
        {
            CustomersLogic cl = new CustomersLogic();
            foreach (var item in cl.GetAll())
            {
                if (cmbNombres.Text == item.ContactName)
                {
                    txtcity.Text = item.City;
                    txtaddress.Text = item.Address;
                    txtcustomerID.Text = item.CustomerID;
                    txtPhone.Text = item.Phone;
                    txtcountry.Text = item.Country;
                }
            }
            MessageBox.Show("Consulta realizada correctamente");
        }
    }
}
