using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace School_Management_System.Models
{
    public class User
    {
        // Primary Key.
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Email { get; set; }
        public string? Password { get; set; }
        public string? Role { get; set; } // Admin / Teacher / Student.
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }

        // Navigation Property.

        // public ICollection<Department> Departments { get; set; }

    }
}