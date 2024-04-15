using prueba4Ev.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prueba4Ev.Servicios
{
    /// <summary>
    /// Clase que contiene todos los metodos relacionados con el menu
    /// </summary>
    internal interface MenuInterfaz
    {
        /// <summary>
        /// Metodo que muestra el menu principal
        /// <author>dmp - 15/04/24</author>
        /// </summary>
        /// <returns></returns>
        public int mostrarMenuYSeleccion();

        /// <summary>
        /// Metodo que muestra el acceso a las puertas
        /// <author>dmp - 15/04/24</author>
        /// </summary>
        /// <returns></returns>
        public int accesoPuertasPrincipal();

        /// <summary>
        /// Metodo que valida si puedes entrar a la puerta este
        /// <author>dmp - 15/04/24</author>
        /// </summary>
        /// <param name="listaPuertas"></param>
        public void accesoPuertaEste(List<PuertaDto> listaPuertas);

        /// <summary>
        /// Metodo que valida si puedes entrar a la puerta oeste
        /// <author>dmp - 15/04/24</author>
        /// </summary>
        /// <param name="listaPuertas"></param>
        public void accesoPuertaOeste(List<PuertaDto> listaPuertas);

        /// <summary>
        /// Metodo que valida si puedes entrar a la puerta sur
        /// <author>dmp - 15/04/24</author>
        /// </summary>
        /// <param name="listaPuertas"></param>
        public void accesoPuertaSur(List<PuertaDto> listaPuertas);
    }
}
