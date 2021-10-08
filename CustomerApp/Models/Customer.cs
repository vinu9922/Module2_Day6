using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomerApp.Models
{
    public class Customer
    {
       public int CustomerId
        { get; set; }
            public int Contact_No { get; set; }
       public string Customer_name { get; set; }
        public string Email_id { get; set; }
        public string CustomerType { get; set; }
    }
}
