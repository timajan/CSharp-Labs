using Lab4;
using System;
using System.Collections.Generic;
using System.Numerics;

class Program
{
    static void Main(string[] args)
    {
        // Creating a planet object with continents, oceans, and islands
        Planet earth = new Planet("Earth", 123123, new List<Continent> {
            new Continent("Asia", 5784, 2345),
            new Continent("Africa", 5784, 2345),
            new Continent("North America", 5784, 2345),
            new Continent("South America", 5784, 2345),
            new Continent("Antarctica", 5784, 2345),
            new Continent("Europe", 5784, 2345),
            new Continent("Australia", 5784, 2345)
        }, new List<Ocean> {
            new Ocean("Pacific Ocean", 5784, 2345),
            new Ocean("Atlantic Ocean", 5784, 2345),
            new Ocean("Indian Ocean", 5784, 2345),
            new Ocean("Southern Ocean", 5784, 2345),
            new Ocean("Arctic Ocean", 5784, 2345)
        }, new List<Island> {
            new Island("Greenland", 3453, 234, true),
            new Island("New Guinea", 23423, 432, false),
            new Island("Borneo", 23423, 432, false),
            new Island("Madagascar", 23423, 432, false)
        });

        earth.PrintPlanet();
        earth.PrintContinent();
        earth.PrintCountContinents();

        Console.WriteLine(earth.ToString());

        Console.ReadLine();
    }
}
