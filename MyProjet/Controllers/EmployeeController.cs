using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using MyProjet.Data;
using MyProjet.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace MyProjet.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly IConfiguration _configuration;
        public readonly ApplicationDbContext _db;

       
        public EmployeeController(ApplicationDbContext db , IConfiguration configuration)
        {
            _db = db;
            _configuration = configuration;
        }

        public IActionResult Index()
        {
            IEnumerable<Employee> emp = _db.Employee;
            return View(emp);
        }

        public IActionResult Index1()
        {
            string mycon = _configuration.GetConnectionString("cnx");
            List<Account> list = new List<Account>();
            SqlConnection cnx = new SqlConnection(mycon);
            cnx.Open();
            SqlCommand cmd = new SqlCommand("select * from compt", cnx);
            SqlDataReader dr = cmd.ExecuteReader();
            while(dr.Read())
            {
                Account a = new Account();
                a.LoginName = dr[0].ToString();
                a.Password = dr[1].ToString();
                a.Categorie = dr[2].ToString();
                list.Add(a);

            }

            IEnumerable<Account> ie = list;
            dr.Close();
            cnx.Close();

            return View(ie);
        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Employee emp)
        {
            _db.Employee.Add(emp);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }



        public IActionResult Account()
        {
            IEnumerable<Account> acc = _db.Accounts;
            return View(acc);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult AddAccount(Account acc)
        {
            _db.Accounts.Add(acc);
            _db.SaveChanges();
            return RedirectToAction("Account");
        }

       
    }

}
