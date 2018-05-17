using System;
namespace SimpleBlog.Models.BlogViewModels
{
    public class ThumbnailImageViewModel
    {
        public Guid Id { get; set; }
        public byte[] Image { get; set; }
        public string Caption { get; set; }
    }
}
