Project Name: DotNet-Angular Customer Portal

🧩 Introduction
DotNet-Angular Customer Portal is a full-stack web application built using ASP.NET Core (Web API) and Angular for managing customer data, purchase history, and testimonials. It demonstrates clean architecture principles and efficient client-server communication, ideal for enterprise-grade customer management systems.

🔍 Overview
This application follows a layered architecture to ensure clean separation of concerns:

Backend (ASP.NET Core):

Exposes RESTful APIs.

Handles customer data, testimonials, payment methods, and purchase history.

Uses Entity Framework Core for database access.

Frontend (Angular):

Consumes the APIs to display customer details and purchase records.

Supports routing (e.g., navigating to /details/:id) to show detailed views.

Includes reusable components for customer list, detail view, and purchase history.

Key Features:

Fetch and display customers with associated payment methods and testimonials.

View and refresh purchase history.

Navigate between components using Angular Router.

⚙️ Prerequisites
To run this project locally, make sure you have the following:

🖥️ Development Tools
Visual Studio 2022 (recommended: Professional or Enterprise edition)

Node.js (v18+): Download Node.js

Angular CLI: Install via npm install -g @angular/cli

SQL Server + SQL Server Management Studio (SSMS)

📦 Database Setup
Open SQL Server Management Studio.

Create a new database named CustomerPortalDb.

Set the connection string in appsettings.json.

🏁 Backend Setup
Open the solution in Visual Studio.

Run the following in Package Manager Console:

bash
Copy
Edit
Add-Migration Initial
Update-Database
Press F5 to run the API.

🌐 Frontend Setup
Open a terminal in the Angular client directory.

Run:

bash
Copy
Edit
npm install
ng serve
Navigate to http://localhost:4200/ in your browser.
