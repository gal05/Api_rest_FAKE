using Dummy_Rest.Models.OtrosIngresosJs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Dummy_Rest.Controllers
{
    public class OtrosIngresosController : ApiController
    {
        public class Fechas
        {
            public string fech_i { get; set; }
            public string fech_f { get; set; }
        }

        [Authorize]
        [HttpPost]
        public IEnumerable<OtrosIngresos> otrosIngresos([FromBody] Fechas fecha)
        {

            List<Cuerpo> cuerpo1 = new List<Cuerpo>();
            cuerpo1.Add(new Cuerpo() { mes = "Enero", sshh = 600, parqueo = 400, tupa = 100, total = 1100 });
            cuerpo1.Add(new Cuerpo() { mes = "Febrero", sshh = 100, parqueo = 200, tupa = 200, total = 500 });
            cuerpo1.Add(new Cuerpo() { mes = "Diciembre", sshh = 200, parqueo = 200, tupa = 300, total = 700 });


            List<OtrosIngresos> consulta = new List<OtrosIngresos>();
            consulta.Add(new OtrosIngresos() { anodeu = "2016", data=cuerpo1 });
            consulta.Add(new OtrosIngresos() { anodeu = "2017", data = cuerpo1 });


            return consulta;
        }


    }
}
