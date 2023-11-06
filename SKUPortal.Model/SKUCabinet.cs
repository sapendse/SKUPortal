using System.ComponentModel.DataAnnotations;

namespace SKUPortal.Model
{
    public class SKUCabinet
    {
        [Required]
        public int Number { get; set; }
        public List<SKURow> Rows { get; set; } = new List<SKURow>();
        public SKUPosition Position { get; set; } = new SKUPosition();
        public SKUSize Size { get; set; } = new SKUSize();
    }
}
