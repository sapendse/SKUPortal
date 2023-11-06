using System.ComponentModel.DataAnnotations;

namespace SKUPortal.Model
{
    public class SKULane
    {
        [Required]
        public int Number { get; set; }
        public string JanCode { get; set; } = string.Empty;
        public int Quantity { get; set; }
        public int PositionX { get; set; }
    }
}