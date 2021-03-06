using System.ComponentModel.DataAnnotations;

namespace Volo.HitCommerce.Directions.Dtos
{
    public class CountryUpdateDto
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public string Code3 { get; set; }

        public bool IsBillingEnabled { get; set; }

        public bool IsShippingEnabled { get; set; }

        public bool IsCityEnabled { get;  set; }

        public bool IsZipCodeEnabled { get;  set; }

        public bool IsDistrictEnabled { get;  set; }
    }
}