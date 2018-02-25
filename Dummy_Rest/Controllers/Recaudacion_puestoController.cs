using Dummy_Rest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Dummy_Rest.Controllers
{
    public class Recaudacion_puestoController : ApiController
    {
        // GET: api/Recaudacion_puesto
        [Authorize]
        public IEnumerable<RecaudacionPuesto> Get(string concepto, string mercado, string codPuesto, string codPasaje, string letra, string fechaIn, string fechaFi)
        {
            List<RecaudacionPuesto> consulta = new List<RecaudacionPuesto>();
            consulta.Add(new RecaudacionPuesto() { concepto = concepto, tipo_conductor = "CON CONTRATO", periodo = "12", emision = 1, servicio = 0, mora = (decimal)3.53, fec_cancelacion = "2017-03-06T00:00:00", cod_letra = "  ", num_contrato = "00274", cod_nombre = "CABEZUDO TORRES VDA DE JERI FELICITA JUANA", insoluto = "whats this?", monto = (decimal)16.53 });
            consulta.Add(new RecaudacionPuesto() { concepto = concepto, tipo_conductor = "CON CONTRATO", periodo = "11", emision = 1, servicio = 0, mora = (decimal)3.53, fec_cancelacion = "2017-03-06T00:00:00", cod_letra = "  ", num_contrato = "00274", cod_nombre = "CABEZUDO TORRES VDA DE JERI FELICITA JUANA", insoluto = "whats this?", monto = (decimal)133.53 });
            consulta.Add(new RecaudacionPuesto() { concepto = concepto, tipo_conductor = "CON CONTRATO", periodo = "10", emision = 1, servicio = 0, mora = (decimal)7.53, fec_cancelacion = "2017-03-06T00:00:00", cod_letra = "  ", num_contrato = "00274", cod_nombre = "CABEZUDO TORRES VDA DE JERI FELICITA JUANA", insoluto = "whats this?", monto = (decimal)122.53 });
            consulta.Add(new RecaudacionPuesto() { concepto = concepto, tipo_conductor = "CON CONTRATO", periodo = "14", emision = 1, servicio = 0, mora = (decimal)8.53, fec_cancelacion = "2017-03-06T00:00:00", cod_letra = "  ", num_contrato = "00274", cod_nombre = "CABEZUDO TORRES VDA DE JERI FELICITA JUANA", insoluto = "whats this?", monto = (decimal)188.53 });
            consulta.Add(new RecaudacionPuesto() { concepto = concepto, tipo_conductor = "CON CONTRATO", periodo = "24", emision = 1, servicio = 0, mora = (decimal)6.53, fec_cancelacion = "2017-03-06T00:00:00", cod_letra = "  ", num_contrato = "00274", cod_nombre = "CABEZUDO TORRES VDA DE JERI FELICITA JUANA", insoluto = "whats this?", monto = (decimal)17.53 });
            consulta.Add(new RecaudacionPuesto() { concepto = concepto, tipo_conductor = "CON CONTRATO", periodo = "12", emision = 1, servicio = 0, mora = (decimal)4.53, fec_cancelacion = "2017-03-06T00:00:00", cod_letra = "  ", num_contrato = "00274", cod_nombre = "CABEZUDO TORRES VDA DE JERI FELICITA JUANA", insoluto = "whats this?", monto = (decimal)16.53 });
            consulta.Add(new RecaudacionPuesto() { concepto = concepto, tipo_conductor = "CON CONTRATO", periodo = "14", emision = 1, servicio = 0, mora = (decimal)3.53, fec_cancelacion = "2017-03-06T00:00:00", cod_letra = "  ", num_contrato = "00274", cod_nombre = "CABEZUDO TORRES VDA DE JERI FELICITA JUANA", insoluto = "whats this?", monto = (decimal)14.53 });

            /*List<string> listdown = new List<string>();
            listdown = consulta.ConvertAll(d =>d.);
            */
            return consulta;
        }





    }
}
