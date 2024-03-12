namespace Tema1;

//Clasa Visitor am creat-o pentru acei utilizatori care doar intra pe site,
//care sunt doar in vizita, adica nu au un cont creat
public class Visitor : BaseUser
{
    public Visitor(string name, string email, string pass) : base(name, email, pass)
    {
        IsActive = true;
    }
    
    public bool IsActive { get; private set; }

    public void SetActive(bool active)
    {
        IsActive = active;
    }
}