using System.ComponentModel.DataAnnotations;

namespace SKUPortal.Model
{
    public class SKUDrink
    {
        [Required]        
        public string JanCode { get; set; } = string.Empty;
        public string DrinkName { get; set; } = string.Empty;
        public int DrinkSizeInMl { get; set; }
        public SKUSize ProductSize { get; set; } = new SKUSize();
        public string ProductShapeType { get; set; } = string.Empty;
        public string ProductImageUrl { get; set; } = string.Empty;
        public string ProductRegistrationTimeStamp { get; set; } = string.Empty;

    }
}