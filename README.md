# Dr. Sillystringz's Factory

### Epicodus Independent Code Review - Many-To-Many Relationships

### By Faisal Rana

## Technologies Used

* Git
* C#
* .NET 5.0
* ASP.NET Core
* Entity Framework Core
* Razor View Engine
* MVC
* RESTful Routing, CRUD & HTTP
* REPL
* MySQL & MySQL Workbench
* Bootstrap
* CSS
* Many-to-Many Relationships

## Description

This is a C# MVC web application that is built to manage Engineers and Machines in a factory.  The engineers and machines have a 'many-to-many' relationship because each engineer can be assigned to work on multiple machines, whilst each machine can be repaired by multiple engineers. 

This webpage must have the following additional functionality:
1.  Splash page where all engineers and machines are displayed
2.  Machine detail view must show associated engineers, while Engineer detail page must show associated machines. 
3. Add/Remove/Edit functionality will be needed so the manager can input/remote/edit data.


## Setup/Installation Requirements

* _Download Visual Studio Code Installation_
* _Open the terminal on your local machine_
* _Navigate to the project root directory_
* _Clone this project with the following command  `$ git clone <https://github.com/FaisalRana/SillyStringz.Solution.git>`_
* _Download and install .NET Core through this link if you don't already have it: https://dotnet.microsoft.com/download_
* _Open this project in Visual Studio Code with the command `$ code .`_
* _Navigate to the `Factory` directory and create an **appsettings.json** file and input the following script (**note the name of the database below needs to match the name of the database you created (e.g. faisal_rana)**)_
![Image of appsettings.json example](Factory/wwwroot/images/appsettings.json_test.png)

* _Retrieve and install packages listed in the .csproj files with the command `$ dotnet restore`_
* _Follow instructions below to install mySQL abd mySQL workbench below_
* _Create internal content for build with the command `$ dotnet build`_
* _Follow instructions for migrating database below_
* _Use command `$ dotnet run`_ to launch web application.

**MySQL and MySQL Workbench Setup Instructions**

