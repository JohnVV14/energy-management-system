# energy-management-system
Project Structure
The project is structured into several projects, each with a specific role:

EnergyManagementSystem.Models: This project contains the data models used in the application. These models represent the objects that we're working with in our system.

EnergyManagementSystem.DataAccess: This project is responsible for all data access operations. It contains the ApplicationDbContext class, which is used to interact with the database, and repository classes, which provide a way to query and save instances of our models.

Controllers: This directory contains the controller classes. Controllers handle incoming HTTP requests and send HTTP responses.

The EnergyManagementSystem.Services project is the main entry point of your application. It's responsible for setting up and starting the web server, configuring the application's services, and handling HTTP requests.

Here's a brief overview of the main files in the EnergyManagementSystem.Services project:

Program.cs: This file contains the Main method, which is the entry point for the application. It creates a host builder, builds the host, and runs it. The host builder is configured to use the Startup class.

Startup.cs: This file contains the Startup class, which is used to configure the application's services and the application's request processing pipeline. The ConfigureServices method is where you configure the application's services, such as the database context and repositories. The Configure method is where you define how the application responds to HTTP requests.

The EnergyManagementSystem.Services project references the EnergyManagementSystem.DataAccess and EnergyManagementSystem.Models projects, so it can use the database context, repositories, and models defined in those projects.

In a typical request, a controller in the EnergyManagementSystem.Services project would use a repository from the EnergyManagementSystem.DataAccess project to query or save data, and then return a response to the client. The data is represented as instances of the models defined in the EnergyManagementSystem.Models project.

And in the EnergyManagementSystem.Models project:

Component.cs: This is an abstract class that represents a component in our system.

TestableUnits: This directory contains "testable" versions of our abstract classes. These classes are used for testing.

In the EnergyManagementSystem.DataAccess project:

ApplicationDbContext.cs: This class is used to interact with the database. It derives from DbContext, which is a class provided by Entity Framework Core.

ComponentRepository.cs: This class provides methods for querying and saving instances of Component.

In the EnergyManagementSystem.Tests project:

ComponentRepositoryTest.cs: This file contains tests for the ComponentRepository class.


### Testing
In this project, we use xUnit for unit testing. Our tests are located in the EnergyManagementSystem.Tests project.

We have structured our tests to use the Arrange-Act-Assert (AAA) pattern. This means that each test is divided into three sections:

Arrange: Set up the test. This is where we create objects, set up mock data, and arrange everything that the test needs to run.

Act: Perform the action that we want to test. This is usually a single method call.

Assert: Check that the action produced the expected result.

We use the in-memory database feature of Entity Framework Core for testing data access code. This allows us to simulate a database in memory, which is faster and easier to set up and tear down than a real database.

Because some of our classes are abstract, we have created "testable" versions of these classes in the EnergyManagementSystem.Models.TestableUnits namespace. These testable classes are concrete subclasses of the abstract classes, which allows us to create instances of them for testing. For example, we have a TestableComponent class that we can use to test code that works with Component objects.

Run Dotnet test in the terminal to execute the tests