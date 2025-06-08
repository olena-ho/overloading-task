namespace CityTask;

public class City
{
    public string Name { get; set; }
    public Population Population { get; private set; }

    public City(string name, Population population)
    {
        Name = name;
        Population = population;
    }

    public void IncreasePopulation(int amountOfPeople)
    {
        Population += amountOfPeople;
    }

    public void DecreasePopulation(int amountOfPeople)
    {
        Population -= amountOfPeople;
    }

    public override string ToString()
    {
        return $"{Name} has population of {Population} people.";
    }
}
