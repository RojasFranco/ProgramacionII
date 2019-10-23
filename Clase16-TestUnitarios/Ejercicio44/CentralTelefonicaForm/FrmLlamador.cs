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
using Ejercicio41;

namespace CentralTelefonicaForm
{
    public partial class FrmLlamador : Form
    {
        private Centralita centralita;
        public FrmLlamador(Centralita centralita)
        {
            InitializeComponent();
            this.centralita = centralita;
            this.comboBoxFranja.DataSource = Enum.GetValues(typeof(Provincial.Franja));
        }

        private void btnLlamar_Click(object sender, EventArgs e)
        {            
            Random random = new Random();
            Provincial.Franja franja;

            if(this.textNroDestino.Text[0] == '#') //o combofranja.enabled
            {
                Enum.TryParse<Provincial.Franja>(comboBoxFranja.SelectedValue.ToString(), out franja);
                /*
                 * no hace falta, lo puedo leer segun enunciado
                switch(comboBoxFranja.Text)
                {
                    case "Franja_1":
                        franja = Provincial.Franja.Franja_1;
                        break;
                    case "Franja_2":
                        franja = Provincial.Franja.Franja_2;
                        break;
                    default:
                        franja = Provincial.Franja.Franja_3;
                        break;
                }

                */
                //this.centralita.Llamadas.Add(new Provincial(textBoxNroOrigen.Text, franja, 10, this.textNroDestino.Text));  
                try
                {
                    this.centralita = this.centralita + (new Provincial(textBoxNroOrigen.Text, franja, random.Next(1, 51), this.textNroDestino.Text));
                }                
                catch(CentralitaException error)
                {
                    MessageBox.Show(error.Message);
                }
            }
            else
            {
                try
                {
                    this.centralita = this.centralita + (new Local(textBoxNroOrigen.Text, random.Next(1, 51), this.textNroDestino.Text, (float)random.NextDouble()));
                }                
                catch(CentralitaException error)
                {
                    MessageBox.Show(error.Message);
                }
            }
            //MessageBox.Show(centralita.Mostrar()); 
        }

        private void textNroDestino_TextChanged(object sender, EventArgs e)
        {
            string nroDestino = this.textNroDestino.Text;
            if(nroDestino.Length != 0 && nroDestino[0] == '#')
            {
                this.comboBoxFranja.Enabled = true;
            }
            else
            {
                this.comboBoxFranja.Enabled = false;
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.textBoxNroOrigen.Text = "Nro Origen";
            this.textNroDestino.Text = "Nro Destino";
            this.comboBoxFranja.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.AgregarNumero(this.textNroDestino, "1");
        }


        private void AgregarNumero(TextBox textBox, string numeroAgregar)
        {
            if (this.textNroDestino.Text == "Nro Destino")
            {
                this.textNroDestino.Text = numeroAgregar;
            }
            else
            {
                this.textNroDestino.Text += numeroAgregar;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.AgregarNumero(textNroDestino, "2");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.AgregarNumero(textNroDestino, "3");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.AgregarNumero(textNroDestino, "4");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.AgregarNumero(textNroDestino, "5");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.AgregarNumero(textNroDestino, "6");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.AgregarNumero(textNroDestino, "7");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.AgregarNumero(textNroDestino, "8");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.AgregarNumero(textNroDestino, "9");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.AgregarNumero(textNroDestino, "*");
        }

        private void button11_Click(object sender, EventArgs e)
        {
            this.AgregarNumero(textNroDestino, "0");
        }

        private void button12_Click(object sender, EventArgs e)
        {
            this.AgregarNumero(textNroDestino, "#");
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
