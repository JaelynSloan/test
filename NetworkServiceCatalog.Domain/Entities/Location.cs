using System.ComponentModel.DataAnnotations;
using System.Net.NetworkInformation;

namespace NetworkServiceCatalog.Domain.Entities
{
    public class Location
    {
        public int Id { get; set; }

        [Required(ErrorMessage ="Please enter a location name")]
        [StringLength(100)]
        public string LocationName { get; set; }

        [Required(ErrorMessage ="Please enter a valid IP address")]
        [StringLength(39)]
        public string IpAddress { get; set; }

    }

}

