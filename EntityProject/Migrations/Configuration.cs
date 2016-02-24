namespace EntityProject.Migrations
{
    using Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<EntityProject.Models.DataContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(EntityProject.Models.DataContext context) {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
            
            var movies = new List<Movie> {
                new Movie { Title = "Star Wars", Director = "Lucas" },
                new Movie { Title = "Momento", Director = "Nolan" },
                new Movie { Title = "Jaws", Director = "Spielberg" }
            };
            var actors = new List<Actor> {
                new Actor { Name = "Harrison Ford", Movie = movies[0] },
                new Actor { Name = "Guy Pearce", Movie = movies[1] },
                new Actor { Name = "Roy Scheider", Movie = movies[2] }
            };
            context.Movies.AddOrUpdate(
                m => m.Title,
                movies[0],
                movies[1],
                movies[2]
            );

            

            context.Actors.AddOrUpdate(
                a => a.Name,
                actors[0],
                actors[1],
                actors[2]
            );
            context.SaveChanges();
        }
    }
}
