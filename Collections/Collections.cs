
namespace Lab1
{
    public class Collections : ICollections
    {
        public IEnumerable<Employee> Employees => new List<Employee>()
        {
            new Employee("Grachov", "Artem", "Sergiyovich", 1)
            {DateOfBirth = new DateTime(2003, 3, 12), RollNumber = "EM1212", Education = ".Net Developer", HireDate = new DateTime(2023, 3, 21), Specialty =  "barista" },

            new Employee("Tkach", "Vladislav", "Anatoliyovich", 2)
            {DateOfBirth = new DateTime(2003, 12, 29), RollNumber = "AV3256", Education = ".Net Developer", HireDate = new DateTime(2023, 3, 20), Specialty =  "manager"  },

            new Employee("Hunko", "Jaroslav", "Yuriyovich", 3)
            {DateOfBirth = new DateTime(2004, 1, 21), RollNumber = "AV9275", Education = "lawyer", HireDate = new DateTime(2023, 1, 12), Specialty =  "lawyer"  },

            new Employee("Petruk", "Olga", "Sergiyivna", 4)
            {DateOfBirth = new DateTime(2003, 12, 31), RollNumber = "VL3256", Education = "JavaScript Developer", HireDate = new DateTime(2023, 6, 2), Specialty =  "Java Developer"  },

            new Employee("Koshilka", "Jaroslav", "Victorovich", 5)
            {DateOfBirth = new DateTime(2003, 8, 19), RollNumber = "VL9043", Education = "Java Developer", HireDate = new DateTime(2022, 12, 11), Specialty =  "JavaScript Developer"  },

            new Employee("Tsvigun", "Olexandr", "Olegovich", 6)
            {DateOfBirth = new DateTime(1998, 4, 30), RollNumber = "VL2552", Education = ".Net Developer", HireDate = new DateTime(2022, 12, 11), Specialty =  "HR"  }
        };

        public IEnumerable<Employee> EmployeesWithoutEmployement => new List<Employee>()
        {
            new Employee("Buk", "Anatoliy", "Ivanovich", 7)
            {DateOfBirth = new DateTime(2002, 1, 27), RollNumber = "EM1752", Education = ".Net Developer"},

            new Employee("Loshuk", "Irina", "Olexandrivna", 8)
            {DateOfBirth = new DateTime(2004, 10, 1), RollNumber = "AV9206", Education = ".Net Developer" },

             new Employee("Tsvigun", "Olexandr", "Olegovich", 6)
            {DateOfBirth = new DateTime(1998, 4, 30), RollNumber = "VL2552", Education = ".Net Developer"}
        };

        public IEnumerable<Company> Companys => new List<Company>()
        {
            new Company("Pilligrim", 1),
            new Company("Squad", 1),
            new Company("Grimm", 2),
        };

        public IEnumerable<Employement> Employements => new List<Employement>()
        {
            new Employement(Employees.ElementAt(0).EmployeeId, Companys.ElementAt(1).Id),
            new Employement(Employees.ElementAt(1).EmployeeId, Companys.ElementAt(0).Id),
            new Employement(Employees.ElementAt(2).EmployeeId, Companys.ElementAt(1).Id),
            new Employement(Employees.ElementAt(3).EmployeeId, Companys.ElementAt(2).Id),
            new Employement(Employees.ElementAt(4).EmployeeId, Companys.ElementAt(2).Id),
            new Employement(Employees.ElementAt(5).EmployeeId, Companys.ElementAt(2).Id),
        };

        public IEnumerable<Salary> Salarys => new List<Salary>()
        {
            new Salary(Employees.ElementAt(0).EmployeeId),
            new Salary(Employees.ElementAt(1).EmployeeId),
            new Salary(Employees.ElementAt(2).EmployeeId),
            new Salary(Employees.ElementAt(3).EmployeeId),
            new Salary(Employees.ElementAt(4).EmployeeId),
            new Salary(Employees.ElementAt(5).EmployeeId),
        };
    }
}
