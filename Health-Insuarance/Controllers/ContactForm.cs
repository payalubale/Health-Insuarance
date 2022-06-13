using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Data;
using Microsoft.Data.SqlClient;
using Health_Insuarance.Models;


namespace Health_Insuarance.Controllers
{
    public class ContactForm : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(ContactFormClass cf)
        {
            string connection = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Health-Insuarance;Integrated Security=True";
            
            using(SqlConnection sqlconn = new SqlConnection(connection))
            {
                string sqlquery = "insert into ContactUsForm(Firstname,Lastname,Email,Mobileno,Message) values('" + cf.Firstname + "','" + cf.Lastname + "','" + cf.Email + "','" + cf.Mobileno + "','" + cf.Message + "')";
                using (SqlCommand sqlcmd = new SqlCommand(sqlquery,sqlconn))
                {
                    sqlconn.Open();
                    sqlcmd.ExecuteNonQuery();
                    ViewData["Message"] = "Your response is saved succesfully...! ";
                }
            }
            return View(cf);
        }
    }
}
