using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio56
{
    public partial class Form1 : Form
    {        
        public Form1()
        {
            InitializeComponent();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            string cantidadCaracteres = (this.richTextBoxTexto.Text.Length).ToString();
            this.toolStripStatusInformacion.Text = cantidadCaracteres;
        }

        private void abrirToolStripMenuAbrir_Click(object sender, EventArgs e)
        {
            DialogResult resultado = this.openFileDialog1.ShowDialog();
            if(resultado==DialogResult.OK)
            {
                string textoLeido = Archivador.LeerArchivo(openFileDialog1.FileName);
                this.richTextBoxTexto.Text = textoLeido;
            }
            else
            {
                MessageBox.Show("No selecciono archivo");
            }
        }

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {

            //Archivador.GuardarArchivo(this.openFileDialog1.FileName, , false, this.richTextBoxTexto.Text);
            
        }
    }
}

