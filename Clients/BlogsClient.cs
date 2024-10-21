using BlogSite.Models;

namespace BlogSite.Clients
{
    public class BlogsClient
    {
        public BlogCard[] GetBlogs()
        {
            return new BlogCard[]
            {
                new BlogCard { Id = 1, Title = "First Blog Post", Summary = "This is the summary of the first blog post.", Author = "John Doe", PublishDate = DateTime.Now.AddDays(-5), File = "first-blog-post" },
                new BlogCard { Id = 2, Title = "Second Blog Post", Summary = "This is the summary of the second blog post.", Author = "Jane Smith", PublishDate = DateTime.Now.AddDays(-3), File = "second-blog-post" },
                new BlogCard { Id = 3, Title = "Third Blog Post", Summary = "This is the summary of the third blog post.", Author = "Bob Johnson", PublishDate = DateTime.Now.AddDays(-1), File = "third-blog-post" }
            };
        }
    }
}
