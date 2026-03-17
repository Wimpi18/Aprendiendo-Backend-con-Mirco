using System.Collections;

public class InvitedRegister : IRegisterInterface
{
    public InvitedRegister() { }

    public (bool isSuccess, string message) Register()
    {
        Console.Write("Registrando usuario como invitado");
        return (true, "Usuario invitado registrado correctamente");
    }
}
