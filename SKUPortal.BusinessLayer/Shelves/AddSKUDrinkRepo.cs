using SKUPortal.BusinessLayer.DALInterfaces;
using SKUPortal.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SKUPortal.BusinessLayer.Shelves
{
    public class AddSKUDrinkRepo : IAddSKUDrinkRepo
    {
        private readonly ICabinetRepository _cabinetRepo;

        public AddSKUDrinkRepo(ICabinetRepository cabinetRepo)
        {
            _cabinetRepo = cabinetRepo;
        }

		public async Task<SKULane> AddSkuDrink(SKULane curLane)
		{
			return await _cabinetRepo.AddSkuDrink(curLane);
		}
	}
}
