public class ActionCommand : ICommand
{
    private readonly Action ExecutionAction;
    private readonly Action UndoAction;

    public ActionCommand(Action executionAction, Action undoAction)
    {
        ExecutionAction = executionAction;
        UndoAction = undoAction;
    }

    public void Execute() => ExecutionAction?.Invoke();

    public void Undo() => UndoAction?.Invoke();
}
