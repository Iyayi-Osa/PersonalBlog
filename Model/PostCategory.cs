using System.ComponentModel.DataAnnotations;

namespace PersonalBlog.Models
{
    public class PostCategory
    {
        public int PostID { get; set; }

        [Required]
        public Post Post { get; set; }

        public int CategoryID { get; set; }

        [Required]
        public Category Category { get; set; }
    }
}
