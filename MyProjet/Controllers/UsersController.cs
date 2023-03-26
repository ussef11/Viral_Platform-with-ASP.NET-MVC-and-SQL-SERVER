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
    public class UsersController : Controller
    {
        public readonly ApplicationDbContext _db;
        public readonly IConfiguration _configuration;

        public UsersController(ApplicationDbContext db , IConfiguration configuration)
        {
            _db = db;
            _configuration = configuration;
        }
        public IActionResult Index()
        {
            return RedirectToRoute("Home");
        }

        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Register(Users user)
        {  
                _db.Users.Add(user);
                _db.SaveChanges();
                return RedirectToAction("Index", "Home");
        }

        public IActionResult Login(string UserName ,string Password)
        {
            var cnxa = _configuration.GetConnectionString("mydefaultcon");
            SqlConnection cnx = new SqlConnection(cnxa);
            cnx.Open();
            SqlCommand cmd = new SqlCommand("select * from Users where UserName = @a and password = @b", cnx);
            cmd.Parameters.AddWithValue("@a", UserName);
            cmd.Parameters.AddWithValue("@b", Password);
            SqlDataReader dr = cmd.ExecuteReader();
            dr.Read();
            if (dr.HasRows)
            {
                HttpContext.Session.SetString("Login", dr[4].ToString());
                return RedirectToAction("Index", "Home");
            }

            return View();




        }
    }
}
