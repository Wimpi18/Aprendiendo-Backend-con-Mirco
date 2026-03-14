public class RegisterSystem
{
    private IRegisterInterface registerInterface;

    public RegisterSystem(IRegisterInterface registerInterface)
    {
        this.registerInterface = registerInterface;
    }

    public (bool isSuccess, string message) Register()
    {
        return registerInterface.Register();
    }

    public void SetStrategy(IRegisterInterface strategy)
    {
        if (strategy != null)
        {
            this.registerInterface = strategy;
        }
    }
}