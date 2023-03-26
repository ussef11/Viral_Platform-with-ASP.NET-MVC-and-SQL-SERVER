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
    public class AddConentController : Controller
    {
        public readonly IWebHostEnvironment _env;
        public readonly IConfiguration _con;
        public readonly ApplicationDbContext _db;

        public AddConentController(IConfiguration configuration,ApplicationDbContext db , IWebHostEnvironment env)
        {
            _con = configuration;
            _db = db;
            _env = env;
            
               
        }
        public IActionResult Index()
        {
            return View();
        }
    
        public IActionResult AddContent()
        {
            //IEnumerable<Articles> ar = _db.Articles;
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddContent(Articles artc)
        {

            
            string uniqueFileName = UploadedFile(artc);

          

            Articles art = new Articles
            {
                NameAr = artc.NameAr,
                images = uniqueFileName,
                theme = artc.theme,
                UserName = HttpContext.Session.GetString("Login"),
                nbLike = 0,
                Article = "zz",
                discription = artc.discription,
            };

            _db.Articles.Add(art);
            await _db.SaveChangesAsync();

            
            string mycon = _con.GetConnectionString("mydefaultcon");
            SqlConnection cnx = new SqlConnection(mycon);
            cnx.Open();
            SqlCommand cmd = new SqlCommand("select Max(NumAr) from Articles", cnx);
            int num = int.Parse(cmd.ExecuteScalar().ToString());
            cnx.Close();

            return  RedirectToAction("Index", "ArticleImg" , new { Id = num});
        }
        private string UploadedFile(Articles model)
        {
            string uniqueFileName = null;
            if (model.imagesFlie != null)
            {
                string uploadsFolder = Path.Combine(_env.WebRootPath, "images");
                uniqueFileName = Guid.NewGuid().ToString() + "_" + model.imagesFlie.FileName;
                string filePath = Path.Combine(uploadsFolder, uniqueFileName);
                using (var fileStream = new FileStream(filePath, FileMode.Create))
                {
                    model.imagesFlie.CopyTo(fileStream);
                }
            }
            return uniqueFileName;

           
        }



    }
}
