using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess_Layer_Database.Entities
{
    [Table("QuizesAssignments")]
    public class QuizesAssignments
    {
        [Key]
        public int Id { get; set; }
        public int Mark { get; set; }
        public string Title { get; set; }

        //Navigation Property
        public User user {  get; set; }
        public Courses Courses { get; set; }


    }
}
