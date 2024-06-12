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
            double aux = 0;
            Console.WriteLine("Introduzca el dia que necesita(dd-MM-yyyy): ");
            string fecha=Console.ReadLine();
            foreach(VentasDto venta in Controladores.Program.listaVentas) 
            {
                if (fecha == venta.InstanteVenta.ToString("dd-MM-yyyy")) 
                {
                    aux = aux + venta.EurosVentas;
                }
            }
            for (int fila = 0; fila < Controladores.Program.listaVentas.Count; fila++) 
            {
                for (int columna = 0; columna < Controladores.Program.listaVentas.Count-1-fila; columna++) 
                {
                    if (Controladores.Program.listaVentas[columna + 1].InstanteVenta > Controladores.Program.listaVentas[columna].InstanteVenta) 
                    { 
                        VentasDto auxiliar=Controladores.Program.listaVentas[columna+1];
                    }
                }
            }

            Console.WriteLine(string.Concat("Total ventas: ",aux));

        }
        

    }
}
