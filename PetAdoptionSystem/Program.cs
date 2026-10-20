using PetAdoptionSystem.Models;
using PetAdoptionSystem.Services;

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