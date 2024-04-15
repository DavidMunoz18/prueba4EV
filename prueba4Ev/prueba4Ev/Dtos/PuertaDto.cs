using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prueba4Ev.Dtos
{
    /// <summary>
    /// Clase que contiene todos los datos relacionados con los controles de las puertas
    /// <author>dmp - 15/04/24</author>
    /// </summary>
    internal class PuertaDto
    {
        long idEntrada;
        string matrícula = "aaaaa";
        char tipVehiculo = 'a';
        string zonaDestino = "aaaaa";
        char mercancia = 'a';
        char esValido = 'a';
        DateTime fechaPaso = DateTime.Now;

        public long IdEntrada { get => idEntrada; set => idEntrada = value; }
        public string Matrícula { get => matrícula; set => matrícula = value; }
        public char TipVehiculo { get => tipVehiculo; set => tipVehiculo = value; }
        public string ZonaDestino { get => zonaDestino; set => zonaDestino = value; }
        public char Mercancia { get => mercancia; set => mercancia = value; }
        public DateTime FechaPaso { get => fechaPaso; set => fechaPaso = value; }
        public char EsValido { get => esValido; set => esValido = value; }

        public PuertaDto()
        {
        }

        public PuertaDto(string matrícula, char tipVehiculo, string zonaDestino, char mercancia, char esValido, DateTime fechaPaso)
        {
            this.matrícula = matrícula;
            this.tipVehiculo = tipVehiculo;
            this.zonaDestino = zonaDestino;
            this.mercancia = mercancia;
            this.esValido = esValido;
            this.fechaPaso = fechaPaso;
        }
    }
}
