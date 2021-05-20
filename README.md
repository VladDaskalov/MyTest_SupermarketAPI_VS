# MyTest SupermarketAPI (coded and tested with Visual Studio)

A test/training attempt to write a well structured RESTful API for an “almost” real world scenario, using the ASP.NET Core framework.

It shows how common frameworks and libraries, such as Entity Framework Core and AutoMapper, are integrated to deliver the necessary functionalities.
It also includes some good patterns for preparing a nicely structured API:
- Dependency Injection - that allows better structuring of the solution and also easy modifiction of the different elements, without the need to change many other related objects
- Repository pattern - classes that encapsulate all logic to handle data access in a clean manner
- Request-Response Pattern - design pattern encapsulates our request and response parameters into classes as a way to encapsulate information that our services will use to process some task and to return information to the class that is using the service.
- Unit of Work Pattern - allowing data access handling in transactions

I would like to express my sincere gratitude to Evandro Gomes (evgomes), who wrote this beautiful article with many usefull links and information and to FreeCodeCamp.org for distributing it:
https://www.freecodecamp.org/news/an-awesome-guide-on-how-to-build-restful-apis-with-asp-net-core-87b818123e28/
