using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyProjet.Models
{
    public class topPost
    {
        public int NumAr { get; set; }

        public string NameAr { get; set; }

        public DateTime creationdate { get; set; }


        public string Article { get; set; }

        public string UserName { get; set; }
        public string theme { get; set; }

        public int nbLike { get; set; }

        public string discription { get; set; }

        public int Idimg { get; set; }
        public int Idimgback { get; set; }
        public string image { get; set; }

        public string images { get; set; }
        public string articlebreak { get; set; }
    }
}
