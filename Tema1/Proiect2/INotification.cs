namespace Proiect2;

public interface INotification
{
    //In aceasta interfata am folosit abstractizarea pentru ca am dat doar datele necesare
    //nu si alte detalii despre implementare, aceasta facandu-se in fiecare clasa copil
    //prin intermediul mostenirii si al polimorfismului
    public void ConfirmationCode(string dest);
    public void ConfirmBid(string dest);
    public void Alert(string dest);
}