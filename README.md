# School Management System

This project is a School Management System designed to manage administrators, students, teachers, subjects, and grades. It includes a React-based frontend and an ASP.NET Web API backend built with .NET 8, utilizing Entity Framework Core for database management.

## Features

- **Admin Panel**: Manage students, teachers, subjects, and grades.
- **Teacher Module**: View and manage students, subjects, and grades assigned to each teacher.
- **Student Module**: Access student details, subjects, and grades.
- **Subjects Management**: Add, update, and delete subjects in the system.
- **Grades Management**: Teachers can assign and manage student grades.

## Technologies Used

### Frontend
- `React`: JavaScript library for building user interfaces.
- `React Router`: Used for routing in the application.
- `Axios`: For making HTTP requests to the API.
- `Tailwind CSS` / `Bootstrap`: For responsive design and UI components (choose one).

### Backend
- `ASP.NET Web API (.NET 8)`: Handles business logic, API endpoints, and data processing.
- `Entity Framework Core`: For database management, migrations, and interacting with the SQL database.
- `SQL Server`: The database used for this project.

## Prerequisites

- `Node.js` and `npm` installed for the frontend.
- `.NET 8 SDK` installed for the backend.
- `SQL Server` or any preferred database configured.

## Getting Started

### Backend Setup

1. Clone the repository and navigate to the backend folder:
    ```bash
    git clone https://github.com/your-username/school-management-system.git
    cd school-management-system/backend
    ```

2. Install the required NuGet packages:
    ```bash
    dotnet restore
    ```

3. Configure the connection string in the `appsettings.json` file to match your SQL Server setup.

4. Run the Entity Framework migrations to set up the database:
    ```bash
    dotnet ef database update
    ```

5. Run the ASP.NET Web API project:
    ```bash
    dotnet run
    ```

### Frontend Setup

1. Navigate to the frontend folder:
    ```bash
    cd ../frontend
    ```

2. Install dependencies:
    ```bash
    npm install
    ```

3. Start the React application:
    ```bash
    npm start
    ```

The application should now be running at `http://localhost:3000` (React) and the API should be available at `http://localhost:5000` (ASP.NET Web API).

## API Documentation

### Endpoints

- `GET /api/students`: Retrieve a list of all students.
- `POST /api/students`: Add a new student.
- `PUT /api/students/{id}`: Update an existing student.
- `DELETE /api/students/{id}`: Delete a student.

Similar endpoints exist for teachers, subjects, and grades.

## Contribution

**Contributions to this project are not open.** This repository is for personal or academic use only.

## License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.
