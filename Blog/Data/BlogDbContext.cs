using System.Data.Entity;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Blog.Models;

namespace Blog.Data
{    
    public class BlogDbContext : IdentityDbContext<User>
    {
        public BlogDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public virtual IDbSet<Post> Posts { get; set; }

        public static BlogDbContext Create()
        {
            return new BlogDbContext();
        }
    }
}