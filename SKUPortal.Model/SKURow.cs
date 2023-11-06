using System.ComponentModel.DataAnnotations;

namespace SKUPortal.Model
{
    public class SKURow
    {
        [Required]
        public int Number { get; set; }
        public List<SKULane> Lanes { get; set; } = new List<SKULane>();
        public int PositionZ { get; set; }
        public SKUSize Size { get; set; } = new SKUSize();
    }
}