using Microsoft.AspNetCore.Hosting;
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
    public class AddQuizzesController : Controller
    {
        public readonly IConfiguration _con;
        public readonly ApplicationDbContext _db;
        public readonly IWebHostEnvironment _env;


        public AddQuizzesController(IConfiguration con , ApplicationDbContext db, IWebHostEnvironment env)
        {
            _con = con;
            _db = db;
            _env = env;
        }
        public IActionResult AddQuizzes()
        {
            return View();
        }


        [HttpPost]
       
        public async Task<IActionResult> AddQuizzes(Quizzes Quizzes)
        {
            string cover = UploadedFile(Quizzes);

            Quizzes qz = new Quizzes
            {
              
                title = Quizzes.title,
                theme = Quizzes.theme,
                cover = cover,
                UserName = Quizzes.UserName
            };

           _db.Quizzes.Add(qz);
           await _db.SaveChangesAsync();

            SqlConnection cnx = new SqlConnection(_con.GetConnectionString("mydefaultcon"));
            cnx.Open();
            SqlCommand cmd = new SqlCommand("select max(Numchoose) from Quizzes", cnx);
            int id = int.Parse(cmd.ExecuteScalar().ToString());
            cnx.Close();
           return RedirectToAction("AddChoose", "AddChoose" ,new { id = id } );
        }

        private string UploadedFile(Quizzes model)
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



        //public ActionResult AddChoose()
        //{
        //    return View();
        //}
        //[HttpPost]
        //public ActionResult AddChoose(chooseQuizzes choose , int QuizzeNumber)
        //{
        //    chooseQuizzes chooseQuizzes = new chooseQuizzes
        //    {
        //        choosetitle = choose.choosetitle,
        //        Answer = choose.Answer,
        //        CorrectAnswer = choose.CorrectAnswer,
        //        image = choose.image,
        //        NumChoose = QuizzeNumber
        //    };

        //    _db.chooseQuizzes.Add(chooseQuizzes);
        //    _db.SaveChanges();

        //    return View();
        //}
    }
}
