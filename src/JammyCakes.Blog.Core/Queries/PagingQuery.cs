using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JammyCakes.Blog.Core.Queries
{
    public class PagingQuery<T>
    {
        public const int DefaultPageSize = 10;

        public int? PageNumber { get; set; }

        public int? PageSize { get; set; }

        public bool DisablePaging { get; set; }

        protected IQueryable<T> ApplyPaging(IQueryable<T> source)
        {
            if (DisablePaging) return source;
            var skipPages = (PageNumber ?? 1) - 1;
            var take = PageSize ?? DefaultPageSize;
            var skip = skipPages * take;
            return source.Skip(skip).Take(take);
        }
    }
}
