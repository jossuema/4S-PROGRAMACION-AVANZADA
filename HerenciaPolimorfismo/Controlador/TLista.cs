using HerenciaPolimorfismo.Entidad;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HerenciaPolimorfismo.Controlador
{
    public class TLista
    {
        public static List<Empleado> listaEmpleados = new List<Empleado>();

        public static void insert(Empleado op)
        {
            listaEmpleados.Add(op);
        }

        public static void update(Empleado op, int pos)
        {
            listaEmpleados[pos] = op;
        }

        public static void delete(int pos)
        {
            listaEmpleados.Remove(listaEmpleados.ElementAtOrDefault(pos));
        }

        public static int buscar(int id)
        {
            int pos = -1;
            for (int i = 0; i < listaEmpleados.Count; i++)
            {
                if (listaEmpleados[i].Codigo == id)
                {
                    pos = i; break;
                }
            }
            return pos;
        }

        public static Empleado getEmpleado(int pos)
        {
            return listaEmpleados[pos];
        }

        public static void guardarLista()
        {
            List<Asalariado> listaAsalariado = new List<Asalariado>();
            List<AsalariadoPorComision> listaAsalariadoPorComision = new List<AsalariadoPorComision>();
            List<PorHoras> listaPorHoras = new List<PorHoras>();
            List<PorComision> listaPorComision = new List<PorComision>();
            for(int i = 0; i < listaEmpleados.Count; i++)
            {
                Empleado empleado = listaEmpleados[i];
                if (empleado is Asalariado)
                {
                    listaAsalariado.Add((Asalariado)empleado);
                }
                if(empleado is AsalariadoPorComision)
                {
                    listaAsalariadoPorComision.Add((AsalariadoPorComision)empleado);
                }
                if(empleado is PorHoras)
                {
                    listaPorHoras.Add((PorHoras)empleado);
                }
                if (empleado is PorComision)
                {
                    listaPorComision.Add((PorComision)empleado);
                }
            }
            File.WriteAllText("Asalariados.json", JsonConvert.SerializeObject(listaAsalariado));
            File.WriteAllText("AsalariadosPorComision.json", JsonConvert.SerializeObject(listaAsalariadoPorComision));
            File.WriteAllText("PorHoras.json", JsonConvert.SerializeObject(listaPorHoras));
            File.WriteAllText("PorComision.json", JsonConvert.SerializeObject(listaPorComision));
        }

        public static void cargarLista()
        {
            if(File.Exists("Asalariados.json"))
            {
                List<Asalariado> listaAsalariado = JsonConvert.DeserializeObject<List<Asalariado>>(File.ReadAllText("Asalariados.json"));
                for(int i = 0; i < listaAsalariado.Count; i++)
                {
                    insert(listaAsalariado[i]);
                }
            }
            if (File.Exists("AsalariadosPorComision.json"))
            {
                List<AsalariadoPorComision> listaAsalariadoPorComision = JsonConvert.DeserializeObject<List<AsalariadoPorComision>>(File.ReadAllText("AsalariadosPorComision.json"));
                for (int i = 0; i < listaAsalariadoPorComision.Count; i++)
                {
                    insert(listaAsalariadoPorComision[i]);
                }
            }
            if (File.Exists("PorHoras.json"))
            {
                List<PorHoras> listaPorHoras = JsonConvert.DeserializeObject<List<PorHoras>>(File.ReadAllText("PorHoras.json"));
                for (int i = 0; i < listaPorHoras.Count; i++)
                {
                    insert(listaPorHoras[i]);
                }
            }
            if (File.Exists("PorComision.json"))
            {
                List<PorComision> listaPorComision = JsonConvert.DeserializeObject<List<PorComision>>(File.ReadAllText("PorComision.json"));
                for (int i = 0; i < listaPorComision.Count; i++)
                {
                    insert(listaPorComision[i]);
                }
            }
        }
    }
}
