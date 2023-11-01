
namespace Lab1
{
    public class Employement
    {
        public int EmployeeId { get; }
        public int CompanyId { get; }

        public Employement(int employeeId, int companyId)
        {
            EmployeeId = employeeId;
            CompanyId = companyId;
        }

        public override string ToString()
        {
            return String.Format(
                $"EmployeeId = {EmployeeId} " +
                $"CompanyId = {CompanyId}"
                );
        }
    }
}
