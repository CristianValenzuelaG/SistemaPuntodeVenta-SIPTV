using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SiPTV
{
    public partial class frmPago : Form
    {
        public frmPago()
        {
            InitializeComponent();
        }

        private int total = 0;
        private int canti = 0;
        private int cambio = 0;

        private void btnPagar_Click(object sender, EventArgs e)
        {
            cambio =Convert.ToInt32(txtSubto.Text);
            if (txtIva.Text == "")
            {

            }
            else
            {


                if (Convert.ToInt32(txtSubto.Text) > Convert.ToInt32(txtIva.Text))
                {
                    error.SetError(txtIva, "Error no le alcanza el dinero");
                }
                else
                {
                    Application.Exit();
                }
            }
        }

        private void txtIva_TextChanged(object sender, EventArgs e)
        {
            if (txtIva.Text == "")
            {
                txtTotal.Text = "";
            }
            else
            {
                canti = Convert.ToInt32(txtIva.Text) - total;
                txtTotal.Text = Convert.ToString(canti);
            }
        }

        private void frmPago_Load(object sender, EventArgs e)
        {
            total = Convert.ToInt32(txtSubto.Text);

        }

        private void txtIva_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidacioneTXT v = new ValidacioneTXT();
            v.SoloNumeros(e);
        }
    }
}
