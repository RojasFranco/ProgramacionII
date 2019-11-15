using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Entidades;
using Archivos;
using System.Threading;
using Patentes;

namespace _20181122_SP
{
    public partial class FrmPpal : Form
    {
        Queue<Patente> cola;
        private List<Thread> listaThreads;

        public FrmPpal()
        {
            InitializeComponent();

            this.cola = new Queue<Patente>();
            this.listaThreads = new List<Thread>();
        }

        private void FrmPpal_Load(object sender, EventArgs e)
        {            
            this.vistaPatente1.finExposicion += ProximaPatente;
            this.vistaPatente2.finExposicion += ProximaPatente;
        }

        public void ProximaPatente(VistaPatente vistaPatente)
        {
            /* ProximaPatente, si hay elementos en la cola de patentes:
            a. Instanciará un hilo parametrizado para el método MostrarPatente del objeto VistaPatente recibido.
            b. Inicializará el hilo recién creado con el próximo elemento de la cola.
            c. Agregará el hilo a la lista.*/
            if(this.cola.Count>0)
            {
                Thread hilo = new Thread(new ParameterizedThreadStart(vistaPatente.MostrarPatente));
                hilo.Start(this.cola.Dequeue());
                this.listaThreads.Add(hilo);
            }            
        }

        private void FrmPpal_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.FinalizarSimulacion();
        }

        private void btnXml_Click(object sender, EventArgs e)
        {

        }

        private void btnTxt_Click(object sender, EventArgs e)
        {
            Texto texto = new Texto();
            try
            {
                texto.Leer(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\patentes.txt", out this.cola);                
            }            
            catch(PatenteInvalidaException error)
            {
                //MessageBox.Show(error.Message);
                this.IniciarSimulacion();
                
            }
        }

        private void btnSql_Click(object sender, EventArgs e)
        {

        }

        private void IniciarSimulacion()
        {
            //this.FinalizarSimulacion();
            this.ProximaPatente(vistaPatente1);
            this.ProximaPatente(vistaPatente2);
        }

        private void FinalizarSimulacion()
        {
            foreach (Thread hilo in this.listaThreads)
            {
                if (hilo != null && hilo.IsAlive)
                {
                    hilo.Abort();
                }
            }
        }
    }
}
