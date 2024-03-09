using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad.Personalizado
{
    public class PrestamoDevolucion
    {
        public int Codigo { get; set; }
        public string Cliente { get; set; }
        public string Maquinaria { get; set; }
        public DateTime FechaEntrega { get; set; }
        public DateTime FechaTentativa { get; set; }
        public DateTime? FechaDevolucion { get; set; }
        public int Dias { get; set; }
        public double Importe { get; set; }
        public double Descuento { get; set; }
        public double Garantia { get; set; }
        public double Multa { get; set; }
        public double Total { get; set; }
        public string Estado { get; set; }

        public PrestamoDevolucion(int codigo, string cliente, string maquinaria, DateTime fechaEntrega, DateTime fechaTentativa, DateTime? fechaDevolucion, int dias, double importe, double descuento, double garantia, double multa, double total, string estado)
        {
            Codigo = codigo;
            Cliente = cliente;
            Maquinaria = maquinaria;
            FechaEntrega = fechaEntrega;
            FechaTentativa = fechaTentativa;
            FechaDevolucion = fechaDevolucion;
            Dias = dias;
            Importe = importe;
            Descuento = descuento;
            Garantia = garantia;
            Multa = multa;
            Total = total;
            Estado = estado;
        }

        public PrestamoDevolucion()
        {
        }
    }
}
