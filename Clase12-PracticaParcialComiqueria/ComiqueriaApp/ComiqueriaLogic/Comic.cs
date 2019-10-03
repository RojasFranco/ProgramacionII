using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComiqueriaLogic
{
    public class Comic : Producto
    {
        private string autor;
        private TipoComic tipoComic;


        #region Metodos

        public Comic(string descripcion, int stock, double precio, string autor, TipoComic tipoComic) : base(descripcion, stock, precio)
        {
            this.autor = autor;
            this.tipoComic = tipoComic;
        }


        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(base.ToString());
            sb.AppendFormat("\n Autor: {0}", this.autor);
            sb.AppendFormat("\n Tipo comic: {0}", this.tipoComic);
            return sb.ToString();
        }
        #endregion



        public enum TipoComic
        {
            Occidental,
            Oriental
        }
    }
}
