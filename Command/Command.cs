
namespace Lab1
{
    public class Command : ICommand
    {
        private readonly IQuery _query;

        public Command(IQuery query)
        {
            _query = query;
        }

        public void Exit()
        {
            Environment.Exit(0);
        }
        public void Command1()
        {
            var c1 = _query.GetEmployees();

            foreach (var employee in c1)
                Console.WriteLine(employee);
        }

        public void Command2()
        {
            var c2 = _query.GetNames();

            foreach (var employee in c2)
                Console.WriteLine(employee);
        }
        public void Command3()
        {
            var c3 = _query.GetByEducation("");

            foreach (var employee in c3)
                Console.WriteLine(employee);
        }

        public void Command4()
        {
            var startWith = _query.GetCompaniesStartWith("S");
            foreach (var a in startWith)
                Console.WriteLine(a);
        }
        public void Command5()
        {
            var olderAndLonger = _query.GetEmployeesYoungerAndWithIdLongerThan(0, new DateTime(2000, 1, 1));
            foreach (var c in olderAndLonger)
                Console.WriteLine(c);
        }
        public void Command6()
        {
            var salaries = _query.GetEmployeesSalaries();
            foreach (var c in salaries)
                Console.WriteLine(c);
        }

        public void Command7()
        {
            var educationIs = _query.GetEmployeesWhoseEducationIs("");
            foreach (var a in educationIs)
                Console.WriteLine(a);
        }
        public void Command8()
        {
            Console.WriteLine(_query.GetMaxIdEmployeeWhoGotSalary());
        }
        public void Command9()
        {
            Console.WriteLine(_query.GetFirstEmployeeWithEducation(".Net Developer"));
        }
        public void Command10()
        {
            var endWith = _query.GetEmployeesWithUseDelegate(x => x.EndsWith("v"));
            foreach (var c in endWith)
                Console.WriteLine(c);
            var startWirh = _query.GetEmployeesWithUseDelegate(x => x.StartsWith("A"));
            foreach (var c in startWirh)
                Console.WriteLine(c);
        }
        public void Command11()
        {
            var salaries = _query.GetSalaryBySpeciality();
            foreach (var a in salaries)
            {
                Console.WriteLine($"{a.Speciality}:");
                foreach (var salary in a.MonthlySalaries)
                {
                    Console.WriteLine($"    {salary}");
                }
            }
        }
        public void Command12()
        {
            var byCondition = _query.GetEmployeesByCondition(999999, ".Net Developer", "Java Developer");
            foreach (var a in byCondition)
                Console.WriteLine(a);
        }
        public void Command13()
        {
            var fromTo = _query.GetEmployeesFromTo(new DateTime(2021, 3, 21), new DateTime(2023, 3, 22));
            foreach (var m in fromTo)
                Console.WriteLine(m);
        }
        public void Command14()
        {
            var EmpSalId = _query.GetEmployeesAndTheirSalaryId();
            foreach (var a in EmpSalId)
                Console.WriteLine(a);
        }
        public void Command15()
        {
            var allEducation = _query.GetAllEducation();
            foreach (var a in allEducation)
                Console.WriteLine(a);
        }
        public void Command16()
        {
            Console.WriteLine(_query.GetNumberOfEmployeesWithEducation(".Net Developer"));
        }
        public void Command17()
        {
            var array = _query.GetEmployeesSalariesArray();
            foreach (var m in array)
                Console.WriteLine(m);
        }
        public void Command18()
        {
            var lookup = _query.GetLookup();

            foreach (var group in lookup)
            {
                Console.WriteLine(group.Key);
                foreach (var employement in group)
                {
                    Console.WriteLine("   " + employement);
                }
            }
        }
        public void Command19()
        {
            var allCardId = _query.GetAllCardId();
            Console.WriteLine(allCardId);
        }
        public void Command20()
        {
            var withoutSalary = _query.GetEmployeesWithoutSalary();
            foreach (var m in withoutSalary)
                Console.WriteLine(m);
        }
        public void Command21()
        {
            var bySpeciality = _query.GetEmployeesBySpeciality("Java Developer");
            foreach (var m in bySpeciality)
                Console.WriteLine(m);
        }
    }
}
