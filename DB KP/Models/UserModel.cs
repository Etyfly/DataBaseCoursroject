using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography;

namespace DB_KP.Models
{
    public class UserModel
    {
        [Key]
        public int Id { set; get; }
        public string Login { set; get; }
        public string Password { set; get; }
        
        
    }
}