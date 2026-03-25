# Unit Testing Study Materials

Last updated: March 23, 2026

Purpose:

- learn unit testing step by step
- understand tools and patterns
- use GitHub code references for study

## What to Learn First

Study in this order:

1. what unit testing is
2. test structure
3. assertions
4. mocking
5. dependency injection
6. test doubles
7. coverage
8. integration vs unit tests
9. test containers and database testing
10. CI test automation

## Core Concepts

### What is a unit test

A unit test checks one small part of code in isolation.

Examples:

- one method
- one service
- one validation rule
- one calculation function

### Good unit test qualities

- small
- fast
- isolated
- repeatable
- easy to read

### Common test pattern

- Arrange
- Act
- Assert

## Recommended Topics

### 1. Assertions

Learn:

- equality
- null checks
- true/false checks
- exception testing
- collection checks

### 2. Mocking

Learn:

- when to mock
- when not to mock
- mocking repositories
- mocking services
- mocking HTTP calls

### 3. Testable code

Learn:

- dependency injection
- interfaces
- separation of concerns
- pure functions vs side effects

### 4. Test organization

Learn:

- test naming
- one behavior per test
- folder structure
- shared setup

### 5. Advanced topics

Learn:

- parameterized tests
- fixture setup
- integration tests
- database testing
- testcontainers
- CI pipelines for tests

## GitHub Code Links by Ecosystem

## .NET

### xUnit

- xUnit repo: https://github.com/xunit/xunit
- xUnit samples search: https://github.com/search?q=xunit+sample+language%3AC%23&type=repositories

### NUnit

- NUnit repo: https://github.com/nunit/nunit
- NUnit docs repo: https://github.com/nunit/docs

### MSTest

- MSTest repo: https://github.com/microsoft/testfx

### ASP.NET Core testing samples

- ASP.NET Core docs samples: https://github.com/dotnet/AspNetCore.Docs.Samples
- Search: https://github.com/search?q=asp.net+core+unit+test+sample+language%3AC%23&type=repositories

### Moq

- Moq repo: https://github.com/devlooped/moq

### NSubstitute

- NSubstitute repo: https://github.com/nsubstitute/NSubstitute

### FluentAssertions

- FluentAssertions repo: https://github.com/fluentassertions/fluentassertions

### Testcontainers for .NET

- Testcontainers .NET repo: https://github.com/testcontainers/testcontainers-dotnet

## JavaScript / TypeScript

### Jest

- Jest repo: https://github.com/jestjs/jest

### Vitest

- Vitest repo: https://github.com/vitest-dev/vitest

### Testing Library

- Testing Library org: https://github.com/testing-library

## Python

### pytest

- pytest repo: https://github.com/pytest-dev/pytest

### unittest examples

- Python examples search: https://github.com/search?q=python+unittest+sample&type=repositories

## Java

### JUnit 5

- JUnit 5 repo: https://github.com/junit-team/junit5

### Mockito

- Mockito repo: https://github.com/mockito/mockito

## API and Integration Testing

### Postman examples

- Postman examples search: https://github.com/search?q=postman+api+test+sample&type=repositories

### Playwright

- Playwright repo: https://github.com/microsoft/playwright

## Suggested .NET Learning Path

If your main stack is .NET, follow this:

1. xUnit
2. FluentAssertions
3. Moq
4. ASP.NET Core test samples
5. integration testing with WebApplicationFactory
6. Testcontainers for database-backed tests

## Study Questions

Use these while reading sample code:

- what exactly is being tested
- what dependency is mocked
- what dependency is real
- is this unit test or integration test
- is the test name clear
- is the assertion meaningful
- what business behavior is protected

## Simple Practice Plan

### Week 1

- learn xUnit basics
- write tests for utility methods
- practice Arrange Act Assert

### Week 2

- learn Moq or NSubstitute
- test service classes with dependencies

### Week 3

- test controllers or API handlers
- add integration tests

### Week 4

- add tests to CI
- study coverage and flaky tests

## Best Search Terms

Use these on GitHub:

- `xunit asp.net core sample`
- `moq service unit test c#`
- `webapplicationfactory integration test sample`
- `testcontainers dotnet sample`
- `jest service unit test sample`
- `pytest mocking sample`

## Final Advice

Do not only read testing theory.

Do this:

1. open one GitHub sample
2. run one test mentally
3. understand why it exists
4. write the same style in your own code
