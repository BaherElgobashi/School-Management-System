using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace School_Management_System.Models
{
    public class Department
    {
        // Primary Key.
        public int Id { get; set; }
        public string? Name { get; set; }
        
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }


        // Foregin Key To User Table
        public User HeadOfDepartmentId { get; set; }

        
    }
}