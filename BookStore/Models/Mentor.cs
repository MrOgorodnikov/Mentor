using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookStore.Models
{
    public class Mentor
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        //public int Price { get; set; }
        public ICollection<Student> Students { get; set; }
    }
}