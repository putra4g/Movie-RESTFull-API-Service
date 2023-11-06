# MOVIE_WEB_API
## Technologies
***
A list of technologies used within the project:
* .Net 7 
* Entity Framework
* Mysql DB

## Installation
***
A little intro about the installation. 

* git clone https://github.com/putra4g/Movie-RESTFull-API-Service.git
* open solution in visual studio (vs 2022)
* change mysql connectionstring into your mysql envy config on **Project API > appsettings.json**
```
"ConnectionStrings": {
  "DefaultConnection": "server=localhost;user=<change to your user/root>;database=Moviedb;password=<input password>;"
}
```
* open  (Tools > NuGet Package Manager > Package Manager Console). for creating object to database. type & run command : "**update-database**" 
* Set API Project as start up
* Running web API
* You can see the API documentation on Swagger, or direct execute also.
