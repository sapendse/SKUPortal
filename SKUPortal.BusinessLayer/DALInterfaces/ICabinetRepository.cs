using SKUPortal.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SKUPortal.BusinessLayer.DALInterfaces
{
    public interface ICabinetRepository
    {
        public Task<SKULane> AddSkuDrink(SKULane curLane);
        public SKUStore MoveSkuDrink(SKUStore store, SKUMoveDrinkInfo moveDrinkInfo);
        public Task<SKULane> RemoveSkuDrink(SKULane curLane);
    }
}
