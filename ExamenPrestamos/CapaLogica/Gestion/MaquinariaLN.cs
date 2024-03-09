using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica.Gestion
{
    public class MaquinariaLN
    {
        public List<CapaEntidad.Gestion.Maquinaria> ListarMaquinarias()
        {
            try
            {
                return CapaDatos.Gestion.MaquinariaCD.ListarMaquinarias();
            }catch(Exception ex)
            {
                throw ex;
            }
        }

        public CapaEntidad.Gestion.Maquinaria BuscarMaquinaria(string codigo)
        {
            try
            {
                return CapaDatos.Gestion.MaquinariaCD.BuscarMaquinaria(codigo);
            }catch(Exception ex)
            {
                throw ex;
            }
        }

        public void InsertarMaquinaria(CapaEntidad.Gestion.Maquinaria maquinaria)
        {
            try
            {
                CapaDatos.Gestion.MaquinariaCD.InsertarMaquinaria(maquinaria);
            }catch(Exception ex)
            {
                throw ex;
            }
        }

        public void ActualizarMaquinaria(CapaEntidad.Gestion.Maquinaria maquinaria)
        {
            try
            {
                CapaDatos.Gestion.MaquinariaCD.ActualizarMaquinaria(maquinaria);
            }catch(Exception ex)
            {
                throw ex;
            }
        }

        public void EliminarMaquinaria(string codigo)
        {
            try
            {
                CapaDatos.Gestion.MaquinariaCD.EliminarMaquinaria(codigo);
            }catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}
