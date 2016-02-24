using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace EntityProject.Models {

    public class DataContext : DbContext {

        public IDbSet<Actor> Actors { get; set; }
        public IDbSet<Movie> Movies { get; set; }
    }
}