using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepeticionExamen3Ev.Servicios
{
    /// <summary>
    /// Clase que implementa a la interfaz de los menus de la aplicacion
    /// irodhan -> 05/06/2024
    /// </summary>
    internal class MenuImplementacion : MenuInterfaz
    {
        public int mostrarMenuYSeleccion()
        {
            int opcion = 0;
            Console.WriteLine("|-----------------------|");
            Console.WriteLine("|     Menu principal    |");
            Console.WriteLine("|-----------------------|");
            Console.WriteLine("| 0. Cerrar Aplicacion  |");
            Console.WriteLine("| 1. Menu Gerencia      |");
            Console.WriteLine("| 2. Menu Empleados     |");
            Console.WriteLine("|-----------------------|");
            Console.WriteLine("Introduzca la opcion que desea usar: ");
            opcion=Console.ReadKey(true).KeyChar - ('0');
            return opcion;
        }

        public int mostrarMenuYSeleccionEmpleados()
        {
            int opcion = 0;
            Console.WriteLine("|--------------------------------|");
            Console.WriteLine("|         Menu Empleados         |");
            Console.WriteLine("|--------------------------------|");
            Console.WriteLine("| 0. Volver al menu principal    |");
            Console.WriteLine("| 1. Añadir ventas               |");
            Console.WriteLine("| 2. Calculo total ventas diario |");
            Console.WriteLine("|--------------------------------|");
            Console.WriteLine("Introduzca la opcion que desea usar: ");
            opcion = Console.ReadKey(true).KeyChar - ('0');
            return opcion;
        }

        public int mostrarMenuYSeleccionGerencia()
        {
            int opcion = 0;
            Console.WriteLine("|------------------------------------------------|");
            Console.WriteLine("|                  Menu Gerencia                 |");
            Console.WriteLine("|------------------------------------------------|");
            Console.WriteLine("| 0. Volver al menu principal                    |");
            Console.WriteLine("| 1. Mostrar ventas del dia y guardar en fichero |");
            Console.WriteLine("| 2. Nuevo pedido a los proveedores              |");
            Console.WriteLine("|------------------------------------------------|");
            Console.WriteLine("Introduzca la opcion que desea usar: ");
            opcion = Console.ReadKey(true).KeyChar - ('0');
            return opcion;
        }
    }
}
