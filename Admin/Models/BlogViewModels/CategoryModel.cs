using System;
using System.Collections.Generic;

namespace Admin.Models.BlogViewModels
{
    public class CategoryModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public List<PostModel> Posts { get; set; }
    }
}