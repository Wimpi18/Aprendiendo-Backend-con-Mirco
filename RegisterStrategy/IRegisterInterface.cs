using System.Collections;

public interface IRegisterInterface
{
    (bool isSuccess, string message) Register();
}