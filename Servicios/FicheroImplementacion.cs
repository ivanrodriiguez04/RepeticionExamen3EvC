using RepeticionExamen3Ev.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepeticionExamen3Ev.Servicios
{
    /// <summary>
    /// Clase que implementa a la interfaz de los ficheros
    /// irodhan -> 05/06/2024
    /// </summary>
    internal class FicheroImplementacion : FicheroInterfaz
    {
        public void escribirFichero()
        {
            StreamWriter sw = null;
            try
            {
                using (sw = new StreamWriter(Controladores.Program.rutaFichero))
                {
                    foreach (VentasDto ventas in Controladores.Program.listaVentas)
                    {
                        sw.WriteLine(ventas.ToString());
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally 
            {
                if (sw != null)
                {
                    sw.Close();
                }
            }
        }
    }
}
