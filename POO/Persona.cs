using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    public class Persona
    {
        public int Codigo { get; set; }
        public string Cedula { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public char Genero { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string Estado { get; set; }

        public Persona() { }
        public Persona(int codigo, string cedula, string nombre, string apellido, char genero, DateTime fechaNacimiento, string estado)
        {
            Codigo = codigo;
            Cedula = cedula;
            Nombre = nombre;
            Apellido = apellido;
            Genero = genero;
            FechaNacimiento = fechaNacimiento;
            Estado = estado;
        }

        public int Edad()
        {
            int edad = DateTime.Now.Year - FechaNacimiento.Year;
            if (DateTime.Now.Month < FechaNacimiento.Month || (DateTime.Now.Month == FechaNacimiento.Month && DateTime.Now.Day < FechaNacimiento.Day))
                edad--;
            return edad;
        }

        public string SignoZodiacal()
        {
            string signo = "";
            switch (FechaNacimiento.Month)
            {
                case 1:
                    if (FechaNacimiento.Day <= 20)
                        signo = "Capricornio";
                    else
                        signo = "Acuario";
                    break;
                case 2:
                    if (FechaNacimiento.Day <= 19)
                        signo = "Acuario";
                    else
                        signo = "Piscis";
                    break;
                case 3:
                    if (FechaNacimiento.Day <= 20)
                        signo = "Piscis";
                    else
                        signo = "Aries";
                    break;
                case 4:
                    if (FechaNacimiento.Day <= 20)
                        signo = "Aries";
                    else
                        signo = "Tauro";
                    break;
                case 5:
                    if (FechaNacimiento.Day <= 21)
                        signo = "Tauro";
                    else
                        signo = "Geminis";
                    break;
                case 6:
                    if (FechaNacimiento.Day <= 21)
                        signo = "Geminis";
                    else
                        signo = "Cancer";
                    break;
                case 7:
                    if (FechaNacimiento.Day <= 23)
                        signo = "Cancer";
                    else
                        signo = "Leo";
                    break;
                case 8:
                    if (FechaNacimiento.Day <= 23)
                        signo = "Leo";
                    else
                        signo = "Virgo";
                    break;
                case 9:
                    if (FechaNacimiento.Day <= 23)
                        signo = "Virgo";
                    else
                        signo = "Libra";
                    break;
                case 10:
                    if (FechaNacimiento.Day <= 23)
                        signo = "Libra";
                    else
                        signo = "Escorpio";
                    break;
                case 11:
                    if (FechaNacimiento.Day <= 22)
                        signo = "Escorpio";
                    else
                        signo = "Sagitario";
                    break;
                case 12:
                    if (FechaNacimiento.Day <= 21)
                        signo = "Sagitario";
                    else
                        signo = "Capricornio";
                    break;
            }
            return signo;
        }

        public string Imprimir()
        {
            return "Codigo: " + Codigo + "\n" +
                "Cedula: " + Cedula + "\n" +
                "Nombre: " + Nombre + "\n" +
                "Apellido: " + Apellido + "\n" +
                "Genero: " + Genero + "\n" +
                "Fecha de Nacimiento: " + FechaNacimiento.ToString("dd/MM/yyyy") + "\n" +
                "Estado: " + Estado + "\n" +
                "Edad: " + Edad() + "\n" +
                "Signo Zodiacal: " + SignoZodiacal();
        }
        
    }
}
