using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication3.Models.DBEntities
{
    public class Airports
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int AirportID { get; set; }
        public string AirportName { get; set; }
        public string Location { get; set; }

    }
}
