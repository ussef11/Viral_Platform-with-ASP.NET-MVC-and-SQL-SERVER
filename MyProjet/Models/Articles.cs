using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace MyProjet.Models
{
    public class Articles
    {

        private DateTime creationdat;

        [Key]
        public int NumAr { get; set; }
        [Required]
        public string NameAr { get; set; }
        [Required]
        public DateTime creationdate { get { return this.creationdate = DateTime.Now; } set { this.creationdat = value; } }

        [Required]
        public string Article { get; set; }
       
        public string UserName { get; set; }
        public string theme { get; set; }
        [Required]
        [Display(Name = "image")]
        public string images { get; set; }
        [NotMapped]
        [Display(Name = "imageFile")]
        public IFormFile imagesFlie { get; set; }
        public int nbLike { get; set; }
        [Required]
        [MaxLength(100)]
        public string discription { get; set; }

        public string Status { get; set; }




        public ICollection<Articlesimages> articlesimages { get; set; }

        public Articles()
        {
            Status = "Active";

        }



        public bool Empty
        {
            get
            {
                return (string.IsNullOrEmpty(NumAr.ToString())

                  );
            }
        }

    }
    }
