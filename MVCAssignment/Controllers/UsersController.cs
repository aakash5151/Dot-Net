using MVCAssignment.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCAssignment.Controllers
{
    public class UsersController : Controller

    {
       

        public ActionResult HomePage()
        {


            if (Session["loginName"] == null)
            {
                return RedirectToAction("Login");
            }

            Users user = new Users();
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = @"Data Source = (localdb)\MsSqlLocalDb; Initial Catalog = JKDec20; Integrated Security = True; Pooling = False";
            cn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from users where loginName=@loginName";
             user.loginName= (string)Session["loginName"];
            cmd.Parameters.AddWithValue("@loginName", user.loginName);



            SqlDataReader dr = cmd.ExecuteReader();
           
            if (dr.Read())
            {

                user.loginName = dr["loginName"].ToString();
                user.password = dr["password"].ToString();
                user.fullName = dr["fullName"].ToString();
                user.emailId = dr["emailId"].ToString();
                user.cityId = Convert.ToInt32(dr["cityId"]);
                user.phone = dr["phone"].ToString();

            }
            return View(user);
        }

        public ActionResult Logout()
        {

            Session["loginName"] = null;
            Session.Abandon();
            return RedirectToAction("Login");
        }


        public ActionResult Login(Users user)
        {
            try
            {
                //Users user = new Users();
                SqlConnection cn = new SqlConnection();
                cn.ConnectionString = @"Data Source = (localdb)\MsSqlLocalDb; Initial Catalog = JKDec20; Integrated Security = True; Pooling = False";
                cn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from users where loginName=@loginName and password=@password";

                cmd.Parameters.AddWithValue("@loginName", user.loginName);
                cmd.Parameters.AddWithValue("@password", user.password);


                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    Session["loginName"] = user.loginName;
                   //Session["fullName"] = user.fullName;
                   // string[] allNames = new string[] {user.loginName,/user.fullName};
                   // Session["names"] = allNames;

                    return RedirectToAction("HomePage");
                   
                }
                else
                {
                    return RedirectToAction("Login");
                }

            }
            catch
            {
                return View();
            }
           

          

              
        }

    
        

        // GET: Users
        public ActionResult Index()
        {
            return View();
        }

        // GET: Users/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Users/Create
        public ActionResult Create()
        {
            Users user = new Users();
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = @"Data Source = (localdb)\MsSqlLocalDb; Initial Catalog = JKDec20; Integrated Security = True; Pooling = False";
            cn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select cityId,cityName from City";
            SqlDataReader dr = cmd.ExecuteReader();

            List<SelectListItem> objCities = new List<SelectListItem>();

            while (dr.Read())
            {
                objCities.Add(
                    new SelectListItem
                    {
                        Text = dr.GetString(1),
                        Value = dr.GetInt32(0).ToString()

                    });
                user.Cities = objCities;
            }
            return View(user);
        }

        // POST: Users/Create
        [HttpPost]
        public ActionResult Create(Users user)
        {
            try
            {
               //Users user = new Users();
                // TODO: Add insert logic here
                // TODO: Add insert logic here
                SqlConnection cn = new SqlConnection();
                cn.ConnectionString = @"Data Source=(localdb)\MsSqlLocalDb;Initial Catalog=JKDec20;Integrated Security=true";

                cn.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandType = CommandType.Text;

                cmd.CommandText = "insert into Users values(@loginName,@password,@fullName,@emailId,@cityId,@phone)";

                cmd.Parameters.AddWithValue("@loginName",user.loginName);
                cmd.Parameters.AddWithValue("@password", user.password);
                cmd.Parameters.AddWithValue("@fullName", user.fullName);
                cmd.Parameters.AddWithValue("@emailId", user.emailId);
                cmd.Parameters.AddWithValue("@cityId", user.cityId);
                cmd.Parameters.AddWithValue("@phone", user.phone);

                Session["loginName"] = user.loginName;
                //MessageBox.Show(cmd.CommandText);

                cmd.ExecuteNonQuery();

                cn.Close();
               return RedirectToAction("Login");
            }
            catch
            {
                return View();
            }
        }

        // GET: Users/Edit/5
        public ActionResult Edit(string id)
        {
            Users user = new Users();
            
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = @"Data Source=(localdb)\MsSqlLocalDb;Initial Catalog=JKDec20;Integrated Security=true";

            cn.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Users where loginName=@loginName";
            cmd.Parameters.AddWithValue("@loginName", id);

            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                user.loginName = dr["loginName"].ToString();
                user.password = dr["password"].ToString();
                user.fullName = dr["fullName"].ToString();
                user.emailId = dr["emailId"].ToString();
                user.cityId = Convert.ToInt32(dr["cityId"]);
                user.phone = dr["phone"].ToString();
  
            }

            return View(user);
          

            
        }

        // POST: Users/Edit/5
        [HttpPost]
        public ActionResult Edit(int? id, Users user)
        {
            try
            {
                SqlConnection cn = new SqlConnection();
                cn.ConnectionString = @"Data Source=(localdb)\MsSqlLocalDb;Initial Catalog=JKDec20;Integrated Security=true";

                cn.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "update users set password=@password,fullName=@fullName,emailId=@emailId,cityId=@cityId,phone=@phone where loginName=@loginName";

               
                cmd.Parameters.AddWithValue("@password", user.password);
                cmd.Parameters.AddWithValue("@fullName", user.fullName);
                cmd.Parameters.AddWithValue("@emailId", user.emailId);
                cmd.Parameters.AddWithValue("@cityId", user.cityId);
                cmd.Parameters.AddWithValue("@phone", user.phone);
                cmd.Parameters.AddWithValue("@loginName", user.loginName);

                cmd.ExecuteNonQuery();

                cn.Close();
                return RedirectToAction("HomePage");
            }
            catch
            {
                return View();
            }
        }
          
        

        // GET: Users/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Users/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
