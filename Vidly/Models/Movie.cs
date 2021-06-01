using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Vidly.Models
{
    public class Movie                  //POCO represent state and behaviour
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
    // page to render these details would be under
    // /movies/random
}
