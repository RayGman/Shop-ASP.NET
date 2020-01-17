using Shop.Data.Models;
using Shop.Data.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Data.mocks
{
    public class MockLights : IAllLights
    {
        private readonly ILightCategory _categoryLights = new MockCategory();

        public IEnumerable<Light> Lights {
            get
            {
                return new List<Light> {
                    new Light {
                        name = "Черная Ретро Гирлянда №1",
                        shortDesc = "15 лампочек - 9 метров",
                        longDesc = "Черная Ретро Гирлянда - 15 лампочек - длина от первой лампы до последней - 7м, длина хвоста до вилки - 2м. Макс. мощность 600Вт.",
                        img = "/img/gar9.jpg",
                        price = 730,
                        isFavourite = true,
                        available = true,
                        Categor = _categoryLights.AllCategories.First()
                    },
                    new Light
                    {
                        name = "Ретро светильник №1",
                        shortDesc = "Светильник Эдисона. Ретро настольная лампа в стиле Лофт",
                        longDesc = "Светильник Эдисона. Ретро настольная лампа. Патрон: Металлический. Мощность лампы: 40W. Рабочее напряжение: 220V.",
                        img = "/img/lamp.jpg",
                        price = 600,
                        isFavourite = false,
                        available = true,
                        Categor = _categoryLights.AllCategories.ElementAt(1)
                    },
                    new Light {
                        name = "Ретро розетка BIRONI ФАБЕРЖЕ",
                        shortDesc = "Пластиковая ретро розетка с заземлением BIRONI Фаберже",
                        longDesc = "Розетка Фаберже Bironi (Бирони).Красивый и прочный корпус из керамики.",
                        img = "/img/socket.jpg",
                        price = 1650,
                        isFavourite = false,
                        available = true,
                        Categor = _categoryLights.AllCategories.Last()
                    },
                    new Light {
                        name = "Черная Ретро Гирлянда №2",
                        shortDesc = "31 лампочек - 17 метров",
                        longDesc = "Черная Ретро Гирлянда - 31 лампочек - длина от первой лампы до последней - 15м, длина хвоста до вилки - 2м. Макс. мощность 775Вт.",
                        img = "/img/gar17.jpg",
                        price = 1495,
                        isFavourite = true,
                        available = true,
                        Categor = _categoryLights.AllCategories.First()
                    },
                    new Light {
                        name = "Черная Ретро Гирлянда №3",
                        shortDesc = "61 лампочек - 33 метров",
                        longDesc = "Черная Ретро Гирлянда - 61 лампочек - длина от первой лампы до последней - 31м, длина хвоста до вилки - 2м. Макс. мощность 1525Вт.",
                        img = "/img/gar33.jpg",
                        price = 2925,
                        isFavourite = true,
                        available = true,
                        Categor = _categoryLights.AllCategories.First()
                    },
                    new Light
                    {
                        name = "Ретро светильник №2",
                        shortDesc = "Светильник Эдисона. Ретро настольная лампа в стиле Лофт",
                        longDesc = "Светильник Эдисона. Ретро настольная лампа. Патрон: Металлический. Мощность лампы: 40W. Рабочее напряжение: 220V.",
                        img = "/img/lamp2.jpg",
                        price = 550,
                        isFavourite = true,
                        available = true,
                        Categor = _categoryLights.AllCategories.ElementAt(1)
                    }
                };
            }
        }
        public IEnumerable<Light> getFavLights { get; set; }

        public Light getObjectLight(int lightId)
        {
            throw new NotImplementedException();
        }
    }
}
