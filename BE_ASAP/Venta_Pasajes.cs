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
    
    public partial class Venta_Pasajes
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Venta_Pasajes()
        {
            this.Comprobante_Venta = new HashSet<Comprobante_Venta>();
            this.Det_Venta = new HashSet<Det_Venta>();
        }
    
        public int Id_Venta_Pasajes { get; set; }
        public Nullable<System.DateTime> Fecha_Venta { get; set; }
        public Nullable<decimal> Precio_Total { get; set; }
        public string Divisa { get; set; }
        public Nullable<int> Cantidad_Pasajes { get; set; }
        public Nullable<int> Id_Reserva_Pasaje { get; set; }
        public Nullable<int> Id_Cliente { get; set; }
        public Nullable<int> Id_Agencia_Viaje { get; set; }
        public Nullable<int> Id_Medio_Compra { get; set; }
        public Nullable<int> Id_Empleado { get; set; }
        public Nullable<int> Id_Tipo_Pago { get; set; }
        public Nullable<int> Id_Asiento { get; set; }
        public Nullable<int> Id_Aerolinea { get; set; }
    
        public virtual Aerolinea Aerolinea { get; set; }
        public virtual Agencia_Viaje Agencia_Viaje { get; set; }
        public virtual Asiento Asiento { get; set; }
        public virtual Cliente Cliente { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Comprobante_Venta> Comprobante_Venta { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Det_Venta> Det_Venta { get; set; }
        public virtual Empleado Empleado { get; set; }
        public virtual Medio_Compra Medio_Compra { get; set; }
        public virtual Reserva_Pasaje Reserva_Pasaje { get; set; }
        public virtual Tipo_Pago Tipo_Pago { get; set; }
    }
}
