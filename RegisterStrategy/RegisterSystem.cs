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
}