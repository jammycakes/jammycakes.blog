﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JammyCakes.Blog.Core.Models
{
    public class BlogContext : DbContext, IBlogContext
    {
        public BlogContext(string connectionString) : base(connectionString)
        {
        }

        public IDbSet<Post> Posts { get; set; }
    }
}