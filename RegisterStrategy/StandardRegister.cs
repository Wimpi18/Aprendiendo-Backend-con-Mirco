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

    public (bool isSuccess, string message) Register()
    {
        Console.Write("Registrando usuario con email " + email + " y password " + password);
        return (true, "Usuario registrado de manera estandar correctamente");
    }
}