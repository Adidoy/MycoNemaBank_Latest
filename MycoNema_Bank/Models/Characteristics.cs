using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MycoNema_Bank.Models
{
    [Table("tbl_Characteristics")]
    public class Characteristics
    {
        [Key]
        public int ID { get; set; }
        public int SpecieReference { get; set; }
        [Display(Name = "Macroscopic Characteristics")]
        public string Macrosopic { get; set; }
        [Display(Name = "Microscopic Characteristics")]
        public string Microscopic { get; set; }
        [ForeignKey("SpecieReference")]
        public TaxonomicUnit FKSpecieReference { get; set; }
    }
}