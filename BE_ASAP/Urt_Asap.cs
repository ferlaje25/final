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
    
    public partial class Urt_Asap
    {
        public int Id_Urt_Asap { get; set; }
        public string Tipo_Resultado { get; set; }
        public Nullable<System.DateTime> Fecha_Resolucion { get; set; }
        public string Estado { get; set; }
        public Nullable<int> Id_Avion { get; set; }
    
        public virtual Avion Avion { get; set; }
    }
}
