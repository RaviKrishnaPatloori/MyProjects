using System.ComponentModel.DataAnnotations.Schema;

namespace HSVS.SinglePostal.Data
{
    public class DefaultPostalSettings
    {
        [Column("id")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Column("message1")]
        public string PostalMessage1 { get; set; }

        [Column("message2")]
        public string PostalMessage2 { get; set; }

        [Column("target_client_limit")]
        public int TargetClientLimit { get; set; }
    }
}
