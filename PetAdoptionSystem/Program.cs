using PetAdoptionSystem.Models;
using PetAdoptionSystem.Services;

PetService petService = new PetService();
PetCatalogFacade petCatalog = new PetCatalogFacade(petService);

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

Console.WriteLine("\nSearch results for cats:");

foreach (Pet pet in petCatalog.SearchBySpecies("Cat"))
{
    Console.WriteLine($"{pet.Name} - {pet.Species}");
}

Console.WriteLine("\nSearch results for Luna:");

foreach (Pet pet in petCatalog.SearchByName("Luna"))
{
    Console.WriteLine($"{pet.Name} - {pet.Species}");
}
