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
    
    public partial class Rol_Tripulacion
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Rol_Tripulacion()
        {
            this.Det_Progra_Tripulacion = new HashSet<Det_Progra_Tripulacion>();
        }
    
        public int Id_Rol_Trip { get; set; }
        public string Descripcion { get; set; }
        public string Estado { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Det_Progra_Tripulacion> Det_Progra_Tripulacion { get; set; }
    }
}
