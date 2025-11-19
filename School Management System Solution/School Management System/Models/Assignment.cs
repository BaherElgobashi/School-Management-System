using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace School_Management_System.Models
{
    public class Assignment
    {
        //vii. Assignment: - Id, ClassId, Title, Description, DueDate, CreatedDate, CreatedByTeacherId  
        
        // Primary Key.
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime DueDate { get; set; }
        public DateTime CreatedDate { get; set; }

        // Foreign Key For Class Table.
        public int ClassId { get; set; }
        // Navigation Property for Class Table
        public Class Class { get; set; }

        // Foreign Key For Teacher Table.
        public int CreatedByTeacherId { get; set; }

        // Navigation Property For Teacher Table.
        public User CreatedByTeacher { get; set; }
    }
}