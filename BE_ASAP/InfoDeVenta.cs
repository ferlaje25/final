using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE_ASAP
{
    public class InfoDeVenta
    {
        //INFO DE BUSQUEDAVUELO
        public string Origen { get; set; }

        public string Destino { get; set; }

        public int CantPasajeros { get; set; }
        public DateTime FSalida { get; set; }
        public DateTime FLLegada { get; set; }

        //INFO DE VUELO SELECCIONADO

        //INFO DE PASAJEROS

        public List<Cliente> Pasajeros { get; set; }
        //public List<string> Pasajeros { get; set; }
        //public List<DateTime> FechasNacimiento { get; set; }
        //public List<string> Genero { get; set; }
        //public List<string> TiposDocumentos { get; set; }
        //public List<string> NroDocumentos { get; set; }

        //public string Direccion { get; set; }
        //public string PaisDepaDist { get; set; }

        //INFO DE PAGO

    }
}


