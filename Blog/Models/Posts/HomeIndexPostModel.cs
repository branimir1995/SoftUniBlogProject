using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Blog.Models.Posts
{
    public class HomeIndexPostModel
    {
        public int Id { get; set; }
        
        public string Title { get; set; }

        public string Recipe { get; set; }

        public string MakeMethod { get; set; }

        public string ImageUrl { get; set; }
    }
}