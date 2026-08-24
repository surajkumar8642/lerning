# StudyPlanner

A small .NET 8 console project for recording study sessions and calculating
total study time.

## What this project teaches

- classes and properties
- input validation and exceptions
- collections and LINQ
- separating application logic from the console UI
- unit testing with xUnit

## Project structure

```text
StudyPlanner/
|-- src/StudyPlanner/          Console application and business logic
|-- tests/StudyPlanner.Tests/  Automated tests
`-- StudyPlanner.sln           Solution file
```

## Run it

From the repository root:

```powershell
dotnet run --project projects/StudyPlanner/src/StudyPlanner
```

## Run the tests

```powershell
dotnet test projects/StudyPlanner/StudyPlanner.sln
```

## Practice exercises

1. Accept a topic and duration from the command line.
2. Add a completion date to each study session.
3. Show the topic with the most study time.
4. Save sessions to a JSON file and load them on startup.
5. Add tests for every new behavior before implementing it.
