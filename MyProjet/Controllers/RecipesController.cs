using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.Extensions.Configuration;
using Microsoft.AspNetCore.Hosting;
using MyProjet.Models;
using System.Data.SqlClient;
using System.Data;
using System.IO;

namespace MyProjet.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RecipesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }


        private readonly IConfiguration _configuration;
            private readonly IWebHostEnvironment _env;
            public RecipesController(IConfiguration configuration, IWebHostEnvironment env)
            {
                _configuration = configuration;
                _env = env;
            }


            [HttpPost]
            public JsonResult Add(Account acc)
            {
                string mycon = _configuration.GetConnectionString("cnx");

                SqlConnection cnx = new SqlConnection(mycon);
                cnx.Open();
                SqlCommand cmd = new SqlCommand("insert into compt(login,password,categorie,actif) values(@a, @b ,@c,@d)", cnx);
                cmd.Parameters.AddWithValue("@a", acc.LoginName);
                cmd.Parameters.AddWithValue("@b", acc.Password);
                cmd.Parameters.AddWithValue("@c", acc.Categorie);
                cmd.Parameters.AddWithValue("@d", acc.actif);
                cmd.ExecuteNonQuery();

                cnx.Close();

                return new JsonResult("____________________________Added Succeffully");

            }


            [HttpGet]
            public JsonResult getAllAccount()
            {
                string mycon = _configuration.GetConnectionString("cnx");

                SqlConnection cnx = new SqlConnection(mycon);
                cnx.Open();
                SqlCommand cmd = new SqlCommand("select * from compt", cnx);
                SqlDataReader dr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dr);
                dr.Close();
                cnx.Close();

                return new JsonResult(dt);

            }

            [HttpPut]
            public JsonResult put(Account acc)
            {
                string mycon = _configuration.GetConnectionString("cnx");

                SqlConnection cnx = new SqlConnection(mycon);
                cnx.Open();
                SqlCommand cmd = new SqlCommand("update compt set actif = @b where login = @a ", cnx);
                cmd.Parameters.AddWithValue("@a", acc.LoginName);
                cmd.Parameters.AddWithValue("@b", acc.actif);
                cmd.ExecuteNonQuery();

                cnx.Close();

                return new JsonResult("___________________Update Seccusefully_________ Succeffully");

            }


            [HttpDelete]
            public JsonResult del()
            {
                string mycon = _configuration.GetConnectionString("cnx");

                SqlConnection cnx = new SqlConnection(mycon);
                cnx.Open();
                SqlCommand cmd = new SqlCommand("delete from compt  where Login = @a", cnx);
                cmd.Parameters.AddWithValue("@a", HttpContext.Request.Query["a"].ToString());
                cmd.ExecuteNonQuery();




                cnx.Close();

                return new JsonResult("Delete___________________________seccusefully_______Seccusefully________Succeffully");

            }

            [Route("savefile")]
            [HttpPost]
            public JsonResult Addfile()
            {
                try
                {
                    var httpRequest = Request.Form;
                    var postfile = httpRequest.Files[0];
                    var filename = postfile.FileName;
                    var physicalpath = _env.ContentRootPath + "/images/" + filename;
                    using (var stream = new FileStream(physicalpath, FileMode.Create))
                    {
                        postfile.CopyTo(stream);
                    }
                    return new JsonResult(filename);

                }
                catch (Exception)
                {
                    return new JsonResult("Annonymos.png");
                }

            }

        }
    }
