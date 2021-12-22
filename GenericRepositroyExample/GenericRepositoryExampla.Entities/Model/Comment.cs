using GenericRepositoryExampla.Entities.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace GenericRepositoryExampla.Entity.Model
{
    public class Comment
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Comment_Id { get; set; }
        public int User_Id { get; set; }


        public int Rate { get; set; }
        public string CommentDetail { get; set; }
        [StringLength(30)]
        public string Title { get; set; }
        //Content:1-Comment:N 
        [ForeignKey("Content")]
        public int Content_Id { get; set; }
        public Content Content { get; set; }
        //User :1 Comment:N
        [ForeignKey("User")]
        public int User_id { get; set; }
        public User User { get; set; }
    }
}
