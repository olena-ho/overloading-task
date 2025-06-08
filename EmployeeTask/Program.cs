using EmployeeTask;

var anne = new Employee("Anne Boleyn", "anna@royalty.com", "Queen of England", new Salary(3000m));

Console.WriteLine(anne);

anne.IncreaseSalary(500m);
Console.WriteLine(anne);

anne.DecreaseSalary(1000m);
Console.WriteLine(anne);

var daniel = new Employee("Daniel Craig", "007@mi6.org", "Special Agent", new Salary(2500m));

Console.WriteLine(daniel);
Console.WriteLine(daniel.Salary == anne.Salary);

daniel.IncreaseSalary(2800m);
Console.WriteLine(daniel.Salary != anne.Salary);

anne.Salary.SetSalary(8000m);
Console.WriteLine(anne);

Console.WriteLine($"Is {anne.FullName}'s salary bigger than {daniel.FullName}'s? {anne.Salary > daniel.Salary}");
Console.WriteLine($"Is {anne.FullName}'s salary smaller than {daniel.FullName}'s? {anne.Salary < daniel.Salary}");
Console.WriteLine($"Is {anne.FullName}'s salary different from that of {daniel.FullName}? {anne.Salary != daniel.Salary}");