//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace audiovisalParcial
{
    using System;
    using System.Collections.Generic;
    
    public partial class usuarios
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public usuarios()
        {
            this.rentaDevolucion = new HashSet<rentaDevolucion>();
        }
    
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Cedula { get; set; }
        public string NoCarnet { get; set; }
        public string TipoUsuario { get; set; }
        public string TipoPersona { get; set; }
        public Nullable<int> Estado { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<rentaDevolucion> rentaDevolucion { get; set; }
    }
}
