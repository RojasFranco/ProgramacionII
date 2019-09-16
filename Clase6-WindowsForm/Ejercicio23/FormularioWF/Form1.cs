using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Billetes;

namespace FormularioWF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            textEuroADolar.Enabled = false;
            textEuroAEuro.Enabled = false;
            textEuroAPeso.Enabled = false;
            textPesoADolar.Enabled = false;
            textPesoAEuro.Enabled = false;
            textPesoAPeso.Enabled = false;
            textDolarADolar.Enabled = false;
            textDolarAEuro.Enabled = false;
            textDolarAPeso.Enabled = false;

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnConvertEuro_Click(object sender, EventArgs e)
        {            
            double euro;
            double cotizacionEuro;

            if (double.TryParse(txtEuro.Text, out euro))
            {

                Euro euroIngresado;// = new Euro(euro);
                if (double.TryParse(textCotizacionEuro.Text, out cotizacionEuro))
                {
                    euroIngresado = new Euro(euro, cotizacionEuro);
                }
                else
                {
                    euroIngresado = new Euro(euro);
                }



                
                double dolarIngresar;
                double pesoIngresar;

                textEuroAEuro.Text = string.Format("{0}", euro);// euro.ToString();

                dolarIngresar = ((Dolar)euroIngresado).GetCantidad();
                pesoIngresar = ((Peso)euroIngresado).GetCantidad();


                textEuroADolar.Text = dolarIngresar.ToString();
                textEuroAPeso.Text = pesoIngresar.ToString();



            }
        }

        private void btnConvertDolar_Click(object sender, EventArgs e)
        {
            double dolar;
            double cotizacionDolar;
            if(double.TryParse(textDolar.Text, out dolar))
            {
                Dolar dolarIngresado;
                if(double.TryParse(textCotizacionDolar.Text, out cotizacionDolar))
                {
                    dolarIngresado = new Dolar(dolar, cotizacionDolar);
                }
                else
                {
                     dolarIngresado = new Dolar(dolar);
                }


                double euroIngresar;
                double pesoIngresar;

                euroIngresar = ((Euro)dolarIngresado).GetCantidad();
                pesoIngresar = ((Peso)dolarIngresado).GetCantidad();

                textDolarADolar.Text = dolar.ToString();
                textDolarAEuro.Text = euroIngresar.ToString();
                textDolarAPeso.Text = pesoIngresar.ToString();

            }



        }

        private void btnConvertPeso_Click(object sender, EventArgs e)
        {
            double peso;
            if(double.TryParse(textPeso.Text, out peso))
            {
                Peso pesoIngresado = new Peso(peso);
                double dolarIngresar;
                double euroIngresar;

                dolarIngresar = ((Dolar)pesoIngresado).GetCantidad();
                euroIngresar = ((Euro)pesoIngresado).GetCantidad();                

                textPesoAPeso.Text = peso.ToString();
                textPesoADolar.Text = dolarIngresar.ToString();
                textPesoAEuro.Text = euroIngresar.ToString();

            }



        }

        private void btnLockCotizacion_Click(object sender, EventArgs e)
        {
            //this.btnLockCotizacion.ImageIndex=1
            //this.btnLockCotizacion.ImageIndex =
            if (this.btnLockCotizacion.ImageIndex==2)
            {
                this.btnLockCotizacion.ImageIndex = 0;
            }
            
            if(this.btnLockCotizacion.ImageIndex==0)
            {
                textCotizacionDolar.Enabled = false;
                textCotizacionEuro.Enabled = false;
                textCotizacionPeso.Enabled = false;
                this.btnLockCotizacion.ImageIndex += 1;
            }
            else
            {
                textCotizacionDolar.Enabled = true;
                textCotizacionEuro.Enabled = true;
                textCotizacionPeso.Enabled = true;
                this.btnLockCotizacion.ImageIndex -= 1;
            }            

            
        }


        private void txtEuro_TextChanged(object sender, EventArgs e)
        {

        }

        private void textEuroAEuro_TextChanged(object sender, EventArgs e)
        {
            //textEuroAEuro.Enabled = false;
        }

        private void TextCotizacionEuro_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
