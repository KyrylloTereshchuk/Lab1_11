
namespace Lab1
{
    public interface ICollections
    {
        IEnumerable<Employee> Employees { get; }
        IEnumerable<Company> Companys { get; }
        IEnumerable<Employement> Employements { get; }
        IEnumerable<Salary> Salarys { get; }
        IEnumerable<Employee> EmployeesWithoutEmployement { get; }
    }
}
