# Dr. Sillystringz's Factory

#### Apply what was learned about MySQL, Databases, and using EntityFramework to construct a web app with an editable database. This version includes Many to Many relationships as well as EntityFrames migration for autocreating MySql tables.

#### By Juan Hasbun

## Technologies Used

   * HTML
   * Github/bash
   * Virtual Studio Code
   * CSS
   * Bootstrap
   * Javascript
   * Jquery
   * Markdown
   * Node.js
   * Web Pack
   * APIs
   * C#
   * MSTest
   * MySQl
   * MySQL Workbench
   * AspNetCore5.0
   * Entity Framework Core

## Description

For this program, the user will be prompted to navigate towards a page for engineers or a page for machines. Either page will display all currently saved data from an exported database. If there is no data at all, the page will display a message and inform the user they should add some.  Each page (engineer or machine) will also have links to allow the user to fill out a form to add either to the database.  A list of each is provided with links to view all the information for that specific machine or engineer.


## Setup/Installation Requirements

   * Clone from repository (use: `$git clone https:github.com/JuanHasbunZem/Factory.Solution`)
   * Once cloned on to your computer, access with GitBash / terminal
   * Before anything, you will need to build the database. To do so, you will need to run the following command: `dotnet ef database update`
  * Additionally, you will need to create an appsettings.json file and include the following within it:
  ```
  {
    "ConnectionStrings": 
    {
      "DefaultConnection": "Server=localhost;Port=3306;database=[firstname_lastname];uid=[user id];pwd=[password];"
    }
  }
```  
Note: `[firstname_lastname]`, `[user id]`, and `[password]` should be replaced with your own information.

   * On your terminal (while within the Pierre folder) run: `$ dotnet restore`
   * To compile the program, first on your terminal run: `$ dotnet build`
   * To execute the program, on your terminal type: `$ dotnet run`
  

## Database Schema
![FactoryDatabase](https://user-images.githubusercontent.com/76922718/120919090-a744be80-c66c-11eb-8343-0fdebf4f1868.png)

## Known Bugs

* Currently no known issues.

## License

Copyright 2021 Juan Hasbun

Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
Contact Information

Email at: [zemenareq@hotmail.com](zemenareq@hotmail.com) 
