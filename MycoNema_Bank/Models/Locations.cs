using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MycoNema_Bank.Models
{
    [Table("tbl_Provinces")]
    public class Provinces
    {
        [Key]
        public int ID { get; set; }

        [Display(Name = "Province")]
        public string Province { get; set; }
    }

    [Table("tbl_Municipality")]
    public class Municipalities
    {
        [Key]
        public int ID { get; set; }

        public int ProvinceReference { get; set; }

        [Display(Name = "City/Municipality")]
        public string Municipality { get; set; }

        [ForeignKey("ProvinceReference")]
        public virtual Provinces FKProvinceReference { get; set; }
    }

    [Table("tbl_Locations")]
    public class Locations
    {
        [Key]
        public int ID { get; set; }

        [Display(Name = "Longitude")]
        public string Logitude { get; set; }

        [Display(Name = "Latitude")]
        public string Latitude { get; set; }

        public int? ProvinceReference { get; set; }

        public int MunicipalityReference { get; set; }

        [Display(Name = "Location Name")]
        public string LocationName { get; set; }

        [ForeignKey("ProvinceReference")]
        public virtual Provinces FKProvinceReference { get; set; }

        [ForeignKey("MunicipalityReference")]
        public virtual Municipalities FKMunicipalitiesReference { get; set; }
    }
}