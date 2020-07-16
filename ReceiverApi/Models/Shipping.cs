using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ReceiverApi.Models
{
    public class Shipping
    {
        [Key]
        public int CustomerID { get; set; }
        public double PackageWeight { get; set; }
        public string PackageType { get; set; }
    }
}