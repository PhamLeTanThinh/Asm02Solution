using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessObject.Models
{
    public class Cart
    {
        public int ProductId { get; set; }
        public String ProductName { get; set; }
        public int quantity { get; set; }
        public Product Product { get; set; }
    }
}
