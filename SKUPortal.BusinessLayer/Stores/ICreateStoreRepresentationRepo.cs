using SKUPortal.Model;

namespace SKUPortal.BusinessLayer.Stores
{
    public interface ICreateStoreRepresentationRepo
    {
        SKUStore ReadAndParseSampleData();
    }
}