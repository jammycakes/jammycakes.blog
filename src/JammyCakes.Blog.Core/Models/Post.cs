using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JammyCakes.Blog.Core.Models
{
    public class Post
    {
        public int ID { get; set; }

        public string Title { get; set; }

        public string Content { get; set; }

        public DateTime PublicationDate { get; set; }

        public virtual ICollection<Comment> Comments { get; set; }
    }
}
