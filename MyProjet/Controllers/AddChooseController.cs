using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using MyProjet.Data;
using MyProjet.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Dynamic;
using System.Linq;
using System.Threading.Tasks;

namespace MyProjet.Controllers
{
    public class AddChooseController : Controller
    {
        public readonly IWebHostEnvironment _env;
        public readonly ApplicationDbContext _db;
        public readonly IConfiguration _con;
        int myid;

        public AddChooseController(IWebHostEnvironment env , ApplicationDbContext db ,IConfiguration con)
        {
            _con = con;
            _db = db;
            _env = env;
        }

        public IActionResult AddChoose(int id)
        {
            myid = id;
            string mycon = _con.GetConnectionString("mydefaultcon");
            SqlConnection cnx = new SqlConnection(mycon);
            cnx.Open();
            SqlCommand cmd = new SqlCommand("select * from chooseQuizzes where Numchoose = @a", cnx);
            cmd.Parameters.AddWithValue("@a", id);
            SqlDataReader dr = cmd.ExecuteReader();
            List<chooseQuizzes> list = new List<chooseQuizzes>();
            while (dr.Read())
            {
                chooseQuizzes sh = new chooseQuizzes();
                sh.NumchooseQuizzes = int.Parse(dr[0].ToString());
                sh.choosetitle = dr[1].ToString();
                sh.Answer = dr[2].ToString();
                sh.CorrectAnswer = dr[3].ToString();
                sh.image = dr[4].ToString();
                sh.NumChoose = int.Parse(dr[5].ToString());
                list.Add(sh);
            }
            cnx.Close();

            IEnumerable<chooseQuizzes> choose = list;
             
            return View(choose);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult AddChoose(chooseQuizzes choose, int id)
        {
            chooseQuizzes chooseQuizzes = new chooseQuizzes
            {
                choosetitle = choose.choosetitle,
                Answer = choose.Answer,
                CorrectAnswer = choose.CorrectAnswer,
                image = choose.image,
                NumChoose = id
            };

            _db.chooseQuizzes.Add(chooseQuizzes);
            _db.SaveChanges();
            

            return RedirectToAction("AddChoose");
        }

        public ActionResult delete(int num  , int id)
        {
            string mycon = _con.GetConnectionString("mydefaultcon");
            SqlConnection cnx = new SqlConnection(mycon);
            cnx.Open();
            SqlCommand cmd = new SqlCommand("delete from chooseQuizzes where NumchooseQuizzes = @a", cnx);
            cmd.Parameters.AddWithValue("@a", num);
            cmd.ExecuteNonQuery();
            cnx.Close();
            return RedirectToAction("AddChoose" , new { id = id });

        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult update(chooseQuizzes choose,int num, int id)
        {
            string mycon = _con.GetConnectionString("mydefaultcon");
            SqlConnection cnx = new SqlConnection(mycon);
            cnx.Open();
            SqlCommand cmd = new SqlCommand("update chooseQuizzes set choosetitle = @a , Answer = @b , CorrectAnswer = @c ,image = @d where NumchooseQuizzes = @n", cnx);
            cmd.Parameters.AddWithValue("@n", num);
            cmd.Parameters.AddWithValue("@a", choose.choosetitle);
            cmd.Parameters.AddWithValue("@b", "ee");
            cmd.Parameters.AddWithValue("@c", "ee");
            cmd.Parameters.AddWithValue("@d", "ee");
            cmd.ExecuteNonQuery();


            SqlCommand c = new SqlCommand("select Max(NumChoose) from Quizzes", cnx);
            int count = int.Parse(c.ExecuteScalar().ToString());

            cnx.Close();
            return RedirectToAction("AddChoose", new { id = count });

        }

    }
}
