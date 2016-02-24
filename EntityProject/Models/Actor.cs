using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EntityProject.Models {
    public class Actor {

        public int Id { get; set; }

        public string Name { get; set; }

        public Movie Movie { get; set; }
    }
}