Inventory Management System
Overview
This Inventory Management System is developed using Windows Forms and utilizes an API to perform CRUD (Create, Read, Update, Delete) operations. 
The application enables users to manage inventory items efficiently by providing a user-friendly interface and robust backend functionality.
**Features**
•	Add, edit, and delete inventory items
•	Export inventory data to Excel
•	Logging of operations for audit and debugging
•	User-friendly interface with Windows Forms
**Technologies Used**
•	C#
•	.NET Framework
•	Windows Forms
•	Web API
•	Entity Framework
•	Excel Interop
**Setup Instructions**
**Prerequisites**
•	Visual Studio 2022
•	Windows Forms: net8.0-windows 
•	API: net8.0
•	SQL Server or any compatible database
**Installation**
1.	Clone the repository:
sh
git clone https://github.com/Anster96/InventoryShipmentManagementV2.git
cd InventoryShipmentManagementV2
2.	Open the Solution:
o	Open InventoryShipmentManagementV2.sln in Visual Studio.
3.	Configure the Database:
o	Update the connection string in appsettings.json to point to your database.
4.	Run Migrations:
o	Open the Package Manager Console in Visual Studio and run:
sh
Update-Database
5.	Build and Run the Application:
o	Build the solution and run the application from Visual Studio.
Usage
1.	Add Inventory Items:
o	Use the form to input details of new inventory items and add them to the database.
2.	Edit and Delete Items:
o	Select an item from the list and edit its details or delete it.
3.	Export to Excel:
o	Export the list of inventory items to an Excel file using the export feature.
Logging
•	All operations are logged to Logging/LogData.txt for audit and debugging purposes.

