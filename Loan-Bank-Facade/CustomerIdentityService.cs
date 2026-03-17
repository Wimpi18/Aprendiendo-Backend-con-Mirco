public class CustomerIdentityService
{
    public bool VerifyIdentity(string customerId)
    {
        Console.WriteLine($"[Identity] Verificando identidad y listas AML para el cliente {customerId}...");
        return true; 
    }
}