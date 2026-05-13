public class User : IUserProvider
{
    public string Name { get; set; }
    public string Role { get; set; } // "User" o "Admin"

    public User GetCurrentUser()
    {
        return this;
    }
}
