using CapaDatos;
using CapaDatos.Gestion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica.Gestion
{
    public class CategoriaLN
    {
        public List<CapaEntidades.Gestion.Categoria> ViewCategoriaFiltro(string val)
        {
            List<CapaEntidades.Gestion.Categoria> ListaCategorias = new List<CapaEntidades.Gestion.Categoria>();
            CapaEntidades.Gestion.Categoria oc = null;
            try
            {
                List<CP_ListarCategoriasResult> auxLista = CategoriaCD.ListarCategoriaFiltro(val);
                foreach (CP_ListarCategoriasResult op in auxLista)
                {
                    oc = new CapaEntidades.Gestion.Categoria(op.id_categoria, op.nombre, op.descripcion);
                    ListaCategorias.Add(oc);
                }
                return ListaCategorias;
            }
            catch (Exception ex)
            {
                throw new LogicaExcepciones("Error listar categoria en CD", ex);
            }
        }

        public void InsertarCategoria(CapaEntidades.Gestion.Categoria categoria)
        {
            try
            {
                CategoriaCD.InsertarCategoria(categoria);
            }
            catch (Exception ex)
            {
                throw new LogicaExcepciones("Error insertar categoria en CD", ex);
            }
        }

        public void ModificarCategoria(CapaEntidades.Gestion.Categoria categoria)
        {
            try
            {
                CategoriaCD.ModificarCategoria(categoria);
            }
            catch (Exception ex)
            {
                throw new LogicaExcepciones("Error actualizar categoria en CD", ex);
            }
        }

        public void EliminarCategoria(int id)
        {
            try
            {
                CategoriaCD.EliminarCategoria(id);
            }
            catch (Exception ex)
            {
                throw new LogicaExcepciones("Error eliminar categoria en CD", ex);
            }
        }
    }
}
