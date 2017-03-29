using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiPTV.Modelo
{
    [Table("Productos")]
    public class Producto
    {
        #region Codigo para la bd
        [Key]
        public int pkCodigo { get; set; }

        [Required(ErrorMessage = "Se requiere Nombre del producto")]
        [StringLength(100)]
        public String Nombre { get; set; }

        public int PrecioUnitario { get; set; }

        public int Cantidad { get; set; }


        public decimal Total { get; set; }

        public Boolean bStatus { get; set; }

        public Producto()
        {
            this.bStatus = true;
        }
        #endregion

        public static List<Producto> getAll()
        {
            //cargar los datos del data grid

            try
            {
                using (var ctx = new DataModel())
                {
                    return ctx.productos.Where(r => r.bStatus == true).ToList();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static List<Producto> BuscarPorNombre(string valorBuscar, Boolean sStatus)
        {
            try
            {
                using (var ctx = new DataModel())
                {
                    return ctx.productos.Where(r => r.Nombre.Contains(valorBuscar) && r.bStatus==sStatus).ToList();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static List<Producto> BuscarporPK(int pkCodi)
        {
            try
            {
                using (var ctx = new DataModel())
                {
                    return ctx.productos.Where(r => r.pkCodigo == pkCodi).ToList();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }



    }
}
