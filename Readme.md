<br>
<p align="center">
  <u><big> <b>AnimalShelterAPI</b> </big></u>
</p>
<p align="center">
    <!-- Project Avatar/Logo -->
    <br>
     <a href="https://github.com/dschaaf89">
        <img src="https://previews.123rf.com/images/macrovector/macrovector1903/macrovector190300553/124254345-animal-shelter-horizontal-illustration-with-pets-sitting-in-cages-and-volunteers-feeding-animals-fla.jpg">
    </a>
    </a>
    <p align="center">
      ___________________________
    </p>
    <!-- GitHub Link -->
    <p align="center">
        <a href="https://github.com/dschaaf89">
            <strong>Daniel Schaaf</strong>
        </a>
    </p>
    <!-- Project Shields -->
    <p align="center">
        <a href="https://github.com/dschaaf89/AnimalSheterApi/graphs/contributors">
            <img src="https://img.shields.io/github/contributors/dschaaf89/AnimalSheterApi.svg?style=plastic">
        </a>
        ¨
        <a href="https://github.com/AnimalSheterApi/stargazers">
            <img src="https://img.shields.io/github/stars/dschaaf89/AnimalSheterApi.svg?color=yellow&style=plastic">
        </a>
        ¨
        <a href="https://github.com/AnimalSheterApi/issues">
            <img src="https://img.shields.io/github/issues/dschaaf89/AnimalShelter?style=plastic">
        </a>
        ¨
        <a href="https://github.com/dschaaf89/AnimalSheterApi/blob/master/LICENSE.txt">
            <img src="https://img.shields.io/github/license/dschaaf89/AnimalSheterApi?color=orange&style=plastic">
        </a>
        ¨
        <a href="https://linkedin.com/in/danielschaaf">
            <img src="https://img.shields.io/badge/-LinkedIn-black.svg?style=plastic&logo=linkedin&colorB=2867B2">
        </a>
    </p>
</p>
<p align="center">
  <small>Initiated 10/30/2020.</small>
</p>
<p align="center">
    <a href="https://github.com/dschaaf89/AnimalShelterApi"><big>Project Docs</big></a> ·
    <a href="https://github.com/dschaaf89/AnimalShelterApi/issues"><big>Report Bug</big></a> ·
    <a href="https://github.com/dschaaf89/AnimalShelterApi/issues"><big>Request Feature</big></a>
</p>

------------------------------
### <u>Table of Contents</u>
* <a href="#🌐-about-the-project">About the Project</a>
    * <a href="#📖-description">Description</a>
    * <a href="#🦠-known-bugs">Known Bugs</a>
    * <a href="#🛠-built-with">Built With</a>
    <!-- * <a href="#🔍-preview">Preview</a> -->
* <a href="#🏁-getting-started">Getting Started</a>
    * <a href="#📋-prerequisites">Prerequisites</a>
    * <a href="#⚙️-setup-and-use">Setup and Use</a>
* <a href="#🛰️-api-documentation">API Documentation</a>
* <a href="#🤝-contributors">Auxiliary</a>
    * <a href="#🤝-contributors">Contributors</a>
    * <a href="#✉️-contact-and-support">Contact</a>
    * <a href="#⚖️-license">License</a>
    * <a href="#🌟-acknowledgements">Acknowledgements</a>
    
------------------------------
## 🌐 About the Project

### 📖 Description
This project was to build an Api for a Animal Shelter. it utilizes RESTful principles,enables Cors,and Has JWT Authentication protocols to make it so that only an Administrator can add,edit,delete entries. The basic user is able to use the basic functions of pulling the list of animals and searching utilizing animalType,age and sex as search parameters. they can also ask for a random animal to be pulled from the api. 

### 🦠 Known Bugs
There are no Known bugs with the system at this time. if you do find a bug please contact by submitting an issue ticket or emailing me at daniel.schaaf@outlook.com

### 🛠 Built With
* [Visual Studio Code](https://code.visualstudio.com/)
* [C#](https://docs.microsoft.com/en-us/dotnet/csharp/)
* [ASP.NET Core MVC](https://docs.microsoft.com/en-us/aspnet/core/mvc/overview?view=aspnetcore-3.1)
* [MySQL 8.0.20 ](https://dev.mysql.com/)
* [Entity Framework Core 2.2.6](https://docs.microsoft.com/en-us/ef/core/)
* [Swagger - NSwag 13.3.0](https://docs.microsoft.com/en-us/aspnet/core/tutorials/getting-started-with-nswag?view=aspnetcore-3.1&tabs=visual-studio)
* [Postman](postman.com)


## 🏁 Getting Started

### 📋 Prerequisites

#### Install .NET Core
* On macOS Mojave or later
  * [Click here](https://dotnet.microsoft.com/download/thank-you/dotnet-sdk-2.2.106-macos-x64-installer) to download the .NET Core SDK from Microsoft Corp for macOS.
* On Windows 10 x64 or later
  * [Click here](https://dotnet.microsoft.com/download/thank-you/dotnet-sdk-2.2.203-windows-x64-installer) to download the 64-bit .NET Core SDK from Microsoft Corp for Windows.

#### Install dotnet script
 Enter the command ``dotnet tool install -g dotnet-script`` in Terminal for macOS or PowerShell for Windows.

#### Install MySQL Workbench
 [Download and install the appropriate version of MySQL Workbench](https://dev.mysql.com/downloads/workbench/).

#### Install Postman
(Optional) [Download and install Postman](https://www.postman.com/downloads/).
#### Code Editor

  To view or edit the code, you will need an code editor or text editor. The popular open-source choices for an code editor are Atom and VisualStudio Code.

  1) Code Editor Download:
     * Option 1: [Atom](https://nodejs.org/en/)
     * Option 2: [VisualStudio Code](https://www.npmjs.com/)
  2) Click the download most applicable to your OS and system.
  3) Wait for download to complete, then install -- Windows will run the setup exe and macOS will drag and drop into applications.
  4) Optionally, create a [GitHub Account](https://github.com)

  #### Cloning

  1) Navigate to the [Travel Api Repository here](https://github.com/dschaaf89/AnimalShelterApi).
  2) Click 'Clone or download' to reveal the HTTPS url ending with .git and the 'Download ZIP' option.
  3) Open up your system Terminal or GitBash, navigate to your desktop with the command: `cd Desktop`, or whichever location suits you best.
  4) Clone the repository to your desktop: `$ git clone https://github.com/dschaaf89/AnimalShelterApi.git`
  5) Run the command `cd AnimalShelterApi.Solution` to enter into the project directory.
  6) View or Edit:
      * Code Editor - Run the command `atom .` or `code .` to open the project in Atom or VisualStudio Code respectively for review and editing.
      * Text Editor - Open by double clicking on any of the files to open in a text editor.
  #### AppSettings

  1) Create a new file in the AnimalShelterApi.Solution/AnimalShelterApi directory named `appsettings.json`
  2) Add in the following code snippet to the new appsettings.json file:
  
  ```
{
    "Logging": {
        "LogLevel": {
        "Default": "Warning"
        }
    },
    "AllowedHosts": "*",
    "ConnectionStrings": {
        "DefaultConnection": "Server=localhost;Port=3306;database=Animal_Shelter;uid=root;pwd=YourPassword;"
    }
}
  ```
  3) Change the server, port, and user id as necessary. You can name your database anything you want just make sure there is a underscore _ in it or no spaces in the name and replace 'YourPassword' with relevant MySQL password (set at installation of MySQL).

  #### Database