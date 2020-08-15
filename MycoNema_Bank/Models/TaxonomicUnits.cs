using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MycoNema_Bank.Models
{
    [Table("tbl_Taxonomic_Classes")]
    public class TaxonomicClasses
    {
        [Key]
        public int ID { get; set; }

        [Display(Name = "Class")]
        [MaxLength(50, ErrorMessage = "{0} must be up to {1} characters only.")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "{0} is a required field.")]
        public string Class { get; set; }

        [Display(Name = "Parent Class")]
        public int? ParentClass { get; set; }

        [Display(Name = "Purge Flag")]
        public bool PurgeFlag { get; set; }

        [Display(Name = "Date Created")]
        public DateTime CreatedAt { get; set; }

        [Display(Name = "Date Updated")]
        public DateTime? UpdatedAt { get; set; }

        [Display(Name = "Date Purged")]
        public DateTime? DeletedAt { get; set; }

        [ForeignKey("ParentClass")]
        public virtual TaxonomicClasses FKParentClassReference { get; set; }
    }

    [Table("tbl_Taxonomic_Unit")]
    public class TaxonomicUnit
    {
        [Key]
        public int ID { get; set; }

        [Display(Name = "Rank")]
        public int Rank { get; set; }

        [Display(Name = "Unit Name")]
        [Column(TypeName = "VARCHAR")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "{0} is a required field.")]
        public string UnitName { get; set; }

        [Display(Name = "Author")]
        [Column(TypeName = "VARCHAR")]
        public string Author { get; set; }

        [Display(Name = "Year")]
        public int Year { get; set; }

        [Display(Name = "Parent Taxon")]
        public int? ParentTaxon { get; set; }

        [Display(Name = "Purge Flag")]
        public bool PurgeFlag { get; set; }

        [Display(Name = "Date Created")]
        public DateTime CreatedAt { get; set; }

        [Display(Name = "Date Updated")]
        public DateTime? UpdatedAt { get; set; }

        [Display(Name = "Date Purged")]
        public DateTime? DeletedAt { get; set; }

        [ForeignKey("Rank")]
        public virtual TaxonomicClasses FKRankReference { get; set; }

        [ForeignKey("ParentTaxon")]
        public virtual TaxonomicUnit FKParenTaxon { get; set; }
    }
}