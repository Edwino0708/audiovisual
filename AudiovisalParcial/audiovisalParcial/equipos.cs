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
    
    public partial class equipos
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public equipos()
        {
            this.rentaDevolucion = new HashSet<rentaDevolucion>();
        }
    
        public int Id { get; set; }
        public string Descripcion { get; set; }
        public string Noserial { get; set; }
        public string ServiceTag { get; set; }
        public int TipoEquipo { get; set; }
        public int Marca { get; set; }
        public int Modelo { get; set; }
        public int TecnologiaConexion { get; set; }
        public Nullable<int> Estado { get; set; }
    
        public virtual marcas marcas { get; set; }
        public virtual modelos modelos { get; set; }
        public virtual tecnologias_conexion tecnologias_conexion { get; set; }
        public virtual tipo_equipos tipo_equipos { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<rentaDevolucion> rentaDevolucion { get; set; }
    }
}