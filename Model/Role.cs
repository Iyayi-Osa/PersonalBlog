using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PersonalBlog.Models
{
    public class Role
    {
        public int RoleID { get; set; }

        [Required] // Specifies that RoleName is required
        public string RoleName { get; set; }

        public ICollection<User>? Users { get; set; }
    }
}
