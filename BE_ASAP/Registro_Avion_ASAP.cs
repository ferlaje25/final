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
    
    public partial class Registro_Avion_ASAP
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Registro_Avion_ASAP()
        {
            this.Autorizacion_Operar = new HashSet<Autorizacion_Operar>();
        }
    
        public int Id_Reg_Avion_ASAP { get; set; }
        public Nullable<System.DateTime> Fecha_Registro { get; set; }
        public string Estado_Propio { get; set; }
        public string Estado { get; set; }
        public Nullable<int> Id_Avion { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Autorizacion_Operar> Autorizacion_Operar { get; set; }
        public virtual Avion Avion { get; set; }
    }
}
