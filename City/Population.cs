namespace CityTask;

public class Population
{
    public int PopulationNumber { get; private set; }

    public Population(int populationNumber)
    {
        PopulationNumber = populationNumber;
    }

    public Population SetNewPopulation(int newPopulationNumber)
    {  
        return new Population(newPopulationNumber);
    }

    public static Population operator +(Population p, int number)
    {
        return new Population(p.PopulationNumber + number);
    }

    public static Population operator -(Population p, int number)
    {
        return new Population(p.PopulationNumber - number);
    }

    public static bool operator ==(Population p1, Population p2)
    {
        return p1.PopulationNumber == p2.PopulationNumber;
    }

    public override bool Equals(object obj)
    {
        return this == (obj as Population);
    }

    public static bool operator !=(Population p1, Population p2)
    {
        return !(p1.PopulationNumber == p2.PopulationNumber);
    }

    public static bool operator >(Population p1, Population p2)
    {
        return p1.PopulationNumber > p2.PopulationNumber;
    }

    public static bool operator <(Population p1, Population p2)
    {
        return p1.PopulationNumber < p2.PopulationNumber;
    }

    public override string ToString()
    {
        return PopulationNumber.ToString();
    }
}