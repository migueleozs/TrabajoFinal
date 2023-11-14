using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Aplication;
using Entidades;

namespace Presentacion
{
    public partial class formVentas : Form
    {
        public formVentas()
        {
            InitializeComponent();

            Empresa empresa = new Empresa();
            Negocio negocio = new Negocio();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void formVentas_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            try
            {
                textBoxNombreP.Text = string.Empty;
                textBoxCodigoP.Text = string.Empty;
                textBoxDNI.Text = string.Empty;
                textBoxMedio.Text = string.Empty;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
