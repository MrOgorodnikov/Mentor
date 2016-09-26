using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace BookStore.Models
{
    public class BookContext : DbContext
    {
        public DbSet<Mentor> Mentors { get; set; }
        public DbSet<Student> Students { get; set; }
    }
}