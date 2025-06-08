using CreditCardTask;

var creditCard1 = new CreditCard("Pavlo Savchuk", new MoneyOnCard(20000));

Console.WriteLine(creditCard1);

creditCard1.SetNewAmount(6000);
Console.WriteLine(creditCard1);

creditCard1.AddToAccount(15000);
Console.WriteLine(creditCard1);

var creditCard2 = new CreditCard("Ivanna Hanchuk", new MoneyOnCard(78000));

Console.WriteLine($"Does {creditCard1.CardOwner} has more money on the account than {creditCard2.CardOwner}? {creditCard1.MoneyOnCard > creditCard2.MoneyOnCard}");