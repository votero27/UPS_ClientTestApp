using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ReceiverApi.Data;
using ReceiverApi.Models;

namespace ReceiverApi.Controllers
{
    public class ShippingsController : ApiController
    {
        ShippingDbContext db = new ShippingDbContext();
        // GET: api/Shippins
        public IHttpActionResult Get()
        {
            var shipping = db.Shippings;
            return Ok(shipping);
        }

        // GET: api/Shippins/5
        public IHttpActionResult Get(int? id)
        {
            var shipping = db.Shippings.Find(id);
            if(shipping == null)
            {
                return NotFound();
            }
            return Ok(shipping);
        }

        // POST: api/Shippins
        public IHttpActionResult Post([FromBody]Shipping shipping)
        {
            db.Shippings.Add(shipping);
            db.SaveChanges();
            return StatusCode(HttpStatusCode.Created);
        }

        // PUT: api/Shippins/5
        public IHttpActionResult Put(int? id, [FromBody]Shipping shipping)
        {
            var entity = db.Shippings.FirstOrDefault(temp => temp.CustomerID == id);
            if(entity == null)
            {
                return BadRequest("No record found agaist this id");
            }
            entity.PackageType = shipping.PackageType;
            entity.PackageWeight = shipping.PackageWeight;
            db.SaveChanges();
            return Ok("Record updated.....");
        }

        // DELETE: api/Shippins/5
        public IHttpActionResult Delete(int? id)
        {
            var shipping = db.Shippings.Find(id);
            if(shipping == null)
            {
                return BadRequest("No record found agaist this id");
            }
            db.Shippings.Remove(shipping);
            db.SaveChanges();

            return Ok("Record Deleted");
        }
    }
}
