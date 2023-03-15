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
    public partial class FrmABMShippers : Form
    {
        public FrmABMShippers()
        {
            InitializeComponent();
            ListarShippers();
        }
        private void btnadd_Click(object sender, EventArgs e)
        {
            try
            {
            ShippersLogic Osl = new ShippersLogic();
            if (txtcompanyname.Text != "" && txtphone.Text != "")
            {
                Shippers obj;
                obj = new Shippers();
                obj.CompanyName = txtcompanyname.Text;
                obj.Phone = txtphone.Text;
                Osl.Add(obj);
                obj = null;
                MessageBox.Show("Se agrego un nuevo registro con exito", "INFO"); 
                ListarShippers();
            }
            else
            {
                MessageBox.Show("Campos Vacios","INFO");
            }

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message + " "+ ex.GetType());
            }
        }
        public void ListarShippers()
        {
            try
            {
                ShippersLogic Osl = new ShippersLogic();
                GrillaShippers.DataSource = null;
                GrillaShippers.DataSource = Osl.GetAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " " + ex.GetType());
            }     
        }
        public void LimpiarText()
        {
            txtcompanyname.Clear();
            txtphone.Clear();
            txtid.Clear();
        }
        private void btnRemove_Click(object sender, EventArgs e)
        {
            try
            {
            ShippersLogic Osl = new ShippersLogic();
            if (txtid.Text != "")
            {
                Osl.Delete(int.Parse(txtid.Text));
                ListarShippers();
                LimpiarText();
                MessageBox.Show("Se removio shipper correctamente", "INFO"); 
            }
            else
            {             
                MessageBox.Show(" Seleccion un Shipper en la lista, por favor", "INFO");
            }

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message + " " + ex.GetType());
            }
        }

        private void GrillaShippers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                Shippers obj;
                obj = (Shippers)GrillaShippers.Rows[e.RowIndex].DataBoundItem;
                txtid.Text = obj.ShipperID.ToString();
                txtcompanyname.Text = obj.CompanyName;
                txtphone.Text = obj.Phone.ToString();
            }
            catch(System.ArgumentOutOfRangeException ex)
            {
                MessageBox.Show(ex.Message + " " + ex.GetType());
            }
            finally
            {

            }
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            try { 
            ShippersLogic Osl = new ShippersLogic();
            if (txtid.Text != "" && txtcompanyname.Text != "" && txtphone.Text != "")
            {
                Shippers obj;
                obj = new Shippers();
                obj.ShipperID = int.Parse(txtid.Text);
                obj.CompanyName = txtcompanyname.Text;
                obj.Phone = txtphone.Text;
                Osl.Update(obj);
                ListarShippers();
                LimpiarText();
                MessageBox.Show("Se actualizo shipper correctamente", "INFO");
            }
            else
            {
                MessageBox.Show("Seleccion un Shipper en la lista, por favor", "INFO");
            }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message + " " + ex.GetType());
            }
        }
    }
}
