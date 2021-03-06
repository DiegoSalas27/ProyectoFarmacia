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
    
    public partial class Producto
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Producto()
        {
            this.Ingreso = new HashSet<Ingreso>();
        }
    
        public int Codigo_Producto { get; set; }
        public string NombreProd { get; set; }
        public string Composicion { get; set; }
        public decimal Precio { get; set; }
        public int Stock { get; set; }
        public int Cantidad_Por_Unidad { get; set; }
        public int Marca { get; set; }
        public int Categoria { get; set; }
        public int Presentacion { get; set; }
        public int Laboratorio { get; set; }
    
        public virtual Categoria Categoria1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Ingreso> Ingreso { get; set; }
        public virtual Laboratorio Laboratorio1 { get; set; }
        public virtual Marca Marca1 { get; set; }
        public virtual Presentacion Presentacion1 { get; set; }
    }
}
