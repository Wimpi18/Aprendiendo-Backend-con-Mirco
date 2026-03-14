using System.Collections;

public class GoogleRegister : IRegisterInterface
{
    private String token;
    public GoogleRegister(string token)
    {
        this.token = token;
    }

    public void Register()
    {
        Console.Write("Registrando usuario con Google y el token " + token);
    }
}