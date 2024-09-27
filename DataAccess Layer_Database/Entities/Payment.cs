using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess_Layer_Database.Entities
{
    [Table("Payments")]
    public class Payment
    {
        public int Id { get; set; }
        public string Method { get; set; }
        public decimal Amount { get; set; }
        public DateTime PaymentDate { get; set; } = DateTime.Now;

        //Navigation Property
        public List<User> users {  get; set; }  
        public Courses Courses { get; set; }


    }
}
