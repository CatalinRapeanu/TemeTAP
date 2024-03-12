namespace Tema1;

public abstract class BaseUser
{
    public BaseUser(string name, string email, string pass)
    {
        Id = Guid.NewGuid();
        Name = name;
        Email = email;
        Password = pass;
    }
    
    //In aceasta clasa am folosit incapsularea pentru ca am pus functionalitatile clasei
    //in metode
    public Guid Id { get; private set; }
    public string Name { get; set; }
    public string Password { get; set; }
    public string Email { get; set; }
}