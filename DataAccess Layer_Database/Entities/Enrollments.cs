using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess_Layer_Database.Entities
{
    [Table("Enrollment")]
    public class Enrollments
    {
        public int Id { get; set; }
        public bool IsCompletion { get; set; }
        public DateTime Date { get; set; } = DateTime.Now;

        [ForeignKey("User")]
        public int UserId { get; set; }


        //Navigation Property
        public Courses courses {  get; set; }
        public User user {  get; set; }

    }
}
