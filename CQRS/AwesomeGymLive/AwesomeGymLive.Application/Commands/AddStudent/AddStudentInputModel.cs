using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AwesomeGymLive.Application.Commands.AddStudent
{
    public class AddStudentInputModel
    {
        public string? FullName { get; set; }
        public DateTime BirthDate { get; set; }
    }
}
