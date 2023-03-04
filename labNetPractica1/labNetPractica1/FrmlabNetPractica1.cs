using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace labNetPractica1
{
    public partial class FrmlabNetPractica1 : Form
    {
        List<TransportePublico> listatransportes = new List<TransportePublico>();
        int acumtaxi = 1;
        int acumomni = 1;
        public FrmlabNetPractica1()
        {
            InitializeComponent();
            this.cboTransporte.Items.Add(typeof(Taxi).Name);
            this.cboTransporte.Items.Add(typeof(Omnibus).Name);
        }
        private void btnagregar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtcantpasajeros.Text != "" && cboTransporte.Text != "" && int.Parse(txtcantpasajeros.Text) != 0)
                {
                    var cantidad_pasajeros = int.Parse(txtcantpasajeros.Text);
                    if (cboTransporte.Text == typeof(Taxi).Name)
                    {
                        listatransportes.Add(new Taxi(typeof(Taxi).Name + acumtaxi, cantidad_pasajeros));
                        listtransportes.Items.Add(typeof(Taxi).Name + acumtaxi);
                        listtransportes.Items.Add("Cantidad de Pasajeros : " + cantidad_pasajeros);
                        MessageBox.Show(cboTransporte.Text + acumtaxi + " con  " + cantidad_pasajeros + " pasajeros", "SE AGREGO CORRECTAMENTE ");
                        acumtaxi = acumtaxi + 1;
                    }
                    if (cboTransporte.Text == typeof(Omnibus).Name)
                    {
                        listatransportes.Add(new Omnibus(typeof(Omnibus).Name + acumomni, cantidad_pasajeros));
                        listtransportes.Items.Add(typeof(Omnibus).Name + acumomni);
                        listtransportes.Items.Add(cantidad_pasajeros);
                        MessageBox.Show(cboTransporte.Text + acumomni + " con  " + cantidad_pasajeros + " pasajeros", "SE AGREGO CORRECTAMENTE ");
                        acumomni = acumomni + 1;
                    }
                    Limpiar();
                }
            }
            catch (Exception ex)
            {

            }          
        }
        private void btnavanzar_Click(object sender, EventArgs e)
        {
            if(listtransportes.SelectedItem != null)
            {
                Avanzar(listtransportes.SelectedItem.ToString());
            }
        }
        private void btndetenerse_Click(object sender, EventArgs e)
        {
            if (listtransportes.SelectedItem != null)
            {
                Detenerse(listtransportes.SelectedItem.ToString());
            }
        }
        public void Avanzar(string combo)
        {
            foreach (var item in listatransportes)
            {
                if(item.GetID() == combo)
                {
                    MessageBox.Show(item.Avanzar());
                }
            }
        }
        public void Detenerse(string combo)
        {
            foreach (var item in listatransportes)
            {
                if (item.GetID() == combo)
                {
                    MessageBox.Show(item.Detenerse());
                }
            }
        }
        public void Limpiar()
        {
            txtcantpasajeros.Clear();
        }
        private void txtcantpasajerostaxi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
        private void txtcantpasajerosomni_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtcantpasajeros_TextChanged(object sender, EventArgs e)
        {
                if (cboTransporte.Text == typeof(Taxi).Name)
                {
                    if (int.Parse(txtcantpasajeros.Text) > 6)
                    {
                        MessageBox.Show("No creo que entren más de 6 personas en un taxi", "INFO");
                        txtcantpasajeros.Text = "1";
                    }
                }
                else if (cboTransporte.Text == typeof(Omnibus).Name)
                {
                    if (int.Parse(txtcantpasajeros.Text) > 25)
                    {
                        MessageBox.Show("Talvez no entren más de 60 personas en un omnibus", "INFO");
                        txtcantpasajeros.Text = "1";
                    }
                }
            }
        }
    }
 

