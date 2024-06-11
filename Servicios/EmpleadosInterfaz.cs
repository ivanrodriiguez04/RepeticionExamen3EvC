using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepeticionExamen3Ev.Servicios
{
    /// <summary>
    /// Interfaz de los empleados en la aplicacion
    /// irodhan -> 05/06/2024
    /// </summary>
    internal interface EmpleadosInterfaz
    {
        /// <summary>
        /// Metodo que crea una venta y la guarda en la lista de ventas
        /// irodhan -> 10/06/2024
        /// </summary>
        public void anadirVentas();
        /// <summary>
        /// Metodo que hace el calculo total de ventas el dia indicado
        /// irodhan -> 10/06/2024
        /// </summary>
        public void calculoVentas();
    }
}
