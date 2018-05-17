using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleBlog.Persistence
{
    public class Category
    {
        public Guid Id { get; set; }

        [Required]
        [StringLength(225)]
        public string Name { get; set; }

        [Required]
        public string Description { get; set; }

        public Category()
        {

        }
    }
}
