using System.ComponentModel.DataAnnotations;

namespace Volo.HitCommerce.Widgets.Dtos
{
    public class WidgetCreateDto
    {
        [Required]
        public string Name { get; set; }

        public string ViewComponentName { get; set; }

        public string CreateUrl { get; set; }

        public string EditUrl { get; set; }

        public bool IsPublished { get; set; }
    }
}