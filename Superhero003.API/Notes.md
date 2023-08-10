The projects needs references to each other

We start with Repository Layer
- Now its time for github----
- Create Models
- Install Entity Framework
- 1) Install
- 2) Create DatabaseContext
- 3) Program.cs
- 4) appsettings.json (Connectionstrings)
- Test if we get a webpage
- Code your Classes (DTO)(Data Transfer Object)
- Migration
- 1) Remember to choose the right project
- Code GetAll() - check the first class
- HeroRepository class 
- 1) We make interface to the class, cause IOC container is dependent
-    on the Interface to be able to generate a DI.
-    If we have the Interface , we can make the instance of HeroRepository
- 2) We have to add DI to IOC

- Use the HeroRepository in COntroller method
- Implement CRUD