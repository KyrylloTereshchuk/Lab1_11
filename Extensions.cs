
namespace Lab1
{
    public static class Extensions
    {
        public static IEnumerable<Employee> WhoseEducationIs(this IEnumerable<Employee> employees, string education)
        {
            return employees.Where(employee => employee.Education == education || employee.Education is null);
        }

        public static IEnumerable<Employee> EmployeesNameStartsOrEndsWith(this IEnumerable<Employee> employees, Func<string, bool> startOrEnd)
        {
            return employees.Where(a => startOrEnd(a.FirstName));
        }
    }
}
