namespace DataLayer.Models;

public class Movie
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public string Review { get; set; }

    public List<Director> Directors { get; set; } = [];
    public List<MovieDirector> MovieDirectors { get; set; }
}