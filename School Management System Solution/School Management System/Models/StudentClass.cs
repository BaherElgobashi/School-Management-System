using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace School_Management_System.Models
{
    public class StudentClass
    {
        //- Id, StudentId, ClassId, EnrollmentDate
        //- Represents enrollment of a student in a class 

        public int Id { get; set; }
        // Foregin Key For User Table.
        public int StudentId { get; set; }
        // Navigation Property for User Table.
        public User User { get; set; }

        // Foregin Key for Class Table.
        public int ClassId { get; set; }
        // Navigation Property for Class Table.
        public Class Class { get; set; }
        

    }
}