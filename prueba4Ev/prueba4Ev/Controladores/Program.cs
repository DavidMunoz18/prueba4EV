using prueba4Ev.Dtos;
using prueba4Ev.Servicios;

namespace prueba4Ev.Controladores
{
    /// <summary>
    /// Clase principal de la aplicación
    /// <author>dmp - 15/04/24</author>
    /// </summary>
    class program
    {
        /// <summary>
        /// Metodo de entrada y salida de la aplicacion
        /// <author>dmp - 15/04/24</author>
        /// </summary>
        /// <param name="args"></param>
        public static void Main(string[] args)
        {
            MenuInterfaz mi = new MenuImplementacion();
            OperativaInterfaz oi = new OperativaImplementacion();
            List<PuertaDto> listaPuertas = new List<PuertaDto>();

            DateTime fechaHoy = DateTime.Today;

            string ruta = fechaHoy.ToString("dd-MM-yyyy");

            bool cerrarMenu = false;
            int opcion;
            while(!cerrarMenu)
            {
                opcion = mi.mostrarMenuYSeleccion();
                switch (opcion)
                {
                    case 0:
                        foreach (PuertaDto puerta in listaPuertas)
                        {
                            using (StreamWriter sw = new StreamWriter(ruta, true))
                            {


                                sw.WriteLine(puerta.IdEntrada + ";" + puerta.Matrícula + ";" + puerta.TipVehiculo + ";" + puerta.ZonaDestino + ";" + puerta.Mercancia + ";" + puerta.EsValido + ";" + puerta.FechaPaso);


                            }
                        }
                        cerrarMenu = true;
                        break;
                    case 1:
                        oi.darAltaVehiculo(listaPuertas);
                        break;
                    case 2:
                        
                        int opcionPuertas = mi.accesoPuertasPrincipal();
                        switch (opcionPuertas)
                        {
                            case 1:
                                mi.accesoPuertaEste(listaPuertas);

                                break;
                            case 2:
                                mi.accesoPuertaOeste(listaPuertas);
                                break;
                            case 3:
                                mi.accesoPuertaSur(listaPuertas);
                                break;
                        }
                        break;

                    default:
                        Console.WriteLine("La opcion seleccionada no existe");
                        break;
                }
            }
        }
    }
}
