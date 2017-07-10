using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HSVS.SinglePostal.Data
{
    public class RapportMapping
    {
        [Key]
        [Column("dsid")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int DSid { get; set; }
      
        [Column("hid")]
        public int HospitalId { get; set; }
        [Column("create_date")]
        public DateTime CreatedDate { get; set; }
    }
}
