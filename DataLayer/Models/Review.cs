namespace DataLayer.Models;

public class Review
{
    public Guid Id { get; set; }
    public string Title { get; set; }
    public string Content { get; set; }
    
    public Guid UserId { get; set; }
    public User User { get; set; }
}