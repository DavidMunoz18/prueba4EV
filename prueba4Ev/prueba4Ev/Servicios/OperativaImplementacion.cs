using prueba4Ev.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prueba4Ev.Servicios
{
    /// <summary>
    /// Clase que implementa los metodos de la operativa interfaz
    /// <author>dmp - 15/04/24</author>
    /// </summary>
    internal class OperativaImplementacion : OperativaInterfaz
    {
        public void darAltaVehiculo(List<PuertaDto> listaPuertas)
        {
            PuertaDto puerta = crearNuevoAcceso(listaPuertas);

            listaPuertas.Add(puerta);
        }
        private PuertaDto crearNuevoAcceso(List<PuertaDto> listaPuertas)
        { 

            PuertaDto puerta = new PuertaDto();

            
            puerta.IdEntrada = idAcceso(listaPuertas);

            Console.WriteLine("ID: " + puerta.IdEntrada);

            Console.WriteLine("Introduzca la matricula");
            puerta.Matrícula = Console.ReadLine();

            Console.WriteLine("Introduce el tipo de vehiculo (P/F/A)");
            puerta.TipVehiculo = Convert.ToChar(Console.ReadLine());

            Console.WriteLine("Introduzca la zona de destino (en minusculas)");
            puerta.ZonaDestino = Console.ReadLine();

            Console.WriteLine("Lleva mercancia (S/N)");
            puerta.Mercancia = Convert.ToChar(Console.ReadLine());

            Console.WriteLine("¿El vehiculo es valido? (S/N)");
            puerta.EsValido = Convert.ToChar(Console.ReadLine());
            

            return puerta; 
        }

        private long idAcceso(List<PuertaDto> listaPuertas)
        {
            long id;
            int tamanioLista = listaPuertas.Count;

            if(tamanioLista == 0)
            {
                id = 1;
            }
            else
            {
                id = listaPuertas[tamanioLista - 1].IdEntrada + 1;
            }
            return id;
        }
    }
}
