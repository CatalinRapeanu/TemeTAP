namespace Proiect2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //In main am testat metodele pentru clasele pe care le-am facut
            INotification smsNotification = new SmsNotification();
            smsNotification.ConfirmationCode("0764569445");
            smsNotification.ConfirmBid("0764569445");
            smsNotification.Alert("0764569445");

            INotification emailNotification = new EmailNotification();
            emailNotification.ConfirmationCode("catalinforthewin@gmail.com"); 
            emailNotification.ConfirmBid("catalinforthewin@gmail.com"); 
            emailNotification.Alert("catalinforthewin@gmail.com"); 
        }
    }
}