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
    
    public partial class Cliente
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Cliente()
        {
            this.Reserva_Pasaje = new HashSet<Reserva_Pasaje>();
            this.Venta_Pasajes = new HashSet<Venta_Pasajes>();
        }
    
        public int Id_Cliente { get; set; }
        public string Nomb_Cliente { get; set; }
        public string Ape_Cliente { get; set; }
        public string Num_Documento { get; set; }
        public string Direccion { get; set; }
        public Nullable<System.DateTime> Fecha_nacimiento { get; set; }
        public string Sexo { get; set; }
        public Nullable<int> Telefono { get; set; }
        public string Estado { get; set; }
        public Nullable<int> Id_Tipo_Documento { get; set; }
        public Nullable<int> Id_Ubigeo { get; set; }
    
        public virtual Tipo_Documento Tipo_Documento { get; set; }
        public virtual Ubigeo Ubigeo { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Reserva_Pasaje> Reserva_Pasaje { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Venta_Pasajes> Venta_Pasajes { get; set; }
    }
}