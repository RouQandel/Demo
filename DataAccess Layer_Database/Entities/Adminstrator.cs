using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess_Layer_Database.Entities
{
    [Table("Adminstrator")] 
    public class Adminstrator
    {
        [Key]
        public int AdminId { get; set; }

        [Required]
        public string AdminName { get; set; }

        [Required]
        public string AdminPassword { get; set; }
        [Required]
        public string AdminEmail { get; set; } = string.Empty;

        //Navigation Property
        public List<User> Users { get; set; }
    }
}
