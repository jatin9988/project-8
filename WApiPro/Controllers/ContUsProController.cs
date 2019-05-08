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
    public class ContUsProController : ApiController
    {
        private ProtMgmtEntities db = new ProtMgmtEntities();

        // GET: api/ContactUs
        public IQueryable<ContactU> GetProConts()
        {
            return db.ContactUs;
        }

        // POST: api/ContactUs
        [ResponseType(typeof(ContactU))]
        public IHttpActionResult PostProCont(ContactU contactU)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.ContactUs.Add(contactU);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = contactU.ContactId }, contactU);
        }
    }
}