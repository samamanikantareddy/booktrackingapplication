using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace manibooktrack.Models
{
    public class categorytypemodel
    {
        [Key]
        public int CategoryTypeId { get; set; }

        [Required]
        [Column(TypeName = "NVARCHAR(250)")]
        [MaxLength(250, ErrorMessage = "Maximum Length is 250")]
        public string Type { get; set; }

        [Required]
        [Column(TypeName = "NVARCHAR(250)")]
        [MaxLength(250, ErrorMessage = "Maximum Length is 250")]
        public string Name { get; set; }


        //RelationShip
        public List<categorymodel> CategoryList { get; set; }
    }
}

