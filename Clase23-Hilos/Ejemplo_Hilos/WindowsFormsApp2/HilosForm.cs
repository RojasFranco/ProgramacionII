using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class HilosForm : Form
    {
        private delegate void Callback();

        private delegate void CallbackParaSalto(object cantidad);


        private Thread hilo;
        private Thread hilo2;

        public HilosForm()
        {
            InitializeComponent();
        }

        private void buttonEscribir_Click(object sender, EventArgs e)
        {
            this.richTextBoxTexto.Text += this.textBoxEscribir.Text + "\n";
            this.textBoxEscribir.Clear();
        }

        private void HilosForm_Load(object sender, EventArgs e)
        {
            //Thread hilo = new Thread(new ThreadStart(Contar));
            this.hilo = new Thread(new ThreadStart(Contar));
            hilo.Start();

            //Thread hilo2 = new Thread(new ParameterizedThreadStart((ContarDeA)));
            this.hilo2 = new Thread(new ParameterizedThreadStart((ContarDeA)));
            hilo2.Start(10);
        }

        private void Contar()
        {
            while(true)
            {
                this.ActualizarLabel();                
                Thread.Sleep(1000);
            }
        }

        private void ActualizarLabel()
        {
            if (this.labelContador.InvokeRequired) //True si se encuentra en un subproceso
            {
                //ESTO es para pasarlo como 'proceso ppal' para poder ingresar luego al else
                Callback callback = new Callback(this.ActualizarLabel);
                this.labelContador.Invoke(callback);
            }
            else
            {
                this.labelContador.Text = (Convert.ToInt32(this.labelContador.Text) + 1).ToString();
            }
        }


        private void ContarDeA(object cantidadSalto)
        {
            while(true)
            {
                this.ActualizarLabelConSalto(cantidadSalto);
                Thread.Sleep(1000);
            }
        }

        private void ActualizarLabelConSalto(object cantidadSalto)
        {
            if(this.labelContadorConSalto.InvokeRequired)
            {
                CallbackParaSalto callbackParaSalto = new CallbackParaSalto(this.ActualizarLabelConSalto);
                this.labelContadorConSalto.Invoke(callbackParaSalto, new object[] { cantidadSalto }); //El 2do parametro es lo que recibe callbackSalto           
                //Es la forma para pasarle parametros. crea el array de object y le pasa cantidadSalto en la pos 0.-
            }
            else
            {
                this.labelContadorConSalto.Text = (Convert.ToInt32(labelContadorConSalto.Text) + Convert.ToInt32(cantidadSalto)).ToString();
            }
        }

        private void HilosForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(this.hilo!=null && this.hilo.IsAlive)
            {
                hilo.Abort();
            }
            if(this.hilo2 != null && this.hilo2.IsAlive)
            {
                hilo2.Abort();
            }
        }

        //private void ContarASaltos(object cantidadASaltar)
        //{
        //    while(true)
        //    {
        //        this.ActualizarLabel(cantidadASaltar);
        //        Thread.Sleep(1000);
        //    }
        //}

        //private void ActualizarLabel(object cantidadASaltar)
        //{
        //    if (this.labelContador.InvokeRequired)
        //    {
        //        object[] parametros = new object[] { cantidadASaltar };
        //        this.labelContador.Invoke(new Callback(this.ActualizarLabel), parametros);
        //    }
        //    else
        //    {
        //        this.labelContador.Text = (Convert.ToInt32(this.labelContador.Text) + (int) cantidadASaltar).ToString();
        //    }
        //}
    }
    }
