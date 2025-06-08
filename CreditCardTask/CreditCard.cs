namespace CreditCardTask;

public class CreditCard
{
    public string CardOwner { get; set; }
    public MoneyOnCard MoneyOnCard {  get; private set; }

    public CreditCard(string name, MoneyOnCard money)
    {
        CardOwner = name;
        MoneyOnCard = money;
    }

    public void SetNewAmount(int amount)
    {
        MoneyOnCard = new MoneyOnCard(amount);
    }

    public override string ToString()
    {
        return $"The card's owner: {CardOwner}. Money on the account: {MoneyOnCard}";
    }

    public void AddToAccount(int amount)
    {
        MoneyOnCard += amount;
    }

    public void WithdrawFromAccount(int amount)
    {
        MoneyOnCard -= amount;
    }
}
