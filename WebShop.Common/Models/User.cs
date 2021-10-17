
namespace WebShop.Common.Models
{
    /// <summary>
    /// Model of user
    /// </summary>
    public class User : BaseModel
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Login { get; set; }

        public string Password { get; set; }

        public UserRole Role { get; set; }
    }
}
