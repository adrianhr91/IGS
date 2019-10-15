# Solution Overview
The solution is using .NET Core 2.2 and ASP.NET Core to produce a RESTFul API.

# How to Run
## Using Visual Studio
1. Open `TheShop.sln` file in Visual Studio.
1. Start `TheShop.Api` project.
## Using Command Line
```
 cd TheShop.Api/
 dotnet run
```

# Details
## Structure
A "feature-oriented" folder structure has been used. In this case, there's only one feature called `Product`. All related classes are grouped under the same folder.

In order to keep the solution appropriately-simple, classes are designed to have as close to a single responsibility as possible, without over-complicating them.

The built-in DI setup is used to decouple classes from each other.

## Approach
The tests were used as a sort of system to integrate with. They can't be changed so it is the API that needs to be adjusted to handle things accordingly.

For example, the `Price` property in the `Product` class is kept as decimal as it is the best fit for storing monetary values. The tests expect the `Price` as a `string`. Therefor, a custom JSON Serializer has been added to handle this, without affecting the internal implentation of the `Product` class.

## Database
For the sake of simplicity, an in-memory database has been implemented. It is configured as a singleton so the same store is used throughout the lifetime of the application.

The implementation can be seen in the `Repository` class.


## Error Handling
Errors are handled by throwing an appropriate exception that then gets handled in an **Exception Filter**. This approach allows for a standardised, flexile & extendable way of dealing with errors and unexpected behaviour. The **Exception Filters** remove the need for duplicated code across multiple methods.

## Areas to Improve
- For a more complex, real-world solution, unit tests are essential for testing classes without having to run the entire API and mock many dependencies. The current solution is simple enough that the Postman tests provide sufficient coverage.
- Related to the previous point, abstraction can be introduced to make it easier to mock dependencies in tests or substitute them with other implementations as the solution grows.
- Docker can be used to containerise the API. Thus, providing an easy way of running & hosting it as it will be better encapsulated. Unfortunately, newest version of Docker for Windows doesn't run on Windows Home and I do not have access to another version of Windows. Older versions of Docker Toolbox can be used and this is something I have done in the past but is harder to install and more error prone.
- A good production ready solution requires a variety of improvements put in place - logging, authentication, etc.
- While .NET Core 3.0 recently went into a stable release, a lot of the surrounding libraries haven't. As this is still a transitional period, the lower version was chosen as surrounding libraries will be more relient. Migration to .NET Core 3.0 was attempted but became tricky due to requirements on using unstable versions of libraries.
