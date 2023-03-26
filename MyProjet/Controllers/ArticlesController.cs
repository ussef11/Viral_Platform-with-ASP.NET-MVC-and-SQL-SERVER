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
    public class ArticlesController : Controller
    {
        public readonly ApplicationDbContext _db;
        public readonly IConfiguration _con;
        public ArticlesController(ApplicationDbContext db ,IConfiguration con)
        {
            _db = db;
            _con = con;
        }
        public IActionResult Index(int Id , int Num)
        {
            string mycon = _con.GetConnectionString("mydefaultcon");
            SqlConnection cnx = new SqlConnection(mycon);
            cnx.Open();
            SqlCommand cmd = new SqlCommand("select * from Articles a inner join Articlesimages ai on a.NumAr = ai.articlesNumAr where NumAr = @a", cnx);
            cmd.Parameters.AddWithValue("@a", Id);
            SqlCommand count = new SqlCommand("select count(*) from Articles a inner join Articlesimages ai on a.NumAr = ai.articlesNumAr where NumAr = @a", cnx);
            count.Parameters.AddWithValue("@a", Id);
            int totalArticles = Convert.ToInt32(count.ExecuteScalar());
            SqlDataReader dr = cmd.ExecuteReader();
            List<ArticlesViewModel> list = new List<ArticlesViewModel>();
            ArticlesViewModel art = new ArticlesViewModel();
            dr.Read();
            if(dr.HasRows)
            {
                art.NameAr = dr[1].ToString();
                art.creationdate = DateTime.Parse(dr[2].ToString());
                art.Article = dr[3].ToString();
                art.UserName = dr[4].ToString();
                art.theme = dr[5].ToString();
                art.image = dr[6].ToString();
                art.nbLike = int.Parse(dr[7].ToString());
                art.images = dr[10].ToString();
                art.max = getNumMax(Id);
                art.min = getNum(Id);
                if (Num == 0)
                {
                    Num = getNum(Id);
                    art.Idimg = getNum(Id) + 1;
                }
                else if (Num < getNumMax(Id))
                {
                    for (int i = 0; i < totalArticles; i++)
                    {
                        art.Idimg = Num + 1;
                        art.Idimgback = Num - 1;
                    }
                }
                else if (Num == 0 || Num < getNumMax(Id) || Num == getNumMax(Id))
                {
                    for (int i = 0; i < totalArticles; i++)
                    {
                        art.Idimgback = Num - 1;
                    }
                }
                if (Num == getNumMax(Id))
                {
                    art.setmax = true;
                }
                if (Num == getNum(Id))
                {
                    art.setmin = true;
                }

                string myart = string.Join(",", getAll(Id, Num));
                art.articlebreak = myart;
                list.Add(art);
                ViewBag.emp = art;
                dr.Close();
                return View("Index", art);

            }
            else
            {
                return RedirectToAction("Index", "Home");
            }
              
        }

        public List<string> getAll(int n , int b)
        {
            string mycon = _con.GetConnectionString("mydefaultcon");
            SqlConnection cnx = new SqlConnection(mycon);
            cnx.Open();
            SqlCommand cmd = new SqlCommand("select articlebreak from  Articlesimages where articlesNumAr = @a and IdImg =@b", cnx);
            cmd.Parameters.AddWithValue("@a", n);
            cmd.Parameters.AddWithValue("@b", b);
            SqlDataReader dr = cmd.ExecuteReader();
            List<string> List = new List<string>();
            while(dr.Read())
            {   
                string articlebreak = dr[0].ToString();
                List.Add(articlebreak);
            }
            dr.Close();
            return List;
        }
        public int getNum(int n)
        {
            string mycon = _con.GetConnectionString("mydefaultcon");
            SqlConnection cnx = new SqlConnection(mycon);
            cnx.Open();
            SqlCommand cmd = new SqlCommand("select min(Idimg) from Articlesimages where articlesNumAr = @a", cnx);        
            cmd.Parameters.AddWithValue("@a", n);
            int val = Convert.ToInt32(cmd.ExecuteScalar());
            cnx.Close();
            return val;
        }
        public int getNumMax(int n)
        {
            string mycon = _con.GetConnectionString("mydefaultcon");
            SqlConnection cnx = new SqlConnection(mycon);
            cnx.Open();
            SqlCommand cmd = new SqlCommand("select Max(Idimg) from Articlesimages where articlesNumAr = @a", cnx);
            cmd.Parameters.AddWithValue("@a", n);
            int val = Convert.ToInt32(cmd.ExecuteScalar());
            cnx.Close();
            return val;
        }
    }
}
