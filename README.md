# Pet Adoption Management System 🐾

## Project Description
For my CSC360 final project, I am creating a Pet Adoption Management

## Current Features
- Basic Pet model containing an ID, name, species, age, and adoption status.
- PetService class for adding and viewing pets.
- Console application that displays pet information.
- MSTest project for unit testing.

## Planned Features
- Search for pets by name, species, or ID.
- Update existing pet information.
- Mark pets as adopted.
- Manage adoption applications.
- Create waiting lists for potential adopters.
- Implement data structures such as dictionaries, queues, and binary search trees.
- 
## First Design Pattern — Strategy
I chose strategy so the pet catalog can use different search algorithms through the same interface. `IPetSearchStrategy` defines the `Search` operation. `SearchByName` finds names containing the search text, and `SearchBySpecies` finds an exact species match. Both searches ignore letter case.

`PetService` is the context. It stores the current strategy, allows it to be changed through `SetSearchStrategy`, and delegates searches through `SearchPets`. This lets me add another search algorithm without changing how `PetService` runs a search.

The console demo searches for the species `Cat` and the name `Luna`. The Kata 02 `PetCatalogFacade` selects each strategy and calls `PetService` for the console.

## Future Plans
As the quarter progresses, I plan to expand the application by adding more features and implementing different data structures. I also plan to write additional unit tests to make sure everything works correctly.
