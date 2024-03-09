using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica.Gestion
{
    public class PrestamoLN
    {

        public CapaEntidad.Gestion.Prestamo BuscarPrestamo(int codigo)
        {
            try
            {
                return CapaDatos.Gestion.PrestamoCD.BuscarPrestamo(codigo);
            }catch(Exception ex)
            {
                throw ex;
            }
        }

        public void InsertarPrestamo(CapaEntidad.Gestion.Prestamo prestamo)
        {
            try
            {
                CapaDatos.Gestion.PrestamoCD.InsertarPrestamo(prestamo);
            }catch(Exception ex)
            {
                throw ex;
            }
        }

        public void ActualizarPrestamo(CapaEntidad.Gestion.Prestamo prestamo)
        {
            try
            {
                CapaDatos.Gestion.PrestamoCD.ActualizarPrestamo(prestamo);
            }catch(Exception ex)
            {
                throw ex;
            }
        }

        public void EliminarPrestamo(int codigo)
        {
            try
            {
                CapaDatos.Gestion.PrestamoCD.EliminarPrestamo(codigo);
            }catch(Exception ex)
            {
                throw ex;
            }
        }

        public List<CapaEntidad.Personalizado.PrestamoDevolucion> ListarPrestamos()
        {
            List<CapaEntidad.Personalizado.PrestamoDevolucion> lista = new List<CapaEntidad.Personalizado.PrestamoDevolucion>();
            try
            {
                foreach (var prestamo in CapaDatos.Gestion.PrestamoCD.ListarPrestamos())
                {
                    var cliente = CapaDatos.Gestion.ClienteCD.BuscarCliente(prestamo.CedulaCliente);
                    var maquinaria = CapaDatos.Gestion.MaquinariaCD.BuscarMaquinaria(prestamo.CodigoMaquinaria);
                    int dias = prestamo.FechaTentativa.Subtract(prestamo.FechaEntrega).Days;
                    double importe = maquinaria.Tarifa * dias;
                    double descuento = (dias>10)?importe * 0.1:0.0;
                    double multa = 0.0;
                    if (prestamo.FechaDevolucion != null && prestamo.FechaDevolucion.Value > prestamo.FechaTentativa)
                    {
                        multa = maquinaria.Tarifa * dias * 0.05;
                    }
                    double garantia = importe - descuento * 0.1;
                    double importeTotal = importe - descuento;
                    if (multa > garantia)
                    {
                        multa = multa - garantia +multa;
                    }

                    lista.Add(new CapaEntidad.Personalizado.PrestamoDevolucion
                    {
                        Codigo = prestamo.Codigo,
                        Cliente = cliente.Nombre + " " + cliente.Apellido,
                        Maquinaria = CapaDatos.Gestion.MaquinariaCD.BuscarMaquinaria(prestamo.CodigoMaquinaria).Codigo,
                        FechaEntrega = prestamo.FechaEntrega,
                        FechaTentativa = prestamo.FechaTentativa,
                        FechaDevolucion = prestamo.FechaDevolucion,
                        Dias = dias,
                        Importe = importe,
                        Descuento = descuento,
                        Garantia = garantia,
                        Multa = multa,
                        Total = importeTotal,
                        Estado = prestamo.Estado
                    });
                }
                return lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<CapaEntidad.Personalizado.PrestamoDevolucion> ListarDevoluciones()
        {
            List<CapaEntidad.Personalizado.PrestamoDevolucion> lista = new List<CapaEntidad.Personalizado.PrestamoDevolucion>();
            try
            {
                foreach (var prestamo in CapaDatos.Gestion.PrestamoCD.ListarPrestamos())
                {
                    if(prestamo.Estado == "Entregado")
                    {
                        continue;
                    }

                    var cliente = CapaDatos.Gestion.ClienteCD.BuscarCliente(prestamo.CedulaCliente);
                    var maquinaria = CapaDatos.Gestion.MaquinariaCD.BuscarMaquinaria(prestamo.CodigoMaquinaria);
                    int dias = prestamo.FechaTentativa.Subtract(prestamo.FechaEntrega).Days;
                    double importe = maquinaria.Tarifa * dias;
                    double descuento = (dias > 10) ? importe * 0.1 : 0.0;
                    double multa = 0.0;
                    if (prestamo.FechaDevolucion != null && prestamo.FechaDevolucion.Value > prestamo.FechaTentativa)
                    {
                        multa = maquinaria.Tarifa * dias * 0.05;
                    }
                    double garantia = importe - descuento * 0.1;
                    double importeTotal = importe - descuento;
                    if (multa > garantia)
                    {
                        multa = multa - garantia + multa;
                    }

                    lista.Add(new CapaEntidad.Personalizado.PrestamoDevolucion
                    {
                        Codigo = prestamo.Codigo,
                        Cliente = cliente.Nombre + " " + cliente.Apellido,
                        Maquinaria = CapaDatos.Gestion.MaquinariaCD.BuscarMaquinaria(prestamo.CodigoMaquinaria).Codigo,
                        FechaEntrega = prestamo.FechaEntrega,
                        FechaTentativa = prestamo.FechaTentativa,
                        FechaDevolucion = prestamo.FechaDevolucion,
                        Dias = dias,
                        Importe = importe,
                        Descuento = descuento,
                        Garantia = garantia,
                        Multa = multa,
                        Total = importeTotal,
                        Estado = prestamo.Estado
                    });
                }
                return lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Dictionary<string, string> ComboBoxClientes()
        {
            try
            {
                Dictionary<string, string> lista = new Dictionary<string, string>();
                foreach (var cliente in CapaDatos.Gestion.ClienteCD.ListarClientes())
                {
                    lista.Add(cliente.Cedula, cliente.Nombre + " " + cliente.Apellido);
                }
                return lista;
            }catch(Exception ex)
            {
                throw ex;
            }
        }

        public Dictionary<string, string> ComboBoxMaquinarias()
        {
            try
            {
                Dictionary<string, string> lista = new Dictionary<string, string>();
                foreach (var maquinaria in CapaDatos.Gestion.MaquinariaCD.ListarMaquinarias())
                {
                    if (maquinaria.Disponible)
                    {
                        lista.Add(maquinaria.Codigo, maquinaria.Codigo);
                    }
                    
                }
                return lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


    }
}
