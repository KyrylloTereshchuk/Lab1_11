
namespace Lab1
{
    public interface IQuery
    {
        public IEnumerable<Employee> GetEmployees();
        public IEnumerable<HelpNames> GetNames();
        public IEnumerable<Employee> GetByEducation(string education);
        public IEnumerable<string> GetCompaniesStartWith(string BegginingOfName);
        public IEnumerable<Employee> GetEmployeesYoungerAndWithIdLongerThan(int MinId, DateTime MaxDate);
        public IEnumerable<HelpCompaniesEmployee> GetEmployeesSalaries();
        public IEnumerable<Employee> GetEmployeesWhoseEducationIs(string education);
        public int GetMaxIdEmployeeWhoGotSalary();
        public Employee GetFirstEmployeeWithEducation(string education);
        public IEnumerable<Employee> GetEmployeesWithUseDelegate(Func<string, bool> predicate);
        public IEnumerable<HelpSalaryBySpeciality> GetSalaryBySpeciality();
        public IEnumerable<Employee> GetEmployeesByCondition(int employeesId, string education1, string education2);
        public IEnumerable<Employee> GetEmployeesFromTo(DateTime MinId, DateTime MaxId);
        public IEnumerable<HelpEmployeesAndTheirSalaryId> GetEmployeesAndTheirSalaryId();
        public IEnumerable<string> GetAllEducation();
        public int GetNumberOfEmployeesWithEducation(string education);
        public Employement[] GetEmployeesSalariesArray();
        public ILookup<DateTime?, string> GetLookup();
        public string? GetAllCardId();
        public IEnumerable<Employee> GetEmployeesWithoutSalary();
        public List<string> GetEmployeesBySpeciality(string speciality);
    }
}
