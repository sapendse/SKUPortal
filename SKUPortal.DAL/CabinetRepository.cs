using SKUPortal.BusinessLayer.DALInterfaces;
using SKUPortal.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SKUPortal.DAL
{
    public class CabinetRepository : ICabinetRepository
    {
		public async Task<SKULane> AddSkuDrink(SKULane curLane)
        {
            curLane.Quantity = curLane.Quantity + 1;
            return curLane;
        }

		public SKUStore MoveSkuDrink(SKUStore store, SKUMoveDrinkInfo moveDrinkInfo)
		{
            int originalRowIndex = moveDrinkInfo.OriginalRow.Lanes.IndexOf(moveDrinkInfo.OriginalLane),
                newRowIndex = moveDrinkInfo.OriginalRow.Lanes.IndexOf(moveDrinkInfo.NewLane);

			SKUDrink originalLaneDrink = store.DrinkInventory.FirstOrDefault(x => x.JanCode == moveDrinkInfo.OriginalLane.JanCode);
            SKUDrink newLaneDrink = store.DrinkInventory.FirstOrDefault(x => x.JanCode == moveDrinkInfo.NewLane.JanCode);

            if (originalLaneDrink.ProductShapeType == newLaneDrink.ProductShapeType)
            {
                SKULane tempLane = moveDrinkInfo.NewLane;
                moveDrinkInfo.NewRow.Lanes[newRowIndex] = moveDrinkInfo.OriginalLane;
				moveDrinkInfo.OriginalRow.Lanes[originalRowIndex] = moveDrinkInfo.NewLane;
				moveDrinkInfo.MoveDrinkMessage = string.Empty;
            }
            else
			{
				moveDrinkInfo.MoveDrinkMessage = "These drinks are not of the same shape type. Can not swap.";
			}
			return store;
        }

		public async Task<SKULane> RemoveSkuDrink(SKULane curLane)
		{
            if (curLane.Quantity > 0)
            {
                curLane.Quantity = curLane.Quantity - 1;
            }
            return curLane;
        }
    }
}
