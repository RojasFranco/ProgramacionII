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
        private string path;

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
                this.path = openFileDialog1.FileName;
                string textoLeido = Archivador.LeerArchivo(path);
                this.richTextBoxTexto.Text = textoLeido;                    
            }
            else
            {
                MessageBox.Show("No selecciono archivo");
            }
        }

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.path == null)
            {
                this.GuardarComo();
            }
            else
            {
                Archivador.GuardarArchivo(path, false, this.richTextBoxTexto.Text);
            }
        }

        private void guardarComoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.GuardarComo();            
        }
        
        private void GuardarComo()
        {
            DialogResult resultado = this.saveFileDialog1.ShowDialog();
            if (resultado == DialogResult.OK)
            {
                this.path = this.saveFileDialog1.FileName;
                Archivador.GuardarArchivo(path, false, this.richTextBoxTexto.Text);
            }
            else
            {
                MessageBox.Show("No selecciono archivo ni su nombre");
            }
        }
    }
}

