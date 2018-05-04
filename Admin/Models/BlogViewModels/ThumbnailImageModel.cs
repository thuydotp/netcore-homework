using System;

namespace Admin.Models.BlogViewModels
{
    public class ThumbnailImageModel
    {
        public Guid Id { get; set; }
        public byte[] Image { get; set; }
        public string Caption { get; set; }

        public Guid PostId { get; set; }
        public PostModel Post { get; set; }
    }
}