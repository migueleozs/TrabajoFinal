using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesoData;
using Entidades;

namespace Aplication
{
    public class Negocio
    {
        private Empresa empresa = new Empresa();
        private RepositorioCliente repo = new RepositorioCliente();

        public Negocio()
        {
        }

        public Negocio(Empresa empresa)
        {
            this.empresa = empresa;
        }

        public void RealizarVenta(Cliente cliente, List<Producto>productos)
        {
            empresa.Vender(cliente,productos);
        }

    }
}
