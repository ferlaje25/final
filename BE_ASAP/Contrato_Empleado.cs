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
    
    public partial class Contrato_Empleado
    {
        public int Id_Contrato_Emp { get; set; }
        public Nullable<System.DateTime> Fecha_Inicio { get; set; }
        public Nullable<System.DateTime> Fecha_Fin { get; set; }
        public string Estado { get; set; }
        public Nullable<int> Id_Empleado { get; set; }
        public Nullable<int> Id_Area { get; set; }
        public Nullable<int> Id_Rol { get; set; }
        public string Tipo_Empresa { get; set; }
        public Nullable<int> Id_Agencia { get; set; }
        public Nullable<int> Id_Aerolinea { get; set; }
    
        public virtual Aerolinea Aerolinea { get; set; }
        public virtual Agencia_Viaje Agencia_Viaje { get; set; }
        public virtual Area Area { get; set; }
        public virtual Empleado Empleado { get; set; }
        public virtual Rol Rol { get; set; }
    }
}
