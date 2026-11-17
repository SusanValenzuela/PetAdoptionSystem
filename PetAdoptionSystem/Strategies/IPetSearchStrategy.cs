using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using PetAdoptionSystem.Models;

namespace PetAdoptionSystem.Strategies
{
    public interface IPetSearchStrategy
    {
        List<Pet> Search(List<Pet> pets, string searchTerm);
    }
}