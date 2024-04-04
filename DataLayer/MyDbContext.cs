using DataLayer.Models;
using Microsoft.EntityFrameworkCore;

namespace DataLayer
{
    // dotnet ef migrations add Initial
    // dotnet ef database update
    public class MyDbContext : DbContext
    {
        //private readonly string _windowsConnectionString = @"Server=.\SQLExpress;Database=Lab5Database1;Trusted_Connection=True;TrustServerCertificate=true";
        //private readonly string _windowsConnectionString = @"Server=localhost\SQLEXPRESS;Database=Lab5Database1;Trusted_Connection=True;TrustServerCertificate=True;";
        private readonly string _windowsConnectionString = @"Server=localhost;Database=Lab5Database1;Trusted_Connection=False;TrustServerCertificate=True;User Id=sa; Password=Rc10@bossu2002";
        
        public DbSet<User> Users { get; set; }
        public DbSet<UserType> UserTypes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_windowsConnectionString);
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<User>()
                .HasOne(f => f.Type)
                .WithMany(c => c.Users)
                .HasForeignKey(f => f.TypeId);

            //one to many relationship between book and author
            builder.Entity<Book>()
                .HasOne(f => f.Author)
                .WithMany(x => x.Books)
                .HasForeignKey(f => f.AuthorId);

            //many to many relationship between movie and director
            builder.Entity<Movie>()
                .HasMany(m => m.Directors)
                .WithMany(m => m.Movies)
                .UsingEntity<MovieDirector>();

            //one to one relationship between user and review
            builder.Entity<User>()
                .HasOne(r => r.Review)
                .WithOne(r => r.User)
                .HasForeignKey<Review>(r => r.UserId)
                .IsRequired();

            //Aici am incercat sa adaug valoile predefinite pentru fiecare tabel
            //dar nu am reusit. Nu stiu daca am facut gresit, dar nu mi le incarca in baza de date
            
            //Pentru UserType am facut inainte din swagger 2 tipuri pentru a avea id-urile
            //sa le pot adauga la User
            
            // builder.Entity<Author>().HasData(
            //     new Author
            //     {
            //         Id = Guid.NewGuid(), Books = [new Book { Title = "Pet Sematary" }, new Book { Title = "IT" }],
            //         Name = "Stephen King"
            //     },
            //     new Author
            //     {
            //         Id = Guid.NewGuid(),
            //         Books = [new Book { Title = "The Raven" }, new Book { Title = "The Black Cat" }],
            //         Name = "Edgar Allan Poe"
            //     }
            // );
            //
            // builder.Entity<Book>().HasData(
            //     new Book
            //     {
            //         Id = Guid.NewGuid(), Title = "Pet Sematary", Synopsis = "sdfsdfsf", PublishingHouse = "Nemira",
            //         Review = "bun"
            //     },
            //     new Book
            //     {
            //         Id = Guid.NewGuid(), Title = "IT", Synopsis = "gdfgdd", PublishingHouse = "Nemira", Review = "f bun"
            //     },
            //     new Book
            //     {
            //         Id = Guid.NewGuid(), Title = "The Raven", Synopsis = "aaaaaa", PublishingHouse = "Nemira",
            //         Review = "bunn"
            //     }
            // );
            //
            // builder.Entity<Movie>().HasData(
            //     new Movie { Id = Guid.NewGuid(), Name = "Kill Bill", Description = "sdfgdsgfdf", Review = "dfgdgfdg" },
            //     new Movie { Id = Guid.NewGuid(), Name = "Taxi Driver", Description = "gggg", Review = "sdfsdf" }
            // );
            //
            // builder.Entity<Director>().HasData(
            //     new Director { Id = Guid.NewGuid(), Name = "Quentin Tarantino" },
            //     new Director { Id = Guid.NewGuid(), Name = "Martin Scorsese" },
            //     new Director { Id = Guid.NewGuid(), Name = "Steven Spielberg" }
            // );
            //
            // builder.Entity<Review>().HasData(
            //     new Review { Id = Guid.NewGuid(), Title = "qweqew", Content = "sdgsdgdf" },
            //     new Review { Id = Guid.NewGuid(), Title = "pppppp", Content = "jtyjyty" }
            // );
            //
            // builder.Entity<UserType>().HasData(
            //     new UserType("normal") { Id = Guid.Parse("44af19e9-0cc8-407c-842a-08dc52e98ea3") },
            //     new UserType("admin") { Id = Guid.Parse("c5e12bb1-b8fd-4155-2f1d-08dc541145e2") }
            // );
            //
            // builder.Entity<User>().HasData(
            //     new User("Gicu", "gigi@gdfgd.com", "gdsgdsfg", Guid.Parse("44af19e9-0cc8-407c-842a-08dc52e98ea3")){Id = Guid.NewGuid()},
            //     new User("Marius", "gsfdgd@gdfgd.com", "fff", Guid.Parse("c5e12bb1-b8fd-4155-2f1d-08dc541145e2")){Id = Guid.NewGuid()}
            // );

        }
    }
}
