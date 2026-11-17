using PetAdoptionSystem.Models;
using PetAdoptionSystem.Strategies;

namespace PetAdoptionSystem.Services
{
    public class PetService
    {
        private readonly List<Pet> pets = new();
        private IPetSearchStrategy searchStrategy = new SearchByName();

        public void AddPet(Pet pet)
        {
            pets.Add(pet);
        }

        public List<Pet> GetAllPets()
        {
            return new List<Pet>(pets);
        }

        public void SetSearchStrategy(IPetSearchStrategy strategy)
        {
            searchStrategy = strategy;
        }

        public List<Pet> SearchPets(string searchTerm)
        {
            return searchStrategy.Search(GetAllPets(), searchTerm);
        }
    }
}