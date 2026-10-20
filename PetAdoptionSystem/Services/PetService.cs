using PetAdoptionSystem.Models;

namespace PetAdoptionSystem.Services
{
    public class PetService
    {
        private readonly List<Pet> pets = new();

        public void AddPet(Pet pet)
        {
            pets.Add(pet);
        }

        public List<Pet> GetAllPets()
        {
            return new List<Pet>(pets);
        }
    }
}