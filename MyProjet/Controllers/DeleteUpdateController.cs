using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using MyProjet.Data;
using MyProjet.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace MyProjet.Controllers
{
    public class DeleteUpdateController : Controller
    {
        public readonly ApplicationDbContext _db;
        public readonly IConfiguration _con;

        public DeleteUpdateController(ApplicationDbContext db , IConfiguration con  )
        {
            _db = db;
            _con = con;
        }

        public IActionResult Index()
        {
            if (HttpContext.Session.GetString("Login")!= null)
            {
                string mycon = _con.GetConnectionString("mydefaultcon");
                SqlConnection cnx = new SqlConnection(mycon);
                cnx.Open();
                SqlCommand cmd = new SqlCommand("select * from Articles where UserName = @a", cnx);
                cmd.Parameters.AddWithValue("@a", HttpContext.Session.GetString("Login"));
                SqlDataReader dr = cmd.ExecuteReader();
                List<Articles> List = new List<Articles>();

                while (dr.Read())
                {
                    Articles artc = new Articles();
                    artc.NumAr = int.Parse(dr[0].ToString());
                    artc.NameAr = dr[1].ToString();
                    artc.images = dr[6].ToString();
                    artc.theme = dr[5].ToString();
                    artc.Status = dr[9].ToString();
                    artc.nbLike = int.Parse(dr[7].ToString());

                    List.Add(artc);

                }
                cnx.Close();

                IEnumerable<Articles> ar = List;
                return View(ar);

            }
            else
            {
                return RedirectToAction("Register", "Users");
            }
          
        }



        public IActionResult Delete(int Num)
        {
            string mycon = _con.GetConnectionString("mydefaultcon");
            SqlConnection cnx = new SqlConnection(mycon);
            cnx.Open();
            SqlCommand cmd = new SqlCommand("Delete from Articles where NumAr = @a", cnx);
            cmd.Parameters.AddWithValue("@a", Num);
            cmd.ExecuteNonQuery();
            cnx.Close();
            return RedirectToAction("Index");
        }

    }
}
