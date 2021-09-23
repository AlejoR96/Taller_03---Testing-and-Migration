using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Taller_Testing
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private int horasNormal, horasExtras, categoria;
        private double precioNormal, precioExtras, total;

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCajas();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            Operacion();
        }

        

        private void Operacion()
        {
            categoria = (Convert.ToInt32(cbCategoria.SelectedIndex) + 1);

            if (Convert.ToInt32(txtHoras.Text) <= 40)
            {
                horasNormal = Convert.ToInt32(txtHoras.Text);
                horasExtras = 0;

                switch (categoria){

                    case 1:
                        precioNormal = 12000 * horasNormal;
                        precioExtras = 0;
                        total = precioNormal + precioExtras;
                        break;

                    case 2:
                        precioNormal = 17000 * horasNormal;
                        precioExtras = 0;
                        total = precioNormal + precioExtras;
                        break;

                    case 3:
                        precioNormal = 22000 * horasNormal;
                        precioExtras = 0;
                        total = precioNormal + precioExtras;
                        break;

                }
            }
            else
            {
                horasExtras = Convert.ToInt32(txtHoras.Text) - 40;
                horasNormal = Convert.ToInt32(txtHoras.Text) - horasExtras;

                switch (categoria)
                {
                    case 1:
                        precioNormal = 12000 * horasNormal;
                        precioExtras =(12000 * horasExtras)*1.25;
                        total = precioNormal + precioExtras;
                        break;

                    case 2:
                        precioNormal = 17000 * horasNormal;
                        precioExtras =(17000 * horasExtras) * 1.25;
                        total = precioNormal + precioExtras;
                        break;

                    case 3:
                        precioNormal = 22000 * horasNormal;
                        precioExtras =(22000 * horasExtras) * 1.25;
                        total = precioNormal + precioExtras;
                        break;
                }
            }
        }

        private void LimpiarCajas()
        {
            txtNombre.Clear();
            txtHoras.Clear();
            txtTotal.Clear();
            txtNombre.Focus();
        }
    }
}
