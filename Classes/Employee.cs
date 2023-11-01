
namespace Lab1
{
    public class Employee
    {
        public string LastName { get; }
        public string FirstName { get; }
        public string MiddleName { get; }
        public DateTime? DateOfBirth { get; set; }
        public int EmployeeId { get; }
        public string? RollNumber { get; set; }
        public string? Education { get; set; }
        public string? Specialty { get; set; }
        public DateTime? HireDate { get; set; }

        public Employee(string lastName, string firstName, string middleName, int emploeeId)
        {
            this.LastName = lastName;
            this.FirstName = firstName;
            this.MiddleName = middleName;
            this.EmployeeId = emploeeId;
        }

        public override string ToString()
        {
            return string.Format(
                $"Last name: {this.LastName};" +
                $" First name: {this.FirstName};" +
                $" Middle name: {this.MiddleName}\n" +
                $"Date of birthday: {this.DateOfBirth};\n" +
                $" Employee Id: {this.EmployeeId};" +
                $" Card Id: {this.RollNumber};\n" +
                $" Education: {this.Education};" +
                $" Speciality: {this.Specialty};\n" +
                $" Hire date: {this.HireDate};\n"
                );
        }
    }
}
