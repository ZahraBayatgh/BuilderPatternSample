using BuilderPatternSample;

public class EmployeeBuilder
{
    private string? _name;
    private int _age;
    private string? _address;
    private string? _jobTitle;
    private double _salary;

    public EmployeeBuilder WithName(string name)
    {
        _name = name;
        return this;
    }

    public EmployeeBuilder WithAge(int age)
    {
        _age = age;
        return this;
    }

    public EmployeeBuilder WithAddress(string address)
    {
        _address = address;
        return this;
    }

    public EmployeeBuilder WithJobTitle(string jobTitle)
    {
        _jobTitle = jobTitle;
        return this;
    }

    public EmployeeBuilder WithSalary(double salary)
    {
        _salary = salary;
        return this;
    }

    public Employee Build()
    {
        Employee employee = new Employee();
        employee.Name = _name;
        employee.Age = _age;
        employee.Address = _address;
        employee.JobTitle = _jobTitle;
        employee.Salary = _salary;
        return employee;
    }
}
