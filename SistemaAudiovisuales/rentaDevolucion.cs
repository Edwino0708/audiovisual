//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SistemaAudiovisuales
{
    using System;
    using System.Collections.Generic;
    
    public partial class rentaDevolucion
    {
        public int NoPrestamo { get; set; }
        public int Empleado { get; set; }
        public int Equipo { get; set; }
        public int Usuario { get; set; }
        public System.DateTime FechaPrestamo { get; set; }
        public Nullable<System.DateTime> FechaDevolucion { get; set; }
        public string Comentario { get; set; }
        public Nullable<int> Estado { get; set; }
    
        public virtual empleado empleado1 { get; set; }
        public virtual equipos equipos { get; set; }
        public virtual usuario usuario1 { get; set; }
    }
}
