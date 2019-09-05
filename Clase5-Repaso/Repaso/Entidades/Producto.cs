using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    class Producto
    {
        private string codigoDeBarra;
        private string marca;
        private float precio;

        public Producto(string marca, string codigo, float precio)
        {

            this.marca = marca;
            this.codigoDeBarra = codigo;
            this.precio = precio;
        }


        public string GetMarca()
        {
            return this.marca;
        }

        public float GetPrecio()
        {
            return this.precio;
        }
        

        // VER    SOBRECARGA EXPLICITA PARA CODIGOBARRA   
        public static explicit operator string(Producto p)
        {
            return p.codigoDeBarra;
        }
        

        public static string MostrarProducto(Producto p)
        {
            string mostrar = string.Empty;

            mostrar += string.Format("Codigo: {0}\n", p.codigoDeBarra);
            mostrar += string.Format("Marca: {0}\n", p.marca);
            mostrar += string.Format("Precio: {0}\n", p.precio);            
            return mostrar;

        }


        /// <summary>
        /// Compara la marca de Producto p con marca ingresada
        /// </summary>
        /// <param name="p"></param>
        /// <param name="marca"></param>
        /// <returns></returns>
        public static bool operator !=(Producto p, string marca)
        {
            if(p.GetMarca() != marca)
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// Compara la marca de Producto p con marca ingresada
        /// </summary>
        /// <param name="p"></param>
        /// <param name="marca"></param>
        /// <returns></returns>
        public static bool operator ==(Producto p, string marca)
        {
            if(p.GetMarca() == marca)
            {
                return true;
            }
            return false;
        }



        /// <summary>
        /// Compara marca y codigo de barra de 2 productos
        /// </summary>
        /// <param name="p1"></param>
        /// <param name="p2"></param>
        /// <returns></returns>
        public static bool operator !=(Producto p1, Producto p2)
        {
            if(p1.GetMarca() != p2.GetMarca() && p1.codigoDeBarra != p2.codigoDeBarra)
            {
                return true;
            }
            return false;
        }


        public static bool operator ==(Producto p1, Producto p2)
        {
            if(p1.GetMarca() == p2.GetMarca() && p1.codigoDeBarra == p2.codigoDeBarra)
            {
                return true;
            }
            return false;

        }


        /*
         * 
         * Sobrecarga implicita
        public static implicit operator float(Producto p)
        {
            return p.precio;
        }
        */

    }
}
