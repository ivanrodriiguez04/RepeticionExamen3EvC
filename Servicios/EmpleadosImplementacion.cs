using Microsoft.VisualBasic;
using RepeticionExamen3Ev.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
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
        public void anadirVentas() 
        {
            VentasDto venta = crearVenta();
            Controladores.Program.listaVentas.Add(venta);
        }
        /// <summary>
        /// Metodo que crea la una venta
        /// irodhan -> 10/06/2024
        /// </summary>
        /// <returns>Devuelve un objeto venta con la informacion necesaria</returns>
        private VentasDto crearVenta() 
        { 
            VentasDto venta = new VentasDto();
            venta.IdVenta = Utils.Utilidades.asignarIdVenta();
            Console.WriteLine("Introduce el total de la venta: ");
            venta.EurosVentas=Convert.ToInt32(Console.ReadLine());
            venta.InstanteVenta=DateTime.Now;
            return venta;
        }
        public void calculoVentas() 
        {
            Console.WriteLine("Introduzca el dia que necesita(dd-MM-yyyy): ");
            string fecha=Console.ReadLine();

        }
        

    }
}
