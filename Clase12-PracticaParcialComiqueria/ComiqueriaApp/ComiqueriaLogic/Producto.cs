using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComiqueriaLogic
{
    public abstract class Producto
    {
        private Guid codigo;
        private string descripcion;
        private double precio;
        private int stock;

        #region Propiedades

        public string Descripcion
        {
            get
            {
                return this.descripcion;
            }
        }


        public double Precio
        {
            get { return precio; }
        }

        public int Stock
        {
            get
            {                
                return this.stock;
            }
            set
            {
                if(value>=0)
                {
                    this.stock = value;
                }
            }
        }


        #endregion

        #region Metodos

        protected Producto(string descripcion, int stock, double precio)
        {
            this.descripcion = descripcion;
            this.Stock = stock;
            this.precio = precio;
            this.codigo = Guid.NewGuid();
        }

        public static explicit operator Guid(Producto p)
        {
            return p.codigo;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("\nDescripcion: {0}", this.Descripcion);
            sb.AppendFormat("\nCodigo : {0}", this.codigo);
            sb.AppendFormat("\nPrecio: {0}", this.Precio);
            sb.AppendFormat("\nStock: {0}", this.Stock);
            return sb.ToString();
        }

        #endregion
    }
}
