namespace CreditCardTask;

public class MoneyOnCard
{
    public int Amount { get; private set; }

    public MoneyOnCard(int amount)
    {
        Amount = amount;
    }

    public MoneyOnCard SetNewAmount(int newAmount)
    {
        return new MoneyOnCard(newAmount);
    }

    public static MoneyOnCard operator +(MoneyOnCard m, int amount)
    {
        return new MoneyOnCard(m.Amount + amount);
    }

    public static MoneyOnCard operator -(MoneyOnCard m, int amount)
    {
        return new MoneyOnCard(m.Amount - amount);
    }

    public static bool operator ==(MoneyOnCard m1, MoneyOnCard m2)
    {
        return m1.Amount == m2.Amount;
    }

    public override bool Equals(object obj)
    {
        return this == (obj as MoneyOnCard);
    }

    public static bool operator !=(MoneyOnCard m1, MoneyOnCard m2)
    {
        return !(m1.Amount == m2.Amount);
    }

    public static bool operator >(MoneyOnCard m1, MoneyOnCard m2)
    {
        return m1.Amount > m2.Amount;
    }

    public static bool operator <(MoneyOnCard m1, MoneyOnCard m2)
    {
        return m1.Amount < m2.Amount;
    }

    public override string ToString()
    {
        return Amount.ToString("C");
    }
}