using AccesoData;
using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class formRegistrarCliente : Form
    {
        private RepositorioCliente _repoCliente;
        public formRegistrarCliente()
        {
            _repoCliente = new RepositorioCliente();
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            try
            {
                if (!Regex.IsMatch(textBoxDNIC.Text, @"^[0-9]{8}$"))
                {
                    throw new Exception("El DNI debe ser numerico y tener 8 cifras");
                }
                if (!Regex.IsMatch(textBoxNombreC.Text, @"^[A-Z][a-zA-Z]*$"))
                {
                    throw new Exception("El nombre empieza con una mayuscula y no debe tener numeros o caracteres especiales");
                }
                if (!Regex.IsMatch(textBoxApellidoC.Text, @"^[A-Z][a-zA-Z]*$"))
                {
                    throw new Exception("El apellido empieza con una mayuscula solo admiten letras");
                }
                if (!Regex.IsMatch(textBoxTelefonoC.Text, @"^[0-9]{10}$"))
                {
                    throw new Exception("El numero de telefono debe tener 10 cifras");
                }
                if (!Regex.IsMatch(textBoxEmailC.Text, @"^\w+([\.-]?\w+)*@\w+([\.-]?\w+)*(\.[a-zA-Z]{2,3})+$"))
                {
                    throw new Exception("El texto no corresponde a una direccion de correo valida. ejm:a@a.com");
                }
                var cliente = new Cliente
                {
                    Id = (int)(string.IsNullOrEmpty(textBoxIDC.Text) ? 0 : Convert.ToInt64(textBoxIDC.Text)),
                    Nombre = textBoxNombreC.Text,
                    Apellido = textBoxApellidoC.Text,
                    DNI = (int)long.Parse(textBoxDNIC.Text.ToString()),
                    Email = textBoxEmailC.Text,
                    Telefono = (int)long.Parse(textBoxTelefonoC.Text.ToString()),
                    
            };

                _repoCliente.GuardarCliente(cliente);
                //MostrarOcultarBotones();
                button2_Click(null, null);
                CargarDataGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CargarDataGrid()
        {
            try
            {
                /*dataGridView1.DataSource = null;
                dataGridView1.DataSource = _repoCliente.getClientes();*/
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                textBoxDNIC.Text = string.Empty;
                textBoxNombreC.Text = string.Empty;
                textBoxApellidoC.Text = string.Empty;
                textBoxTelefonoC.Text = string.Empty;
                textBoxEmailC.Text = string.Empty;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void MostrarOcultarBotones(bool ocultar = false)
        {
            try
            {
                button2.Visible = ocultar;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textBoxIDC_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxNombreC_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
