//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace lad.org.entities2
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
