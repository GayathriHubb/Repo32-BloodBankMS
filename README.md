📋 Project Overview
This is a C# Windows Forms Desktop Application designed to manage blood bank operations efficiently. The system handles donor information, blood stock management, and related transactions for blood banks.

Repository: GayathriHubb/Repo32-BloodBankMS |
Language: C# (.NET Framework) |
License: MIT License |
Created: January 14, 2026

🎯 Key Features
1. User Authentication
Login System (Form1.cs) - Secure user authentication
Sign Up (SignUp.cs) - New user registration
Forgot Password (ForgotPassword.cs) - Password recovery functionality
2. Donor Management
Add Donor (AddDonor.cs) - Register new blood donors
Edit Donors (EditDonors.cs) - Update donor information
Delete Donors (DeleteDonors.cs) - Remove donor records
View Donors Details (DonorsDetails.cs) - Display complete donor information
3. Blood Stock Management
Stock Increase (BloodStockIncrease.cs) - Add new blood units to inventory,
Stock Decrease (BloodStockDecrease.cs) - Remove blood units during transfusion/usage,
View Stock Details (StockDetails.cs) - Monitor blood inventory levels
4. Search & Filter Features
Search by Blood Group (SearchByBloodGroup.cs) - Find donors by blood type,
Search by Location (SearchByLocation.cs) - Find donors by geographic location
5. Main Dashboard
BloodBankMainForm.cs - Central hub for accessing all features,
Intuitive navigation menu for all operations

📁 Architecture
Technology Stack:
Framework: .NET Windows Forms,
Database: SQL Server (BloodBank.mdf database file included),
Language: C#,
Project File: BloodBankMS.csproj

Project Structure:
Program.cs - Application entry point,
App.config - Configuration settings,
Multiple .Designer.cs and .resx files for UI design (Designer pattern),
Database files: BloodBank.mdf and BloodBank_log.ldf

🚀 Getting Started
Prerequisites:
Visual Studio 2015 or higher,
.NET Framework 4.0+,
SQL Server (for database connectivity)

Steps to Run:
Clone the repository,
Open BloodBankMS.csproj in Visual Studio,
Build the project,
Run the application,
Log in or create a new account through the Sign Up form

💾 Database: 
The application uses SQL Server with a local database file

Database Name: BloodBank
Files: BloodBank.mdf (data file), BloodBank_log.ldf (log file)
📝 License
This project is licensed under the MIT License - see the LICENSE file for details.

🤝 Contributing:
This is a public repository. Users can fork and contribute improvements or enhancements.

This Blood Bank Management System provides a complete solution for blood bank staff to manage donors, track blood inventory, and process daily operations efficiently through a user-friendly Windows desktop interface.
