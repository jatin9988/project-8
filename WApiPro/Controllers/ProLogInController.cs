using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using WApiPro.Models;

namespace WApiPro.Controllers
{
    public class ProLogInController : ApiController
    {
        private ProtMgmtEntities db = new ProtMgmtEntities();

        // GET: api/LogIn
        [ResponseType(typeof(LogIn))]
        public IHttpActionResult ProLogIn(LogIn logIn)
        {
            LogIn log = db.LogIns.FirstOrDefault(u => u.UserName == logIn.UserName && u.Password == logIn.Password);
            if (log == null)
            {
                return NotFound();
            }

            return Ok(log);
        }

    }
}