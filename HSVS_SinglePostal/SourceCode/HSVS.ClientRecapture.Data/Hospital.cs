using System.ComponentModel.DataAnnotations.Schema;

namespace HSVS.SinglePostal.Data
{
    public class Hospital
    {
        [Column("id")]
        public int Id { get; set; }

        [Column("long_name")]
        public string HospitalLongName { get; set; }

        [Column("short_name")]
        public string HospitalShortName { get; set; }

        [Column("phone")]
        public string Phone { get; set; }

        [Column("address1")]
        public string Address1 { get; set; }

        [Column("address2")]
        public string Address2 { get; set; }

        [Column("address3")]
        public string Address3 { get; set; }

        [Column("city")]
        public string City { get; set; }

        [Column("state")]
        public string State { get; set; }

        [Column("zip")]
        public string Zip { get; set; }

        [Column("url")]
        public string Url { get; set; }
    }
}
