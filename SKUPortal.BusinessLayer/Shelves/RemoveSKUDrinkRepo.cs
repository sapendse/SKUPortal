using SKUPortal.BusinessLayer.DALInterfaces;
using SKUPortal.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SKUPortal.BusinessLayer.Shelves
{
	public class RemoveSKUDrinkRepo : IRemoveSKUDrinkRepo
    {
        private readonly ICabinetRepository _cabinetRepo;

        public RemoveSKUDrinkRepo(ICabinetRepository cabinetRepo)
        {
            _cabinetRepo = cabinetRepo;
        }

		public async Task<SKULane> RemoveSkuDrink(SKULane curLane)
		{
			return await _cabinetRepo.RemoveSkuDrink(curLane);
		}
	}
}
