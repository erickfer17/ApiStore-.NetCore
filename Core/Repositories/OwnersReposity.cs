using System.Threading.Tasks;
using Core.Dtos;
using Core.Dbcontex;
using Core.Repositories.Interfaces;
using System.Collections;
using Core.Entities;
using System.Collections.Generic;
using System.Linq;
using System;

namespace Core.Repositories
{
     public class OwnersReposity : IOwnersRepository
    {
        private readonly MyDbContex _contex;
        public OwnersReposity(MyDbContex contex)
        {
            _contex = contex;
        }

        //GetOwners from DB
        public IEnumerable<Owners> GetOwners() {

            return _contex.Owners.ToList<Owners>();
        }

        //Select Owner from DB
         public Owners GetOwner(Guid id) { 
            if (id == null)
            {
                throw new ArgumentNullException(nameof(id));
            }
            return _contex.Owners.FirstOrDefault(a => a.Id == id);
        }

        //Add new Owner from DB
        public void AddOwner(Owners owner) {
            if (owner == null) {
                throw new ArgumentNullException(nameof(owner));
            }
            owner.Id = Guid.NewGuid();
            _contex.Owners.Add(owner);
            _contex.SaveChanges();
        }

      
    }
}
