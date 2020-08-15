using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MycoNema_Bank.Models
{
    [Table("tbl_Hosts")]
    public class Hosts
    {
        [Key]
        public int ID { get; set; }

        [Display(Name = "ScientificName")]
        public string ScientificName { get; set; }

        [Display(Name = "Local Name")]
        public string LocalName { get; set; }

        [Display(Name = "Description")]
        public string Description { get; set; }
    }

    [Table("tbl_SpeciePerLocationAndHost")]
    public class SpeciePerLocationAndHost
    {
        [Key, Column(Order = 0)]
        public int LocationReference { get; set; }
        [Key, Column(Order = 1)]
        public int HostReference { get; set; }
        [Key, Column(Order = 2)]
        public int SpeciesReference { get; set; }

        [Display(Name = "Symptoms")]
        public string Symptoms { get; set; }

        [ForeignKey("LocationReference")]
        public Locations FKLocationReference { get; set; }
        [ForeignKey("HostReference")]
        public Hosts FKHostReference { get; set; }
        [ForeignKey("SpeciesReference")]
        public TaxonomicUnit FKSpeciesReference { get; set; }
    }
}