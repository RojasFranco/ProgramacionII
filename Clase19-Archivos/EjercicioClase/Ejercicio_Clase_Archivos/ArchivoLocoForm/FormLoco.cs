using System;
using System.IO;
using System.Windows.Forms;
using Entidades;

namespace ArchivoLocoForm
{
    public partial class FormLoco : Form
    {
        private const string EXTENSION_VALIDA = ".txt";

        public FormLoco()
        {
            InitializeComponent();
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {            
            string textoGuardar = this.richTextBoxTexto.Text;
            //MessageBox.Show(textoGuardar);
            try
            {
                Archivador.GuardarTexto(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), false, "Miarchivo", textoGuardar);
            }            
            catch(Exception errorPathInexistente)
            {
                MessageBox.Show(errorPathInexistente.Message);
            }
        }

        private void buttonLeer_Click(object sender, EventArgs e)
        {
            DialogResult resultado = this.openFileDialog1.ShowDialog();                       
            if (resultado==DialogResult.OK)
            {
                string rutaArchivo = openFileDialog1.FileName;                    
                if(Path.GetExtension(rutaArchivo) == EXTENSION_VALIDA)
                {
                    string texto = Archivador.LeerTexto(rutaArchivo);
                    MessageBox.Show(texto);
                }                
                else
                {
                    MessageBox.Show("Extension invalida");
                }
            }
            else
            {
                MessageBox.Show("No se selecciono ruta");
            }
        }
    }
}
