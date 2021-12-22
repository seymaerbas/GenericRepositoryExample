using GenericRepositoryExampla.Entities.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace GenericRepositoryExampla.Entity.Model
{
    public class Folder
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Folder_Id { get; set; }
        public string Type { get; set; }

        //User:1 Folder:N
        [ForeignKey("User")]
        public int User_id { get; set; }
        public User User { get; set; }
        //Folder:N Content:1
        [ForeignKey("Content")]
        public int Content_Id { get; set; }
        public Content Content { get; set; }
    }
}
