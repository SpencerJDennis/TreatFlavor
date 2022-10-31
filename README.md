# TreatFlavors

#### By Spencer Dennis

## Technologies Used

- C#
- .NET 5
- ASP.NET Core MVC
- Entity
- Identity
- MySQL
- Javascript
- HTML

## Description

This application is a flavor and treat tracker for Pierre's Bakery. Users may access the site to view a list of all the treats and flavors available, or they can register and log in to add treats and flavors to the list themselves.

Registered users can edit and delete treats and flavors, and delete links between treats and flavors. When a treat or flavor is deleted, its associated links are removed as well.

## Setup/Installation Requirements


- Create a file named `appsettings.json` in the project folder `/TreatFlavors/`
- Put the following code inside `appsettings.json`, making sure to set your uid and pwd:

```json
{
  "ConnectionStrings": {
    "DefaultConnection": "Server=localhost;Port=3306;database=treatflavors;uid=YOURUSERNAME;pwd=YOURPASSWORD;"
  }
}
```

### Requires

- [.NET 5](https://dotnet.microsoft.com/en-us/download/dotnet/5.0) - <https://dotnet.microsoft.com/en-us/download/dotnet/5.0>
- MySQL - Recommend [MySQL Workbench](https://dev.mysql.com/downloads/workbench/)

### Download/Run Instructions (git)

- clone: `$ git clone https://github.com/SpencerJDennis/TreatFlavor.git` or Code>Download ZIP
- navigate to project folder: `$ cd /TreatFlavors`
- restore: `$ dotnet restore`
- build: `$ dotnet build`
- Apply migrations: `$ dotnet ef database update`
- run: `$ dotnet run`
- Access the site by visiting http://localhost:5000

## Known Bugs

## License

Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:
The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.
THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE
 
Copyright (c) _10/31/2022_ _Spencer Dennis_