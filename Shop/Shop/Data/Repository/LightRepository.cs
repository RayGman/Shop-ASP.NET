using Microsoft.EntityFrameworkCore;
using Shop.Data.interfaces;
using Shop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Data.Repository
{
    public class LightRepository : IAllLights
    {
        private readonly AppDBContent appDBContent;

        public LightRepository(AppDBContent appDBContent)
        {
            this.appDBContent = appDBContent;
        }

        public IEnumerable<Light> Lights => appDBContent.Light.Include(c => c.Categor);

        public IEnumerable<Light> getFavLights => appDBContent.Light.Where(p => p.isFavourite).Include(c => c.Categor);

        public Light getObjectLight(int lightId) => appDBContent.Light.FirstOrDefault(p => p.id == lightId);
    }
}
