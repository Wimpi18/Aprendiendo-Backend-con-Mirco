namespace Chain_of_Responsability_Handler_Levels;

public class Level1Handler : SupportHandler
{
    public override void HandleRequest(int difficulty)
    {
        if (difficulty <= 1)
        {
            Console.WriteLine("Level 1 handled the request.");
        }
        else
            PassToNext(difficulty);
    }
}
