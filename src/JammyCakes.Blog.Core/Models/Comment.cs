using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JammyCakes.Blog.Core.Models
{
    public class Comment
    {
        public int ID { get; set; }

        public int PostID { get; set; }

        public Post Post { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }

        public string Content { get; set; }

        public DateTime Time { get; set; }

        public CommentStatus Status { get; set; }
    }
}
