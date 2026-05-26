using System.Collections.Concurrent;

public class TransactionManager
{
    private readonly ConcurrentStack<ICommand> Commands = new ConcurrentStack<ICommand>();

    public void ExecuteCommand(ICommand command)
    {
        command.Execute();
        Commands.Push(command);
    }

    public void UndoCommand()
    {
        if (Commands.TryPop(out ICommand? result))
            result?.Undo();
        else
            Console.WriteLine("No existen comandos para deshacer");
    }
}
