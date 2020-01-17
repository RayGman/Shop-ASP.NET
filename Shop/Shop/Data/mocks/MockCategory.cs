using Shop.Data.Models;
using Shop.Data.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Data.mocks
{
    public class MockCategory: ILightCategory
    {
        public IEnumerable<Categor> AllCategories {
            get {
                return new List<Categor> {
                    new Categor { categoryName = "Ретро гирлянда", desc = "Гирлянда для интерьера"},
                    new Categor { categoryName = "Ретро светильник", desc = "Светильник для стола"},
                    new Categor { categoryName = "Ретро проводка", desc = "Проводка для помещений и улицы"}
                };
            }
        }
    }
}
