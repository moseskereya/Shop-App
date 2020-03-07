using System.Collections.Generic;
using System.Data.Entity;

namespace ShoppingCart.Models
{
    public class ProductDatabaseInitializer : DropCreateDatabaseIfModelChanges<ProductContext>
    {
        protected override void Seed(ProductContext context)
        {
            GetCategories().ForEach(p => context.categories.Add(p));
            GetProducts().ForEach(a => context.products.Add(a));
        }

        private static List<Category> GetCategories()
        {
            var categories = new List<Category> {
                new Category
                {
                    CategoryID = 1,
                    CategoryName = "Laptops"
                },
                new Category
                {
                    CategoryID = 2,
                    CategoryName = "Phones"
                },
                new Category
                {
                    CategoryID = 3,
                    CategoryName = "Others"
                },
                new Category
                {
                    CategoryID = 4,
                    CategoryName = "HeadPhones"
                },
                new Category
                {
                    CategoryID = 5,
                    CategoryName = "Watch"
                },
            };

            return categories;
        }

        private static List<Product> GetProducts()
        {
            var products = new List<Product> {
                new Product
                {
                    ProductID = 1,
                    ProductName = "Lenovo Flex 14 14.0",
                    Description = "The convertible Laptop is cheap and easy to use!",
                    ImgPath="https://i5.walmartimages.com/asr/166b57a0-e314-41e6-b3fc-1a111c502244_1.48e2f1a53165a49cb8ed03f4628211bf.jpeg?odnWidth=undefined&odnHeight=undefined&odnBg=ffffff",
                    UnitPrice = 22.50,
                    CategoryID = 1
               },
                new Product
                {
                    ProductID = 2,
                    ProductName = "Lenovo Y540 17.3, Gaming Laptop Intel Core",
                    Description = "There's nothing old about this Laptop , except it's looks. Compatible with other old laptops.",
                    ImgPath="https://i5.walmartimages.com/asr/4b03b5f7-4b03-4824-a0b3-d3ab07baa913_1.ae55d1c063d566309597f40f4c708499.jpeg?odnWidth=450&odnHeight=450&odnBg=ffffff",
                    UnitPrice = 15.95,
                     CategoryID = 1
               },
                new Product
                {
                    ProductID = 3,
                    ProductName = "Sumsung ",
                    Description = "Yes this Laptop is Good and light , easy to use compatible and cheap(affordable).",
                    ImgPath="https://images.unsplash.com/photo-1516321318423-f06f85e504b3?ixlib=rb-1.2.1&ixid=eyJhcHBfaWQiOjEyMDd9&auto=format&fit=crop&w=1350&q=80",
                    UnitPrice = 32.99,
                    CategoryID = 1
                },
                new Product
                {
                    ProductID = 4,
                    ProductName = "Acer Aspire 3, 14 HD",
                    Description = "Use this super fast Laptop whis is AMD A9-9420e, 4GB DDR4, 128GB SSD, Windows 10 in S mode, A314-21-91V1",
                    ImgPath="https://i5.walmartimages.com/asr/684550ac-d2bd-4a25-9c1f-9e7ac1e99ed4_1.ff8a181c93385f6108583f4dbab2f0c1.png?odnWidth=undefined&odnHeight=undefined&odnBg=ffffff",
                    UnitPrice = 8.95,
                    CategoryID = 1
                },
                new Product
                {
                    ProductID = 5,
                    ProductName = "Acer Chromebook Spin 11",
                    Description = "This is Convertible Laptop, Celeron N3350, 11.6" + "HD Touch, 4GB DDR4",
                    ImgPath="https://i5.walmartimages.com/asr/9a6c07d9-870e-46ec-b278-369d4defdffb_2.de11a084b93052ccfc0db893981bfbb3.jpeg?odnWidth=undefined&odnHeight=undefined&odnBg=ffffff",
                    UnitPrice = 34.95,
                    CategoryID = 1
                },
                new Product
                {
                    ProductID = 6,
                    ProductName = "Boost Mobile LG Tribute Royal",
                    Description = "The best Mobile LG phone to use , its light and easy to use. Features realistic color and details.",
                    ImgPath="https://i5.walmartimages.com/asr/02d4152f-79f3-4c11-adaf-2bcaa3540794_1.2bab010d2b8e1280515e5477e537e7b6.jpeg?odnWidth=undefined&odnHeight=undefined&odnBg=ffffff",
                    UnitPrice = 95.00,
                    CategoryID = 2
                },
                new Product
                {
                    ProductID = 7,
                    ProductName = "Apple 11-inch iPad Pro (2018)",
                    Description = "Peace of mind with the best value for device replacement.With the best display ever. Some assembly required.",
                    ImgPath="https://i5.walmartimages.com/asr/0ce1fd2b-b134-4f42-81bb-deddf12f2200_1.3974ca991aeb4d064a3a84007bbf05f5.jpeg?odnHeight=200&odnWidth=200&odnBg=ffffff",
                    UnitPrice = 4.95,
                    CategoryID = 2
                },
                new Product
                {
                    ProductID = 8,
                    ProductName = "Product TitleApple 10.5-inch iPad Air",
                    Description = "This is best iPad Air Wi-Fi 64GB .",
                    ImgPath="https://i5.walmartimages.com/asr/7cc67db7-7570-4b8a-9a27-8d198fd90fde_1.60c345646a1842713e570e9bed5a7bd8.jpeg?odnWidth=undefined&odnHeight=undefined&odnBg=ffffff",
                    UnitPrice = 2.95,
                    CategoryID = 2
                },
                new Product
                {
                    ProductID = 9,
                    ProductName = "Samsung Galaxy Fold Android Smartphone",
                    Description = "The Samsung Galaxy Fold is the tech giant’s most futuristic, most expensive smartphone available today. ",
                    ImgPath="https://hips.hearstapps.com/vader-prod.s3.amazonaws.com/1569603557-samsung-galaxy-fold-1569603543.jpg?crop=1xw:1xh;center,top&resize=768:*",
                    UnitPrice = 32.95,
                    CategoryID = 2
                },
                new Product
                {
                    ProductID = 10,
                    ProductName = "Solo Pro",
                    Description = "Active Noise Cancelling (ANC) blocks external noise, With Fast Fuel, a 10-minute charge = 3 hours of listening time ",
                    ImgPath="https://www.beatsbydre.com/content/dam/beats/web/pcp/headphones/solo-pro/pcp-headphones-solo-pro.png.large.1x.png",
                    UnitPrice = 15.00,
                    CategoryID = 3
                },
                new Product
                {
                    ProductID = 11,
                    ProductName = "Anker Soundcore Life Q10 Wireless Over-Ear Headphones",
                    Description = "The Soundcore Life Q10 are hands-down the best under $50. They surprised me with their cool design (a variant with a striking blue finish is also available)",
                    ImgPath="https://hips.hearstapps.com/vader-prod.s3.amazonaws.com/1582224561-soudncore-wireless-headphones-1582224533.jpg?crop=1xw:1xh;center,top&resize=768:*",
                    UnitPrice = 26.00,
                    CategoryID = 3
                },
                new Product
                {
                    ProductID = 12,
                    ProductName = "Grado Prestige Series SR80e Wired Open-Back Headphones",
                    Description = "Designed and developed in Brooklyn, the Prestige Series SR80e on-ear headphones by Grado Labs feature perfectly balanced sound",
                    ImgPath="https://hips.hearstapps.com/vader-prod.s3.amazonaws.com/1582224843-1486392969-grado-sr80e-headphones.jpg?crop=1xw:1xh;center,top&resize=768:*",
                    UnitPrice = 29.00,
                    CategoryID = 3
                },
                new Product
                {
                    ProductID = 13,
                    ProductName = "Samsung Galaxy Watch Active2",
                    Description = "The latest smartwatch from Samsung brings improved sensors, LTE connectivity, plus fitness and wellness tracking.",
                    ImgPath="https://hips.hearstapps.com/vader-prod.s3.amazonaws.com/1570205927-shop-widget-galaxy-watch-active2-1570205897.jpg?crop=1xw:1xh;center,top&resize=768%3A%2A",
                    UnitPrice = 95.00,
                    CategoryID = 4
                },
                new Product
                {
                    ProductID = 14,
                    ProductName = "Victorinox Swiss Army I.N.O.X. Carbon Watch",
                    Description = "Tactical watches are typically designed for use by military and law enforcement",
                    ImgPath="https://hips.hearstapps.com/vader-prod.s3.amazonaws.com/1560801541-swiss-army-inox-carbon-watch-1560801512.jpg?crop=1xw:1xh;center,top&resize=768:*",
                    UnitPrice = 4.95,
                    CategoryID = 4
                },
                new Product
                {
                    ProductID = 15,
                    ProductName = "Luminox EVO Navy SEAL Colormark Watch",
                    Description = "The Luminox EVO Navy SEAL Colormark watch has a carbon-reinforced case, which is paired with a scratch-resistant, anti-reflective mineral crystal",
                    ImgPath="https://hips.hearstapps.com/vader-prod.s3.amazonaws.com/1560796558-luminox-watch-1560796428.jpg?crop=1xw:1xh;center,top&resize=768:*",
                    UnitPrice = 42.95,
                    CategoryID = 4
                },
                new Product
                {
                    ProductID = 16,
                    ProductName = "Bell & Ross BR 03-92 Black Camo Watch",
                    Description = "The Bell & Ross BR 03-92 Black Camo watch is badass and luxe in equal measure. ",
                    ImgPath="https://hips.hearstapps.com/vader-prod.s3.amazonaws.com/1560800377-bell-ross-watch-1560800355.jpg?crop=1xw:1xh;center,top&resize=768:*",
                    UnitPrice = 122.95,
                    CategoryID = 5
                }
            };

            return products;
        }
    }
}