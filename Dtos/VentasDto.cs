using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepeticionExamen3Ev.Dtos
{
    /// <summary>
    /// Clase que contiene los dtos de las ventas
    /// irodhan -> 05/06/2024
    /// </summary>
    internal class VentasDto
    {
        //Atributos
        private long idVenta;
        private int eurosVentas=0;
        private DateTime instanteVenta = DateTime.Now;
        
        //Controladores
        public VentasDto(long idVenta, int eurosVentas, DateTime instanteVenta)
        {
            this.IdVenta = idVenta;
            this.EurosVentas = eurosVentas;
            this.InstanteVenta = instanteVenta;
        }
        public VentasDto() { }

        //Getters & Setters
        public long IdVenta { get => idVenta; set => idVenta = value; }
        public int EurosVentas { get => eurosVentas; set => eurosVentas = value; }
        public DateTime InstanteVenta { get => instanteVenta; set => instanteVenta = value; }

        //Metodo ToString
        override
        public string ToString()
        {
            string concatenacion = string.Concat(".......... \nVenta número: ",this.idVenta,"\nEuros: ",this.eurosVentas,"\nInstante de compra: ",this.instanteVenta,"\n..........");
            return concatenacion;
        }
    }
}
