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
    public partial class formProducto : Form
    {
        private RepositorioProductos _repoP;
        public formProducto()
        {
            _repoP = new RepositorioProductos();
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            try
            {
                if (!Regex.IsMatch(textBoxNombreP.Text, @"^[A-Z][a-zA-Z]*$"))
                {
                    throw new Exception("El nombre solo admiten letras, debe empezar en mayuscula");
                }
                if (!Regex.IsMatch(textBoxPrecioP.Text, @"^[0-9]*$"))
                {
                    throw new Exception("El precio debe ser numerico");
                }
                var producto = new Producto
                {
                    Nombre = textBoxNombreP.Text,
                    Descripcion = textBoxDescripcionP.Text,
                    Precio = long.Parse(textBoxPrecioP.Text.ToString()),
                    
                };
                _repoP.GuardarProducto(producto);
                //MostrarOcultarBotones();
                //BtnLimpiar_Click(null, null);
                //CargarDataGrid();
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
                textBoxNombreP.Text = string.Empty;
                textBoxPrecioP.Text = string.Empty;
                textBoxDescripcionP.Text = string.Empty;
              
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
