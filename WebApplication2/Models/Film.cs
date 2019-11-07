using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication2.Models {
    public class Film {
        // ID фильма
        public int Id { get; set; }
        // название фильма
        public string Name { get; set; }
        // режиссёр фильма
        public string Author { get; set; }
        // дата
        public DateTime Date { get; set; }
        // отзыв
        public string Review { get; set; }
    }
}