//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace audiovisalParcial.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class empleado
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public empleado()
        {
            this.rentaDevolucions = new HashSet<rentaDevolucion>();
        }
    
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Cedula { get; set; }
        public string TandaLabor { get; set; }
        public Nullable<System.DateTime> FechaIngreso { get; set; }
        public Nullable<int> Estado { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<rentaDevolucion> rentaDevolucions { get; set; }
    }
}