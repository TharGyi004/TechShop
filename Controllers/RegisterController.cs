using Microsoft.AspNetCore.Mvc;
using System.Text;
using TechShop.Models;
using System.Security.Cryptography;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;

namespace TechShop.Controllers
{
    public class RegisterController : Controller
    {
        private readonly IConfiguration _config;

        public RegisterController(IConfiguration config)
        {
            _config = config;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(User user)
        {
            if (!ModelState.IsValid)
            {
                var errors = ModelState.Values.SelectMany(v => v.Errors);
                foreach (var error in errors)
                {
                    // Log or debug: error.ErrorMessage
                }
                return View(user);
            }


            string connStr = _config.GetConnectionString("MyDB");
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                // Check if email already exists
                string checkEmailQuery = "SELECT COUNT(*) FROM Users WHERE email = @Email";
                using (SqlCommand checkCmd = new SqlCommand(checkEmailQuery, conn))
                {
                    checkCmd.Parameters.AddWithValue("@Email", user.email);
                    object result = checkCmd.ExecuteScalar();

                    int count = 0;
                    if (result != null && result != DBNull.Value)
                    {
                        count = Convert.ToInt32(result);
                    }

                    if (count > 0)
                    {
                        ModelState.AddModelError("", "Email already registered.");
                        return View(user);
                    }
                }

                string query = "INSERT INTO users (username, email, user_password, user_telephone, user_state, user_township, user_address) VALUES (@Username, @Email, @Password, @Phone, @DivState, @Town, @Address)";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Username", user.Username);
                    cmd.Parameters.AddWithValue("@Email", user.email);
                    cmd.Parameters.AddWithValue("@Password", user.Password);
                    cmd.Parameters.AddWithValue("@Phone", user.phone);
                    cmd.Parameters.AddWithValue("@DivState", user.divstate);
                    cmd.Parameters.AddWithValue("@Town", user.town);
                    cmd.Parameters.AddWithValue("@Address", user.address);


                    try
                    {
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        ViewBag.Message = "Registration successful!";
                        return View();
                    }
                    catch (Exception ex)
                    {
                        ModelState.AddModelError("", ex.Message);
                    }
                }
            }

            return View(user);
        }


        private string HashPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                StringBuilder builder = new StringBuilder();
                foreach (byte b in bytes)
                    builder.Append(b.ToString("x2"));
                return builder.ToString();
            }
        }
    }
}
