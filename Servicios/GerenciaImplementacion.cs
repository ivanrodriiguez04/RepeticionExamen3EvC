using RepeticionExamen3Ev.Dtos;
using RepeticionExamen3Ev.Servicios;
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
        public void nuevoPedido() 
        {
            //Variables
            string confirmacion = "n";
            do
            {
                PedidosDto pedido = crearPedido();
                Controladores.Program.listaPedidos.Add(pedido);
                Console.WriteLine("Quiero hacer otro pedido:(s=si || n=no)");
                confirmacion = Console.ReadLine();
            } while (confirmacion == "s");
            foreach (PedidosDto pedido in Controladores.Program.listaPedidos) 
            {
                Console.WriteLine(pedido.ToString());
            }
            
        }
        /// <summary>
        /// Metodo que crea un nuevo pedido
        /// irodhan -> 05/06/2024
        /// </summary>
        /// <returns>Devuelve un objeto con toda la informacion necesaria del pedido</returns>
        private PedidosDto crearPedido() 
        {
            PedidosDto nuevoPedido = new PedidosDto();
            nuevoPedido.IdPedido = Utils.Utilidades.asignarIdPedido();
            Console.WriteLine("Introduce el nombre del producto: ");
            nuevoPedido.NombreProducto = Console.ReadLine();
            Console.WriteLine("Introduce la cantidad del producto: ");
            nuevoPedido.CantidadProducto = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Introduce la fecha de entrega deseada(dd-MM-yyyy): ");
            nuevoPedido.FchDeseadaEntrega = Convert.ToDateTime(Console.ReadLine());
            return nuevoPedido;
        }

        public void mostrarVentas()
        {
            FicheroInterfaz fI = new FicheroImplementacion();
            Console.WriteLine("Indica la fecha deseada(dd-MM-yyyy): ");
            DateTime fecha = Convert.ToDateTime(Console.ReadLine());
            foreach (VentasDto venta in Controladores.Program.listaVentas)
            {
               DateTime fch = venta.InstanteVenta;
                if (fch.ToString("dd-MM-yyyy")==fecha.ToString("dd-MM-yyyy"))
                {
                    Console.WriteLine(venta.ToString());
                    fI.escribirFichero(fecha);
                    
                }
            }


        }
    }
}
