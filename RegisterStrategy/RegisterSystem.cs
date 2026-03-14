public class RegisterSystem
{
    private IRegisterInterface registerInterface;

    public RegisterSystem(IRegisterInterface registerInterface)
    {
        this.registerInterface = registerInterface;
    }

    public void Register()
    {
        registerInterface.Register();
    }

    public void SetStrategy(IRegisterInterface strategy)
    {
        if (strategy != null)
        {
            this.registerInterface = strategy;
        }
    }
}