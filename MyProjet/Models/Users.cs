using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyProjet.Models
{
    public class Users
    {
        [Key]
       
        public int UserId { get; set; }
       
        public String UserName { get; set; }
       

       
        public String Email { get; set; }
       
        public String Password { get; set; }
       
        public String CreatedDate { get; set; }

       public Users()
        {
            CreatedDate = DateTime.Now.ToString();
        }
    }
}
