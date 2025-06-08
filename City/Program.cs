using CityTask;

var newYork = new City("New York", new Population(30000000));
var kyiv = new City("Kyiv", new Population(4000000));

Console.WriteLine(newYork);
kyiv.IncreasePopulation(10000);
newYork.DecreasePopulation(25000);

Console.WriteLine($"Are there more people in {newYork.Name} than in {kyiv.Name}? {newYork.Population > kyiv.Population}");

Console.WriteLine($"Is Kyiv's population same as NY's? {kyiv.Population == newYork.Population}");