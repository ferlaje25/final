//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BE_ASAP
{
    using System;
    using System.Collections.Generic;
    
    public partial class Det_Servicio
    {
        public int Id_Det_Servicio { get; set; }
        public Nullable<System.DateTime> Fecha_Registro { get; set; }
        public string Tipo { get; set; }
        public Nullable<System.DateTime> Fecha_Actualizacion { get; set; }
        public string Estado_Actividad { get; set; }
        public Nullable<int> Id_Aerolinea { get; set; }
        public Nullable<int> Id_Servicio { get; set; }
        public Nullable<int> Id_Empleado { get; set; }
    
        public virtual Aerolinea Aerolinea { get; set; }
        public virtual Empleado Empleado { get; set; }
        public virtual Servicio Servicio { get; set; }
    }
}
