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
    public class AccountController : Controller
    {

        public readonly ApplicationDbContext _db;
        public readonly IConfiguration _configuration;
        public AccountController(ApplicationDbContext db , IConfiguration configuration)
        {
            _db = db;
            _configuration = configuration;
        }

        public IActionResult AllAccount()
        {
            IEnumerable<Account> acc = _db.Accounts;
            return View(acc);
        }

        public IActionResult AddAccount()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult AddAccount(Account acc)
        {
            if (ModelState.IsValid)
            {
                _db.Accounts.Add(acc);
                _db.SaveChanges();
                return RedirectToAction("AllAccount");
            }
            return View(acc);
        }

        public IActionResult Edit(string LoginName)
        {
            if(LoginName == null)
            {
                return NotFound();
            }
            var acc = _db.Accounts.Find(LoginName);
            if(acc ==null)
            {
                return NotFound();
            }
            return View(acc);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Account acc)
        {
            if (ModelState.IsValid)
            {
                _db.Accounts.Update(acc);
                _db.SaveChanges();
                return RedirectToAction("AllAccount");
            }
            return View(acc);


        }

        public IActionResult Delete(string? LoginName)
        {
            if (LoginName == null)
            {
                return NotFound();
            }
            var acc = _db.Accounts.Find(LoginName);
            if (acc == null)
            {
                return NotFound();
            }
            return View(acc);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult DeletePost(string? LoginName)
        {
            var acc = _db.Accounts.Find(LoginName);
            if (acc == null)
            {
                return NotFound();
            }

           
            _db.Accounts.Remove(acc);
            _db.SaveChanges();
            return RedirectToAction("AllAccount");

        }

        public IActionResult Deletesql(string? LoginName)
        {
            if (LoginName == null)
            {
                return NotFound();
            }
            var acc = _db.Accounts.Find(LoginName);
            if (acc == null)
            {
                return NotFound();
            }
            return View(acc);
        }


        [HttpPost]
        public IActionResult deleteSQ(string LoginName)
        {
            string mycon = _configuration.GetConnectionString("mydefaultcon");
            SqlConnection cnx = new SqlConnection(mycon);
            cnx.Open();
            SqlCommand cmd = new SqlCommand("Delete from Accounts where LoginName = @a", cnx);
            //var acc = _db.Accounts.Find(LoginName);
         
            cmd.Parameters.AddWithValue("@a", LoginName);
            cmd.ExecuteNonQuery();
            return RedirectToAction("AllAccount"); ;
        }


    }
}
