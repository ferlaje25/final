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
    
    public partial class Tipo_Pago
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Tipo_Pago()
        {
            this.Venta_Pasajes = new HashSet<Venta_Pasajes>();
        }
    
        public int Id_Tipo_Pago { get; set; }
        public string Descripcion { get; set; }
        public string Estado { get; set; }
        public Nullable<int> Id_Tarjeta { get; set; }
    
        public virtual Tarjeta Tarjeta { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Venta_Pasajes> Venta_Pasajes { get; set; }
    }
}
