using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using PetAdoptionSystem.Models;

namespace PetAdoptionSystem.Strategies
{
    public class SearchBySpecies : IPetSearchStrategy
    {
        public List<Pet> Search(List<Pet> pets, string searchTerm)
        {
            return pets.Where(pet =>
                pet.Species.Equals(searchTerm,
                    StringComparison.OrdinalIgnoreCase)).ToList();
        }
    }
}