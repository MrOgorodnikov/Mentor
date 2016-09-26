using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BookStore.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        //public int BookId { get; set; }
        //public DateTime Date { get; set; }
        [F]
        public int MentorId { get; set; }
    }
}