using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace RepeticionExamen3Ev.Utils
{
    /// <summary>
    /// Clase que contiene las utilidades de la aplicacion
    /// irodhan -> 05/06/2024
    /// </summary>
    internal static class Utilidades
    {
        /// <summary>
        /// Metodo que asigna el id a cada pedido que se realize
        /// irodhan -> 10/06/2024
        /// </summary>
        /// <returns>Devuelve el id asignado al pedido</returns>
        public static long asignarIdPedido()
        {
            int tamanyoLista = Controladores.Program.listaPedidos.Count;
            long id;
            if (tamanyoLista > 0)
            {
                id = Controladores.Program.listaPedidos[tamanyoLista - 1].IdPedido + 1;
            }
            else
            {
                id = 1;
            }
            return id;
        }
        /// <summary>
        /// Metodo que asigna el id a cada venta que se realize
        /// irodhan -> 10/06/2024
        /// </summary>
        /// <returns>Devuelve el id asignado a la venta</returns>
        public static long asignarIdVenta()
        {
            int tamanyoLista = Controladores.Program.listaVentas.Count;
            long id;
            if (tamanyoLista > 0)
            {
                id = Controladores.Program.listaVentas[tamanyoLista - 1].IdVenta + 1;
            }
            else
            {
                id = 1;
            }
            return id;
        }
        /// <summary>
        /// Metodo que crea la ruta completa de la creacion del fichero
        /// irodhan -> 11/06/2024
        /// </summary>
        /// <returns>Devuelve el nombre del fichero</returns>
        public static string rutaFicheroCompleta(DateTime fecha) 
        {
            string rutaFichero = "aaaaa";
            string fch=fecha.ToString("ddMMyyyy");
            rutaFichero = string.Concat(Controladores.Program.rutaFichero,fch,".txt");
            return rutaFichero;
        
        }
    }
}
