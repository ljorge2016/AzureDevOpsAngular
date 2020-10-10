using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AzureDevOpsAngular.Services.Model
{
    public class Product
    {
        public int ProductId { get; set; }
        public String Description { get; set; }
        public Double Price { get; set; }
        public DateTime Created { get; set; }
        public DateTime Update { get; set; }

    }
}
