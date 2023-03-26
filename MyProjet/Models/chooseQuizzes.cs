using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MyProjet.Models
{
    public class chooseQuizzes
    {
        [Key]
        public int NumchooseQuizzes { get; set; }

        public string choosetitle { get; set; }
        public string Answer { get; set; }

        public string CorrectAnswer { get; set; }
        public string image { get; set; }

        public int NumChoose { get; set; }
        [ForeignKey("NumChoose")]
        public Quizzes Quizzes { get; set; }

    }
}
