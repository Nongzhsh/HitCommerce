using System;

namespace Volo.HitCommerce.Medias.Dtos
{
    public class GetMediaUrlInputDto
    {
        public Guid? MediaId { get; set; }
        
        public string FileName { get; set; }
    }
}