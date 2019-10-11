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

        private void comboBoxTipoBotella_ValueMemberChanged(object sender, EventArgs e)
        {
            Botella.Tipo tipo;
            Enum.TryParse<Botella.Tipo>(comboBoxTipoBotella.SelectedValue.ToString(), out tipo);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if(radioBtnAgua.Checked == true)
            {
                //Agregar agua                          
            }
            else if(radioBtnCerveza.Checked == true)
            {
                //Agregar cerveza
            }
        }
    }
}
