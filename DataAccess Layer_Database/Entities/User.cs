using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore.Metadata;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess_Layer_Database.Entities
{
    [Table("Users")]
    public class User : IdentityUser<int>
    {
        // Properties
       public string TypeOfUser { get; set; }
       public DateTime DateCreated { get; set; } = DateTime.Now;
       public string PhoneNumber { get; set; }

       [ForeignKey("Role")]
       public int RoleId { get; set; }
        

       // [ForeignKey("Account")]
       //public int AdminId { get; set; }

        //Navigation Property
       public Role UserRole { get; set; }
       //public List<Payment> payments { get; set; }
       //public List<Courses> courses { get; set; }
       //public List<Review> reviews { get; set; }
       //public WishList WishList { get; set; }
       //public Adminstrator Adminstrator { get; set; }
       //public List<Certificates> certificates { get; set; }
       //public List<Enrollments> enrollments { get; set; }
       //public List<QuizesAssignments> quizes { get; set; }
       //public Account account { get; set; } 
    }
}
