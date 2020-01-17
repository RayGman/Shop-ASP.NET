using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Shop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Data
{
    public class DBObjects
    {
        public static void Initil(AppDBContent content)
        {

            if (!content.Categor.Any())
            {
                content.Categor.AddRange(Categories.Select(c => c.Value));
            }

            if (!content.Light.Any())
            {
                content.AddRange(
                    new Light
                    {
                        name = "Черная Ретро Гирлянда №1",
                        shortDesc = "15 лампочек - 9 метров",
                        longDesc = "Черная Ретро Гирлянда - 15 лампочек - длина от первой лампы до последней - 7м, длина хвоста до вилки - 2м. Макс. мощность 600Вт.",
                        img = "/img/gar9.jpg",
                        price = 730,
                        isFavourite = true,
                        available = true,
                        Categor = Categories["Ретро гирлянда"]
                    },
                    new Light
                    {
                        name = "Ретро светильник №1",
                        shortDesc = "Ретро настольная лампа в стиле Лофт",
                        longDesc = "Светильник Эдисона. Ретро настольная лампа. Патрон: Металлический. Мощность лампы: 40W. Рабочее напряжение: 220V.",
                        img = "/img/lamp.jpg",
                        price = 600,
                        isFavourite = false,
                        available = true,
                        Categor = Categories["Ретро светильник"]
                    },
                    new Light
                    {
                        name = "Ретро розетка BIRONI ФАБЕРЖЕ",
                        shortDesc = "Пластиковая ретро розетка с заземлением BIRONI Фаберже",
                        longDesc = "Розетка Фаберже Bironi (Бирони).Красивый и прочный корпус из керамики.",
                        img = "/img/socket.jpg",
                        price = 1650,
                        isFavourite = false,
                        available = true,
                        Categor = Categories["Ретро проводка"]
                    },
                    new Light
                    {
                        name = "Черная Ретро Гирлянда №2",
                        shortDesc = "31 лампочек - 17 метров",
                        longDesc = "Черная Ретро Гирлянда - 31 лампочек - длина от первой лампы до последней - 15м, длина хвоста до вилки - 2м. Макс. мощность 775Вт.",
                        img = "/img/gar17.jpg",
                        price = 1495,
                        isFavourite = true,
                        available = true,
                        Categor = Categories["Ретро гирлянда"]
                    },
                    new Light
                    {
                        name = "Черная Ретро Гирлянда №3",
                        shortDesc = "61 лампочек - 33 метров",
                        longDesc = "Черная Ретро Гирлянда - 61 лампочек - длина от первой лампы до последней - 31м, длина хвоста до вилки - 2м. Макс. мощность 1525Вт.",
                        img = "/img/gar33.jpg",
                        price = 2925,
                        isFavourite = true,
                        available = true,
                        Categor = Categories["Ретро гирлянда"]
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
                        Categor = Categories["Ретро светильник"]
                    }
                    );
            }

            content.SaveChanges();
        }

        private static Dictionary<string, Categor> category;
        public static Dictionary<string, Categor> Categories
        {
            get
            {
                if (category == null)
                {
                    var list = new Categor[] {
                        new Categor { categoryName = "Ретро гирлянда", desc = "Гирлянда для интерьера"},
                        new Categor { categoryName = "Ретро светильник", desc = "Светильник для стола"},
                        new Categor { categoryName = "Ретро проводка", desc = "Проводка для помещений и улицы"}
                    };
                    category = new Dictionary<string, Categor>();
                    foreach (Categor el in list)
                    {
                        category.Add(el.categoryName, el);
                    }
                }
                return category;
            }
        }
    }
}
