using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyProjet.Models
{
    public class Account
    {
        [Key]
        public string LoginName { get; set; }
        [Required]
        public string Password { get; set; }
         //[Range(6,int.MaxValue,ErrorMessage ="Error")]
        public string Categorie { get; set; }
        public string actif { get; set; }
        

    }
}