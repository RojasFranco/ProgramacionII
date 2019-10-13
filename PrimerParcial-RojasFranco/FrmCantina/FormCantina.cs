using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace FrmCantina
{
    public partial class FormCantina : Form
    {        
        public FormCantina()
        {
            InitializeComponent();
        }

        private void FormCantina_Load(object sender, EventArgs e)
        {
            this.barra1.SetCantina = Cantina.GetCantina(10);        
            this.comboBoxTipoBotella.DataSource = Enum.GetValues(typeof(Botella.Tipo));            
        }

        /*private void comboBoxTipoBotella_ValueMemberChanged(object sender, EventArgs e)
        {
            Botella.Tipo tipo;
            Enum.TryParse<Botella.Tipo>(comboBoxTipoBotella.SelectedValue.ToString(), out tipo);
            this.tipo = tipo;
        }*/

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Botella.Tipo tipo;
            Enum.TryParse<Botella.Tipo>(comboBoxTipoBotella.SelectedValue.ToString(), out tipo);

            if (radioBtnAgua.Checked == true)
            {
                barra1.AgregarBotella(new Agua(Convert.ToInt32(numericUpDown1Capacidad.Value), this.textBoxMarca.Text, Convert.ToInt32(numericUpDownContenido.Value)));                
            }
            else if(radioBtnCerveza.Checked == true)
            {
                barra1.AgregarBotella(new Cerveza(Convert.ToInt32(numericUpDown1Capacidad.Value), this.textBoxMarca.Text, tipo, Convert.ToInt32(numericUpDownContenido.Value)));                
            }
        }

    }
}
