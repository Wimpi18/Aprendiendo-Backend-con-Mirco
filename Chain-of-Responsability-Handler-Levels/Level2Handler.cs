namespace Chain_of_Responsability_Handler_Levels;

public class Level2Handler : SupportHandler
{

    public override void HandleRequest(int difficulty)
    {
        if (difficulty <= 2)
        {
            Console.WriteLine("Level 2 handled the request.");
        }
        else PassToNext(difficulty);
    }
}
