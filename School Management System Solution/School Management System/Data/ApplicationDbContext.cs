using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using School_Management_System.Models;

namespace School_Management_System.Data
{
    public class ApplicationDbContext : DbContext
    {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }
        // override protected void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        // {
        //     optionsBuilder.UseSqlServer("Server=.;Database=SchoolManagementDB;Trusted_Connection=True;MultipleActiveResultSets=true");
        // }




        //public DbSet<User> Users { get; set; }
        //public DbSet<Department> Departments { get; set; }
        //public DbSet<Course> Courses { get; set; }
        //public DbSet<Class> Classes { get; set; }
        //public DbSet<StudentClass> StudentClasses { get; set; }
        //public DbSet<Attendance> Attendances { get; set; }
        //public DbSet<Assignment> Assignments { get; set; }
        //public DbSet<Submission> Submissions { get; set; }
        //public DbSet<Notification> Notifications { get; set; }
    }
}