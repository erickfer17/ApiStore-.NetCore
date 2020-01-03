using Core.Repositories.Interfaces;
using Core.Services.Interfaces;

namespace Core.Services
{
    public class StoreService : IStoreService
    {
        private readonly IStoreRepository _storeRepository;

        public StoreService(IStoreRepository storeRepository)
        {
            _storeRepository = storeRepository;


        }


        public string GetHolaMundo() {
            string x = _storeRepository.HolaMundo();
            return x;
        }
    }
}
