using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace GenericRepositoryExampla.Entities.Model
{
    public class Content
    {
        [Key]
        public int Content_Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Detail { get; set; }
        [ForeignKey("Category")]
        public int Category_Id { get; set; }

        public Category Category { get; set; }
    }
}
