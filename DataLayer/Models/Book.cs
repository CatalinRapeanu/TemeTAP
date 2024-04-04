namespace DataLayer.Models;

public class Book
{
    public Guid Id { get; set; }
    public string Title { get; set; }
    public string Synopsis { get; set; }
    public string PublishingHouse { get; set; }
    public string Review { get; set; }
    
    public Guid AuthorId { get; set; }
    public Author Author { get; set; }
}