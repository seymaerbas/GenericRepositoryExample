using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace GenericRepositoryExampla.Entity.Model
{
    public class Faq
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Faq_Id { get; set; }
        public string Question { get; set; }
        public string Answer { get; set; }


    }
}
