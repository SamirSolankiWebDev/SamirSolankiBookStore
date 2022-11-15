Program name:- WEB452_SamirSolankiBookStore
Program purpose:- To review the components of an ASP.NET
Program author:- Samir Solanki
Date Created :- 2022-13-11 2318 [ISO date format]

2318 -Today I created a new Application in ASP>NET MVC application w/ .NET core 3.1 framework
Authentication - Individual Account
HTTP? - Yes
Razor runtime... will this actually work  Let us test this application

2320 Let us execute the application
2330  I didnt worked because i did not commented the file From Property->launchSetting.josn
 //  "sslPort": 44307  This line of i commented so now it will run the application.

 2345 - Installed Bootstrap from Bootswatch.com
 2346 - I used Solar Bootstrap in my application
 2347 - Changed/Replace the file of bootstrap.css in Lib>bootstrap>dist>css

23-55  - Replace the existing site.css in the main folder

0105  - Changes the file from View>Shared >Layout.cshtml Changed the name of bootstrap.man.css to bootstrap.css

0107  Changed the nav classfrom navbar-light to navbar dark and bg-white to bg-primary

0115 Added _Layout.cshtml page the additional stylesheets and scripts from the CSS_JS.txt file given 

0125 Added the new project 
    1)SamirSolankiBooks.DataAccess
    2)SamirSolankiBooks.Models
    3)SamirSolankiBooks.Utility

0145 Copy the Data Folder and pasted to DataAccess Project and deleted the original folder

Installed Install-Package Microsoft.EntityFrameWorkCore.Relation in the application 

0155 Deleted the migration Folder

 PM> Install-Package Microsoft.AspNetCore.Identity.EntityFrameworkCore -version 3.1.29 
 Install in NuGet package which is given incorrect in documents

 THIS LINE OF CODE GIVE ME MANY ERROR AS I ONLY ADDED "Identity.EntityFrameworkCore"

 0200 Modify the namespace in the project

 0200 Deleted all the Class1.cs files from the application 

 0201 Moved the Models folder from main application to SamirSolanki.Models and deleted the original folder

 0215 Added the Project reference from .DataAccess and .Models

 0215 Rename the Models folder to ViewModels

 0216 Rename the file name of ErrorViewModels.cs namespace to .Models.ViewModels

 0230 In the Utility Class Created a new class SD.cs

 0239 Changed the routes in Startup.cs similar in the ScaffoldingReadMe.txt

 0245 I have Moved the HomeController.cs to the Ared > Customer > Controller folder and deleted the Data and Models 

 0245 Done changes in the HomeController.cs in the Customer Area
 Moved Views from HomeController

 0255 Copy the ViewImport and ViewStart to Customer Area

 0256  Changed the file ViewStart.cshtml 
 given new file path

 After Running the Application its alomest done

 0301 Added the Admin area in the area and 
 deleted the data and models folder

 - After this deleted the controller folder and again updated to github

 @model SamirSolankiBookStore.Models.ViewModels.ErrorViewModel;
Copy this line in Error.cshtml From View-Shared-Error.cshtml


Addthis line using SamirSolankiBookStore.DataAccess.Data; in startup.cs

================= This was end of Part 1 application ================

======================= PART 2 ===============

Changed the databse local address as per given 

0315 Created the migrations  and modify the database name and saved 

0330 Added the migration file :- 20221114222428_AddDefaultIdentityMigration.cs

0331 this is the migration file name which is been used in the application

0335 -Done the Migration and then Update the database now by 
 - update-database  
 this is the command used to update 

 After this Steps lets us check the database 
 Added the new table to Db - 
 Added the new Class name "Category.cs"

 - After this added the Migration 
  by using this line 
  add-migration AddCategoryToDB 
  - IMPORTANT Select only SamirSolankiBooks.DataAccess in the dropdown

  === Part two Repository
  Added the new Folder name "Repository" in DataAccess project 
  Added new folder iRepository inside this folder

  Doing Changes in the file 