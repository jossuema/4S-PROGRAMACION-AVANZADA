using CapaEntidades.Gestion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos.Gestion;
using CapaDatos;

namespace CapaLogica.Gestion
{
    public class AutorLN
    {
        public List<CapaEntidades.Gestion.Autor> ViewAutorFiltro(string val)
        {
            List<CapaEntidades.Gestion.Autor> ListaAutores = new List<CapaEntidades.Gestion.Autor>();
            CapaEntidades.Gestion.Autor oa = null;
            try
            {
                List<CP_ListarAutoresResult> auxLista = AutorCD.ListarAutorFiltro(val);
                foreach (CP_ListarAutoresResult op in auxLista)
                {
                    oa = new CapaEntidades.Gestion.Autor(op.id_autor,op.estado,op.nombre,op.apellido,op.sexo,op.fecha_nacimiento);
                    ListaAutores.Add(oa);
                }
                return ListaAutores;
            }
            catch (Exception ex)
            {
                throw new LogicaExcepciones("Error listar autor en CD", ex);
            }
           
        }

        public void InsertarAutor(CapaEntidades.Gestion.Autor autor)
        {
            try
            {
                AutorCD.InsertarAutor(autor);
            }
            catch (Exception ex)
            {
                throw new LogicaExcepciones("Error insertar autor en CD", ex);
            }
        }

        public void ModificarAutor(CapaEntidades.Gestion.Autor autor)
        {
            try
            {
                AutorCD.ModificarAutor(autor);
            }
            catch (Exception ex)
            {
                throw new LogicaExcepciones("Error actualizar autor en CD", ex);
            }
        }

        public void EliminarAutor(int id)
        {
            try
            {
                AutorCD.EliminarAutor(id);
            }
            catch (Exception ex)
            {
                throw new LogicaExcepciones("Error eliminar autor en CD", ex);
            }
        }
    }
}
