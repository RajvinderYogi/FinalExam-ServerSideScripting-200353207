namespace COMP2084FinalF2017.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Country
    {
        public int CountryID { get; set; }

        [Column("Country")]
        [Required]
        [StringLength(50)]
        public string Country1 { get; set; }

        public int Gold { get; set; }

        public int Silver { get; set; }

        public int Bronze { get; set; }

        public int TotalMedals { get; set; }

        [Required]
        [StringLength(100)]
        public string Flag { get; set; }
    }
}
