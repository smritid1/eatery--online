using System.Linq;
using eateryonline.Models;
public static class DbInitializer
{
    public static void Initialize(ApplicationDbContext context)
    {
        context.Database.EnsureCreated();

        if (context.FoodItems.Any())
        {
            return; // DB has been seeded
        }

        var foodItems = new FoodItem[]
        {
            new FoodItem { Name = "Pizza", Description = "Cheese pizza", Price = 10.99M, ImageUrl = "https://example.com/pizza.jpg" },
            new FoodItem { Name = "Burger", Description = "Double cheese burger", Price = 8.99M, ImageUrl = "https://example.com/burger.jpg" },
            new FoodItem { Name = "Pasta", Description = "Alfredo pasta", Price = 12.99M, ImageUrl = "https://example.com/pasta.jpg" },
            new FoodItem { Name = "Pizza", Description = "Mexican pizza", Price = 10.99M, ImageUrl = "https://example.com/pizza.jpg" },
            new FoodItem { Name = "MoMo", Description = "Buff Momo", Price = 8.99M, ImageUrl = "https://example.com/burger.jpg" },
            new FoodItem { Name = "Salad", Description = "Fresh garden salad", Price = 6.99M, ImageUrl = "https://example.com/salad.jpg" },
            new FoodItem { Name = "Sushi", Description = "Assorted sushi platter", Price = 15.99M, ImageUrl = "https://example.com/sushi.jpg" },
            new FoodItem { Name = "Tacos", Description = "Beef tacos with salsa", Price = 9.99M, ImageUrl = "https://example.com/tacos.jpg" },
            new FoodItem { Name = "Sandwich", Description = "Grilled chicken sandwich", Price = 7.99M, ImageUrl = "https://example.com/sandwich.jpg" },
            new FoodItem { Name = "Ice Cream", Description = "Vanilla ice cream scoop", Price = 3.99M, ImageUrl = "https://example.com/icecream.jpg" }
        };

        foreach (var item in foodItems)
        {
            context.FoodItems.Add(item);
        }
        context.SaveChanges();
    }
}
/*using System.Linq;
using eateryonline.Models;
public static class DbInitializer
{
    public static void Initialize(ApplicationDbContext context)
    {
        context.Database.EnsureCreated();

        if (context.FoodItems.Any())
        {
            return; // DB has been seeded
        }

        var foodItems = new FoodItem[]
        {
            new FoodItem { Name = "Pizza", Description = "Cheese pizza", Price = 10.99M, ImageUrl = "https://example.com/pizza.jpg" },
            new FoodItem { Name = "Burger", Description = "Double cheese burger", Price = 8.99M, ImageUrl = "https://example.com/burger.jpg" },
            new FoodItem { Name = "Pasta", Description = "Alfredo pasta", Price = 12.99M, ImageUrl = "https://example.com/pasta.jpg" },
            new FoodItem { Name = "Pizza", Description = "Mexicn pizza", Price = 10.99M, ImageUrl = "https://example.com/pizza.jpg" },
            new FoodItem { Name = "MoMo", Description = "Buff Momo", Price = 8.99M, ImageUrl = "https://example.com/burger.jpg" }
        };

        foreach (var item in foodItems)
        {
            context.FoodItems.Add(item);
        }
        context.SaveChanges();
    }
}*/
