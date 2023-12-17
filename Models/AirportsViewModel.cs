using System.ComponentModel;

namespace WebApplication3.Models
{
    public class AirportsViewModel
    {
        public int AirportID { get; set; }

        [DisplayName("AirportName")]
        public string AirportName { get; set; }

        [DisplayName("Location")]

        public string Location { get; set; }

    }
}
