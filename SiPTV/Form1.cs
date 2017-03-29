using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SiPTV.Modelo;

namespace SiPTV
{
    public partial class Form1 : Form
    {
        ValidacioneTXT valor = new ValidacioneTXT();
        public void cargarAlumnos(string idGrupo)
        {
            List<Producto> nLista = new List<Producto>();
            foreach (var item in Producto.BuscarPorNombre(idGrupo, chStatus.Checked))
            {
                nLista.Add(item);
            }
            this.grdDatos.DataSource = nLista;
        }

        private frmVenta ve = new frmVenta();
        public Form1()
        {
            InitializeComponent();
            grdDatos.AutoGenerateColumns = false;
        }
        

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            this.cargarAlumnos(txtBuscar.Text);
            //grdDatos.DataSource = Producto.BuscarPorApellido(txtBuscar.Text);
        }

        private frmVenta d;
        private void grdDatos_DataSourceChanged(object sender, EventArgs e)
        {
            lblCantidad.Text = "Registros: " + grdDatos.Rows.Count;
        }
        private void chStatus_CheckedChanged(object sender, EventArgs e)
        {
            this.cargarAlumnos(txtBuscar.Text);
        }

        public void grdDatos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if(Convert.ToBoolean(grdDatos.Rows[e.RowIndex].Cells[2].Value))
            {
              valor.valor = grdDatos.Rows[e.RowIndex].Cells[0].Value.ToString();
                
            }
            ve.txtCodigoprod.Text = valor.valor;
            this.Hide();

        }
    }
}
