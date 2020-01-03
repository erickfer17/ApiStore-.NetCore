
using Core.Entities;
using Core.Repositories.Interfaces;
using Core.Services.Interfaces;
using System;
using System.Collections.Generic;

namespace Core.Services
{
    public class OwnersService : IOwnersService
    {
        private readonly IOwnersRepository _ownersRepository;
        public OwnersService(IOwnersRepository ownersRepository)
        {
            _ownersRepository = ownersRepository;
        }

        public IEnumerable<Owners> GetOwners() {
            IEnumerable<Owners> owners = _ownersRepository.GetOwners();
            return owners;
        }


        public void AddOwner(Owners owner) {
            _ownersRepository.AddOwner(owner);
        }

        public Owners GetOwner(Guid id) {
            Owners owner;
            owner = _ownersRepository.GetOwner(id);
            return owner;
        }
        

        

    }
}
