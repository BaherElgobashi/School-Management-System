using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace School_Management_System.Models
{
    // ii. 
    // Course: 
    // - Id, Name, Code, Description, DepartmentId, Credits, CreatedDate, UpdatedDate 
    // - Each course belongs to a department 
    // - Each course can have multiple classes (batches) 
    public class Course
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Code { get; set; }
        public string? Description { get; set; }

        public int Credits { get; set; }

        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }

        // Foreign Key to Department Table.

        public int DepartmentId { get; set; }
        // Navigation Property To Department Table.
        public Department Department { get; set; }
        
    }
}