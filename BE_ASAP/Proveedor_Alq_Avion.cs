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
    
    public partial class Proveedor_Alq_Avion
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Proveedor_Alq_Avion()
        {
            this.Contrato_Alquiler = new HashSet<Contrato_Alquiler>();
        }
    
        public int Id_Provee_Alq_Avion { get; set; }
        public string Razon_Social { get; set; }
        public string Num_Documento { get; set; }
        public string Direccion { get; set; }
        public string Representante_Legal { get; set; }
        public Nullable<int> Telefono { get; set; }
        public string Estado { get; set; }
        public Nullable<int> Id_Ubigeo { get; set; }
        public Nullable<int> Id_Tipo_Documento { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Contrato_Alquiler> Contrato_Alquiler { get; set; }
        public virtual Tipo_Documento Tipo_Documento { get; set; }
        public virtual Ubigeo Ubigeo { get; set; }
    }
}
