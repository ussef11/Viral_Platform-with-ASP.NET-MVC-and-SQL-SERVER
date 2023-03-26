using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using MyProjet.Data;
using MyProjet.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Dynamic;
using System.Linq;
using System.Threading.Tasks;

namespace MyProjet.Controllers
{
    public class HomeController : Controller
    {

        private readonly IConfiguration _con;
        private readonly ApplicationDbContext _db;
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger , ApplicationDbContext db , IConfiguration con)
        {
            _logger = logger;
            _db = db;
            _con = con;
        }

        public IActionResult Index()
        {
           
            IEnumerable<Articles> acc = _db.Articles;
            dynamic models = new ExpandoObject();

            models.Articles = acc;
             models.topPost = topPost();


            return View(models);
   
        }


        public List<topPost> topPost()
        {
           
            string mycon = _con.GetConnectionString("mydefaultcon");
            SqlConnection cnx = new SqlConnection(mycon);
            cnx.Open();
            SqlCommand cmd = new SqlCommand("select top 3 * from Articles", cnx);
            SqlDataReader dr = cmd.ExecuteReader();
            List<topPost> ar = new List<topPost>();
            while (dr.Read())
            {
                topPost art = new topPost();
                art.NameAr = dr[1].ToString();
                art.UserName = dr[4].ToString();
                art.theme = dr[5].ToString();
                art.images = dr[6].ToString();
                art.nbLike = int.Parse(dr[7].ToString());
                art.discription = dr[8].ToString();

                ar.Add(art);

            }

            return ar;


        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
