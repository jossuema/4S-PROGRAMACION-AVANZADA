using CapaDatos;
using CapaDatos.Gestion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica.Gestion
{
    public class EditorialLN
    {
        public List<CapaEntidades.Gestion.Editorial> ViewEditorialFiltro(string val)
        {
            List<CapaEntidades.Gestion.Editorial> ListaEditoriales = new List<CapaEntidades.Gestion.Editorial>();
            CapaEntidades.Gestion.Editorial oc = null;
            try
            {
                List<CP_ListarEditorialesResult> auxLista = EditorialCD.ListarEditorialFiltro(val);
                foreach (CP_ListarEditorialesResult op in auxLista)
                {
                    oc = new CapaEntidades.Gestion.Editorial(op.id_editorial, op.nombre, op.pais);
                    ListaEditoriales.Add(oc);
                }
                return ListaEditoriales;
            }
            catch (Exception ex)
            {
                throw new LogicaExcepciones("Error listar editorial en CD", ex);
            }
        }

        public void InsertarEditorial(CapaEntidades.Gestion.Editorial editorial)
        {
            try
            {
                EditorialCD.InsertarEditorial(editorial);
            }
            catch (Exception ex)
            {
                throw new LogicaExcepciones("Error insertar editorial en CD", ex);
            }
        }

        public void ModificarEditorial(CapaEntidades.Gestion.Editorial editorial)
        {
            try
            {
                EditorialCD.ModificarEditorial(editorial);
            }
            catch (Exception ex)
            {
                throw new LogicaExcepciones("Error actualizar editorial en CD", ex);
            }
        }

        public void EliminarEditorial(int id)
        {
            try
            {
                EditorialCD.EliminarEditorial(id);
            }
            catch (Exception ex)
            {
                throw new LogicaExcepciones("Error eliminar editorial en CD", ex);
            }
        }
    }
}
