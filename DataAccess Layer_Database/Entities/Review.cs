using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess_Layer_Database.Entities
{
    [Table("Reviews")]
    public class Review
    {
        [Key]
        public int ReviewId { get; set; }
        public string Comment { get; set; }
        public int  Rating { get; set; }
        public DateTime ReviewDate { get; set; }= DateTime.Now;

        [ForeignKey("User")]
        public int UserId { get; set; }


        //Navigation Property
        public User? user { get; set; }


    }
}
