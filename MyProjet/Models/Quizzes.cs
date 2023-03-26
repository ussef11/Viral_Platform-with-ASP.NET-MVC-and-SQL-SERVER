using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MyProjet.Models
{
    public class Quizzes
    {
        [Key]
        public int NumChoose { get; set; }
        public string theme { get; set; }
        public string title { get; set; }
        public string cover { get; set; }
        [NotMapped]
        [Display(Name = "imageFile")]
        public IFormFile imagesFlie { get; set; }
        public string UserName { get; set; }

    }
}
