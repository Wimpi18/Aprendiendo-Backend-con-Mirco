using System.Collections;

public class StandardRegister : IRegisterInterface
{
    private String email;
    private String password;
    public StandardRegister(String email, String password)
    {
        this.email = email;
        this.password = password;
    }

    public void Register()
    {
        Console.Write("Registrando usuario con email " + email + " y password " + password);
    }
}