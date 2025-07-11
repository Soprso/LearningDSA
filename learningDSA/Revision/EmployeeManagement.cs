class Employee
{
    public int Id { get; set; }
    public required string Name { get; set; }

    public required string Department { get; set; }

    public double Salary { get; set; }
}

interface IEmployeeRepository<T>
{
    void Add(T item);
    List<T> GetAllEmployees();
    List<T> SearchEmployee(Func<T, bool> predicate);
    void RemoveEmployee(T item);
    void UpdateEmployee(T item);
}

class EmployeeRepository : IEmployeeRepository<Employee>
{
    private List<Employee> emp = new List<Employee>();
    public void Add(Employee item)
    {
        emp.Add(item);
    }
    public List<Employee> GetAllEmployees()
    {
        return emp;
    }

    public List<Employee> SearchEmployee(Func<Employee, bool> predicate)
    {
        return emp.Where(predicate).ToList();
    }

    public void RemoveEmployee(Employee item)
    {
        emp.Remove(item);
    }

    public void UpdateEmployee(Employee item)
    {
        var existingEmp = emp.FirstOrDefault(e => e.Id == item.Id);
        if (existingEmp != null)
        {
            existingEmp.Name = item.Name;
            existingEmp.Department = item.Department;
            existingEmp.Salary = item.Salary;
        }
    }
}