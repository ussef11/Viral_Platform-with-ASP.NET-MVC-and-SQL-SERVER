using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyProjet.Models
{
    public class AllArTModelView
    {
        public List<Articles> Articles { get; set; }
        public List<Articlesimages> articlesimages { get; set; }

        public List<ArticlesViewModel> ArticlesViewModel { get; set; }
    }
}
