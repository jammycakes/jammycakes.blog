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
        public PostSortOrder Order { get; set; }

        public bool Descending { get; set; }

        public IQueryable<Post> GetPosts(IQueryable<Post> source)
        {
            switch (this.Order)
            {
                case PostSortOrder.Date:
                    source = Descending
                        ? source.OrderByDescending(x => x.PublicationDate)
                        : source.OrderBy(x => x.PublicationDate);
                    break;
                case PostSortOrder.Title:
                    source = Descending
                        ? source.OrderByDescending(x => x.Title)
                        : source.OrderBy(x => x.Title);
                    break;
            }

            return base.ApplyPaging(source);
        }
    }
}
