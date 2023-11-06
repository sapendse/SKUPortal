using SKUPortal.Model;

namespace SKUPortal.BusinessLayer.Shelves
{
    public interface IMoveSKUDrinkRepo
    {
        SKUStore MoveSkuDrink(SKUStore store, SKUMoveDrinkInfo moveDrinkInfo);
    }
}