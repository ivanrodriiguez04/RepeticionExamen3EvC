using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepeticionExamen3Ev.Dtos
{
    /// <summary>
    /// Clase que contiene los dtos de los pedidos
    /// irodhan -> 05/06/2024
    /// </summary>
    internal class PedidosDto
    {
        //Atributos
        private long idPedido;
        private string nombreProducto = "aaaaa";
        private int cantidadProducto = 0;
        private string fchDeseadaEntrega = "31/12/9999";
        //Controladores
        public PedidosDto(long idPedido, string nombreProducto, int cantidadProducto, string fchDeseadaEntrega)
        {
            this.IdPedido = idPedido;
            this.NombreProducto = nombreProducto;
            this.CantidadProducto = cantidadProducto;
            this.FchDeseadaEntrega = fchDeseadaEntrega;
        }
         public PedidosDto() { }
        //Getters & Setters
        public long IdPedido { get => idPedido; set => idPedido = value; }
        public string NombreProducto { get => nombreProducto; set => nombreProducto = value; }
        public int CantidadProducto { get => cantidadProducto; set => cantidadProducto = value; }
        public string FchDeseadaEntrega { get => fchDeseadaEntrega; set => fchDeseadaEntrega = value; }

        //Metodo ToString
        override
        public string ToString()
        {
            string concatenacion =string.Concat("Producto: ",this.nombreProducto,"\nCantidad: ",this.cantidadProducto,"\nFecha entrega: ",this.fchDeseadaEntrega);
            return concatenacion;
        }

    }
}
