using System.ComponentModel.DataAnnotations;

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
        public bool IsOnline { get; set; }
        public virtual string IsOnlineStr => IsOnline ? "Online" : "Offline";
    }
}
