
namespace Lab1
{
    public class HelpNames
    {
        public string FirstName { get; }
        public string LastName { get; }
        public string MiddleName { get; }

        public HelpNames(string firstName, string lastName, string middleName)
        {
            FirstName = firstName;
            LastName = lastName;
            MiddleName = middleName;
        }
        public override string ToString()
        {
            return string.Format(
                $"Last name: {this.LastName};" +
                $" First name: {this.FirstName};" +
                $" Middle name: {this.MiddleName}\n"               
                );
        }
    }
}
