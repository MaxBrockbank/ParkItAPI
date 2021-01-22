<h1 align="center">~Park It API~</h1>
<div align="center">
<img src="https://github.com/MaxBrockbank.png" width="200px" height="auto" >
</div>
<p align="center">Authored by Max Brockabnk</p>
<p align="center">Updated on Friday, January 15th, 2021</p>

## Description
<hr>
This API is used to track State and National Parks with a C# .NET Core API built with a MySQL database. A user can get all parks, query the api for a specific park, create, update, or delete new parks. The API utilizes versioning that way as the code is updated and features are added, those using the earlier versions aren't forced to shut down their site or application until they are ready to the newest version. Swagger docs are also available for easily readable documentation on each API endpoint and the ability to test those endpoints with a user friendly interface.

## Required Technologies
<hr>

* C# .NET Core Ver 2.2.0
* MySQL Ver 8.0.15 and MySQL Workbench
* Text editor
* Modern web browser 

## Set-up Instructions
<hr>

#### Cloning this repo
1. On GitHub, navigate to my ParkItAPI.Solution repo, then click on the green button on the right side of the screen that says 'Code'.
2. To clone the repo you'll want to click on the clipboard icon next to where you see a URL in a text input. This will copy the url for this repo to your clipboard.
3. Open your computer termianl and navigate to whichever directory you'd like this project to live in.
4. Then run the command `git clone (Paste URL here)`. Additionally if you'd like to give this project's root directory a specific name you can run `git clone (Paste URL here) (New directory name)`. (Do not include the parens in these commands)
5. Set up the `MySQL database` and `appsettings.json` file (see the following sets of instructions on how to do this).
6. Then navigate to the project directory `cd SweetNSavory`, then run the build command `dotnet build` and the run command `dotnet run` to start up the local server and view this project.
7. _SIDENOTE_: if you make adjustments to a controller file you will need to re-build with `dotnet build` and run again with `dotnet run` to see these changes take effect.

#### Generate MySQL Database Using Entity Framework Core
1. In your terminal navigate to the ParkItAPI.Solution/ParkIt directory. From the root directory of the project that will be  `cd ParkIt`.
2. Run the command `dotnet ef database update`. Entity Framework Core will then generate the database structure using the included migration files. 
3. __SIDENOTE__, should you need to make changes to the code that adjust the structure of the databse, you can apply those updates with the following two commands. 
* `dotnet ef mirgrations add (Migration name here)`
* `dotnet ef database update`
Although messing with the data-types in the models folder will require that you drop the database schema and re-build it with the 'dotnet ef database update` command.


### Setting up `appsettings.json`
1. Create a file called appsettings.json in the `ParkIt` directory with the following code:
```
{
  "Logging": {
    "LogLevel": {
      "Default": "Warning"
    }
  },
  "AllowedHosts": "*",
  {
  "ConnectionStrings":{
    "DefaultConnection": "Server=localhost;Port=PORT_NUMBER;database=park_it;uid=USER;pwd=PASSWORD"
  }
}
}
```
3. Replace `PORT_NUMBER`, `USER`, and `PASSWORD` with your machines configurations.


## API Documentation
<hr>

### Using Swagger Documentation

To utilize Swagger Documentation for the Park It API, get the api running with the `dotnet run` command and then in your web browser go the `http://localhost:5000/swagger`. Here you can see and test each of the endpoints of the API.


### Pagination



### Endpoints

Base URL: `http://localhost:5000`

#### HTTP Request Structure
<br>

#### API VERSION 1.0
```
GET - api/parks
POST - api/parks
PUT - api/parks{id}
DELETE - api/parks{id}
```
<br>

#### API VERSION 2.0
```
GET - api/{Version:apiVersion}/parks/{id}
RANDOM - api/{Version:apiVersion}/parks/random (GET request that is randomized)
```
<br>

#### Path Parameters
|Parameter|Type|Default|Required|Description|
|:--| :--| :--| :--| ---|
|name|string|none|false|Return matches by park name.
|state|string|none|false|Return matches by park state.
|parkType|string|none|false|Return matches by park what kind of park it is. (Ex. National Park vs State Park)
<br>
<br>
## Technologies Used
<hr>

* C# .NET Core 2.2.0
* ASP.NET Core 
* Entity Framework Core 2.2.0
* API verioning 4.1.0
* Swashbuckle Swagger Documentation 5.5.0
* MySQL

## Known Bugs
<hr>

* No currently known bugs, please contact me if any are found.


## Contact 
<hr>

* [maxbrockbank1999@gmail.com](mailto:maxbrockbank1999@gmail.com)


## Legal
<hr>

* Copyright © 2020 Max Brockbank
* This software is licensed under the MIT license