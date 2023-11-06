using SKUPortal.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SKUPortal.BusinessLayer.DALInterfaces
{
    public interface IStoreRepository
    {
        public SKUStore ReadAndParseSampleData();
    }
}
