using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Web.Http;
using System.Web.Http.Description;
using WApiPro.Models;

namespace WApiPro.Controllers
{
    public class ProductController : ApiController
    {
        private ProtMgmtEntities db = new ProtMgmtEntities();

        // GET: api/Product
        public IQueryable<ProductMaster> GetProducts()
        {
            return db.ProductMasters;
        }

        // GET: api/Product/5
        [ResponseType(typeof(ProductMaster))]
        public IHttpActionResult GetProduct(int id)
        {
            ProductMaster product = db.ProductMasters.Find(id);
            if (product == null)
            {
                return NotFound();
            }

            return Ok(product);
        }

        // PUT: api/Product/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutProduct(int id, ProductMaster product)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != product.ProductId)
            {
                return BadRequest();
            }

            db.Entry(product).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ProductExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/Product
        [ResponseType(typeof(ProductMaster))]
        public IHttpActionResult PostProduct(ProductMaster product)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.ProductMasters.Add(product);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = product.ProductId }, product);
        }

        // DELETE: api/Product/5
        [ResponseType(typeof(ProductMaster))]
        public IHttpActionResult DeleteProduct(int id)
        {
            ProductMaster product = db.ProductMasters.Find(id);
            if (product == null)
            {
                return NotFound();
            }

            db.ProductMasters.Remove(product);
            db.SaveChanges();

            return Ok(product);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool ProductExists(int id)
        {
            return db.ProductMasters.Count(e => e.ProductId == id) > 0;
        }

    }
}