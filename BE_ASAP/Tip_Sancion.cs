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
    
    public partial class Tip_Sancion
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Tip_Sancion()
        {
            this.Sancion = new HashSet<Sancion>();
        }
    
        public int Id_Tip_Sancion { get; set; }
        public string Descripcion { get; set; }
        public string Estado { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Sancion> Sancion { get; set; }
    }
}
