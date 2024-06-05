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
        public static long asignarIdPedido() 
        {
            int tamanyoLista = Controladores.Program.listaPedidos.Count;
            long id;
            if (tamanyoLista>0) 
            { 
                id= Controladores.Program.listaPedidos[tamanyoLista-1].IdPedido+1;
            }
            else 
            {
                id = 1;
            }
            return id;
        }
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
    }
}
