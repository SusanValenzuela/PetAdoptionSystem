using PetAdoptionSystem.Models;
using PetAdoptionSystem.Services;
using PetAdoptionSystem.Strategies;

PetService petService = new PetService();

petService.AddPet(new Pet
{
    Id = 1,
    Name = "Luna",
    Species = "Cat",
    Age = 2
});

Console.WriteLine("Pet Adoption Management System");
Console.WriteLine("------------------------------");

foreach (Pet pet in petService.GetAllPets())
{
    Console.WriteLine($"Name: {pet.Name}");
    Console.WriteLine($"Species: {pet.Species}");
    Console.WriteLine($"Age: {pet.Age}");
    Console.WriteLine($"Adopted: {pet.IsAdopted}");
}

petService.SetSearchStrategy(new SearchBySpecies());

Console.WriteLine("\nSearch results for cats:");

foreach (Pet pet in petService.SearchPets("Cat"))
{
    Console.WriteLine($"{pet.Name} - {pet.Species}");
}

petService.SetSearchStrategy(new SearchByName());

Console.WriteLine("\nSearch results for Luna:");

foreach (Pet pet in petService.SearchPets("Luna"))
{
    Console.WriteLine($"{pet.Name} - {pet.Species}");
}