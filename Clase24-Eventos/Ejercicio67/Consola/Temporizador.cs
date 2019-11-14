using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Consola
{
    public sealed class Temporizador
    {
        private Thread hilo;
        private int intervalo;

        public delegate void encargadoTiempo();
        public event encargadoTiempo EventoTiempo;



        #region Propiedades

        public bool Activo
        {
            get
            {
                if(this.hilo!=null && this.hilo.IsAlive)
                {
                    return true;
                }
                return false;
            }
            set
            {
                if(value)
                {
                    if(!this.Activo)
                    {                        
                        this.hilo = new Thread(new ThreadStart(this.Corriendo)); 
                        hilo.Start();
                    }
                }
                else
                {
                    if(this.Activo)
                    {
                        this.hilo.Abort();
                    }
                }
            }
        }

        public int Intervalo
        {
            get { return this.intervalo; }
            set { this.intervalo = value; }
        }

        #endregion

        private void Corriendo()
        {            
            while (true)
            {
                Thread.Sleep(this.Intervalo);
                if (EventoTiempo != null)
                {
                    this.EventoTiempo.Invoke();
                }
            }            
        }


    }
}
