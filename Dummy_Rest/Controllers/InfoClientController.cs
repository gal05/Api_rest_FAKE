using Dummy_Rest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Security.Claims;
using System.Web.Http;

namespace Dummy_Rest.Controllers
{
    public class InfoClientController : ApiController
    {
        // GET: api/InfoClient
        [Authorize]
        public IEnumerable<ClientInfo> Get()
        {
            var identity = (ClaimsIdentity)User.Identity;
            var roles = identity.Claims
                        .Where(c => c.Type == ClaimTypes.Role)
                        .Select(c => c.Value);

            List<ClientInfo> consulta = new List<ClientInfo>();
            consulta.Add(new ClientInfo() { nombre = identity.Name, estado = 1, cargo = "ADMIN" });
            

            return consulta;
        }
    }
}
