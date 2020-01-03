
using Core.Entities;
using System;
using System.Collections.Generic;

namespace Core.Services.Interfaces
{
    public interface IOwnersService
    {
        Owners GetOwner(Guid id);
        void AddOwner(Owners owner);
        IEnumerable<Owners> GetOwners();

    }
}
