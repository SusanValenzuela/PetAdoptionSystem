using PetAdoptionSystem.Models;
using PetAdoptionSystem.Strategies;

namespace PetAdoptionSystem.Services
{
    public class PetCatalogFacade
    {
        private readonly PetService petService;

        public PetCatalogFacade(PetService petService)
        {
            this.petService = petService;
        }

        public List<Pet> SearchByName(string name)
        {
            petService.SetSearchStrategy(new SearchByName());
            return petService.SearchPets(name);
        }

        public List<Pet> SearchBySpecies(string species)
        {
            petService.SetSearchStrategy(new SearchBySpecies());
            return petService.SearchPets(species);
        }
    }
}
