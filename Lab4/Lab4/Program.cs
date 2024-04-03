using Lab4;

Continent continent1 = new Continent
{
    Name = "Africa",
    Area = 346723,
    MaxHeight = 3427
};

Continent continent2 = new Continent
{
    Name = "America",
    Area = 298031,
    MaxHeight = 4155
};

Island island1 = new Island
{
    Name = "Madagascar",
    Area = 53567,
    MaxHeight = 690,
    IsCountry = true
};

Island island2 = new Island
{
    Name = "New Zealand",
    Area = 17337,
    MaxHeight = 2981,
    IsCountry = true
};

Island island3 = new Island
{
    Name = "Isle of Man",
    Area = 960,
    MaxHeight = 359,
    IsCountry = false
};

Ocean ocean1 = new Ocean
{
    Name = "Pacific Ocean",
    Area = 9843902,
    MaxDeep = 9430
};

Planet planet1 = new Planet
{
    Name = "Earth",
    Radius = 4390,
    Continents = new List<Continent> { continent1, continent2 },
    Islands = new List<Island> { island1, island2, island3 },
    Oceans = new List<Ocean> { ocean1 }
};


planet1.PrintPlanet();
planet1.PrintContinent();
planet1.PrintCountContinents();

Console.WriteLine(planet1.ToString());

Console.ReadLine();
