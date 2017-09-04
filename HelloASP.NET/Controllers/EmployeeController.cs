using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HelloASP.NET.Models;
using System.Data.SqlClient;
using System.Data.Odbc;
using System.Data.OleDb;

namespace HelloASP.NET.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult Index()
        {
            SqlConnection cn = new SqlConnection(@"Data Source=.\SQLEXPRESS; database=aspado; integrated security=SSPI");
            SqlCommand cmd = new SqlCommand("select * from employee",cn);
            cn.Open();
            Employee employee = new Employee()
            {
                EmployeeId = 12,
                EmployeeName = "Tharaka",
                Gender = "Male",
                City = "Ragama"
            };
            SqlDataReader rdr = cmd.ExecuteReader();
            Console.WriteLine(rdr);
            cn.Close();
            
            return View(rdr);
        }
    }
}