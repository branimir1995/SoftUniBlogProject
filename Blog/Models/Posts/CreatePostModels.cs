using Blog.Infrastructure;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Blog.Models
{
    public class CreatePostModels
    {
        [Required]
        [MaxLength(50)]
        public string Title { get; set; }

        [Required]
        [Url]
        [ImageUrlAttributes]
        [Display(Name = "Image Url")]
        public string ImageUrl { get; set; }

        [Required]
        [MaxLength(200)]
        public string Recipe { get;  set; }

        [Required]
        [Display(Name = "How do you prepare it?")]
        [MaxLength(500)]
        public string MakeMethod { get; set; }
    }
}