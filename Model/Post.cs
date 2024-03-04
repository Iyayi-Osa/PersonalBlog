using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PersonalBlog.Models
{
    public class Post
    {
        public int PostID { get; set; }

        public int UserID { get; set; }

        [Required]
        public User User { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public string Content { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime UpdatedAt { get; set; }

        public ICollection<PostCategory>? PostCategories { get; set; }
    }
}
