using BlogSite.Models;

namespace BlogSite.Clients
{
    public class BlogsClient
    {
        private readonly BlogCard[] _blogs = new[]
        {
            new BlogCard { Id = 1, Title = "Introduction to Blazor", Summary = "Learn the basics of Blazor web development", Author = "John Doe", PublishDate = DateTime.Now.AddDays(-5) },
            new BlogCard { Id = 2, Title = "Advanced C# Techniques", Summary = "Dive deep into C# programming", Author = "Jane Smith", PublishDate = DateTime.Now.AddDays(-3) },
            new BlogCard { Id = 3, Title = "Web API Best Practices", Summary = "Explore best practices for building Web APIs", Author = "Bob Johnson", PublishDate = DateTime.Now.AddDays(-1) },
        };

        public BlogCard[] GetBlogs() => _blogs;
    }
}
