//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace lad.org.domain
{
    using System;
    using System.Collections.Generic;
    
    public partial class Ingreso
    {
        public int Codigo_Ingreso { get; set; }
        public int Codigo_Producto { get; set; }
        public System.DateTime Fecha_Ingreso { get; set; }
        public string Tipo_Comprobante { get; set; }
        public int Cantidad { get; set; }
        public System.DateTime FechaVen { get; set; }
        public decimal Total { get; set; }
    
        public virtual Producto Producto { get; set; }
    }
}
