using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess_Layer_Database.Entities
{
    [Table("Certificates")]
    public class Certificates
    {
        [Key]
        public int Id { get; set; }
        public DateTime IssuseDate { get; set; } = DateTime.Now;

        //Navigation Property
        [ForeignKey("CoursesId")]
        public Courses courses {  get; set; }

        [ForeignKey("UserId")]
        public int UserId { get; set; }

        public User user {  get; set; } 

    }
}
