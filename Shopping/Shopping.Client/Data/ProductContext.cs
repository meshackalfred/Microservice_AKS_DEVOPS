using Shopping.Client.Models;

namespace Shopping.Client.Data
{
    public static class ProductContext
    {
        public static readonly List<Product> Products = new List<Product> 
        {
            new()
            {
                
                Name = "Laptop",
                Category = "Electronics",
                Description = "A high-performance laptop for work and play.",
                Image = "laptop.jpg",
                Price = 999.99m
            },
            new()
            {
                
                Name = "Smartphone",
                Category = "Electronics",
                Description = "A sleek",
                 Image = "laptop.jpg",
                Price = 999.99m
        },
            new()
            {
             
                Name = "Headphones",
                Category = "Audio",
                Description = "Noise-cancelling headphones for immersive sound.",
                Image = "headphones.jpg",
                Price = 199.99m
            },
            new()
            {
               
                Name = "Coffee Maker",
                Category = "Home Appliances",
                Description = "Brew the perfect cup of coffee every morning.",
                Image = "coffeemaker.jpg",
                Price = 49.99m
            }
        };

    }
}
