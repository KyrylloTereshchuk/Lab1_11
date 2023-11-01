
namespace Lab1
{
    public class Menu : IMenu
    {
        private readonly ICommand _command;
        public Menu(ICommand command)
        {
            _command = command;
        }

        public  Action[] CreateMenu()
        {
            Action[] methods = new Action[]
            {
                () => _command.Exit(),
                () => _command.Command1(),
                () => _command.Command2(),
                () => _command.Command3(),
                () => _command.Command4(),
                () => _command.Command5(),
                () => _command.Command6(),
                () => _command.Command7(),
                () => _command.Command8(),
                () => _command.Command9(),
                () => _command.Command10(),
                () => _command.Command11(),
                () => _command.Command12(),
                () => _command.Command13(),
                () => _command.Command14(),
                () => _command.Command15(),
                () => _command.Command16(),
                () => _command.Command17(),
                () => _command.Command18(),
                () => _command.Command19(),
                () => _command.Command20(),
                () => _command.Command21(),
            };

            return methods;
            
        }
    }
}
