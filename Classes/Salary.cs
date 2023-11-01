
namespace Lab1
{
    public class Salary
    {
        public int EmployeeId { get; }
        public List<decimal> Salaries { get; }

        public Salary(int employeeId)
        {
            EmployeeId = employeeId;
            this.Salaries = new List<decimal>();
        }

    }
}
