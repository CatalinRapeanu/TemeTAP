namespace Tema1;

//Vedeti README
public class BidEntity
{
    public Guid Id { get; set; }
    public Guid HouseId { get; set; }
    public HouseEntity? House { get; set; }
    public string Bidder { get; set; } = string.Empty;
    public int Amount { get; set; }
}