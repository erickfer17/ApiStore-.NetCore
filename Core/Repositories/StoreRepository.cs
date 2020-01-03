using Core.Repositories.Interfaces;

namespace Core.Repositories
{
     public class StoreRepository: IStoreRepository
    {
        public StoreRepository()
        {
                
        }

        public string HolaMundo() {

            return "Hello babys, how are you today? i hope that you are ok!";
        }

    }
}
