using System;

namespace SimpleBlog.Models.BlogViewModels
{
    public class PostViewModel
    {
        public Guid Id { get; set; }
        public string Slug { get; set; }
        public string ShortDescription { get; set; }
        public string MainContent { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
    }
}
