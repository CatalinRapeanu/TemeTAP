using System;

namespace Proiect2;

//In aceasta clasa am folosit mostenirea
//Am mostenit interfata INotification
public class EmailNotification : INotification
{
    Random rand = new Random();
    
    //Datorita polimorfismului am putut implementa metode diferite pentru
    //toate clasele care mostenesc interfata INotification
    //In clasa EmailNotification am o implementare pentru aceste metode, iar
    //in clasa SmsNotification am alta implementare
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