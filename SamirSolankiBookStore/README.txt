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

 PM> Install-Package Microsoft.AspNetCore.Identity.EntityFrameworkCore -version 3.1.29 
 Install in NuGet package which is given incorrect in documents

 @model SamirSolankiBookStore.Models.ViewModels.ErrorViewModel;
Copy this line in Error.cshtml From View-Shared-Error.cshtml


Addthis line using SamirSolankiBookStore.DataAccess.Data; in startup.cs
