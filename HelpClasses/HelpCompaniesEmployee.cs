
namespace Lab1
{
    public class HelpCompaniesEmployee
    {
        public string Company { get; }
        public string FirstName { get; }

        public HelpCompaniesEmployee(string company, string firstName)
        {
            this.FirstName = firstName;
            this.Company = company;
        }

        public override string ToString()
        {
            return string.Format(
                $"Company: {this.Company};" +
                $" First name: {this.FirstName}\n"
                );
        }
    }
}
