using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace GenericRepositoryExampla.Entity.Model
{
    public class Setting
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Setting_Id { get; set; }
        [StringLength(30)]
        public string Facebook { get; set; }
        [StringLength(30)]
        public string Twitter { get; set; }
        [StringLength(30)]
        public string Instagram { get; set; }

    }
}
