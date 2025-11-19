using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace School_Management_System.Models
{
    public class Attendance
    {
        //- Id, ClassId, StudentId, Date, Status (Present/Absent/Late), MarkedByTeacherId, CreatedDate 

        // Primary Key
        public int Id { get; set; }

        public DateTime Date { get; set; }

        public string Status { get; set; } //Present/Absent/Late

        public DateTime CreatedDate { get; set; }

        // Foreign Key For Class Table.
        public int ClassId { get; set; }

        // Navigation Property For Class Table.
        public Class Class { get; set; }

        // Foreign Key For User Table.
        public int StudentId { get; set; }

        // Navigation Property For User Table.
        public User Student { get; set; }


        // Foreign Key For User Table.
        public int MarkedByTeacherId { get; set; }
        // Navigation Property For User Table.
        public User MarkedByTeacher { get; set; }

        





    }
}