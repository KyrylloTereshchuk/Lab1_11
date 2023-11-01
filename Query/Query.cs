
namespace Lab1
{
    public class Query : IQuery
    {
        private readonly ICollections _collections;
        public Query(ICollections collections)
        {
            _collections = collections;
        }
        public IEnumerable<Employee> GetEmployees()
        {
            return from e in _collections.Employees
                        select e;          
        }

        public IEnumerable<HelpNames> GetNames()
        {
            return from e in _collections.Employees
                            select new HelpNames (e.FirstName, e.LastName, e.MiddleName);
            
        }

        public IEnumerable<Employee> GetByEducation(string education)
        {
            return from e in _collections.Employees
                   where e.Education == education
                   select e;
        }

        public IEnumerable<string> GetCompaniesStartWith(string BegginingOfName)
        {
            var query = from x in _collections.Companys
                        where x.Name.StartsWith(BegginingOfName)
                        select x.Name;
            return query;
        }

        public IEnumerable<Employee> GetEmployeesYoungerAndWithIdLongerThan(int MinId, DateTime MaxDate)
        {
            var query = from x in _collections.Employees
                        where
                        (x.EmployeeId > MinId) &&
                        (x.DateOfBirth < MaxDate)
                        select x;
            return query;
        }

        public IEnumerable<HelpCompaniesEmployee> GetEmployeesSalaries()
        {
            var query = from x in _collections.Employees
                        from y in _collections.Companys
                        from z in _collections.Employements
                        where (z.CompanyId == y.Id) &&
                        (z.EmployeeId == x.EmployeeId)
                        orderby y.Name
                        select new HelpCompaniesEmployee( x.FirstName, y.Name);
            return query;
        }

        public IEnumerable<Employee> GetEmployeesWhoseEducationIs(string education)
        {
            var query = from x in _collections.Employees.WhoseEducationIs(education)
                        select x;
            return query;
        }

        public int GetMaxIdEmployeeWhoGotSalary()
        {
            return _collections.Salarys.Where(a => a.Salaries != null).Max(b => b.EmployeeId);
        }

        public Employee GetFirstEmployeeWithEducation(string education)
        {
            var query = (from x in _collections.Employees select x).First(x => x.Education == education);
            return query;
        }

        public IEnumerable<Employee> GetEmployeesWithUseDelegate(Func<string, bool> startOrEnd)
        {
            var query = from x in _collections.Employees.EmployeesNameStartsOrEndsWith(startOrEnd)
                        select x;
            return query;
        }


        public IEnumerable<HelpSalaryBySpeciality> GetSalaryBySpeciality()
        {
            var query = _collections.Employees.GroupJoin(_collections.Salarys, a => a.EmployeeId, b => b.EmployeeId, (a, b) =>
             new HelpSalaryBySpeciality(a.Specialty, b));
            return query;
        }

        public IEnumerable<Employee> GetEmployeesByCondition(int employeesId, string education1, string education2)
        {
            var query = _collections.Employees.Where((x) =>
            {
                return (x.EmployeeId < employeesId) && ((x.Education == education1) ||
                    (x.Education == education2));
            }).OrderBy(x => x.Education).ThenByDescending(x => x.EmployeeId);
            return query;
        }

        public IEnumerable<Employee> GetEmployeesFromTo(DateTime MinDate, DateTime MaxDate)
        {
            var query = _collections.Employees.SkipWhile(employee => employee.HireDate < MinDate)
                        .TakeWhile(employee => employee.HireDate <= MaxDate);
            return query;
        }

        public IEnumerable<HelpEmployeesAndTheirSalaryId> GetEmployeesAndTheirSalaryId()
        {
            var AllEmployees = _collections.Employees.Concat(_collections.EmployeesWithoutEmployement);


            var query = (from x in AllEmployees
                         join y in _collections.Salarys
                         on x.EmployeeId equals y.EmployeeId into temp
                         from t in temp.DefaultIfEmpty()
                         select new HelpEmployeesAndTheirSalaryId(x.LastName, (t == null) ? 0 : t.EmployeeId)).DistinctBy(e => e.LastName);
            return query;
        }

        public IEnumerable<string> GetAllEducation()
        {
            var query = (from x in _collections.Employees
                         select x.Education).Distinct();
            return query;
        }

        public int GetNumberOfEmployeesWithEducation(string education)
        {
            var query = _collections.Employees.Count(x => x.Education == education);
            return query;
        }

        public Employement[] GetEmployeesSalariesArray()
        {
            var query = (from x in _collections.Employements select x).ToArray();
            return query;
        }

        public ILookup<DateTime?, string> GetLookup()
        {
            var query = (from x in _collections.Employees
                         select x).ToLookup(x => x.HireDate, x => x.LastName);
            return (ILookup<DateTime?, string>)query;
        }

        public string? GetAllCardId()
        {
            var query = _collections.Employees
                        .Aggregate( (total, current) =>
                        {
                            total.RollNumber += " " + current.RollNumber;
                            return total;
                        });
            return query.RollNumber;
        }

        public IEnumerable<Employee> GetEmployeesWithoutSalary()
        {
            var query = _collections.EmployeesWithoutEmployement
                .Except(_collections.Employees, new EqualityComparer());
            return query;
        }

        public List<string> GetEmployeesBySpeciality(string speciality)
        {
            List<string> employeesName = new ();

            var query = _collections.Employees.GroupBy(p => p.Specialty);
            foreach (var group in query)
            {
                if (group.Key == speciality)
                {
                    foreach (var employee in group)
                    {
                        employeesName.Add(employee.LastName);
                    }
                }
            }
            return employeesName;
        }
    }
}
