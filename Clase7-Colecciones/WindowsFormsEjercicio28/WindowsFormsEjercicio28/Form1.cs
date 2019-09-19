using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsEjercicio28
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dictionary<string, int> contadorPalabras = new Dictionary<string, int>();
            string textoIngresado;            
            textoIngresado = this.richTextBoxTextoIngresado.Text;
            //textoIngresado.Split(' ');

            //List<string> palabrasSeparadas = new List<string>();
            string[] palabrasSeparadas = textoIngresado.Split(' ');

            foreach (string palabra in palabrasSeparadas)
            {
                if(contadorPalabras.ContainsKey(palabra))
                {
                    contadorPalabras[palabra] = contadorPalabras[palabra] + 1;
                }
                else
                {
                    contadorPalabras.Add(palabra, 1);
                }
            }
                       

            string mostrador = string.Empty;
            foreach(string palabra in contadorPalabras.Keys)
            {
                mostrador += string.Format(" {0} {1}\n", palabra, contadorPalabras[palabra]);
            }
            MessageBox.Show(mostrador, "Palabras encontradas");


            /*Puedo usar
             contadorPalabras.orderByDescending(
             keyValuePair => keyValuePair.Value)
             Param entrada       lo que devuelve            



            */

            /*
             Ordenados TOP 3 
             
            List<int> listaOrdenar = contadorPalabras.Values.ToList();
            listaOrdenar.Sort();
            string mostrarTop3 = string.Empty;
            for (int i=0;i<3;i++)
            {                

            }
            */

        }                
    }
}
