
# Expense Tracker 📊
An enterprise application built with ASP.NET Core, demonstrating the Model-View-Controller architecture
=======



☁️ Hosted on Microsoft Azure - Default Domain : https://enterprise-expense-tracker.azurewebsites.net (My Azure student subscription ended today 🥲 (16/09/2024) Actively working on migration)



# The Enterprise Solution to Managing Finances 💰

## Project Description 🗺️

This project demonstrates the Model-View-Controller architecture through the use of C# and ASP.NET Core.
An intuitive way to track expenses and visualise trends in money management !

## Demo: (App can also be found at its publicly hosted Microsoft Azure Domain: https://enterprise-expense-tracker.azurewebsites.net)

https://github.com/user-attachments/assets/858f7bed-af6a-4e9a-9797-0ad7fa72e5d5

## Screenshots:

<div style="display: flex; justify-content: center; align-items: center;">
    <kbd>
        <img src="https://github.com/user-attachments/assets/9d3d33b4-4a48-4a8a-8e2f-405faff6b6c8" alt="ExpenseTrackerTransactions" width="500" height="250">
    </kbd>
    <kbd>
        <img src="https://github.com/user-attachments/assets/d6a19cd7-9f91-4802-9d88-c93a5ab675b0" alt="ExpenseTrackerCategories" width="500" height="250">
    </kbd>
</div>

<div style="display: flex; justify-content: center; align-items: center;">
    <kbd>
        <img src="https://github.com/user-attachments/assets/8b23e456-0834-43bb-9d39-7aa2b30f5099" alt="ExpenseTrackerDashboard" width="500" height="250">
    </kbd>
    <kbd>
        <img src="https://github.com/user-attachments/assets/07103ba5-e9b8-4805-ab24-80a4d1104af4" alt="ExpenseTrackerWidgets" width="500" height="250">
    </kbd>
</div>

### Prerequisites 📋

- Visual Studio 2022
- ASP.NET Core MVC Template (Installable using Visual Studio Installer)
- .NET 6.0 SDK
- Microsoft SQL Server
- SQL Server Management Studio (SSMS)

### Frameworks

- Microsoft.AspNetCore.App
- Microsoft.NETCore.App

### Packages

- Microsoft.EntityFrameworkCore (6.0.25)
- Microsoft.EntityFrameworkCore.SqlServer (6.0.25)
- Microsoft.EntityFrameworkCore.Tools (6.0.25)
- Syncfusion.EJ2.AASPNET.Core (20.1.0.58)

## Skills Demonstrated 🖌️

This project provides a thorough depiction of the combination of User Interface best practices and the .NET Framework to create enterprise software.
The Model-View-Controller (MVC) is an architectural design pattern that separates an application into three main logical components: Model, View, and Controller.
The main goal of this design pattern is to separate the presentation layer from the business logic, making the code less complex and easier to work with1. It was traditionally used for desktop graphical user interfaces (GUIs), but nowadays, MVC is one of the most frequently used industry-standard web development frameworks to create scalable and extensible projects1. It is also used for designing mobile apps.

- **Model**: This component corresponds to all the data-related logic that the user works with. It can represent either the data that is being transferred between the View and Controller components or any other business logic-related data. It can add or retrieve data from the database.

- **View**: The View component is used for all the UI logic of the application. It generates a user interface for the user. Views are created by the data which is collected by the model component but these data aren’t taken directly but through the controller.


- **Controller**: The controller is the component that enables the interconnection between the views and the model so it acts as an intermediary. The controller doesn’t have to worry about handling data logic, it just tells the model what to do. It processes all the business logic and incoming requests, manipulates data using the Model component, and interacts with the View to render the final output.

## Contributing ⚙️

We believe that great knowledge like that which you possess is meant to be shared, and we welcome contributions from fellow geniuses and developers alike. If you have a beneficial or creative code snippet to add or a design improvement to suggest, feel free to fork our repository, make your enhancements, and submit a pull request. Together, let's make the world even more advanced.

## License 🪪

This project is licensed under the [MIT License](LICENSE), which means you're free to modify, distribute, and use the code as you see fit. Just remember to attribute the original work to **Ariel Tyson's GitHub** and keep the aspiring developer spirit alive!

---
