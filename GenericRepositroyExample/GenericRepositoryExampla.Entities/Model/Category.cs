using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace GenericRepositoryExampla.Entities.Model
{
    public class Category
    {
        public Category()
        {
            Contents = new Collection<Content>();
        }
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Category_Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public ICollection<Content> Contents { get; set; }
    }
}
