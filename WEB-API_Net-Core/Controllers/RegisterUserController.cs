using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Nancy.Json;
using Newtonsoft.Json;
using System.Data;
using System.Data.SqlClient;
using WEB_API_Net_Core.DB;
using WEB_API_Net_Core.Models.DB;

namespace WEB_API_Net_Core.Controllers
{
    public class RegisterUserController : ControllerBase
    {
        private readonly DB_Demo_APIContext _context;
        public RegisterUserController(DB_Demo_APIContext context)
        {
            _context = context;
        }

        //insert
        [HttpPost]
        [Route("/register/user")]
        public string UserRegistration(Input inputData)
        {
            var response = string.Empty;
            try
            {

                var FirstName = inputData.FirstName;
                var LastName = inputData.FirstName;
                var EmailAddress = inputData.FirstName;
                var PhoneNumber = inputData.FirstName;

                using var cmd = _context.Database.GetDbConnection().CreateCommand();
                cmd.CommandText = "customer";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@FirstName", SqlDbType.VarChar) { Value = FirstName });
                cmd.Parameters.Add(new SqlParameter("@LastName", SqlDbType.VarChar) { Value = LastName });
                cmd.Parameters.Add(new SqlParameter("@EmailAddress", SqlDbType.VarChar) { Value = EmailAddress });
                cmd.Parameters.Add(new SqlParameter("@PhoneNumber", SqlDbType.VarChar) { Value = PhoneNumber });
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                response = ex.Message;
            }

            return response.Replace("[", string.Empty).Replace("]", string.Empty);
        }


        //public string UserRegistration(Input inputData)
        //{

        //    string ID = string.Empty;
        //    ID = inputData.ID;
        //    string FirstName = string.Empty;
        //    FirstName = inputData.FirstName;
        //    string LastName = string.Empty;
        //    LastName = inputData.LastName;

        //    string EmailAddress = string.Empty;
        //    //EmailAddress = inputData.EmailAddress;
        //    string PhoneNumber = string.Empty;
        //    PhoneNumber = inputData.PhoneNumber;



        //    var response = string.Empty;
        //    //try
        //    //{

        //    //    var Data = dataInfor.inputData;
        //    //    var Dserializer = new JavaScriptSerializer();
        //    //    var DreceivedData = Dserializer.Deserialize<dynamic>(Data);
        //    //    string fname = string.Empty;

        //    //    fname = DreceivedData["FirstName"].ToString();
        //    //    string lname = string.Empty; lname = DreceivedData["LastName"].ToString();
        //    //    string email = string.Empty; email = DreceivedData["EmailAddress"].ToString();
        //    //    string phone = string.Empty; phone = DreceivedData["PhoneNumber"].ToString();

        //    //    SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["conn"].ToString());
        //    //    con.Open();

        //    using (var cmd = _context.Database.GetDbConnection().CreateCommand())
        //    {
        //        cmd.CommandText = "customer";
        //        cmd.CommandType = System.Data.CommandType.StoredProcedure;
        //        cmd.Connection.Open();

        //        //if (cmd.Connection.State != System.Data.ConnectionState.Open)
        //        //cmd.Parameters.Add(new SqlParameter("LOGIN", user));
        //        //cmd.Parameters.Add(new SqlParameter("PASSWORD", password));

        //        cmd.Parameters.Add(new SqlParameter("ID", ID));
        //        cmd.Parameters.Add(new SqlParameter("FirstName", FirstName));
        //        cmd.Parameters.Add(new SqlParameter("LastName", LastName));
        //        cmd.Parameters.Add(new SqlParameter("EmailAddress", EmailAddress));
        //        cmd.Parameters.Add(new SqlParameter("PhoneNumber", PhoneNumber));

        //        DataTable dt = new DataTable();
        //        using (var da = new SqlDataAdapter(cmd))
        //        {
        //            cmd.CommandType = CommandType.StoredProcedure;
        //            da.Fill(dt);

        //        }
        //    }


        //    //    SqlCommand cmd = new SqlCommand("customer", con);
        //    //    cmd.Parameters.AddWithValue("@FirstName", fname);
        //    //    cmd.Parameters.AddWithValue("@LastName", lname);
        //    //    cmd.Parameters.AddWithValue("@EmailAddress", email);
        //    //    cmd.Parameters.AddWithValue("@PhoneNumber", phone);
        //    //    DataTable dt = new DataTable();
        //    //    using (var da = new SqlDataAdapter(cmd))
        //    //    {
        //    //        cmd.CommandType = CommandType.StoredProcedure;
        //    //        da.Fill(dt);
        //    //    }
        //    //    con.Close(); con.Dispose();

        //    //    response = JsonConvert.SerializeObject(dt);
        //    //    var jss = new JavaScriptSerializer();
        //    //    var sData = jss.Deserialize<dynamic>(response.Replace("[", string.Empty).Replace("]", String.Empty)
        //    //                                                 .Replace("]", String.Empty).Replace("]", String.Empty));
        //    //}
        //    //catch (Exception ex)
        //    //{
        //    //    response = ex.Message;
        //    //}

        //    return response.Replace("[", string.Empty).Replace("]", string.Empty);
        //}




    }




}
