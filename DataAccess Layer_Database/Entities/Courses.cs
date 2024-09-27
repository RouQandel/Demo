using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess_Layer_Database.Entities
{
    [Table("Course")]
    public class Courses
    {
        [Key]
        public int CoursesId { get; set; }
        public int Price { get; set; }
        public string InstrctorName { get; set; }
        public string Content { get; set; }
        public string Description { get; set; }
        public string Title { get; set; }

        [ForeignKey("User")]
        public int UserId { get; set; }


        //Navigation Property
        public User Instructor { get; set; }
        public List<Category> categories {  get; set; }
        public List<Payment> payments { get; set; }
        public List<WishList> wishLists {  get; set; }
        public List<Certificates> Certificates { get; set; }
        public List<Enrollments> Enrollments {  get; set; }
        public List<QuizesAssignments> quizes {  get; set; }

    }
}
