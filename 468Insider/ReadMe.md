# 468 Insider Backend
This DotNet 7 project allows all users to handle the locations

## Third party tools and libraries
 - [Mediatr](https://github.com/jbogard/MediatR) 
 - [AutoMapper](https://automapper.org/)

 ## Solution architecture
The solution is built using a clean architecture approach. Concerns are split across different projects. Folders are used to organize all files into a logical structure for easy reference and keeping it clean.
The project uses viewmodels and domain models to keep a clear separation of concerns. Although this may introduce a little duplication of code the benefits are worth it. In regards to validation it is recommended to validate both on the client side as well as the domain side. For client side validation validation attributes can be added onto the viewmodels. For domain side validation see the description of the 468Insider.Infrastructure project.

Below describes the usage of each of the projects per folder:
### Core folder
This folder contains the following projects:

 - 468Insider.Core
 - 468Insider.Domain

#### 468Insider.Core
This project contains the business rules including all interfaces used by the application.
[Mediatr](https://github.com/jbogard/MediatR) is used to decouple the logic asynchronously. The logic for this can be found in the "Features" folder. Each feature is in its own folder and contains "Commands" (crud actions for example) and "Queries" (actions that retrieve data). This allows for a clean separation and easy reference.
[AutoMapper](https://automapper.org/) is used to convert objects. For this the "Profiles" folder contains the mapping profiles it can use.
The "ApplicationServiceRegistration" class contains all the service registrations needed for the Core project. "AddApplicationServices" is called from the web project's "Program" as follows: 
`builder.Services.AddApplicationServices();`
#### 468Insider.Domain
This project contains all the domain related information like the entity models.

#### Infrasctructure folder
The NJSFDA_Electronic_Contracts.Infrastructure project contains all actual integration logic. Any code interacting with a database or IO should be in here. The repositories that are used in the Core project reside here. 
The base repository can be used for any entities that use this format but can be overridden as well. Each entity can optionally have logic in its specific implementation using its own repository.