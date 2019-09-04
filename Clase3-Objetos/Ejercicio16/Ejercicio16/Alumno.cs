using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio16
{
    public class Alumno
    {
        #region Atributos

        private byte nota1;
        private byte nota2;
        private float notaFinal;
        private string nombre;
        private string apellido;
        private int legajo;
        #endregion

        #region Constructores
        /// <summary>
        /// Instancia un nuevo alumno
        /// </summary>
        /// <param name="nombre">Nombre alumno</param>
        /// <param name="apellido">Apellido alumno</param>
        /// <param name="legajo">Legajo alumno</param>
        public Alumno(string nombre, string apellido, int legajo)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.legajo = legajo;
        }
        #endregion      
        
        public void CalcularFinal()
        {
            if(this.nota1>=4 && this.nota2>=4)
            {
                this.notaFinal = (new Random().Next(1, 11)); //o Random r=new Random(); double num=r.Next();                               
            }
            else
            {
                this.notaFinal = -1;
            }            
        }

        /// <summary>
        /// Carga nota del alumno
        /// </summary>
        /// <param name="notaUno">nota 1er parcial</param>
        /// <param name="notaDos">nota 2do parcial</param>
        public void Estudiar(byte notaUno, byte notaDos)
        {
            this.nota1 = notaUno;
            this.nota2 = notaDos;
        }
        
        public string Mostrar()
        {
                                                                        
            string mostrar = string.Empty;
            mostrar += string.Format("Nombre y apellido: {0} {1}\n", this.nombre, this.apellido);
            mostrar += string.Format("Nota1: {0}\n", this.nota1);
            mostrar += string.Format("Nota2: {0}\n", this.nota2);
            mostrar += string.Format("Legajo: {0}\n", this.legajo);
            if (this.notaFinal == -1)
            {
                mostrar+= "alumno desaprobado\n";
                return mostrar;                
            }
            mostrar += string.Format("Nota Final: {0}\n", this.notaFinal);
            return mostrar; // "Aprobado";            
            
        }
    }
}
