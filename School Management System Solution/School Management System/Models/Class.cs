using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace School_Management_System.Models
{
    public class Class
    {
        // - Id, Name, CourseId, TeacherId, Semester, StartDate, EndDate, IsActive, CreatedDate, 
        //UpdatedDate
         //A teacher teaches a class for a course 
         // - A class contains multiple students 

        // Primary Key.
        public int Id { get; set; }
        public string Name { get; set; }

        public string Semester { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }

        // Foregin Key For Course Table.
        public int CourseId { get; set; }
        // Navigation Property For Course Table.
        public Course Course { get; set; }

        // Foregin Key For User Table.
        public int TeacherId { get; set; }

        // Navigation Property For User Table.
        public User User { get; set; }

        // Navigation Property For StudentClass Table.
        public ICollection<StudentClass> StudentClasses { get; set; }






    }
}