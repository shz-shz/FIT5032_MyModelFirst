using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FIT5032_MyModelFirst.Models2
{
    public class Student
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public virtual ICollection<Unit> Unit { get; set; }
    }
}