using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace FirstMVC5Entity.Models
{
    public class BookContext : DbContext
    { //Свойства помогают получать из БД набор данных определенного типа (например, набор объектов Book)
        public DbSet<Book> Books { get; set; }
        public DbSet<Purchase> Purchases { get; set; }
    }
}