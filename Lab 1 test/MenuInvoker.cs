using Lab_1_test.Interfaces;

public class MenuInvoker
{
    private List<ICommand> commands = new List<ICommand>();

    public void AddCommand(ICommand command)
    {
        commands.Add(command);
    }

    public void ExecuteCommand(int index)
    {
        if (index >= 0 && index < commands.Count)
        {
            commands[index].Execute();
        }
    }
}