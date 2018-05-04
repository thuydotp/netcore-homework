using System;

namespace Admin.Models.BlogViewModels
{
    public class PostModel
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Slug { get; set; }
        public string ShortDescription { get; set; }
        public string Content { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
        
        public Guid PostImageId { get; set; }
        public ThumbnailImageModel PostImage { get; set; }
        public Guid CategoryId { get; set; }
        public CategoryModel Category { get; set; }
    }
}