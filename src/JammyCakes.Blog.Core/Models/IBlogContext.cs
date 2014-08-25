using System;
using System.Data.Entity;

namespace JammyCakes.Blog.Core.Models
{
    public interface IBlogContext
    {
        IDbSet<Post> Posts { get; set; }
    }
}
