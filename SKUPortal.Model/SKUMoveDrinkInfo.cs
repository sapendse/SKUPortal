using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SKUPortal.Model
{
	public class SKUMoveDrinkInfo
	{
		public bool MoveAction { get; set; } = false;
		public bool HideError { get; set; } = false;
		public string MoveDrinkMessage { get; set; } = string.Empty;
		public SKULane OriginalLane { get; set; } = new SKULane();
		public SKULane NewLane { get; set; } = new SKULane();
		public SKURow OriginalRow { get; set; } = new SKURow();
		public SKURow NewRow { get; set; } = new SKURow();

	}
}
