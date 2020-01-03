using Core.Entities;
using System;
using System.Collections.Generic;

namespace Core.Repositories.Interfaces
{
    public interface IOwnersRepository
    {
        Owners GetOwner(Guid id);
        void AddOwner(Owners owner);
        IEnumerable<Owners> GetOwners();



    }
}
