using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace WebApplication2.Models {
    public class ElementContext : DbContext {
        public DbSet<Book> Books { get; set; }
        public DbSet<Film> Films { get; set; }
    }
}