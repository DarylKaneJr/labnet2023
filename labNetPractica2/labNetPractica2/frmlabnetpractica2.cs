using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace labNetPractica2
{
    public partial class frmlabnetpractica2 : Form
    {
        public frmlabnetpractica2()
        {
            InitializeComponent();
        }
        //punto 1
        private void btnvalor_Click(object sender, EventArgs e)
        {
            //punto 1
            try
            {
                decimal div = Convert.ToDecimal(txtvalor.Text);
                string message = div.DividorPorCero();
                MessageBox.Show(message, "MENSAJE");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                MessageBox.Show("Termino operacion punto 1");
            }
        }
        // punto 2
        private void btndividir_Click(object sender, EventArgs e)
        {
            try
            {
                if (decimal.Parse(txtnum1.Text) >= 0 && decimal.Parse(txtnum2.Text) >=0)
                {
                    // punto 2
                    string message = ExtensionsMethods.Dividir(int.Parse(txtnum1.Text), int.Parse(txtnum2.Text));
                    MessageBox.Show(message, "MENSAJE");
                }   
            }
            catch (Exception ex)
            {
                MessageBox.Show("Seguro Ingreso una letra o no ingreso nada!" + ex.Message);
            }
            finally
            {
            }       
        }
        // punto 3
        private void btnopera3_Click(object sender, EventArgs e)
        {
            try
            {
                Logic.CapturarExcepcion();
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show(ex.Message + " " + ex.GetType());

            }
            finally
            {
                MessageBox.Show("FIN PUNTO 3");
            }   
        }
        // punto 4
        private void btnopera4_Click(object sender, EventArgs e)
        {
            try
            {
                // punto 4
                Logic.ThrowCustomException(txtnombre.Text);
            }
            catch (CustomException ex)
            {
                MessageBox.Show(ex.Message + " exception del tipo : "+ ex.GetType(), "INFO");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
            }
        }
    }
}
