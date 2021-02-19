using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MovieRegistration.Models
{
    public class Movie
    {
        public int id { get; set; }
        public string title { get; set; }
        public string genre { get; set; }
        public DateTime year { get; set; }
        public string actors { get; set; }
        public string directors { get; set; }
    }
}
