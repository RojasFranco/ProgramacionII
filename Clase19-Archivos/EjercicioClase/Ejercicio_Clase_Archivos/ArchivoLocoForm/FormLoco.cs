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
            this.openFileDialog1.ShowDialog();            
            string textoGuardar = this.richTextBoxTexto.Text;
            Archivador.GuardarTexto(openFileDialog1.FileName, false, "Archiv", textoGuardar);
            //Environment.GetFolderPath(Environment.SpecialFolder.Desktop)
        }

        private void buttonLeer_Click(object sender, EventArgs e)
        {
            DialogResult resultado = this.openFileDialog1.ShowDialog();            
            if (resultado==DialogResult.OK)
            {
                string rutaArchivo = openFileDialog1.FileName;                    
                string texto = Archivador.LeerTexto(rutaArchivo, this.richTextBoxTexto.Text);
                MessageBox.Show(texto);
                
            }
        }
    }
}
