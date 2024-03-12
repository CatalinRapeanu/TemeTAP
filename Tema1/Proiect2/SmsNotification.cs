namespace Proiect2;

//In aceasta clasa am folosit aceleasi principii ca in clasa EmailNotification
public class SmsNotification : INotification
{
    Random rand = new Random();
    public void ConfirmationCode(string dest)
    {
        Console.WriteLine("Your confirmation code is " + rand.Next(1000, 9999));
    }

    public void ConfirmBid(string dest)
    {
        Console.WriteLine("Are you sure you want to bid on this house?");
    }

    public void Alert(string dest)
    {
        Console.WriteLine("Someone logged into your account from another device. Is that you?");
    }
}