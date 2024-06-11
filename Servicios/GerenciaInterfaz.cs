using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepeticionExamen3Ev.Servicios
{
    /// <summary>
    /// Interfaz de las operaciones que se realicen en la aplicacion
    /// irodhan -> 05/06/2024
    /// </summary>
    internal interface GerenciaInterfaz
    {
        /// <summary>
        /// Metodo que añade un nuevo pedido a la lista
        /// irodhan -> 5/06/2024
        /// </summary>
        public void nuevoPedido();
        /// <summary>
        /// Metodo que muestra las ventas de un dia en especifico
        /// irodhan -> 10/06/2024
        /// </summary>
        public void mostrarVentas();


    }
}
