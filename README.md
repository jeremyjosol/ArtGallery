# Art Gallery

## Technologies Used
* _Github_
* _VSCode_
* _C#_
* _.NET_
* _CSHTML_
* _CSS_
* _JSON_
* _Figma_
* _Bootstrap_
* _Google Fonts API_
* _Material Symbols_
* _MySQL Workbench_
* _Swagger_
* _Postman_

## Prerequisites

* _MySQL_
* _MySQL Workbench_
* _Entity Framework Core_
* _Postman_

#### Install MySQL Workbench
 [MySQL Workbench](https://dev.mysql.com/downloads/workbench/).

#### Install Postman
(Optional) [Download and install Postman](https://www.postman.com/downloads/).

## Application Setup

1. Clone this repo.
2. Open the terminal and navigate to this project's production directory called "ArtGallery".
3. Within the production directory "ArtGallery", create two new files: `appsettings.json` and `appsettings.Development.json`.
4. Within `appsettings.json`, put in the following code. Make sure to replace the `uid` and `pwd` values in the MySQL database connection string with your own username and password for MySQL.

```json
{
  "Logging": {
    "LogLevel": {
      "Default": "Information",
      "Microsoft.AspNetCore": "Warning"
    }
  },
  "AllowedHosts": "*",
  "ConnectionStrings": {
    "DefaultConnection": "Server=localhost;Port=3306;database={YOUR_DATABASE};uid={USERNAME};pwd={PASSWORD};"
  }
}
```

5. Within `appsettings.Development.json`, add the following code:

```json
{
  "Logging": {
    "LogLevel": {
      "Default": "Information",
      "Microsoft": "Trace",
      "Microsoft.AspNetCore": "Information",
      "Microsoft.Hosting.Lifetime": "Information"
    }
  }
}
```

6. Open your shell (e.g., Terminal or GitBash) to the production directory "ArtGallery", and run `dotnet ef database update`.
    > To optionally create a migration, run the command `dotnet ef migrations add MigrationName` where `MigrationName` is your custom name for the migration in UpperCamelCase. 
7. Within the production directory "ArtGallery", run `dotnet watch run --launch-profile "ArtGallery-Production"` in the command line to start the project in production mode with a watcher. 
8. To optionally further build out this project in development mode, start the project with `dotnet watch run` in the production directory "ArtGallery".
9. Use your program of choice to make API calls. In your API calls, use the domain _http://localhost:5000_. Keep reading to learn about all of the available endpoints.

## 🛰️ API Documentation
Explore the API endpoints in Postman or a browser.

### Using Swagger Documentation 
To explore Art Gallery with NSwag, launch the project using `dotnet run` with the Terminal or Powershell, and input the following URL into your browser: `http://localhost:5000/swagger`

### Pagination
Art Gallery returns a default of 2 results per page at a time. To modify this, use the query parameters `page` and `pageSize` and replace `{customize}` with integer values where `pageSize` is the amount of objects to be viewed.

```
http://localhost:5000/api/artworks?page={customize}&pageSize={customize}
```

### Available Endpoints

`GET` http://localhost:5000/api/artworks/

`GET` http://localhost:5000/api/artworks/{id}

`POST`http://localhost:5000/api/artworks/

`PUT` http://localhost:5000/api/artworks/{id}

`DELETE` http://localhost:5000/api/artworks/{id}

**Note**: `{id}` is a variable and it should be replaced with the id number of the artwork you want to GET, PUT, or DELETE.

#### Optional Query String Parameters for GET Request

| Parameter   | Type        |  Required    | Description |
| ----------- | ----------- | -----------  | ----------- |
| title       | String      | not required | Returns artwork with a matching title value |
| description | String      | not required | Returns artwork with a matching description value |
| artist      | String      | not required | Returns artwork with a matching artist name |
| year        | Int         | not required | Returns artwork with a matching year |