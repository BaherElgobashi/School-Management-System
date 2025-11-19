using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace School_Management_System.Models
{
    public class Notification
    {
        //- Id, Title, Message, RecipientRole, RecipientId (optional), CreatedDate, IsRead 

        // Primary Key.
        public int Id { get; set; }
        public string Title { get; set; }
        public string Message { get; set; }

        public string RecipientRole { get; set; }
        public int? RecipientId { get; set; } // Optional
        public DateTime CreatedDate { get; set; }
        public bool IsRead { get; set; }


    }
}