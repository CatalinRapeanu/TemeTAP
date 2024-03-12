namespace Tema1;

//Vedeti README
public class HouseEntity
{
    public Guid Id { get; set; }
    //Am folosit string? pentru a face aceasta proprietate nullable
    //Pentru a putea primi null daca nu ii este data alta valoare de 
    //tip string
    public string? Address { get; set; }
    public string? Country { get; set; }
    public string? Description { get; set; }
    public int Price { get; set; }
    public string? Photo { get; set; }
}