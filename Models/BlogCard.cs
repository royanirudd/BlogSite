﻿namespace BlogSite.Models
{
    public class BlogCard
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public string? Summary { get; set; }
        public string? Author { get; set; }
        public DateTime PublishDate { get; set; }
    }
}
