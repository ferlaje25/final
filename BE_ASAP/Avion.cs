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
    
    public partial class Avion
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Avion()
        {
            this.Asiento = new HashSet<Asiento>();
            this.Mantenimiento = new HashSet<Mantenimiento>();
            this.Programacion_vuelo = new HashSet<Programacion_vuelo>();
            this.Reg_Cambios_Vuelo = new HashSet<Reg_Cambios_Vuelo>();
            this.Registro_Avion_ASAP = new HashSet<Registro_Avion_ASAP>();
            this.Urt_Asap = new HashSet<Urt_Asap>();
        }
    
        public int Id_Avion { get; set; }
        public string Nomb_Fabricante { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Numero_Placa { get; set; }
        public Nullable<int> Cantidad_Pasajeros { get; set; }
        public Nullable<int> Numero_Motores { get; set; }
        public Nullable<System.DateTime> Fecha_Fabricacion { get; set; }
        public Nullable<decimal> Peso_Bruto { get; set; }
        public Nullable<decimal> Peso_Neto { get; set; }
        public string Estado { get; set; }
        public Nullable<decimal> Tiempo_Recorrido { get; set; }
        public Nullable<decimal> Kilometraje { get; set; }
        public Nullable<int> Id_Aerolinea { get; set; }
        public Nullable<int> Id_Servicio { get; set; }
        public Nullable<int> Id_Contrato_Alquiler { get; set; }
    
        public virtual Aerolinea Aerolinea { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Asiento> Asiento { get; set; }
        public virtual Contrato_Alquiler Contrato_Alquiler { get; set; }
        public virtual Servicio Servicio { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Mantenimiento> Mantenimiento { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Programacion_vuelo> Programacion_vuelo { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Reg_Cambios_Vuelo> Reg_Cambios_Vuelo { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Registro_Avion_ASAP> Registro_Avion_ASAP { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Urt_Asap> Urt_Asap { get; set; }
    }
}
