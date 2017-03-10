using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class ProductDbInitializer : DropCreateDatabaseAlways<EfDbContext>
    {
        protected override void Seed(EfDbContext db)
        {
            db.Products.Add(new Product
            {
                Name = "Смартфон Xiaomi Redmi 4 16GB Gray",
                Description =
                    "Android, экран 5 IPS(720x1280), ОЗУ 2 ГБ, флэш - память 16 ГБ, карты памяти, камера 13 Мп, аккумулятор 4100 мАч, 2 SIM, цвет темно - серый",
                Category = "Смартфоны",
                Price = 319.00m
            });
            db.Products.Add(new Product
            {
                Name = "Смартфон Apple iPhone 7 32GB Black",
                Description =
                    "Apple iOS, экран 4.7\" IPS (750x1334), ОЗУ 2 ГБ, флэш-память 32 ГБ, камера 12 Мп, аккумулятор 1960 мАч, 1 SIM, цвет черный",
                Category = "Смартфоны",
                Price = 1600.00m
            });
            db.Products.Add(new Product
            {
                Name = "Смартфон Samsung Galaxy S7 Edge",
                Description =
                    "Android, экран 5.5\" AMOLED (1440x2560), ОЗУ 4 ГБ, флэш-память 32 ГБ, карты памяти, камера 12 Мп, аккумулятор 3600 мАч, 1 SIM, цвет черный",
                Category = "Смартфоны",
                Price = 1350.00m
            });
            db.Products.Add(new Product
            {
                Name = "Смартфон iPhone 5s 16GB Space",
                Description =
                    "Apple iOS, экран 4\" IPS (640x1136), ОЗУ 1 ГБ, флэш-память 16 ГБ, камера 8 Мп, аккумулятор 1560 мАч, 1 SIM, цвет темно-серый",
                Category = "Смартфоны",
                Price = 680.00m
            });
            db.Products.Add(new Product
            {
                Name = "Игровая мышь A4Tech Bloody V7",
                Description =
                   "полноразмерная игровая мышь для ПК, проводная, USB, сенсор оптический 3200 dpi, 8 кнопок, колесо с нажатием, цвет черный",
                Category = "Игровые мыши",
                Price = 36.44m
            });
            db.Products.Add(new Product
            {
                Name = "Игровая мышь A4Tech Bloody V8",
                Description =
                   "полноразмерная игровая мышь для ПК, проводная, USB, сенсор оптический 3200 dpi, 8 кнопок, колесо с нажатием, цвет черный",
                Category = "Игровые мыши",
                Price = 36.66m
            });
            db.Products.Add(new Product
            {
                Name = "Игровая мышь Logitech G403",
                Description =
                   "пполноразмерная игровая мышь для ПК, проводная, USB, сенсор оптический 12000 dpi, 6 кнопок, колесо с нажатием, цвет черный",
                Category = "Игровые мыши",
                Price = 124.30m
            });
            db.Products.Add(new Product
            {
                Name = "Наушники с микрофоном Apple AirPods",
                Description =
                   "Наушники Apple AirPods эффективно передают данные по беспроводной сети, воспроизводят звук высокого качества и работают без подзарядки в режиме прослушивания музыки до 5 часов. При этом они поддерживают функции Siri: голосовой помощник доступен с помощью двойного тапа по поверхности чашки.",
                Category = "Наушники",
                Price = 520.00m
            });
            db.Products.Add(new Product
            {
                Name = "Наушники Sennheiser HD 800",
                Description =
                   "наушники, аудиофильские, оформление открытое, 6-51000 Гц, 300 Ом, кабель 3 м",
                Category = "Наушники",
                Price = 1800.00m
            });
            db.Products.Add(new Product
            {
                Name = "Наушники Sennheiser HD 650",
                Description =
                   "Дорогие аудиофильские наушники для любителей и профессионалов. Имеют неокрашенное звучание и ровную частотную отдачу благодаря вручную подобранным парам излучателей, наличию акустического шелка внутри чашек, оптимизированной магнитной системе и легким алюминиевым катушкам.",
                Category = "Наушники",
                Price = 758.83m
            });
            base.Seed(db);
        }
    }
}
