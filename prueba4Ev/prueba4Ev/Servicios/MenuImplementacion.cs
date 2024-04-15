using prueba4Ev.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prueba4Ev.Servicios
{
    /// <summary>
    /// Clase que implementa todos los metodos relacionados con el menu
    /// <author>dmp - 15/04/24</author>
    /// </summary>
    internal class MenuImplementacion : MenuInterfaz
    {
        public void accesoPuertaEste(List<PuertaDto> listaPuertas)
        {
            Console.WriteLine("Introduzca la matricula");
            string matricula = Console.ReadLine();

            foreach (PuertaDto puerta in listaPuertas)
            {
             if (puerta.Matrícula.Equals(matricula) && puerta.ZonaDestino == "este" && puerta.TipVehiculo == 'F' || puerta.TipVehiculo == 'A' )
                {
                    Console.WriteLine("Tienes acceso a la puerta SE");
                    DateTime instanteFechaPaso = DateTime.Now;
                    puerta.FechaPaso = instanteFechaPaso;
                    Console.WriteLine("¿Quieres acceder a la puerta norte? (S/N)");
                    char opcionUsu = Convert.ToChar(Console.ReadLine());

                    if(opcionUsu.Equals('S') )
                    {
                        if (puerta.Matrícula.Equals(matricula) && puerta.ZonaDestino == "norte" && puerta.EsValido == 'S' && puerta.TipVehiculo == 'F' || puerta.TipVehiculo == 'A' )
                        {
                            Console.WriteLine("Tienes acceso a la puerta EN");
                        }
                        else
                        {
                            Console.WriteLine("No tienes acceso a la puerta EN");
                        }
                    }
                }
             else
                {
                    Console.WriteLine("No tiene acceso a la puerta SE");
                }
            }
            }

        public void accesoPuertaOeste(List<PuertaDto> listaPuertas)
        {
            Console.WriteLine("Introduzca la matricula");
            string matricula = Console.ReadLine();

            foreach (PuertaDto puerta in listaPuertas)
            {
                if (puerta.Matrícula.Equals(matricula) && puerta.TipVehiculo == 'P' && puerta.ZonaDestino == "oeste")
                {
                    Console.WriteLine("Tienes acceso a la puerta SO");
                    DateTime instanteFechaPaso = DateTime.Now;
                    puerta.FechaPaso = instanteFechaPaso;
                }
                else
                {
                    Console.WriteLine("No tiene acceso a la puerta SO");
                }
            }
        }

        public int accesoPuertasPrincipal()
        {
           
            int opcionAccesoPuertas;
            Console.WriteLine("[PUERTA PRINCIPAL S]");
            Console.WriteLine("0. Volver");
            Console.WriteLine("1. Acceso a la puerta SE");
            Console.WriteLine("2. Acceso a la puerta SO");
            Console.WriteLine("3. Acceso a la puerta sur");
            opcionAccesoPuertas = Convert.ToInt32(Console.ReadLine());
            return opcionAccesoPuertas;
        }

        public void accesoPuertaSur(List<PuertaDto> listaPuertas)
        {
            Console.WriteLine("Introduzca la matricula");
            string matricula = Console.ReadLine();

            foreach (PuertaDto puerta in listaPuertas)
            {
                if (puerta.Matrícula.Equals(matricula) && puerta.ZonaDestino == "norte" && puerta.Mercancia == 'N' && puerta.TipVehiculo == 'F' || puerta.TipVehiculo == 'A' )
                {
                    Console.WriteLine("Tienes acceso a la puerta SN");
                    DateTime instanteFechaPaso = DateTime.Now;
                    puerta.FechaPaso = instanteFechaPaso;
                    Console.WriteLine("¿Quieres acceder a la puerta norte? (S/N)");
                    char opcionUsu = Convert.ToChar(Console.ReadLine());

                    if (opcionUsu.Equals('S'))
                    {
                        if (puerta.Matrícula.Equals(matricula) && puerta.ZonaDestino == "norte" && puerta.EsValido == 'S' && puerta.TipVehiculo == 'F' || puerta.TipVehiculo == 'A')
                        {
                            Console.WriteLine("Tienes acceso a la puerta EN");
                        }
                        else
                        {
                            Console.WriteLine("No tienes acceso a la puerta EN");
                        }
                    }
                }
                else
                {
                    Console.WriteLine("No tiene acceso a la puerta");
                }
            }
        }

        public int mostrarMenuYSeleccion()
        {
            int opcion;
            Console.WriteLine("0. Cerrar menu");
            Console.WriteLine("1. Dar alta vehiculo");
            Console.WriteLine("2. Acceso a puertas");
            opcion = Convert.ToInt32(Console.ReadLine());

            return opcion;
        }

       
            
        
    }
}
