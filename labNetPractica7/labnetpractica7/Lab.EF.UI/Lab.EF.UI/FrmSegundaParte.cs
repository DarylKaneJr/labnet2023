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

namespace Lab.EF.UI
{
    public partial class FrmSegundaParte : Form
    {
        public FrmSegundaParte()
        {
            InitializeComponent();
        }

        private void btnquery7_Click(object sender, EventArgs e)
        {
            try
            {
                CustomerLogic cl = new CustomerLogic();
                grilladatos.DataSource = cl.Punto7();
                MessageBox.Show(" Query para devolver Join entre Customers y Orders donde los customers sean de la  Región WA y la fecha de orden sea mayor a 1 / 1 / 1997.", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (SystemException ex)
            {
                MessageBox.Show(ex.Message + " " + ex.GetType());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " " + ex.GetType());
            }
        }

        private void btnquery8_Click(object sender, EventArgs e)
        {
            try
            {
                CustomerLogic cl = new CustomerLogic();
                grilladatos.DataSource = cl.Punto8();
                MessageBox.Show("  Query para devolver los primeros 3 Customers de la  Región WA", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (SystemException ex)
            {
                MessageBox.Show(ex.Message + " " + ex.GetType());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " " + ex.GetType());
            }
        }

        private void btnquery9_Click(object sender, EventArgs e)
        {
            try
            {
                ProductLogic pl = new ProductLogic();
                grilladatos.DataSource = pl.Punto9();
                MessageBox.Show("Query para devolver lista de productos ordenados por nombre", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (SystemException ex)
            {
                MessageBox.Show(ex.Message + " " + ex.GetType());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " " + ex.GetType());
            }
        }

        private void btnquery10_Click(object sender, EventArgs e)
        {
            try
            {
                ProductLogic pl = new ProductLogic();
                grilladatos.DataSource = pl.Punto10();
                MessageBox.Show("Query para devolver lista de productos ordenados por unit in stock de mayor a menor.", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (SystemException ex)
            {
                MessageBox.Show(ex.Message + " " + ex.GetType());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " " + ex.GetType());
            }
        }

        private void btnquery11_Click(object sender, EventArgs e)
        {
            try
            {
                ProductLogic pl = new ProductLogic();
                grilladatos.DataSource = pl.Punto11();
                MessageBox.Show("Query para devolver las distintas categorías asociadas a los productos", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (SystemException ex)
            {
                MessageBox.Show(ex.Message + " " + ex.GetType());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " " + ex.GetType());
            }
        }
        private void btnquery12_Click(object sender, EventArgs e)
        {
            try
            {
                ProductLogic pl = new ProductLogic();
                grilladatos.DataSource = pl.Punto12();
                MessageBox.Show("Query para devolver el primer elemento de una lista de productos", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (SystemException ex)
            {
                MessageBox.Show(ex.Message + " " + ex.GetType());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " " + ex.GetType());
            }
        }

        private void btnquery13_Click(object sender, EventArgs e)
        {
            try
            {
                CustomerLogic pl = new CustomerLogic();
                grilladatos.DataSource = pl.Punto13();
                MessageBox.Show("Query para devolver los customer con la cantidad de ordenes asociadas", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (SystemException ex)
            {
                MessageBox.Show(ex.Message + " " + ex.GetType());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " " + ex.GetType());
            }
        }
    }
}
