using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepeticionExamen3Ev.Servicios
{
    /// <summary>
    /// Interfaz de los menus de la aplicacion
    /// irodhan -> 05/06/2024
    /// </summary>
    internal interface MenuInterfaz
    {
        /// <summary>
        /// Metodo que muestra el menu principal de la aplicacion y obtiene la opcion indicada por el usuario
        /// irodhan -> 05/06/2024
        /// </summary>
        /// <returns>Devuelve la opcion indicada por el usuario</returns>
        public int mostrarMenuYSeleccion();

        /// <summary>
        /// Metodo que muestra el menu de la gerencia de la aplicacion
        /// irodhan -> 05/06/2024
        /// </summary>
        /// <returns>Devuelve la opcion indicada por el usuario</returns>
        public int mostrarMenuYSeleccionGerencia();

        /// <summary>
        /// Metodo que muestra el menu de los empleados de la aplicacion
        /// irodhan -> 05/06/2024
        /// </summary>
        /// <returns>Devuelve la opcion indicada por el usuario</returns>
        public int mostrarMenuYSeleccionEmpleados();

    }
}
