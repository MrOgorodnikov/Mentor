using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace BookStore.Models
{
    public class BookDbInitializer : DropCreateDatabaseAlways<BookContext>
    {
        protected override void Seed(BookContext db)
        {
            db.Mentors.Add(new Mentor { Name = "1", Surname = "2"});
            db.Mentors.Add(new Mentor { Name = "1", Surname = "2"});
            db.Mentors.Add(new Mentor { Name = "1", Surname = "2"});

            db.Students.Add(new Student { Name = "q", Surname = "w"});
            db.Students.Add(new Student { Name = "e", Surname = "r" });
            db.Students.Add(new Student { Name = "t", Surname = "y" });

            base.Seed(db);
        }
    }
}