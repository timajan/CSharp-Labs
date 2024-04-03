using System;
using Lab4_2.Services;
using Lab4_2.Sweets;

class Program
{
    static void Main(string[] args)
    {
        var giftService = new GiftService();
        // Adding different types of sweets
        giftService.AddSweet(new Candy("Gummy Bears", 30, 15, "Gummy"));
        giftService.AddSweet(new ChocolateBar("Milk Chocolate Bar", 50, 25, "Milk"));
        giftService.AddSweet(new Lollipop("Cherry Lollipop", 10, 8, false));
        giftService.AddSweet(new Marshmallow("Strawberry Marshmallow", 40, 20, "Strawberry"));

        Console.WriteLine($"Total Weight: {giftService.CalculateTotalWeight()} grams");

        Console.WriteLine("\nCandies sorted by weight:");
        foreach (var sweet in giftService.SortSweetsByWeight())
        {
            Console.WriteLine($"{sweet.Name}: {sweet.Weight} grams");
        }

        // Example of finding candies by sugar content
        double minSugar = 10;
        double maxSugar = 20;
        Console.WriteLine($"\nCandies with sugar content between {minSugar} and {maxSugar} grams:");
        foreach (var sweet in giftService.FindSweetsBySugarContent(minSugar, maxSugar))
        {
            Console.WriteLine($"{sweet.Name}: {sweet.SugarContent} grams of sugar");
        }

        Console.ReadKey();

    }
}