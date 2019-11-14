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

namespace FormPersona
{
    public partial class FormPersona : Form
    {
        private Persona persona;

        public FormPersona()
        {
            InitializeComponent();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            if(persona==null)
            {                
                persona = new Persona();
                persona.Nombre = this.textBoxNombre.Text;
                persona.Apellido = this.textBoxApellido.Text;                
            }
        }

        public static void NotificarCambio(string cambio)
        {
            MessageBox.Show(cambio);
        }

        private void FormPersona_Load(object sender, EventArgs e)
        {
            persona.EventoString += NotificarCambio;
        }
    }
}
