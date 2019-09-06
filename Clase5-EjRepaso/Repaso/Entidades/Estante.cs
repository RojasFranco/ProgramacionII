using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    class Estante
    {
        private Producto[] productos;
        private int ubicacionEstante;

        private Estante(int capacidad)
        {
            this.productos = new Producto[5];
        }


        public Estante(int capacidad, int ubicacion) : this(capacidad)
        {
            this.ubicacionEstante = ubicacion;                        
        }


        
        public Producto[] GetsProductos()
        {
            return this.productos;
        }
        


        public string MostrarEstante(Estante e)
        {
            string retorno = string.Empty;
            for (int i=0; i<e.productos.Length; i++)
            {
                //Para mostrar los productos
                retorno+= Producto.MostrarProducto(e.productos[i]);
            }
            return retorno;

        }



        /*
        public static bool operator !=(Estante e, Producto p)
        {
            for(int i=0; i<e.productos.Length; i++)
            {
                if(e.productos[i] == p)
                {


                }

            }

        }*/

    }
}
