using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Linq;

namespace manibooktrack.Models
{
    public class booksmodel
    {
        [Key]
        public int BookId { get; set; }

        [Required]
        [Column(TypeName = "NVARCHAR(50)")]
        [MaxLength(13, ErrorMessage = "Minimum Length is 13")]
        [MinLength(10, ErrorMessage = "Minimum Length Length is 10")]
        public string ISBN { get; set; }

        [Required]
        [Column(TypeName = "NVARCHAR(250)")]
        [MaxLength(250, ErrorMessage = "Maximum Length is 250")]
        public string Title { get; set; }

        [Required]
        [Display(Name = "category")]
        [ForeignKey("categorymodel")]
        public int Category { get; set; }
        public categorymodel categorymodel { get; set; }

        [Required]
        [Column(TypeName = "NVARCHAR(250)")]
        [MaxLength(250, ErrorMessage = "Maximum Length is 250")]
        public string Author { get; set; }
    }
}

