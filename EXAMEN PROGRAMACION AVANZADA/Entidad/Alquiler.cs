using EXAMEN_PROGRAMACION_AVANZADA.Controlador;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXAMEN_PROGRAMACION_AVANZADA.Entidad
{
    public class AlquilerVehiculo
    {
        public int Id { get; set; }
        public string CedCliente { get; set; }
        public string PlacaVehiculo { get; set; }
        public DateTime FechaEntrega { get; set; }
        public DateTime FechaRecogida { get; set; }
        public bool Devuelto { get; set; }

        public AlquilerVehiculo()
        {
        }

        public AlquilerVehiculo(int id, string cedCliente, string placaVehiculo, DateTime fechaEntrega, DateTime fechaRecogida)
        {
            Id = id;
            CedCliente = cedCliente;
            PlacaVehiculo = placaVehiculo;
            FechaEntrega = fechaEntrega;
            FechaRecogida = fechaRecogida;
            Devuelto = false;
        }

        public int DiasAlquiler
        {
            get
            {
                return (FechaRecogida - FechaEntrega).Days;
            } 
        }

        public double Importe
        {
            get
            {
                double tarifa = TListaTarifas.getTarifaValor(TListaVehiculos.getVehiculoModelo(PlacaVehiculo));
                return tarifa * DiasAlquiler;
            }
        }
        public double Descuento
        {
            get
            {
                if (DiasAlquiler > 15)
                {
                    return Importe * 0.10;
                }
                else
                {
                    return 0;
                }
            }
        }
        public double Total
        {
            get
            {
                return Importe - Descuento;
            }
        }



    }
}
