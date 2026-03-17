using System.Collections;

public class GoogleRegister : IRegisterInterface
{
    private String token;

    public GoogleRegister(string token)
    {
        this.token = token;
    }

    public (bool isSuccess, string message) Register()
    {
        Console.Write("Registrando usuario con Google y el token " + token);
        return (true, "Usuario registrado con Google correctamente");
    }
}
