using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppDemoJulio.Models
{
    public class Ordenes
    {
        public string? Instrumento { get; set; }
        public decimal? Precio { get; set; }

        public string? TipoPrecio { get; set; }
        public int? Cantidad { get; set; }

        public decimal Costo { get;set;}
        public decimal Tax { get;set;}
        public decimal Total { get;set;}


        public void CalcularOrden()
        {
            Costo = (decimal)(Precio * Cantidad);
            Tax = Costo * 0.18m;
            Total = Costo + Tax;
        }
        
    }
}