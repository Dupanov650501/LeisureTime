﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication2.Models {
    public class Book {
        // ID книги
        public int Id { get; set; }
        // название книги
        public string Name { get; set; }
        // автор книги
        public string Author { get; set; }
        // дата
        public DateTime Date { get; set; }
        // отзыв
        public string Review { get; set; }
    }
}