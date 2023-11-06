using SKUPortal.Model;

namespace SKUPortal.BusinessLayer.Shelves
{
    public interface IAddSKUDrinkRepo
    {
        Task<SKULane> AddSkuDrink(SKULane curLane);
    }
}