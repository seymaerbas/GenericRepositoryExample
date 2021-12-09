using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace GenericRepositoryExampla.Entities.Model
{
   public class Profile : BaseEntity
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Profil_Id { get; set; }
      
        public string Image { get; set; }
        public string Address { get; set; }
        public int Phone { get; set; }
            
        [ForeignKey("User")]
        public int User_Id { get; set; }

        //Hangi tabloyla ilişki kuracak
        public User User { get; set; }
        
    }
}
