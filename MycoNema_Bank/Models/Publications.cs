using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MycoNema_Bank.Models
{
    [Table("tbl_Publications")]
    public class Publications
    {
        [Key]
        public int ID { get; set; }

        [Column(TypeName = "VARCHAR")]
        [Display(Name = "Author(s)/Editor(s)")]
        [MaxLength(50, ErrorMessage = "{0} must be up to {1} characters only.")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "{0} is a required field.")]
        public string Authors { get; set; }

        [Display(Name = "Publication Date")]
        public DateTime PublicationDate { get; set; }

        [Column(TypeName = "VARCHAR")]
        [Display(Name = "Article/Chapter Title")]
        [MaxLength(175, ErrorMessage = "{0} must be up to {1} characters only.")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "{0} is a required field.")]
        public string ArticleTitle { get; set; }

        [Column(TypeName = "VARCHAR")]
        [Display(Name = "Journal/Book Name, Vol. No.")]
        [MaxLength(175, ErrorMessage = "{0} must be up to {1} characters only.")]
        public string JournalBookName { get; set; }

        [Column(TypeName = "VARCHAR")]
        [Display(Name = "Page(s)")]
        [MaxLength(175, ErrorMessage = "{0} must be up to {1} characters only.")]
        public string Pages { get; set; }

        [Column(TypeName = "VARCHAR")]
        [Display(Name = "Publisher")]
        [MaxLength(175, ErrorMessage = "{0} must be up to {1} characters only.")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "{0} is a required field.")]
        public string Publisher { get; set; }

        [Column(TypeName = "VARCHAR")]
        [Display(Name = "Publication Place")]
        [MaxLength(175, ErrorMessage = "{0} must be up to {1} characters only.")]
        public string PublicationPlace { get; set; }

        [Column(TypeName = "VARCHAR")]
        [Display(Name = "ISSN/ISBN")]
        [MaxLength(75, ErrorMessage = "{0} must be up to {1} characters only.")]
        public string ISSN_ISBN { get; set; }
    }

    [Table("tbl_Taxon_Publication")]
    public class TaxonPublication
    {
        [Key, Column(Order = 0)]
        public int TaxonomicUnitID { get; set; }
        [Key, Column(Order = 1)]
        public int PublicationID { get; set; }

        [ForeignKey("TaxonomicUnitID")]
        public virtual TaxonomicUnit FKTaxonReference { get; set; }

        [ForeignKey("PublicationID")]
        public virtual Publications FKPublicationReference { get; set; }
    }
}