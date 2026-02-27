namespace Chain_of_Responsability_Handler_Levels;

public abstract class SupportHandler
{
    protected SupportHandler? Successor;

    public void SetSuccessor(SupportHandler succesor)
    {
        this.Successor = succesor;
    }

    public abstract void HandleRequest(int difficulty);

    protected void PassToNext(int difficulty)
    {
        if (Successor != null)
        {
            Successor.HandleRequest(difficulty);
        }
        else
        {
            Console.WriteLine("End of chain reached: No one could handle this request.");
        }
    }
}
