using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleBlog.Persistence
{
    public class Post
    {
        public Guid Id { get; set; }
        public string Slug { get; set; }
        public string ShortDescription { get; set; }
        public string MainContent { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
    }
}
