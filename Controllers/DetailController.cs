using Microsoft.AspNetCore.Mvc;
using TechShop.Models;
using System.Collections.Generic;
using System.Linq;

namespace TechShop.Controllers
{
    public class DetailController : Controller
    {
        private static readonly List<Item> Items = new List<Item>
        {
            new Item
            {
                Id = 1,
                Name = "Red Magic 9 Pro",
                Image = "/redmagic.png",
                Price = 799.99m,
                ShortDescription = "High-performance gaming phone with advanced cooling.",
                Brand = "RedMagic",
                ModelNumber = "RM9P",
                Display = "6.8\" 120Hz AMOLED",
                Processor = "Snapdragon 8 Gen 2",
                RAM = "12GB",
                Storage = "256GB",
                RearCamera = "50MP + 8MP + 2MP",
                FrontCamera = "16MP",
                Battery = "6000 mAh",
                OperatingSystem = "Android 14",
                Network = "5G",
                SIM = "Dual SIM",
                Color = "Black",
                Weight = "210g",
                Warranty = "12 months",
                Reviews = new List<Review>
                {
                    new Review { Author = "Alice", Rating = 5, Comment = "Amazing for gaming!" },
                    new Review { Author = "Bob", Rating = 4, Comment = "Battery is great." }
                }
            },
            new Item
            {
                Id = 2,
                Name = "ROG Phone 8",
                Image = "/ss1.jpg",
                Price = 899.99m,
                ShortDescription = "Gamer-focused phone with extra accessories.",
                Brand = "Asus",
                ModelNumber = "ROG8",
                Display = "6.7\" 144Hz OLED",
                Processor = "Snapdragon 8 Gen 3",
                RAM = "16GB",
                Storage = "512GB",
                RearCamera = "64MP + 13MP",
                FrontCamera = "32MP",
                Battery = "6500 mAh",
                OperatingSystem = "Android 14",
                Network = "5G",
                SIM = "Dual SIM",
                Color = "Phantom Black",
                Weight = "230g",
                Warranty = "12 months",
                Reviews = new List<Review>
                {
                    new Review { Author = "Charlie", Rating = 5, Comment = "Best cooling I've seen!" }
                }
            },
            new Item
{
    Id = 3,
    Name = "Huawei Mate 60 Pro",
    Image = "/ss9.jpg",
    Price = 1099.99m,
    ShortDescription = "Flagship phone with powerful Kirin chipset and premium design.",
    Brand = "Huawei",
    ModelNumber = "Mate60Pro",
    Display = "6.82\" OLED 120Hz",
    Processor = "Kirin 9000S",
    RAM = "12GB",
    Storage = "512GB",
    RearCamera = "50MP + 13MP + TOF",
    FrontCamera = "13MP",
    Battery = "4800 mAh",
    OperatingSystem = "HarmonyOS 4",
    Network = "5G",
    SIM = "Dual SIM",
    Color = "Emerald Green",
    Weight = "212g",
    Warranty = "12 months",
    Reviews = new List<Review>
    {
        new Review { Author = "Liam", Rating = 5, Comment = "Outstanding build quality and camera." }
    }
},

             new Item
            {
                Id = 4,
                Name = "iPhone 15 Pro Max",
                Image = "/ss2.webp",
                Price = 1299.99m,
                ShortDescription = "Latest iPhone with powerful A17 chip.",
                Brand = "Apple",
                ModelNumber = "A2894",
                Display = "6.7\" OLED",
                Processor = "Apple A17 Pro",
                RAM = "8GB",
                Storage = "512GB",
                RearCamera = "48MP + 12MP + 12MP",
                FrontCamera = "12MP",
                Battery = "4323 mAh",
                OperatingSystem = "iOS 17",
                Network = "5G",
                SIM = "Dual SIM",
                Color = "Titanium",
                Weight = "221g",
                Warranty = "12 months",
                Reviews = new List<Review>
                {
                    new Review { Author = "Emma", Rating = 4, Comment = "Great performance but pricey." }
                }
            },
             new Item
            {
                Id = 5,
                Name = "Google Pixel 8 Pro",
                Image = "/ss3.jpg",
                Price = 899.99m,
                ShortDescription = "Google’s flagship phone with pure Android experience.",
                Brand = "Google",
                ModelNumber = "GLU0G",
                Display = "6.7\" LTPO OLED",
                Processor = "Google Tensor G3",
                RAM = "12GB",
                Storage = "256GB",
                RearCamera = "50MP + 48MP + 12MP",
                FrontCamera = "11.1MP",
                Battery = "5000 mAh",
                OperatingSystem = "Android 14",
                Network = "5G",
                SIM = "Dual SIM",
                Color = "Obsidian",
                Weight = "213g",
                Warranty = "12 months",
                Reviews = new List<Review>
                {
                    new Review { Author = "Fiona", Rating = 5, Comment = "Clean OS and excellent photos!" }
                }
            },

            new Item
            {
                Id = 6,
                Name = "OnePlus 11",
                Image = "/ss4.png",
                Price = 699.99m,
                ShortDescription = "Flagship killer with fast charging.",
                Brand = "OnePlus",
                ModelNumber = "OnePlus 11",
                Display = "6.7\" AMOLED 120Hz",
                Processor = "Snapdragon 8 Gen 2",
                RAM = "16GB",
                Storage = "256GB",
                RearCamera = "50MP + 32MP + 2MP",
                FrontCamera = "16MP",
                Battery = "5000 mAh",
                OperatingSystem = "Android 13",
                Network = "5G",
                SIM = "Dual SIM",
                Color = "Titan Black",
                Weight = "205g",
                Warranty = "12 months",
                Reviews = new List<Review>
                {
                    new Review { Author = "George", Rating = 4, Comment = "Super smooth and fast." }
                }
            },

            new Item
            {
                Id = 7,
                Name = "Xiaomi 13 Pro",
                Image = "/ss5.webp",
                Price = 799.99m,
                ShortDescription = "High-end specs at a reasonable price.",
                Brand = "Xiaomi",
                ModelNumber = "2206133G",
                Display = "6.73\" AMOLED 120Hz",
                Processor = "Snapdragon 8 Gen 2",
                RAM = "12GB",
                Storage = "256GB",
                RearCamera = "50MP + 50MP + 50MP",
                FrontCamera = "32MP",
                Battery = "4820 mAh",
                OperatingSystem = "Android 13",
                Network = "5G",
                SIM = "Dual SIM",
                Color = "Ceramic White",
                Weight = "221g",
                Warranty = "12 months",
                Reviews = new List<Review>
                {
                    new Review { Author = "Hannah", Rating = 5, Comment = "Fantastic camera and screen." }
                }
            },

            new Item
            {
                Id = 8,
                Name = "Sony Xperia 1 V",
                Image = "/ss6.png",
                Price = 1199.99m,
                ShortDescription = "Professional-level camera features.",
                Brand = "Sony",
                ModelNumber = "XQ-CT72",
                Display = "6.5\" 4K OLED",
                Processor = "Snapdragon 8 Gen 2",
                RAM = "12GB",
                Storage = "256GB",
                RearCamera = "12MP + 12MP + 12MP",
                FrontCamera = "12MP",
                Battery = "5000 mAh",
                OperatingSystem = "Android 13",
                Network = "5G",
                SIM = "Dual SIM",
                Color = "Black",
                Weight = "187g",
                Warranty = "12 months",
                Reviews = new List<Review>
                {
                    new Review { Author = "Ian", Rating = 4, Comment = "Excellent for video shooting." }
                }
            },

            new Item
            {
                Id = 9,
                Name = "Motorola Edge 40 Pro",
                Image = "/ss7.png",
                Price = 799.99m,
                ShortDescription = "Great screen and solid performance.",
                Brand = "Motorola",
                ModelNumber = "XT2471-2",
                Display = "6.67\" OLED 144Hz",
                Processor = "Snapdragon 8 Gen 2",
                RAM = "12GB",
                Storage = "256GB",
                RearCamera = "50MP + 12MP",
                FrontCamera = "60MP",
                Battery = "4400 mAh",
                OperatingSystem = "Android 13",
                Network = "5G",
                SIM = "Dual SIM",
                Color = "Storm Grey",
                Weight = "193g",
                Warranty = "12 months",
                Reviews = new List<Review>
                {
                    new Review { Author = "Jack", Rating = 4, Comment = "Smooth performance and display." }
                }
            },

            new Item
            {
                Id = 10,
                Name = "Samsung Galaxy Z Fold 5",
                Image = "/ss8.webp",
                Price = 1799.99m,
                ShortDescription = "Foldable with powerful specs and flexibility.",
                Brand = "Samsung",
                ModelNumber = "SM-F946B",
                Display = "7.6\" Foldable AMOLED",
                Processor = "Snapdragon 8 Gen 2",
                RAM = "12GB",
                Storage = "512GB",
                RearCamera = "50MP + 12MP + 10MP",
                FrontCamera = "10MP",
                Battery = "4400 mAh",
                OperatingSystem = "Android 13",
                Network = "5G",
                SIM = "Dual SIM",
                Color = "Graphite",
                Weight = "253g",
                Warranty = "12 months",
                Reviews = new List<Review>
                {
                    new Review { Author = "Kelly", Rating = 5, Comment = "Innovative design and great specs." }
                }
            },

        };

        public IActionResult Detail(int id)
        {
            var item = Items.FirstOrDefault(i => i.Id == id);
            if (item == null) return NotFound();
            return View(item);
        }
    }
}
