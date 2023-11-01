
namespace Lab1
{
    public class Execution
    {
        private readonly IMenu _menu;

        public Execution(IMenu menu)
        {
            _menu = menu;
        }

        public void ExecutionProcess()
        {
            var methods = _menu.CreateMenu();

            while (true)
            {
                Console.Write("Enter methods number: ");
                if (int.TryParse(Console.ReadLine(), out int methodNumber) && methodNumber >= 0 && methodNumber <= 21 && methodNumber <= methods.Length)
                {
                    methods[methodNumber]();
                }
                else
                {
                    Console.WriteLine("Wrong input");
                }
            }
        }
    }
}
