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
    
    public partial class DETALLE_DE_RUTA
    {
        public int Id_Det_Ruta_Aerea { get; set; }
        public Nullable<int> Id_Aerolinea { get; set; }
        public string TIPO_DE_RUTA { get; set; }
        public string Estado { get; set; }
        public Nullable<decimal> Tiempo_Total { get; set; }
        public Nullable<decimal> Kilometraje_Total { get; set; }
        public Nullable<int> Ruta_1 { get; set; }
        public Nullable<decimal> TIEMPO_R1 { get; set; }
        public Nullable<decimal> KILOMETRAJE_R1 { get; set; }
        public Nullable<int> Ruta_2 { get; set; }
        public Nullable<decimal> TIEMPO_R2 { get; set; }
        public Nullable<decimal> KILOMETRAJE_R2 { get; set; }
        public Nullable<int> Ruta_3 { get; set; }
        public Nullable<decimal> TIEMPO_R3 { get; set; }
        public Nullable<decimal> KILOMETRAJE_R3 { get; set; }
        public Nullable<int> Ruta_4 { get; set; }
        public Nullable<decimal> TIEMPO_R4 { get; set; }
        public Nullable<decimal> KILOMETRAJE_R4 { get; set; }
        public Nullable<int> ID_R1ORIGEN { get; set; }
        public Nullable<int> ID_R1DESTINO { get; set; }
        public string RA1_ORIGEN_AEROPUERTO { get; set; }
        public string RA1_DESTINO_AEROPUERTO { get; set; }
        public Nullable<int> ID_R2DESTINO { get; set; }
        public string RA2_ORIGEN_AEROPUERTO { get; set; }
        public string RA2_DESTINO_AEROPUERTO { get; set; }
        public Nullable<int> ID_R3DESTINO { get; set; }
        public string RA3_ORIGEN_AEROPUERTO { get; set; }
        public string RA3_DESTINO_AEROPUERTO { get; set; }
        public Nullable<int> ID_R4DESTINO { get; set; }
        public string RA4_ORIGEN_AEROPUERTO { get; set; }
        public string RA4_DESTINO_AEROPUERTO { get; set; }
    }
}
