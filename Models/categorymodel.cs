using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Linq;

namespace manibooktrack.Models
{
    public class categorymodel
    {
        [Key]
        public int CategoryId { get; set; }

        [Required]
        [Display(Name = "Name Token")]
        [Column(TypeName = "NVARCHAR(250)")]
        [MaxLength(250, ErrorMessage = "Maximum Length is 250")]
        public string NameToken { get; set; }

        [Required]
        [ForeignKey("categorytypemodel")]
        public int Type { get; set; }
        public categorytypemodel categorytypemodel { get; set; }

        [Required]
        [Column(TypeName = "NVARCHAR(MAX)")]
        public string Description { get; set; }


        //RelationShip
        public List<booksmodel> BookList { get; set; }
    }
}

