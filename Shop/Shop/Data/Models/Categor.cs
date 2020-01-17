using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Data.Models
{
    public class Categor
    {
        public int id { get; set; }

        public string categoryName { get; set;}

        public string desc { get; set; }

        public List<Light> light { get; set; }
    }
}
