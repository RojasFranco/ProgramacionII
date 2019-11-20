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

namespace CronometroForm
{
    public partial class FormCronometro : Form
    {
        Thread hiloCronometro;
        int horas;
        int minutos;
        int segundos;

        public delegate void DelegadoCallback();        

        public FormCronometro()
        {
            InitializeComponent();
        }

        private void ButtonIniciar_Click(object sender, EventArgs e)
        {            
            if (this.hiloCronometro !=null && this.hiloCronometro.IsAlive)
            {
                this.hiloCronometro.Abort();
                this.buttonIniciar.Text = "Iniciar";
            }
            else
            {
                this.hiloCronometro = new Thread(new ThreadStart(this.MetodoAvanzaCronometro));
                this.hiloCronometro.Start();                
                this.buttonIniciar.Text = "Detener";
            }              
        }

        private void ButtonReiniciar_Click(object sender, EventArgs e)
        {
            this.hiloCronometro.Abort();
            this.segundos = 00;
            this.minutos = 00;
            this.horas = 00;
            this.MostrarCronometro();
            this.buttonIniciar.Text = "Iniciar";


        }

        private void FormCronometro_Load(object sender, EventArgs e)
        {
            //this.hiloCronometro = new Thread(new ThreadStart(this.MetodoAvanzaCronometro));

            /*this.horas = 00;
            this.minutos = 00;
            this.segundos = 00;            */
        }

        public void MetodoAvanzaCronometro()
        {
            while(true)
            {
                Thread.Sleep(1000);
                segundos += 1;
                if(segundos==60)
                {
                    segundos = 0;
                    minutos += 1;
                }
                if(minutos==60)
                {
                    minutos = 0;
                    horas += 1;
                }
                this.MostrarCronometro();
            }
        }

        public void MostrarCronometro()
        {
            if(this.labelCronometro.InvokeRequired)
            {
                DelegadoCallback callback = new DelegadoCallback(this.MostrarCronometro);

                this.labelCronometro.Invoke(callback);

            }
            else
            {
                this.labelCronometro.Text = string.Format("{0:00} : {1:00} : {2:00}", this.horas, this.minutos, this.segundos);
            }            
        }

        private void FormCronometro_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(this.hiloCronometro!=null && hiloCronometro.IsAlive)
            {
                this.hiloCronometro.Abort();
            }
        }
    }
}
