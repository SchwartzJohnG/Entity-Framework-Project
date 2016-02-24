using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EntityProject.Models {
    public class Movie {

        public int Id { get; set; }

        public string Title { get; set; }
        public string Director { get; set; }

        public IList<Actor> Actors { get; set; }
    }
}