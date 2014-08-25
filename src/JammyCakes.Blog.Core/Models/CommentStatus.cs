using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JammyCakes.Blog.Core.Models
{
    public enum CommentStatus
    {
        Submitted,
        PendingModeration,
        Approved,
        Spam
    }
}
