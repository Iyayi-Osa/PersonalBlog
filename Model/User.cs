using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PersonalBlog.Models
{
    public class User
    {
        public int UserID { get; set; }

        [Required] // Specifies that Username is required
        public string Username { get; set; }

        [Required] // Specifies that Email is required
        public string Email { get; set; }

        [Required] // Specifies that PasswordHash is required
        public string PasswordHash { get; set; }

        public int RoleID { get; set; }

        public Role? Role { get; set; }

        public List<Post>? Posts { get; set; }
    }
}
