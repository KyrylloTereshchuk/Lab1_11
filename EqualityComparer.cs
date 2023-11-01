
namespace Lab1
{
    public class EqualityComparer : IEqualityComparer<Employee>
    {

        public bool Equals(Employee x, Employee y)
        {

            bool Result = false;
            if (x.LastName == y.LastName &&
                x.FirstName == y.FirstName &&
                x.MiddleName == y.MiddleName &&
                x.DateOfBirth == y.DateOfBirth || (x.DateOfBirth is null || y.DateOfBirth is null) &&
                x.EmployeeId == y.EmployeeId &&
                x.RollNumber == y.RollNumber &&
                x.Education == y.Education &&
                x.Specialty == y.Specialty || (x.Specialty is null || y.Specialty is null) &&
                x.HireDate == y.HireDate ||(x.HireDate is null || y.HireDate is null))
                Result = true;
            return Result;
        }

        public int GetHashCode(Employee obj)
        {
            return obj.EmployeeId;
        }
    }

}
