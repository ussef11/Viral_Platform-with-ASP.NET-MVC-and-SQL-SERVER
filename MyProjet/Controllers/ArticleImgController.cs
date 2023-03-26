using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using MyProjet.Data;
using MyProjet.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace MyProjet.Controllers
{
    public class ArticleImgController : Controller
    {

        public readonly IWebHostEnvironment _env;
        public readonly IConfiguration _con;
        public readonly ApplicationDbContext _db;

        public ArticleImgController(IConfiguration configuration, ApplicationDbContext db, IWebHostEnvironment env)
        {
            _con = configuration;
            _db = db;
            _env = env;


        }
        public IActionResult Index()
        {
            //IEnumerable<Articlesimages> ar = _db.Articlesimages;
            return View();
        }


        [HttpPost]
        public IActionResult Index(teest product, IFormFile[] photos , Articlesimages art , int Id)
        {
            //int Num = int.Parse(HttpContext.Request.Query["Num"]);
            if (photos == null || photos.Length == 0)
            {
                Articlesimages list = new Articlesimages
                {                  
                    Photos = product.Photos,
                    articlebreak = art.articlebreak,
                    articlesNumAr = Id
                };
                _db.Articlesimages.Add(list);
                _db.SaveChanges();
            }
            else
            {
                product.Photos = new List<string>();
                foreach (IFormFile photo in photos)
                {
                    string nameimg = null;

                    string uploadsFolder = Path.Combine(_env.WebRootPath, "images");

                    var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/images", photo.FileName);
                    nameimg = photo.FileName;
                    var stream = new FileStream(path, FileMode.Create);
                    photo.CopyToAsync(stream);
                    product.Photos.Add(photo.FileName);
                  

                    Articlesimages list = new Articlesimages
                    {
                        image = nameimg,
                        Photos = product.Photos,
                        articlebreak = art.articlebreak,
                        articlesNumAr = Id
                };
                    _db.Articlesimages.Add(list);
                    _db.SaveChanges();
                }
            }
            ViewBag.product = product;
            return  View();
        }

        public IActionResult articlesImg()
        {
            string mycon = _con.GetConnectionString("mydefaultcon");
            SqlConnection cnx = new SqlConnection(mycon);
            cnx.Open();
            List<Articlesimages> list = new List<Articlesimages>();
            SqlCommand cmd = new SqlCommand("select * from Articlesimages", cnx);
            SqlDataReader dr = cmd.ExecuteReader();
            while(dr.Read())
            {
                Articlesimages ar = new Articlesimages();
                ar.image = dr[1].ToString();
                list.Add(ar);
            }
            IEnumerable<Articlesimages> ai = list;
            dr.Close();
            cnx.Close();
            return View(ai);
            
        }









    }
}
