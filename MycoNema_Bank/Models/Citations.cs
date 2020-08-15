using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MycoNema_Bank.Models
{
    [Table("tbl_Citations")]
    public class Citation
    {
        [Key]
        public int ID { get; set; }

        public int SpecieReference { get; set; }

        [Display(Name = "Title")]
        public string Title { get; set; }

        [Display(Name = "Authors")]
        public string Authors { get; set; }

        [Display(Name = "Editors")]
        public string Editors { get; set; }

        [Display(Name = "Reference Type")]
        public int DocumentType { get; set; }

        [Display(Name = "Year Published")]
        public string YearPublished { get; set; }

        [ForeignKey("SpecieReference")]
        public virtual TaxonomicUnit FKSpecieReference { get; set; }
    }
}