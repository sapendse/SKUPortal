using SKUPortal.BusinessLayer.DALInterfaces;
using SKUPortal.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SKUPortal.BusinessLayer.Shelves
{
    public class MoveSKUDrinkRepo : IMoveSKUDrinkRepo
    {
        private readonly ICabinetRepository _cabinetRepo;

        public MoveSKUDrinkRepo(ICabinetRepository cabinetRepo)
        {
            _cabinetRepo = cabinetRepo;
        }

		public SKUStore MoveSkuDrink(SKUStore store, SKUMoveDrinkInfo moveDrinkInfo)
		{
			return _cabinetRepo.MoveSkuDrink(store, moveDrinkInfo);
		}
	}
}
