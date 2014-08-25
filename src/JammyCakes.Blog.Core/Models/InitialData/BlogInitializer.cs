using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JammyCakes.Blog.Core.Models.InitialData
{
    public class BlogInitializer : DropCreateDatabaseAlways<BlogContext>
    {
        protected override void Seed(BlogContext context)
        {
            var posts = new List<Post> {
                new Post {
                    Title = "First post",
                    Content = "Welcome to JammyCakes.Blog. This is a sample post. " +
                        "Please feel free to delete it and start over with your own " +
                        "blog entries.",
                    PublicationDate = DateTime.UtcNow,
                    Comments = new List<Comment> {
                        new Comment {
                            Name = "Anonymous Coward",
                            Email = "anonymous.coward@example.com",
                            Status = CommentStatus.Approved,
                            Time = DateTime.UtcNow,
                            Content = "This is a comment."
                        }
                    }
                }
            };

            posts.ForEach(p => context.Posts.Add(p));
            context.SaveChanges();
        }
    }
}
