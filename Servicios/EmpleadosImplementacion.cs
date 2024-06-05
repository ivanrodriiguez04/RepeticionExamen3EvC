using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepeticionExamen3Ev.Servicios
{
    /// <summary>
    /// Clase que implementa a la interfaz de los empleados
    /// irodhan -> 05/06/2024
    /// </summary>
    internal class EmpleadosImplementacion:EmpleadosInterfaz
    {
        public void submenuEmpleados()
        {
            //Objetos
            MenuInterfaz mI = new MenuImplementacion();
            //Variables
            int opcion = 0;
            bool cerrarMenu = false;
            do
            {
                opcion = mI.mostrarMenuYSeleccionEmpleados();
                switch (opcion)
                {

                }
            } while (!cerrarMenu);

        }
    }
}
