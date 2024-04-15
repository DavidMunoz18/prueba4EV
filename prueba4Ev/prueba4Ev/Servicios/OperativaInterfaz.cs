using prueba4Ev.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prueba4Ev.Servicios
{
    /// <summary>
    /// Clase que contiene los metodos relacionados con dar de alta
    /// <author>dmp - 15/04/24</author>
    /// </summary>
    internal interface OperativaInterfaz
    {
        /// <summary>
        /// Metodo que da de alta un nuevo vehiculo en el control
        /// <author>dmp - 15/04/24</author>
        /// </summary>
        /// <param name="listaPuertas"></param>
        public void darAltaVehiculo(List<PuertaDto> listaPuertas);
    }
}
