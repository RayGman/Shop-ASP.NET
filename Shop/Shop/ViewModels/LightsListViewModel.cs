using Shop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.ViewModels
{
    public class LightsListViewModel
    {
        public IEnumerable<Light> allLights { get; set; }

        public string lighCategor { get; set; }
    }
}
