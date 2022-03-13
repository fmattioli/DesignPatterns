using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AwesomeGymLive.Domain.Entities
{
    public class Student
    {
        public Student(string FullName, DateTime BirthDate)
        {
            this.FullName = FullName;
            this.BirthDate = BirthDate;
            Active = true;
        }
        public int Id { get; set; }
        public string FullName { get; set; }
        public DateTime BirthDate { get; set; }
        public bool Active { get; set; }


    }
}
