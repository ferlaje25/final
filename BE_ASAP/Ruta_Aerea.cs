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
    
    public partial class Ruta_Aerea
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Ruta_Aerea()
        {
            this.Det_Ruta_Aerea = new HashSet<Det_Ruta_Aerea>();
            this.Det_Ruta_Aerea1 = new HashSet<Det_Ruta_Aerea>();
            this.Det_Ruta_Aerea2 = new HashSet<Det_Ruta_Aerea>();
            this.Det_Ruta_Aerea3 = new HashSet<Det_Ruta_Aerea>();
        }
    
        public int Id_Ruta_Aerea { get; set; }
        public Nullable<decimal> Kilometraje { get; set; }
        public Nullable<decimal> Tiempo { get; set; }
        public string Estado { get; set; }
        public Nullable<int> Id_Tipo_Ruta { get; set; }
        public Nullable<int> Id_Ubigeo_Origen { get; set; }
        public Nullable<int> Id_Ubigeo_Destino { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Det_Ruta_Aerea> Det_Ruta_Aerea { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Det_Ruta_Aerea> Det_Ruta_Aerea1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Det_Ruta_Aerea> Det_Ruta_Aerea2 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Det_Ruta_Aerea> Det_Ruta_Aerea3 { get; set; }
        public virtual Tipo_Ruta Tipo_Ruta { get; set; }
        public virtual Ubigeo Ubigeo { get; set; }
        public virtual Ubigeo Ubigeo1 { get; set; }
    }
}
