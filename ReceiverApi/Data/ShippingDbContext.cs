using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using ReceiverApi.Models;

namespace ReceiverApi.Data
{
    public class ShippingDbContext: DbContext
    {
        public DbSet<Shipping> Shippings { get; set; }
    }
}