using Models;
using Services;

namespace Controllers
{
    public class StoreController
    {
        private StoreServices storeService;

        public StoreController()
        {
            storeService = new StoreServices();
        }

        public bool Insert(Store store)
        {
            return storeService.Insert(store);
        }

        public List<Store> GetAll() 
        {
            return storeService.GetAll();   
        }
    }
}