namespace DataLayer.Models;

public class Director
{
    public Guid Id { get; set; }
    public string Name { get; set; }

    public List<Movie> Movies { get; set; } = [];
    public List<MovieDirector> MovieDirectors { get; set; }
}