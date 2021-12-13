using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DogGo.Models;

namespace DogGo.Repositories
{
    public interface IOwnersRepository
    {
        List<Owner> GetAllOwners();
        Owner GetOwnerById(int id);
    }
}