* Download MySQL Workbench here: https://dev.mysql.com/downloads/file/?id=484391
* For Mac Users please [Click Here](https://dev.mysql.com/downloads/file/?id=484914) to download MySQL Installer
* For Windows Users please [Click Here](https://dev.mysql.com/downloads/file/?id=484919)
* Verify MySQL installation by opening the terminal and entering the command `mysql -uroot -p[THEPASSWORDYOUSELECTED]`

**Database Migration Instructions**
1. Navigate to Factory directory in terminal
2. Use the command `dotnet ef migrations iniital` and  `dotnet ef database update` to create database migration. 


## Diagram of the Many-To-Many relationship used in this project

![Image of SQL Designer](Factory/wwwroot/images/schema.png)


## User Stories 
 
- As the factory manager, Dr. SS needs to be able to see a list of all engineers, and they need to be able to see a list of all machines | 
- As the factory manager, Dr. SS needs to be able to select an engineer, see their details, and see a list of all machines that engineer is licensed to repair. They also need to be able to select a machine, see its details, and see a list of all engineers licensed to repair it | 
- As the factory manager, Dr. SS needs to add new engineers to our system when they are hired. They also need to add new machines to our system when they are installed | 
- As the factory manager, Dr. SS should be able to add new machines even if no engineers are employed. They should also be able to add new engineers even if no machines are installed | 
-  As the factory manager, Dr. SS needs to be able to add or remove machines that a specific engineer is licensed to repair. They also need to be able to modify this relationship from the other side, and add or remove engineers from a specific machine |
- Dr.SS should be able to navigate to a splash page that lists all engineers and machines. Users should be able to click on an individual engineer or machine to see all the engineers/machines that belong to it |

## Known Bugs

Currently engineers can have the same machine assinged to them more than once

## Link

This project is not hosted on GitHub Pages

## License

Copyright (c) 2021 Faisal Rana

This software is licensed under the MIT license

## Contact Information

cchap14@gmail.com
### _This project is not in a complete or portfolio ready state, and should not be considered representiational of professional work._

# Dr. Sillystringz's Factory

### Epicodus Independent Code Review - Many-To-Many Relationships

### By Faisal Rana

## Technologies Used

* Git
* C#
* .NET 5.0
* ASP.NET Core
* Entity Framework Core
* Razor View Engine
* MVC
* RESTful Routing, CRUD & HTTP
* REPL
* MySQL & MySQL Workbench
* Bootstrap
* CSS

## Description

This is a C# MVC web application built for the famous Dr. Sillystringz to keep track of the machine repairs for his factory. This application helps manages the engineers and the machines they are licensed to fix.


## Setup/Installation Requirements

* _Requires Visual Studio Code Installation_
* _Requires Terminal Installation_
* _Open the terminal on your local machine_
* _Navigate to the directory inside of which you wish to house this project_
* _Clone this project with the following command  `$ git clone <https://github.com/faisalrana/Sillystringz.Solution.git>`_
* _Next you will need to download and install .NET Core through this link if you don't already have it: https://dotnet.microsoft.com/download_
* _After downloading and installing .NET Core, return to your terminal and navigate to the root directory by entering `$ cd Sillystringz.Solution`_
* _Open this project in Visual Studio Code with the command `$ code .`_
* _Still in the terminal, navigate to the desired subdirectory of the repository with the command `$ cd Factory`_
* _Retrieve and install packages listed in the .csproj files with the command `$ dotnet restore`_
* _Create internal content for build with the command `$ dotnet build`_


**The following instructions are for the application setup and connection to SQL**

* If you do not have MySQL Workbench, it can be downloaded here: https://dev.mysql.com/downloads/file/?id=484391
* In MySQL Workbench, navigate to the _Administration_ window and click _Data Import/Restore_
* In the _Data Import_ screen, select _Import from Self-Contained File_, click the 3 dots on the right, and navigate to _Sillystrinz.Solution\faisal_rana.sql_
* Under _Default Scheme to be Import To_ select the _New_ button
  * Enter a name for your database (e.g. faisal_rana)
  * Click _Ok_
* Click _Start Import_
* In the _Navigator_ > _Schemas_ tab, right click and select _Refresh All_. The new database will appear.

* _In Visual Studio Code, navigate to the `Factory` directory and create an **appsettings.json** file and input the following script (**note the name of the database below needs to match the name of the database you created (e.g. faisal_rana)**)_

![Image of appsettings.json example](./Factory/wwwroot/img/appsettings.json_test.png)
* _Back in the terminal, navigate to `$ cd Factory` and run the application with the command `$ dotnet run`


## Diagram of the Many-To-Many relationship used in this project

![Image of SQL Designer](./Factory/wwwroot/img/sql_design.png)


## User Stories 

| Functionalities | 
|:---: |
| As the factory manager, Dr. SS needs to be able to see a list of all engineers, and they need to be able to see a list of all machines | 
| As the factory manager, Dr. SS needs to be able to select an engineer, see their details, and see a list of all machines that engineer is licensed to repair. They also need to be able to select a machine, see its details, and see a list of all engineers licensed to repair it | 
| As the factory manager, Dr. SS needs to add new engineers to our system when they are hired. They also need to add new machines to our system when they are installed | 
| As the factory manager, Dr. SS should be able to add new machines even if no engineers are employed. They should also be able to add new engineers even if no machines are installed | 
| As the factory manager, Dr. SS needs to be able to add or remove machines that a specific engineer is licensed to repair. They also need to be able to modify this relationship from the other side, and add or remove engineers from a specific machine |
| Dr.SS should be able to navigate to a splash page that lists all engineers and machines. Users should be able to click on an individual engineer or machine to see all the engineers/machines that belong to it |

## Known Bugs

Currently engineers can have the same machine assinged to them more than once

## Link

This project is not hosted on GitHub Pages

## License

Copyright (c) 2021 Faisal Rana

This software is licensed under the MIT license

## Contact Information

inquisitive@gmail.com
