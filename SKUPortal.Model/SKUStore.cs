using System.ComponentModel.DataAnnotations;

namespace SKUPortal.Model
{
    public class SKUStore
    {
        [Required]
        public List<SKUCabinet> Cabinets { get; set; } = new List<SKUCabinet>();

        [Required]
        public List<SKUDrink> DrinkInventory { get; set; } = new List<SKUDrink>();
    }
}
