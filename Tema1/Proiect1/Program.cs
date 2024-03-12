namespace Tema1;

class Program
{
    static void Main(string[] args)
    {
        //Am testat functionalitatile claselor implementate
        var admin1 = new Admin("Iulian Rusu", "iulian.rusu@centric.eu", "password", Data.Role1);
        var admin2 = new Admin("Popescu Ionut", "pop.ionut@centric.eu", "password", Data.Role2);

        Data.AddAdmin(admin1);
        Data.AddAdmin(admin2);
        Console.WriteLine("Total admins found: " + Data.Admins.Count());
        Console.WriteLine("R1 admins found: " + Data.Admins.Count(x => x.Type == Data.Role1));
        Console.WriteLine("R2 admins found: " + Data.Admins.Count(x => x.Type == Data.Role2));
        
        var visitor1 = new Visitor(String.Empty, String.Empty, String.Empty);
        var visitor2 = new Visitor(String.Empty, String.Empty, String.Empty);
        var visitor3 = new Visitor(String.Empty, String.Empty, String.Empty);
        
        Data.AddVisitor(visitor1);
        Data.AddVisitor(visitor2);  
        Data.AddVisitor(visitor3);
        
        Console.WriteLine("Total visitors: " + Data.Visitors.Count());
        Console.WriteLine("Total active visitors: " + Data.Visitors.Count(x => x.IsActive));
        
        Data.RemoveVisitor(visitor2.Id);
        
        Console.WriteLine("Total active visitors: " + Data.Visitors.Count(x => x.IsActive));
        Console.WriteLine("Total desactivated visitors: " + Data.Visitors.Count(x => x.IsActive == false));

        var user1 = new NormalUser("Gigel", "gigifortosu@yahoo.com", "barosanu123", "qwerty");
        var user2 = new NormalUser("Mihai", "mihaibaros@gmail.com", "fortosu", "qwerty123");
        var user3 = new NormalUser("Aurica", "aurasdelaoras@yahoo.com", "magnet", "qwerty12");
        
        Data.AddUser(user1);
        Data.AddUser(user2);
        Data.AddUser(user3);
        
        //Aici am testat daca un admin cu rolul R2 poate sterge un utilizator
        Data.RemoveUser(user1.Id, admin2);
        Data.RemoveUser(user3.Id, admin1);
        
        Console.WriteLine("Total active users: " + Data.Users.Count(x => x.IsActive));
        Console.WriteLine("Total desactivated users: " + Data.Users.Count(x => x.IsActive == false));
    }
}