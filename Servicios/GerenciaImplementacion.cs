using RepeticionExamen3Ev.Dtos;
using RepeticionExamen3Ev.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepeticionExamen3Ev.Servicios
{
    /// <summary>
    /// Clase que implementa a la interfaz de las operaciones realizadas en la aplicacion
    /// irodhan -> 05/06/2024
    /// </summary>
    internal class GerenciaImplementacion : GerenciaInterfaz
    {
        public void subMenuGerencia()
        {
            //Objetos
            MenuInterfaz mI = new MenuImplementacion();
            FicheroInterfaz fI = new FicheroImplementacion();
            //Variables
            int opcion = 0;
            bool cerrarMenu = false;
            do
            {
                opcion = mI.mostrarMenuYSeleccionGerencia();
                switch (opcion)
                {
                    case 0:
                        Console.WriteLine("[INFO] - Ha seleccionado la opcion 0");
                        Console.WriteLine("[INFO] - Se va a volver al menu princìpal");
                        cerrarMenu = true;
                        break;
                    case 1:
                        Console.WriteLine("[INFO] - Ha seleccionado la opcion 1");
                        fI.escribirFichero();
                        break;
                    case 2:
                        Console.WriteLine("[INFO] - Ha seleccionado la opcion 2");
                        nuevoPedido();
                        break;
                    default:
                        Console.WriteLine("[INFO] - La opcion seleccionada no coincide con ninguna opcion mostrada anteriormente");
                        break;
                }
            } while (!cerrarMenu);
        }

        private void nuevoPedido() 
        {
            PedidosDto pedido = crearPedido();
            Controladores.Program.listaPedidos.Add(pedido);
        }
        private PedidosDto crearPedido() 
        { 
            //Variables
            char confirmacion = 'a';
            do 
            {
                PedidosDto nuevoPedido = new PedidosDto();
                nuevoPedido.IdPedido = Utils.Utilidades.asignarIdPedido();
                Console.WriteLine("Introduce el nombre del producto: ");
                nuevoPedido.NombreProducto = Console.ReadLine();
                Console.WriteLine("Introduce la cantidad del producto: ");
                nuevoPedido.CantidadProducto=Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Introduce la fecha de entrega deseada(dd/MM/yyyy): ");
                nuevoPedido.FchDeseadaEntrega = Console.ReadLine();
                Console.WriteLine("Quiero hacer otro pedido:(s=si || n=no)");
                confirmacion=Convert.ToChar(Console.ReadLine());
                return nuevoPedido;
            } while (confirmacion == 's');
        }
    }
}
