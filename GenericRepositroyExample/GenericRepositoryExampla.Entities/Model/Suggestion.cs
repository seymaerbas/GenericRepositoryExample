using GenericRepositoryExampla.Entities.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace GenericRepositoryExampla.Entity.Model
{
    public class Suggestion
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Suggestion_Id { get; set; }

        [StringLength(50)]
        public string Detail { get; set; }
        [StringLength(30)]
        public string Title { get; set; }
        //User:1 Suggestion :N
        [ForeignKey("User")]
        public int User_id { get; set; }
        public User User { get; set; }
        //Content:1 Suggestion:N
        [ForeignKey("Content")]
        public int Content_Id { get; set; }
        public Content Content { get; set; }
    }
}
