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
        public event DelegadoString EventoForm;


        public FormPersona()
        {
            InitializeComponent();
        }

        /*
   d.  
      iii. En ambos casos notificar al usuario siempre el nombre y el apellido de la persona 
            utilizando el método Mostrar.  
 */
        private void btnCrear_Click(object sender, EventArgs e)
        {
            if(persona==null)
            {
                persona = new Persona();
                persona.EventoString += NotificarCambio;
                persona.Nombre = this.textBoxNombre.Text;
                persona.Apellido = this.textBoxApellido.Text;
                this.btnCrear.Text = "Actualizar";
                this.EventoForm.Invoke(string.Format("Se actualizo persona- {0}",persona.Mostrar()));                
            }
            else
            {
                persona.Nombre = this.textBoxNombre.Text;
                persona.Apellido = this.textBoxApellido.Text;
                this.EventoForm.Invoke(string.Format("Se actualizo persona- {0}", persona.Mostrar()));
            }
        }


        public static void NotificarCambio(string cambio)
        {
            MessageBox.Show(cambio);
        }

        private void FormPersona_Load(object sender, EventArgs e)
        {
            //persona = new Persona();            
            //persona.EventoString += NotificarCambio;            
            this.EventoForm += NotificarCambio;
        }
    }
}
