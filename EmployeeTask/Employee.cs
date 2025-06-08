namespace EmployeeTask;

public class Employee
{
    public string FullName { get; private set; }
    public string Email { get; private set; }
    public string Position { get; private set; }
    public Salary Salary { get; private set; }

    public Employee(string fullName, string email, string position, Salary salary)
    {
        FullName = fullName;
        Email = email;
        Position = position;
        Salary = salary;
    }

    public void IncreaseSalary(decimal amount)
    {
        Salary += amount;
    }

    public void DecreaseSalary(decimal amount)
    {
        Salary -= amount;
    }

    public override string ToString()
    {
        return $"Employee: {FullName}, position: {Position}, salary: {Salary}. Contact info: {Email}"; 
    }
}
