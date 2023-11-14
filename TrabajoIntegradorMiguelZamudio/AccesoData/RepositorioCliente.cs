using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using Entidades;

namespace AccesoData
{
    public class RepositorioCliente : IRepositorio<Cliente>
    {
        public SqlConnection _sqlConectar;
        public SqlDataAdapter _sqlAdaptador;
        public SqlCommandBuilder _sqlConstructorComandos;

        List<Cliente> clientes = new List<Cliente>
        {
            new Cliente{
                Nombre="miguel",
                DNI=959123
            },
            new Cliente{}
        };

        public RepositorioCliente() { }
        public RepositorioCliente(SqlConnection sqlConectar, SqlDataAdapter sqlAdaptador, SqlCommandBuilder sqlConstructorComandos)
        {
            _sqlConectar = sqlConectar;
            _sqlAdaptador = sqlAdaptador;
            _sqlConstructorComandos = sqlConstructorComandos;
        }

        public bool GuardarCliente(Cliente cliente)
        {
            return true;
        }

        public void addItems()
        {
            throw new NotImplementedException();
        }

        public List<Cliente> getClientes()
        {
            return clientes;
        }

        public void getItems()
        {
            throw new NotImplementedException();
        }
        public void removeItems()
        {
            throw new NotImplementedException();
        }

        public void updateItems()
        {
            throw new NotImplementedException();
        }
    }
}
