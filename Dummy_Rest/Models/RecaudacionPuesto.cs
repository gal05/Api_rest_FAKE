using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Dummy_Rest.Models
{
    public class RecaudacionPuesto
    {
        public string concepto { get; set; }
        public string contrato { get; set; }
        public string periodo { get; set; }
        public Nullable<decimal> emision { get; set; }
        public Nullable<decimal> servicio { get; set; }
        public Nullable<decimal> mora { get; set; }
        public string fec_cancelacion{ get; set; }
        public string cod_letra{ get; set; }
        public string num_contrato{ get; set; }
        public string cod_nombre{ get; set; }
        public string cod_tipopro{ get; set; }
        public string insoluto{ get; set; }
        public Nullable<decimal> monto{ get; set; }
    }
}