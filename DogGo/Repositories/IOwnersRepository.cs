using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DogGo.Models;

namespace DogGo.Repositories
{
    public interface IOwnersRepository
    {
        void AddOwner(Owner owner);
        void DeleteOwner(int ownerId);
        List<Owner> GetAllOwners();
        Owner GetOwnerByEmail(string email);
        Owner GetOwnerById(int id);
        void UpdateOwner(Owner owner);
    }
}
