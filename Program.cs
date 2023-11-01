
namespace Lab1
{
    class Program
    {

        static void Main()
        {
            Collections collections = new ();
            Query query = new(collections);
            Command command = new (query);
            Menu menu = new (command);
            Execution execution = new(menu);
            execution.ExecutionProcess();
        }

    }

}