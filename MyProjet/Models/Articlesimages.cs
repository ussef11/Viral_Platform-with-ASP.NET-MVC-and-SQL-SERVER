using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MyProjet.Models
{
    public class Articlesimages
    {
        [Key]
        public int Idimg { get; set; }
        public string image { get; set; }

        public string articlebreak { get; set; }

        public int articlesNumAr { get; set; }

        [ForeignKey("articlesNumAr")]
        public Articles articles { get; set; }
        [NotMapped]
        public List<string> Photos { get; set; }

  
    }
}
