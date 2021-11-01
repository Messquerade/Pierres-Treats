# Pierre's Sweet and Savory Treats

### _By Anna Clarke_

Pierre's shop of delicious treats of many flavors!

## Technologies Used

* C#
* .NET v5.0
* ASP.NET Core MVC
* HTML 
* Bootstrap
* MySQL
* CSS
* MySQL Workbench
* Razor
* Entity FrameworkCore
* .NET Core CLI

## Description

This web application allows any user to view treats and flavors currently available at Pierre's Sweet and Savory Treats. Only users who have registered and are logged in can create, edit, and delete treats or flavors.

### Technology Requirements

* [.NET 5](https://dotnet.microsoft.com/download/dotnet/5.0)
* A text editor like [VS Code](https://code.visualstudio.com/)

## Setup/Installation Requirements

* Clone this repository to your desktop
* Open in text editor
* Create appsettings.json in PierresShop.Solution/PierresShop/ directory
* Copy this code into appsettings.json, replacing YOUR_PASSWORD with your MySQL password:
```
{
  "ConnectionStrings": {
      "DefaultConnection": "Server=localhost;Port=3306;database=pierres_shop;uid=root;pwd=YOUR_PASSWORD;"
  }
}
```
* In terminal, navigate into PierresShop.Solution/PierresShop/ and enter this command, to install necessary packages  

        $ dotnet restore
* enter this command to build the program

       $ dotnet build
* enter this command to build your database

        $ dotnet ef database update
* enter this command to view this application in your browser 

        $ dotnet run
* follow instructions on the website to register as a new user and login

  

## Known Bugs

* _NA_

## License

_[MIT](https://opensource.org/licenses/MIT)_  

Copyright (c) 2021 Anna Clarke

## Contact Information

Anna Clarke: <anclarkie@gmail.com>