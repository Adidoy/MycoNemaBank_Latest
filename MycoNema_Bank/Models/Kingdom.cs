using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MycoNema_Bank.Models
{
    [Table("tbl_Kingdom")]
    public class Kingdom
    {
        [Key]
        public int ID { get; set; }

        [Column(TypeName = "VARCHAR")]
        [Display(Name = "Kingdom Name")]
        [MaxLength(25, ErrorMessage = "{0} must be up to {1} characters only.")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "{0} is required.")]
        public string KingdomName { get; set; }

        [Display(Name = "Purge Flag")]
        public bool PurgeFlag { get; set; }

        [Display(Name = "Date Created")]
        public DateTime CreatedAt { get; set; }

        [Display(Name = "Date Updated")]
        public DateTime UpdateAt { get; set; }

        [Display(Name = "Date Deleted")]
        public DateTime DeletedAt { get; set; }
    }
}