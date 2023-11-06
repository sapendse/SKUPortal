using SKUPortal.Model;

namespace SKUPortal.BusinessLayer.Shelves
{
    public interface IRemoveSKUDrinkRepo
    {
        Task<SKULane> RemoveSkuDrink(SKULane curLane);
    }
}