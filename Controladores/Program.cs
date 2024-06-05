using RepeticionExamen3Ev.Dtos;
using RepeticionExamen3Ev.Servicios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepeticionExamen3Ev.Controladores
{
    /// <summary>
    /// Clase principal de la aplicacion
    /// irodhan -> 05/06/2024
    /// </summary>
    internal class Program
    {
        //Atributos
        public static List<PedidosDto> listaPedidos=new List<PedidosDto>();
        public static List<VentasDto> listaVentas=new List<VentasDto>();
        public static string rutaFichero = "C:\\Users\\csi22-irodhan\\Desktop\\Programacion\\Recuperacion\\RepeticionExamen3Ev\\Ficheros\\ficheroPedidos.txt";
        /// <summary>
        /// Metodo principal de la aplicacion
        /// irodhan -> 05/06/2024
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args) 
        { 
            //Objetos
            MenuInterfaz mI = new MenuImplementacion();
            GerenciaInterfaz gI= new GerenciaImplementacion();
            EmpleadosInterfaz eI = new EmpleadosImplementacion();
            //Variables
            int opcionSeleccionada = 0;
            int opcion = 0; 
            bool cerrarMenu=false;
            //Bucle do...while
            do
            {
                try 
                {
                    opcionSeleccionada = mI.mostrarMenuYSeleccion();
                    switch ( opcionSeleccionada ) 
                    { 
                        case 0:
                            Console.WriteLine("[INFO] - Ha seleccionado la opcion 0");
                            Console.WriteLine("[INFO] - Se va a cerrar la aplicacion");
                            cerrarMenu = true;
                            break;
                        case 1:
                            Console.WriteLine("[INFO] - Ha seleccionado la opcion 1");
                            Console.WriteLine("[INFO] - Ha seleccionado el menu de gerencia");
                            gI.subMenuGerencia();
                            break; 
                        case 2:
                            Console.WriteLine("[INFO] - Ha seleccionado la opcion 2");
                            Console.WriteLine("[INFO] - Ha seleccionado el menu de empleados");
                            eI.submenuEmpleados();
                            break;
                        default:
                            Console.WriteLine("[INFO] - La opcion indicada no coincide con ninguna opcion mostrada anteriormente.");
                            break;
                    }
                } 
                catch( Exception ex ) 
                { 
                    Console.WriteLine(ex.Message);
                }
            } while (!cerrarMenu);
        }
    }
}
