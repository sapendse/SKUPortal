using SKUPortal.BusinessLayer.DALInterfaces;
using SKUPortal.Model;

namespace SKUPortal.BusinessLayer.Stores
{
    public class CreateStoreRepresentationRepo : ICreateStoreRepresentationRepo
    {
        private readonly IStoreRepository _storeRepo;

        public CreateStoreRepresentationRepo(IStoreRepository storeRepo)
        {
            _storeRepo = storeRepo;
        }

        public SKUStore ReadAndParseSampleData()
        {
            return _storeRepo.ReadAndParseSampleData();
        }
    }
}
