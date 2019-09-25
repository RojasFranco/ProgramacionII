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


            List<KeyValuePair<string, int>> lista = contadorPalabras.ToList();

            InformarMayorCantidad(lista, 3);                       



            //InformarMayorCantidad(lista, 4);


            /*
            string mostrador = string.Empty;
            foreach(KeyValuePair<string, int> palabra in lista)
            {
                mostrador += string.Format(" {0}: {1}\n", palabra.Key, palabra.Value);
            }
            MessageBox.Show(mostrador, "Palabras encontradas");
            */


        }

        private void InformarMayorCantidad(List<KeyValuePair<string, int >> lista, int cantidadPedidas)
        {

            lista = lista.OrderByDescending(z => z.Value).ToList();
            StringBuilder sb = new StringBuilder();
            //lista.Sort();
            for (int i=0; i<cantidadPedidas; i++)
            {
                sb.AppendFormat(" {0} : {1}\n", lista[i].Key, lista[i].Value);
            }

            MessageBox.Show(sb.ToString(), "Palabras encontradas", MessageBoxButtons.OK);
        }

        /*private void Comparador(List<KeyValuePair<string, int>> listaRecibida)
        {
            listaRecibida
        }*/


    }
}
