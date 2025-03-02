📦 MyApp.Api (Main API project)
 ┣ 📂 Controllers
 ┣ 📂 Configurations
 ┃ ┣ 📜 DependencyInjection.cs (Service registration)
 ┃ ┣ 📜 AppSettings.json  
 ┣ 📂 Middlewares  
 ┣ 📂 Program.cs  
 ┣ 📂 appsettings.json  

📦 MyApp.Application (CQRS Logic)  
 ┣ 📂 Features
 ┃ ┣ 📂 Users
 ┃ ┃ ┣ 📂 Commands  
 ┃ ┃ ┣ 📂 Queries 
 ┃ ┃ ┣ 📂 Handlers  
 ┃ ┃ ┣ 📂 DTOs 
 ┣ 📂 Common
 ┣ 📂 Behaviors
 ┣ 📂 DependencyInjection.cs  

📦 MyApp.Domain (Entities & Interfaces)  
 ┣ 📂 Entities 
 ┣ 📂 Interfaces


📦 MyApp.Infrastructure (Data Layer)  
 ┣ 📂 Persistence
 ┃ ┣ 📜 ApplicationDbContext.cs    
 ┣ 📂 DependencyInjection.cs  
 ┣ 📂 Services  
  

📦 MyApp.Tests (Unit & Integration Tests)  
 ┣ 📂 Features
 ┃ ┣ 📂 Users
 ┃ ┃ ┣ 📂 Commands 
 ┃ ┃ ┣ 📂 Queries
  

![high-level-writes-side](https://github.com/user-attachments/assets/36e6aa84-b2dc-44e8-abd8-10d75f428bb6)
![add-ha-message-queue](https://github.com/user-attachments/assets/5a6ac39d-e37e-4d8b-8b0a-8cea4cd83638)
![mediator-cqrs-microservice](https://github.com/user-attachments/assets/682248f9-a336-4046-af89-3e0cb596bf44)
