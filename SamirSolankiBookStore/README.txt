Program name:- WEB452_SamirSolankiBookStore
Program purpose:- To review the components of an ASP.NET
Program author:- Samir Solanki
Date Created :- 2022-11-13 2318 [ISO date format]

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

0329 ===run this ====== add-migration AddDefaultIdentityMigration

0330  run command add-migration AddCategoryToDb and update-database

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

  Doing Changes in the file of iRepository

  0415 -Add a new class SP_Call.cs in the Repository Folder

  0416 Update the implementation of the ISP_Call interface 

  0418 As per the Documents Add the wrapper for Unit of Work in the SP_Call.cs  file 

  0418 Add a new interface (IUnitOfWork) in the IRepository folder and update the code

  0419 Add the code changes in Startup.cs File


  ============================= PART 2 2.3 Category CRUD ==========================

  0419 Build and Run the application 

  0420 Add the new MVC Controller empty insdide the Area/Admin 

  0420 Added the file as CategoryController.cs

  0421 Done Changes in IUnityOfWork from the .DataAccess in the IRepository

  0421 Added the new folder in the Area/View with the same name as the Controller

  0422 Add a new Index view to the folder

  0422 Save and Run the folder 

  0423 Change in the _Layout.cshtml  Move this Category link to the Content Management drop-down 

  0425 Update the code and puch the code to GitHub

  0426 Changes don ein the Index.cshtml and add the icons in the Category section 

  0428 Index.cshtml add the @section call to the category.js

  0435 Add the Edit and Delete buttons and Create New Category using the Upsert action.

  0436 Add the new file _CreateAndBackToListButton.cshtml and ass the asp action.

  0438 Done the changes in the code in the Upsert file

  0439 Add the asp-action to the Index.cshtml page 

  0440 Run the application and test it.....................

  0442 Create new Category and modify 

  0442 Changes done in the Upsert.cshtml File......

  0445 Add the Save Method in the IUnitOfWork interface and save method......

  0448 Remove the _db.SaveChanges methos in the CategoryRepository.cs and move the _unitOfWork.Save() 

  0449 Test the application and run the application.....

  0455 Add the API call for HTTPDelete in the CategoryController.cs

  0458 Add the delete functionality in category.js onclick.....

  0458 Add the Delete(url) function code

  ================= Completed the PART 2 2.3 Category CRUD ===================

  ================ Part 3 3.1 Cover Type CRUD=========

  0810  Done Changes in the Index.cshtml Change the Text "Cover Type List"

  0814 Change the text in Index.cshtml to "Create New Cover Type"

  ============================= Part 3 ================================

  0820 Added the File Product.cs in the SamirSolankiBooks.Models

  0821 Added the Code in Product.cs File 

  0825 Run the --- [add-migration addProductToDb] command in the "SamirSolankiBooks.DataAccess"
       for an 'addProductToDb' migration and
       update-database

  0835  20221124071403_addProductToDb.cs         ===== this is db timestamp added in my README File===

   --Ceate a new migration 

  ======  [add-migration addValidationToProduct] 

  and update-database

  == Added ICategoryRepository.cs in the Repository Folder

   Build and run the application 

     ============================= Part 3 ================================
                                   3.2 Product CRUD(2)
  
  === Added ProductController.cs inside Area>ADmin>Controllers Folder


  == Added ProductVM inside Models ViewModels Folder and done changes