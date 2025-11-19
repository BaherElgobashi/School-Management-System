using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace School_Management_System.Models
{
    public class Submission
    {
        //viii. Submission: - Id, AssignmentId, StudentId, SubmittedDate, FileUrl, Grade, GradedByTeacherId, Remarks 
        // Primary Key.
        public int Id { get; set; }
        public DateTime SubmittedDate { get; set; }
        public string FileUrl { get; set; }
        public string Grade { get; set; }
        public string Remarks { get; set; }

        // Foreign Key For Assignment Table.
        public int AssignmentId { get; set; }
        public Assignment Assignment { get; set; }

        // Foreign Key For Student Table.

        public int StudentId { get; set; }
        public User Student { get; set; }

        // Foreign Key For Teacher Table.
        public int GradedByTeacherId { get; set; }

        public User GradedByTeacher { get; set; }


    }
}