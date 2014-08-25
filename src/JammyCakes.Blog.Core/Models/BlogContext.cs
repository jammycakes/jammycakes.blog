using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JammyCakes.Blog.Core.Models.InitialData;

namespace JammyCakes.Blog.Core.Models
{
    public class BlogContext : DbContext, IBlogContext
    {
        static BlogContext()
        {
            Database.SetInitializer<BlogContext>(new BlogInitializer());
        }

        public BlogContext() : base("Blog")
        {
        }

        public IDbSet<Post> Posts { get; set; }

        public IDbSet<Comment> Comments { get; set; }
    }
}
