using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Blog.Infrastructure
{
    public class ImageUrlAttributes : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            var imageUrl = value as string;
            if (imageUrl == null)
            {
                return true;
            }

            return imageUrl.EndsWith(".jpg")
                || imageUrl.EndsWith(".png")
                || imageUrl.EndsWith(".jpeg")
                || imageUrl.EndsWith(".gif");
        }
    }
}