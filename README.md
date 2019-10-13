# Solution Overview
The solution is a using .NET Core 2.2 and ASP.NET Core to produce a RESTFul API.

# How to Run
1. Open `TheShop.sln` file in Visual Studio.
1. Start `TheShop.Api` project.

# Details
## Structure
A "feature-oriented" folder structure has been used. In this case, there's only one feature called `Product`. All related classes are grouped under the same folder.

In order to keep the solution appropriately-simple, classes are designed to have as close to a single responsibility as possible, without over-complicating them.

The in-built DI setup is used to decouple classes from each other.

## Approach
The tests were used as a sort of system to integrate with. They can't be changed so it is the API that needs to be adjusted to handle things accordingly.

For example, the `Price` property in the `Product` class is kept as decimal as it is the best fit for storing monetary values. The tests expect the `Price` as a `string`. Therefor, a custom JSON Serializer has been added to handle this, without affecting the internal implentation of the `Product` class.

## Database
For the sake of simplicity, an in-memory database has been implemented. It is configured as a singleton so the same store is used throughout the lifetime of the application.

##

The implementation can be seen in the `Repository` class.

## .NET Core Version
While .NET Core 3.0 recently went into a stable release, a lot of the surrounding libraries haven't. As this is still a transitional period, the lower version was chosen as surrounding libraries will be more relient. Migration to .NET Core 3.0 was attempted but became relied on using unstable versions of libraries.

