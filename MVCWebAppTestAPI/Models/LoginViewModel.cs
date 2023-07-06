namespace MVCWebAppTestAPI.Models
{
    public class LoginViewModel
    {
        public string Username { get; set; }
        public string Password { get; set; }
    }
    public class UserViewModel
    {
        public int UserId { get; set; }
        public string Username { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string IdNumber { get; set; }
    }
}
