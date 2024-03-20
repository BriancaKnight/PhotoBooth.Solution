# Portland Photo Booth MVC

### A C# Photo Booth Finder Application.

#### By Brianca Knight

## Technologies Used

* C#
* .Net 6
* ASP.Net / MVC
* Entity Framework Core
* MySQL
* MySQL Workbench

## Description

This webpage client side MVC which works with a PhotoBoothApi. Users can have read functionality, however create, update, and delete functionality is currently restricted for users. 

## Setup/Installation Requirements

This project assumes you have MySQL and MySQL Workbench installed on your system. If you do not, follow along with the installation steps outlined in this lesson [LearnHowToProgram](https://full-time.learnhowtoprogram.com/c-and-net/getting-started-with-c/installing-and-configuring-mysql).

### Set Up

#### Client-Side Setup
* Clone this repo from `https://github.com/BriancaKnight/PhotoBooth.Solution`.

* In the production sub directory (named `PhotoBooth`) create a file named `appsettings.json` and add the following code to it:

 ```json
{
  "Logging": {
    "LogLevel": {
      "Default": "Information",
      "Microsoft.AspNetCore": "Warning"
    }
  },
  "AllowedHosts": "*"
}
   ```

* In the terminal run the commands `dotnet restore` to install dependencies. 

#### API Setup

* Navigate to `https://github.com/BriancaKnight/PhotoBoothApi.solution` and follow instructions in the README to set up and run the corresponding API. 

#### Finishing Set Up

* With the API built and running, open the client-side application with the command `dotnet watch run`. Both servers must be running for application to work. 

* Open the browser to https://localhost:7109 to use the application. 

## Known Bugs

* Authentication is currently disabled for the client-side server, application is unable to create, update, or delete photobooths. 

## License

[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](https://opensource.org/licenses/MIT)

Copyright (c) 2023 Brianca Knight