using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using PetAdoptionSystem.Models;

namespace PetAdoptionSystem.Strategies
{
    public class SearchByName : IPetSearchStrategy
    {
        public List<Pet> Search(List<Pet> pets, string searchTerm)
        {
            return pets.Where(pet =>
                pet.Name.Contains(searchTerm,
                    StringComparison.OrdinalIgnoreCase)).ToList();
        }
    }
}