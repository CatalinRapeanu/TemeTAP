namespace Tema1;

//Am mostenit clasa abstracta BaseUser
public class Admin : BaseUser
{
    //Aici am implementat constructorul clasei de baza, si l-am adaptat pentru clasa noua, Admin
    public Admin(string name, string email, string pass, string type) : base(name, email, pass)
    {
        Type = type;
    }
    
    public string Type { get; set; } 
}