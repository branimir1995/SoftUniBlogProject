using Blog.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Blog.Models
{
    public class Post
    {
        public int Id { get; set; }

        [Required]
        public string ImageUrl { get; set; }

        [Required]
        public string Recipe { get; set; }

        [Required]
        public string MakeMethod { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public string PublisherId { get; set; }

        public virtual User Publsher { get; set; }
    }
}