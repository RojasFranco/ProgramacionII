using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CentralitaHerencia;

namespace CentralTelefonicaForm
{
    public partial class FormMostrador : Form
    {        
        private Llamada.TipoLlamada tipoLlamada;
        private Centralita centralita;
        public FormMostrador(Centralita centralita)
        {
            InitializeComponent();
            this.centralita = centralita;
        }

        public Llamada.TipoLlamada TipoLlamada
        {
            set
            {
                this.tipoLlamada = value;                
                                
                if(tipoLlamada == Llamada.TipoLlamada.Local)
                {
                    richTextBox1.Text = "Ganancia Local: " + centralita.GananciaPorLocal.ToString();
                }                
                else if(tipoLlamada == Llamada.TipoLlamada.Provincial)
                {
                    richTextBox1.Text = "Ganancia Provincial: " + centralita.GananciaPorProvincial.ToString();
                }
                else
                {
                    richTextBox1.Text = "Ganancia total: " + centralita.GananciaPorTotal.ToString();
                }
            }
        }





    }
}
