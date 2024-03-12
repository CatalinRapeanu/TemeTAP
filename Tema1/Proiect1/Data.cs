namespace Tema1;

//Clasa statica Data ne ajuta sa stocam datele
//Cum ar fi listele de admini, de utilizatori normali sau vizitatori
//Am implementat si metode de adaugare si stergere pentru aceste liste
public static class Data
{
    public static string Role1 = "R1";

    public static string Role2 = "R2";

    public static List<Admin> Admins = new List<Admin>();
    public static List<Visitor> Visitors = new List<Visitor>();
    public static List<NormalUser> Users = new List<NormalUser>();

    public static void AddAdmin(Admin admin)
    {
        if (Admins.Contains(admin))
        {
            Console.WriteLine("Admin already exists.");
        }
        else
        {
            Admins.Add(admin);
            Console.WriteLine("Admin added.");
        }
    }
    
    public static void AddUser(NormalUser user)
    {
        if (Users.Contains(user))
        {
            Console.WriteLine("User already exists.");
        }
        else
        {
            Users.Add(user);
            Console.WriteLine("User added.");
        }
    }

    //Aici am incercat sa ii dau o functionalitate in plus adminului
    //Adica daca un admin este de tipul R2, acesta nu poate sterge utilizatori de pe site
    //Doar adminii cu rolul R1 pot sterge alti utilizatori
    public static void RemoveUser(Guid userId, Admin admin)
    {
        var user = Users.SingleOrDefault(x => x.Id == userId);
        if (admin.Type == "R2")
        {
            Console.WriteLine("You don't have permission to delete this user.");
            return;
        }

        if (user != null)
        {
            user.SetActive(false);
            Console.WriteLine("User desactivated.");
        }
    }

    public static void AddVisitor(Visitor visitor)
    {
        if (Visitors.Contains(visitor))
        {
            Console.WriteLine("Visitor already exists.");
        }
        else
        {
            Visitors.Add(visitor);
            Console.WriteLine("Visitor added.");
        }
    }

    public static void RemoveVisitor(Guid visitorId)
    {
        var visitor = Visitors.SingleOrDefault(x => x.Id == visitorId);
        if(visitor != null)
        {
            visitor.SetActive(false);
            Console.WriteLine("Visitor desactivated.");
        }
    }
}