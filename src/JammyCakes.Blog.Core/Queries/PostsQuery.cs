using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JammyCakes.Blog.Core.Models;

namespace JammyCakes.Blog.Core.Queries
{
    public class PostsQuery : PagingQuery<Post>
    {
        public IQueryable<Post> GetPosts(IDbSet<Post> source)
        {
            return base.ApplyPaging(source);
        }
    }
}
