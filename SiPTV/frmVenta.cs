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
using SiPTV.Modelo;

namespace SiPTV
{
    public partial class frmVenta : Form
    {
        public frmVenta()
        {
            InitializeComponent();
            grdDatos.AutoGenerateColumns = false;
        }
        
        private String Nombre;
        int sumatoria = 0;
        double iva = 0;
        double res = 0;
        int tota = 0;
        ValidacioneTXT va = new ValidacioneTXT();
        private void frmVenta_Load(object sender, EventArgs e)
        {

        }
        
        private void frmVenta_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode & Keys.F1) == Keys.F1)
            {   
                Form1 nm = new Form1();
                nm.Show();
            }
             if (e.KeyData == Keys.Escape)
            {
                this.Close();
            }
        }

        private void txtCodigoprod_TextChanged(object sender, EventArgs e)
        {
            //this.txt1.Text = Producto.BuscarporPK(Int32.Parse(txtCodigoprod.Text));
        }
        private void txtCodigoprod_KeyDown(object sender, KeyEventArgs e)
        {
            if (txtCodigoprod.Text == "")
            {

            }
            else
            {
                if (e.KeyCode == Keys.Enter)
                {
                    grdDatos.DataSource = null;
                    grdDatos.Rows.Add(txtCodigoprod.Text);
                    grdDatos.DataSource = Producto.BuscarporPK(Int32.Parse(txtCodigoprod.Text));
                    txtCodigoprod.Clear();


                    foreach (DataGridViewRow row in grdDatos.Rows)
                    {
                        sumatoria += Convert.ToInt32(row.Cells["total"].Value);
                    }

                    tota = sumatoria;
                    iva = tota*0.16;
                    res = tota + iva;
                    txtSubto.Text = Convert.ToString(tota);
                    txtIva.Text = Convert.ToString(iva);
                    txtTotal.Text = Convert.ToString(res);

                }
            }
        }

        private void btnPagar_Click(object sender, EventArgs e)
        {
            if (txtTotal.Text == "")
            {

            }
            else
            {
                frmPago pa = new frmPago();
                pa.txtSubto.Text = txtTotal.Text;
                pa.ShowDialog();
            }
        }

        private void txtCodigoprod_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidacioneTXT ne = new ValidacioneTXT();
            ne.SoloNumeros(e);
        }
    }
}
