namespace Tema1;

//La fel ca la clasa Admin, am mestenit clasa abstracta BaseUser
//si am implementat constructorul, si pe lannga acesta inca o metoda
//care schimba starea utilizatorului, activ sau inactiv
public class NormalUser : BaseUser
{
    public NormalUser(string name, string email, string pass, string imgProfile) : base(name, email, pass)
    {
        ImageProfile = imgProfile;
        IsActive = true;
    }
    
    public string ImageProfile { get; set; }
    
    public bool IsActive { get; private set; }

    public void SetActive(bool active)
    {
        IsActive = active;
    }
    
}