﻿using System;

namespace SimpleBlog.Models.BlogViewModels
{
    public class CategoryViewModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public CategoryViewModel()
        {

        }
    }
}
