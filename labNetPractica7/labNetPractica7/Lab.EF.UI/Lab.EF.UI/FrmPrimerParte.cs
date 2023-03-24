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
    public partial class FrmPrimerParte : Form
    {
        public FrmPrimerParte()
        {
            InitializeComponent();
        }

        private void btnquery1_Click(object sender, EventArgs e)
        {
            try
            {
                CustomerLogic cl = new CustomerLogic();
                grilladatos.DataSource = cl.Punto1MC();
                MessageBox.Show("Query para devolver objeto customer", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch(SystemException ex)
            {
                MessageBox.Show(ex.Message + " " + ex.GetType());
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message + " " + ex.GetType());
            }
        }

        private void btnquery_Click(object sender, EventArgs e)
        {
            try
            {
                ProductLogic pl = new ProductLogic();
                grilladatos.DataSource = pl.Punto2();
                MessageBox.Show("Query para devolver todos los productos sin stock", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void btnquery3_Click(object sender, EventArgs e)
        {
            try
            {
                ProductLogic pl = new ProductLogic();
                grilladatos.DataSource = pl.Punto3();
                MessageBox.Show("Query para devolver todos los productos que tienen stock y que cuestan más de 3 por unidad", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void btnquery4_Click(object sender, EventArgs e)
        {
            try
            {
                CustomerLogic cl = new CustomerLogic();
                grilladatos.DataSource = cl.Punto4MC();
                MessageBox.Show("Query para devolver todos los customers de la Región WA", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void btnquery5_Click(object sender, EventArgs e)
        {
            try
            {
                ProductLogic pl = new ProductLogic();
                MessageBox.Show("Query para devolver el primer elemento o nulo de una lista de productos donde el ID de producto sea igual a 789", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MessageBox.Show(pl.Punto5());
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

        private void btnquery6_Click(object sender, EventArgs e)
        {
            try
            {
                CustomerLogic cl = new CustomerLogic();
                foreach (var item in cl.Punto6MC())
                {
                    cmbmayusculas.Items.Add(item.ToUpper());
                    cmbminisculas.Items.Add(item.ToLower());
                }
                btnquery6.Enabled = false;
                MessageBox.Show("Query para devolver los nombre de los Customers. Mostrarlos en Mayuscula y en Minuscula", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
