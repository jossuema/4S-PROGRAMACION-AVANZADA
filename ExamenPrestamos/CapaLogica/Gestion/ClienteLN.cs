using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica.Gestion
{
    public class ClienteLN
    {
        public List<CapaEntidad.Gestion.Cliente> ListarClientes()
        {
            try
            {
                return CapaDatos.Gestion.ClienteCD.ListarClientes();
            }catch(Exception ex)
            {
                throw ex;
            }
        }

        public CapaEntidad.Gestion.Cliente BuscarCliente(string cedula)
        {
            try
            {
                return CapaDatos.Gestion.ClienteCD.BuscarCliente(cedula);
            }catch(Exception ex)
            {
                throw ex;
            }
        }

        public void InsertarCliente(CapaEntidad.Gestion.Cliente cliente)
        {
            try
            {
                CapaDatos.Gestion.ClienteCD.InsertarCliente(cliente);
            }catch(Exception ex)
            {
                throw ex;
            }
        }

        public void ActualizarCliente(CapaEntidad.Gestion.Cliente cliente)
        {
            try
            {
                CapaDatos.Gestion.ClienteCD.ActualizarCliente(cliente);
            }catch(Exception ex)
            {
                throw ex;
            }
        }

        public void EliminarCliente(string cedula)
        {
            try
            {
                CapaDatos.Gestion.ClienteCD.EliminarCliente(cedula);
            }catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}
