namespace EmployeeTask;

public class Salary
{
    public decimal Value { get; private set; }

    public Salary(decimal value)
    {
        if (value < 0)
        {
            throw new ArgumentException("Salary cannot be negative.");
        }
        Value = value;
    }

    public void SetSalary(decimal newSalary)
    {
        if (newSalary < 0)
        {
            throw new ArgumentException("Salary cannot be negative");
        }
        Value = newSalary;
    }

    #region + / -
    public static Salary operator +(Salary s, decimal amount) => new Salary(s.Value + amount);

    public static Salary operator -(Salary s, decimal amount) => new Salary(s.Value - amount);
    #endregion

    #region == / !=
    public static bool operator ==(Salary s1, Salary s2) => (s1.Value == s2.Value);

    public override bool Equals(object obj)
    {
        return this == (obj as Salary);
    }

    public static bool operator !=(Salary s1, Salary s2) => !(s1 == s2);

    #endregion

    #region > / <
    public static bool operator >(Salary s1, Salary s2) => (s1.Value > s2.Value);

    public static bool operator <(Salary s1, Salary s2) => s1.Value < s2.Value;

    #endregion
    public override string ToString() => $"{Value:C}";
}
