# Pierre's Sweet and Savory Treats

#### Independent Code Review
#### Created 01.15.2021 | Last Updated 01.15.2021

#### **By Chelsea Becker**

## 📊Project Overview

### Description
An application to market Pierre's sweet and savory treats.

### Technologies Used

VS Code<br>
C# 7.3.0<br>
.NET Core 2.2.0<br>
ASP.NET Core MVC<br>
Entity Framework Core 2.2.6<br>
Identity<br>
Razor<br>
MySQL Workbench 8.0 for Windows

### Preview

[![Pierres-Preview.png](https://i.postimg.cc/NfhYPg4t/Pierres-Preview.png)](https://postimg.cc/rz9vD23Z)

### Specifications

<table>
<tr>
  <th>User Story #</th>
  <th>User Story</th>
  <th>Actualized</th>
</tr>
<tr>
  <td>1</td>
  <td>"As the user, I need to be able to log into my account, and only logged in users can create, update, and delete objects. All users should be able to have read functionality."</td>
  <td>True</td>
</tr>
<tr>
  <td>2</td>
  <td>"As the user, I need to see the relationships between all treats and flavors. A treat can have many flavors, and a flavor can belong to many treats."</td>
  <td>True</td>
</tr>
  <td>3</td>
  <td>"As the user, I need to see all treats and flavors on the splash page. I can then click on links to see additional details for each treat and flavor."</td>
  <td>True</td>
</tr>
</table>
<br>

### Known Bugs

No known bugs at this time.

## 🔌Setup/Installation Requirements

### **Code Editor**

To open the project on your local machine, you will need to download and install a code editor. The most popular choices are [Atom](https://atom.io/) and [Visual Studio Code](https://code.visualstudio.com/). Visual Studio Code is the code editor used to create this application.

### **Installing .NET Core Framework for Windows(10+) Users**

1. Download the 64-bit .NET Core SDK (Software Development Kit) by following this link: https://dotnet.microsoft.com/download/thank-you/dotnet-sdk-2.2.203-windows-x64-installer.<br>
1a. Follow prompts to begin your download. The download will be a .exe file. Click to install when it is finished downloading.
2. After clicking the downloaded .exe file, follow the prompts in the installer and use suggested default settings.
3. You can confirm a successful installation by opening a command line terminal and running the command `$ dotnet --version` , which should return a version number.


### **Installing .NET Core Framework for Mac Users**

1. Download the .NET Core SDK by following this link: https://dotnet.microsoft.com/download/thank-you/dotnet-sdk-2.2.106-macos-x64-installer.<br>
1a. Follow prompts to begin your download. The download will be a .pkg file. Click to install when it is finished downloading.
2. After clicking the downloaded .pkg file, follow the prompts in the installer and use suggested default settings.
3. You can confirm a successful installation by opening a command line terminal and running the command `$ dotnet --version` , which should return a version number.

### **Installing MySQL Workbench**

1. [Download and install](https://dev.mysql.com/downloads/workbench/) the version of MySQL Workbench suitable for your machine.

## 💻View Locally/Project Setup

### **Clone**
1. Follow above steps to install necessary software.
2. Open web browser and go to https://github.com/cschweig2/Pierre.Solution.
3. After clicking the green "code" button, you can copy the URL for the repository.
4. Open a terminal window, such as Command Prompt or Git Bash, and navigate to the folder you wish to keep this project in.<br>
  4a. Type in this command: `git clone` , followed by the URL you just copied. The full command should look like this: `git clone https://github.com/cschweig2/Pierre.Solution` .
5. View the code on your favorite text editor.

### **Download**
1. Click [here](https://github.com/cschweig2/Pierre.Solution) to view project repository.
2. Click "Clone or download" to find the "Download ZIP" option.
3. Click "Download ZIP" and extract files.
4. Open the project in a text editor by clicking on any file in the project folder.

### **Import Database in MySQL Workbench**
1. Open MySQL Workbench and enter your password to open a server.
2. From the top navigation bar, follow: `Server > Data Import`.
4. Select the option `Import from Self-Contained File`.
5. Click the `...` button to navigate to the project file folder `Pierre` and select `Pierre.sql`.
5. Set `Default Target Schema` or create new schema.
6. Select the schema objects you would like to import.
7. To finalize, click `Start Import`.

### **Import Database with Entity Framework Core/Command Line**
1. Navigate to the `Pierre` project folder and enter `dotnet ef database update` in the command line, which will create the database in MySQL Workbench using the migrations from the `Migrations` folder.

### **Import Database with SQL Schema**

Open MySQL Workbench and paste the following Schema Create Statement to replicate the database and its tables.

```
DROP TABLE IF EXISTS `__efmigrationshistory`;
CREATE TABLE `__efmigrationshistory` (
  `MigrationId` varchar(95) NOT NULL,
  `ProductVersion` varchar(32) NOT NULL,
  PRIMARY KEY (`MigrationId`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

DROP TABLE IF EXISTS `aspnetroleclaims`;
CREATE TABLE `aspnetroleclaims` (
  `Id` int NOT NULL AUTO_INCREMENT,
  `RoleId` varchar(255) NOT NULL,
  `ClaimType` longtext,
  `ClaimValue` longtext,
  PRIMARY KEY (`Id`),
  KEY `IX_AspNetRoleClaims_RoleId` (`RoleId`),
  CONSTRAINT `FK_AspNetRoleClaims_AspNetRoles_RoleId` FOREIGN KEY (`RoleId`) REFERENCES `aspnetroles` (`Id`) ON DELETE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

DROP TABLE IF EXISTS `aspnetroles`;
CREATE TABLE `aspnetroles` (
  `Id` varchar(255) NOT NULL,
  `Name` varchar(256) DEFAULT NULL,
  `NormalizedName` varchar(256) DEFAULT NULL,
  `ConcurrencyStamp` longtext,
  PRIMARY KEY (`Id`),
  UNIQUE KEY `RoleNameIndex` (`NormalizedName`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

DROP TABLE IF EXISTS `aspnetuserclaims`;
CREATE TABLE `aspnetuserclaims` (
  `Id` int NOT NULL AUTO_INCREMENT,
  `UserId` varchar(255) NOT NULL,
  `ClaimType` longtext,
  `ClaimValue` longtext,
  PRIMARY KEY (`Id`),
  KEY `IX_AspNetUserClaims_UserId` (`UserId`),
  CONSTRAINT `FK_AspNetUserClaims_AspNetUsers_UserId` FOREIGN KEY (`UserId`) REFERENCES `aspnetusers` (`Id`) ON DELETE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

DROP TABLE IF EXISTS `aspnetuserlogins`;
CREATE TABLE `aspnetuserlogins` (
  `LoginProvider` varchar(255) NOT NULL,
  `ProviderKey` varchar(255) NOT NULL,
  `ProviderDisplayName` longtext,
  `UserId` varchar(255) NOT NULL,
  PRIMARY KEY (`LoginProvider`,`ProviderKey`),
  KEY `IX_AspNetUserLogins_UserId` (`UserId`),
  CONSTRAINT `FK_AspNetUserLogins_AspNetUsers_UserId` FOREIGN KEY (`UserId`) REFERENCES `aspnetusers` (`Id`) ON DELETE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

DROP TABLE IF EXISTS `aspnetuserroles`;
CREATE TABLE `aspnetuserroles` (
  `UserId` varchar(255) NOT NULL,
  `RoleId` varchar(255) NOT NULL,
  PRIMARY KEY (`UserId`,`RoleId`),
  KEY `IX_AspNetUserRoles_RoleId` (`RoleId`),
  CONSTRAINT `FK_AspNetUserRoles_AspNetRoles_RoleId` FOREIGN KEY (`RoleId`) REFERENCES `aspnetroles` (`Id`) ON DELETE CASCADE,
  CONSTRAINT `FK_AspNetUserRoles_AspNetUsers_UserId` FOREIGN KEY (`UserId`) REFERENCES `aspnetusers` (`Id`) ON DELETE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

DROP TABLE IF EXISTS `aspnetusers`;
CREATE TABLE `aspnetusers` (
  `Id` varchar(255) NOT NULL,
  `UserName` varchar(256) DEFAULT NULL,
  `NormalizedUserName` varchar(256) DEFAULT NULL,
  `Email` varchar(256) DEFAULT NULL,
  `NormalizedEmail` varchar(256) DEFAULT NULL,
  `EmailConfirmed` bit(1) NOT NULL,
  `PasswordHash` longtext,
  `SecurityStamp` longtext,
  `ConcurrencyStamp` longtext,
  `PhoneNumber` longtext,
  `PhoneNumberConfirmed` bit(1) NOT NULL,
  `TwoFactorEnabled` bit(1) NOT NULL,
  `LockoutEnd` datetime(6) DEFAULT NULL,
  `LockoutEnabled` bit(1) NOT NULL,
  `AccessFailedCount` int NOT NULL,
  PRIMARY KEY (`Id`),
  UNIQUE KEY `UserNameIndex` (`NormalizedUserName`),
  KEY `EmailIndex` (`NormalizedEmail`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

DROP TABLE IF EXISTS `aspnetusertokens`;
CREATE TABLE `aspnetusertokens` (
  `UserId` varchar(255) NOT NULL,
  `LoginProvider` varchar(255) NOT NULL,
  `Name` varchar(255) NOT NULL,
  `Value` longtext,
  PRIMARY KEY (`UserId`,`LoginProvider`,`Name`),
  CONSTRAINT `FK_AspNetUserTokens_AspNetUsers_UserId` FOREIGN KEY (`UserId`) REFERENCES `aspnetusers` (`Id`) ON DELETE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

DROP TABLE IF EXISTS `flavors`;
CREATE TABLE `flavors` (
  `FlavorId` int NOT NULL AUTO_INCREMENT,
  `FlavorType` longtext,
  `UserId` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`FlavorId`),
  KEY `IX_Flavors_UserId` (`UserId`),
  CONSTRAINT `FK_Flavors_AspNetUsers_UserId` FOREIGN KEY (`UserId`) REFERENCES `aspnetusers` (`Id`) ON DELETE RESTRICT
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

DROP TABLE IF EXISTS `flavortreat`;
CREATE TABLE `flavortreat` (
  `FlavorTreatId` int NOT NULL AUTO_INCREMENT,
  `TreatId` int DEFAULT NULL,
  `FlavorId` int DEFAULT NULL,
  PRIMARY KEY (`FlavorTreatId`),
  KEY `IX_FlavorTreat_FlavorId` (`FlavorId`),
  KEY `IX_FlavorTreat_TreatId` (`TreatId`),
  CONSTRAINT `FK_FlavorTreat_Flavors_FlavorId` FOREIGN KEY (`FlavorId`) REFERENCES `flavors` (`FlavorId`) ON DELETE CASCADE,
  CONSTRAINT `FK_FlavorTreat_Treats_TreatId` FOREIGN KEY (`TreatId`) REFERENCES `treats` (`TreatId`) ON DELETE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

DROP TABLE IF EXISTS `treats`;
CREATE TABLE `treats` (
  `TreatId` int NOT NULL AUTO_INCREMENT,
  `TreatType` longtext,
  `UserId` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`TreatId`),
  KEY `IX_Treats_UserId` (`UserId`),
  CONSTRAINT `FK_Treats_AspNetUsers_UserId` FOREIGN KEY (`UserId`) REFERENCES `aspnetusers` (`Id`) ON DELETE RESTRICT
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
```

### **Final Steps**
1. Navigate to the `Pierre` and `Pierre.Tests` folders and enter `dotnet restore` in the command line to install packages.

2.After packages are installed in each of these folders, navigate to the `Pierre` project folder and enter `dotnet run`  in the command line to both run and build the program.

## 📧Support and contact details

If you run into any issues, you can contact the creator at chelraebecker@gmail.com, or make contributions to the code on GitHub via forking and creating a new branch.

## 📝Contributors

<table>
  <tr>
    <th>Author</th>
    <th>GitHub Profile</th>
    <th>Contact Email</th>
  </tr>
  <tr>
    <td>Chelsea Becker</td>
    <td>https://github.com/cschweig2</td>
    <td>chelraebecker@gmail.com</td>
  </tr>
</table>

## 🧐Legal

*This software is licensed under the MIT license.*

Copyright (c) 2020 **Chelsea Becker**
