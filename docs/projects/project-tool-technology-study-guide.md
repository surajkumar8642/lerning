# Project, Tool, and Technology Study Guide

Last updated: March 25, 2026

Purpose:

- prepare for interview questions like:
  - where did you use this technology
  - why did you use it
  - what problem did it solve
  - why not another technology
- connect your resume with realistic industry project usage
- give you a deep study file for learning, revision, and video practice

Primary source:

- `docs/interview/Resume.txt`

Secondary source:

- resume-based industry expansion
- realistic project interpretation from your stack and experience

Important note:

- this file follows your resume
- where your resume is short, this file expands the situation into a realistic industry-style explanation
- direct resume items are marked as `Source: Resume`
- expanded practical explanations are marked as `Source: Resume + industry expansion`

How to study this file:

1. read one project section
2. read the related technology section
3. answer aloud:
   - what is it
   - where used
   - why used
   - what impact it created
4. record a 2 to 5 minute explanation

Core interview rule:

- do not answer with only tool names
- always connect tool to project, problem, role, and reason

Basic answer formula:

1. I used `technology`
2. in `project`
3. for `problem`
4. because `reason`
5. and it helped with `impact`

Example:

- I used SQL Server in a hospital management system because the project had highly relational and transactional data such as patient records, billing, and structured workflows. It helped us keep data consistency and support reporting.

## 1. Resume Project Map

Main projects from your resume:

1. Hospital Management System
2. PMS Windows Application
3. E-Commerce Order Management Web Application
4. Sales Analytics Dashboard
5. Internal Admin Panel

Main technologies from your resume:

- .NET 8
- ASP.NET Core
- C#
- Web API
- MVC
- Blazor
- React.js
- Azure
- AWS
- Microservices
- Clean Architecture
- DDD
- CQRS
- SQL Server
- EF Core
- Dapper
- PostgreSQL
- MongoDB
- Docker
- Kubernetes
- Azure DevOps
- Jenkins
- OAuth2
- JWT
- Azure AD
- Redis
- RabbitMQ
- Azure Service Bus
- Azure OpenAI

Why this guide expands beyond short resume bullets:

- interviewers ask technology by technology
- they expect project-based answers
- they want to know where and why you used the tool
- they want industry reasoning, not only definitions

## 2. Project 1 - Hospital Management System

Project type:

- enterprise healthcare platform

Likely users:

- doctors
- nurses
- front desk staff
- billing team
- hospital admin
- patients for some workflows

Likely modules:

- patient registration
- appointment scheduling
- billing
- patient records
- lab integration
- insurance coordination
- notifications
- reporting

Your role:

- Solution Architect and Lead Developer

Main technical responsibilities:

- service design
- API design
- security
- integration handling
- SQL optimization
- frontend-backend alignment
- CI/CD and deployment planning

Why this project is interview-friendly:

- it lets you explain microservices
- it lets you explain APIs
- it lets you explain security
- it lets you explain SQL performance
- it lets you explain cloud deployment

Practical architecture thinking:

- different hospital workflows justify modular separation
- transactional data justifies SQL
- integrations justify API-first design
- user roles justify secure auth design
- performance optimization matters because staff workflows are time-sensitive

Example interview answer:

- One major project I worked on was a US-based Hospital Management System. It handled patient records, appointments, billing, and third-party integrations like labs and insurance services. My role was on backend architecture and API development. We used .NET Core microservices because the business modules were large and had separate responsibilities. We used SQL Server for relational and transactional data, React for the frontend, JWT for secure API authentication, and Azure DevOps for deployment automation.

Source:

- Resume
- Resume + industry expansion

## 3. Project 2 - PMS Windows Application

Project type:

- desktop accounting and GST software

Main users:

- accountants
- finance operators
- business owners

Main modules:

- billing
- ledgers
- GST and tax calculations
- reporting
- invoicing
- inventory control

Your role:

- Core Module Developer

What kind of technical work belongs here:

- business-rule validation
- calculation logic
- report queries
- transactional correctness
- data entry and form flows

Why this project is useful in interviews:

- strong business logic story
- strong SQL story
- strong correctness story
- strong finance workflow story

Example interview answer:

- I worked on a Windows-based PMS application focused on accounting and GST workflows. My main work was on core modules such as billing, ledgers, tax calculations, invoicing, and reports. In this kind of project, correctness, validation, and reliable SQL handling are more important than distributed architecture.

Source:

- Resume
- Resume + industry expansion

## 4. Project 3 - E-Commerce Order Management Web Application

Project type:

- order and inventory platform

Main users:

- retailers
- distributors
- operations staff
- admins

Main modules:

- products
- customers
- orders
- inventory
- tracking
- permissions

Your role:

- API Developer and Integrations Lead

Main technology use:

- ASP.NET MVC or web application style
- REST APIs
- SQL Server
- role-based access
- order tracking

Why this project is useful:

- explains API design
- explains security
- explains integrations
- explains order lifecycle workflows

Example interview answer:

- I worked on an e-commerce order management application used by retailers and distributors. My main role was API development and integrations. We used secure REST APIs for product, order, and inventory workflows, and role-based access control to keep permissions separate for different users.

Source:

- Resume
- Resume + industry expansion

## 5. Project 4 - Sales Analytics Dashboard

Project type:

- read-heavy dashboard system

Main users:

- management
- executives
- analysts

Main functions:

- KPI view
- trend analysis
- filtering
- dashboard summaries

Your role:

- API and dashboard support

Technology fit:

- React.js
- backend APIs
- read optimization
- chart-ready data shaping

Why this project matters:

- helps explain React
- helps explain reporting APIs
- helps explain performance and caching

Example interview answer:

- I worked on a Sales Analytics Dashboard where the main goal was to provide business KPI visibility and filtered summaries. The backend focus in that type of system is usually read performance and data shaping, while the frontend focus is interactive visualization and reusable UI components.

Source:

- Resume
- Resume + industry expansion

## 6. Project 5 - Internal Admin Panel

Project type:

- internal business support application

Main users:

- HR
- admins
- managers
- internal staff

Main functions:

- employee profile management
- attendance
- workflow support
- CRUD operations
- analytics support

Your role:

- Full Stack Developer

Main technology use:

- Blazor
- .NET Core APIs
- internal authentication
- business forms and data operations

Why this project helps:

- explains Blazor
- explains internal tool design
- explains CRUD architecture

Example interview answer:

- I worked on an Internal Admin Panel built with Blazor and .NET Core. It handled employee profiles, attendance, and internal workflow operations. We used Blazor because it fit well for internal business tooling and aligned well with the .NET backend stack.

Source:

- Resume
- Resume + industry expansion

## 7. Project-First Interview Strategy

When interviewer asks:

- where did you use DI
- where did you use Azure Functions
- where did you use EF Core
- where did you use SQL or NoSQL

Answer this way:

1. mention project
2. mention module
3. mention problem
4. mention reason
5. mention impact

Bad answer:

- I know DI, microservices, Azure, Docker, Redis, and CQRS.

Better answer:

- In the hospital platform, we used dependency injection across service and repository layers because it improved testability and kept business logic loosely coupled.

## 8. Technology 1 - .NET 8 / .NET Core

What it is:

- modern application platform for backend and enterprise development

Where used:

- Hospital Management System
- Internal Admin Panel backend
- migrated legacy applications
- enterprise APIs

Why used:

- modern framework
- performance
- cloud compatibility
- DI support
- API support

What problem it solved:

- older framework limitations
- need for scalable backend services
- need for maintainable modern codebase

What kind of modules fit:

- APIs
- services
- business logic
- background workers

Interview answer:

- I used .NET Core and .NET 8 mainly for enterprise backend services, APIs, and modernization work. It was a good fit because it supports scalable API development, dependency injection, cloud deployment, and clean architecture style implementations.

Source:

- Resume

## 9. Technology 2 - C#

What it is:

- primary language used in your backend stack

Where used:

- all .NET projects
- services
- APIs
- business rules
- data access layers

Why used:

- strong typing
- enterprise ecosystem
- tooling maturity
- maintainability

What problem it solved:

- clean enterprise development
- stable backend implementation

Interview answer:

- C# is my main backend language across enterprise projects. I use it for APIs, service layers, business rules, and cloud-integrated backend systems because it provides a strong enterprise development experience with good tooling and maintainability.

Source:

- Resume

## 10. Technology 3 - ASP.NET Core Web API

What it is:

- framework for HTTP APIs

Where used:

- Hospital Management System
- E-Commerce APIs
- Internal Admin Panel backend

Why used:

- frontend-backend separation
- integration support
- standard API contracts
- secure endpoint design

What problem it solved:

- communication between frontend and backend
- service integration
- external system integration

Interview answer:

- I used ASP.NET Core Web API in projects where secure, structured communication was needed between frontend clients, internal services, and external integrations. It was especially useful in healthcare and order management systems.

Source:

- Resume

## 11. Technology 4 - ASP.NET MVC

What it is:

- model-view-controller web application structure

Where used:

- E-Commerce Order Management Web Application
- server-rendered business workflows

Why used:

- standard business forms
- request-response applications
- simpler server-rendered pages

What problem it solved:

- clear separation between controller logic, views, and models

Interview answer:

- I used MVC where the application was a traditional enterprise web system with standard business pages and forms. It provided a clean structure for server-rendered workflows and was a practical fit for that type of application.

Source:

- Resume + industry expansion

## 12. Technology 5 - Blazor

What it is:

- .NET-based UI framework

Where used:

- Internal Admin Panel

Why used:

- internal business tooling
- .NET stack alignment
- productivity for .NET team

What problem it solved:

- need for internal UI without fully separate frontend stack

Interview answer:

- I used Blazor in the Internal Admin Panel because it matched the .NET ecosystem and was a practical choice for internal business tooling, CRUD workflows, and admin-facing functionality.

Source:

- Resume

## 13. Technology 6 - React.js

What it is:

- component-based frontend library

Where used:

- Hospital Management System frontend
- Sales Analytics Dashboard

Why used:

- dynamic UI
- reusable components
- richer dashboard interactions
- API-driven architecture

What problem it solved:

- need for interactive and modular frontend

Interview answer:

- I used React.js in projects that needed a dynamic and reusable frontend, especially dashboards and API-driven interfaces. It was useful where richer interactivity and component-level reuse mattered.

Source:

- Resume

## 14. Technology 7 - Microservices

What it is:

- splitting a large system into smaller services by business responsibility

Where used:

- Hospital Management System

Why used:

- domain separation
- maintainability
- clearer service ownership
- better scaling options for specific modules

What problem it solved:

- growing business complexity
- large backend responsibilities

What tradeoff it introduced:

- deployment complexity
- service communication overhead
- distributed debugging

Interview answer:

- We used microservices in the hospital system because different business areas such as records, billing, and integrations had enough complexity to justify separation. The choice was made for maintainability and service clarity, not just because microservices are popular.

Source:

- Resume

## 15. Technology 8 - Clean Architecture

What it is:

- organizing code so business logic stays separate from infrastructure concerns

Where used:

- enterprise .NET applications
- migration work
- maintainable backend services

Why used:

- better separation of concerns
- better testability
- easier long-term maintenance

What problem it solved:

- framework-heavy business logic
- tightly coupled application layers

Interview answer:

- I used clean architecture principles to keep business rules independent from framework and infrastructure details. That made applications easier to test, evolve, and maintain over time.

Source:

- Resume

## 16. Technology 9 - DDD

What it is:

- domain-driven design

Where used:

- domain boundary thinking in larger business systems
- hospital workflows

Why used:

- aligns software model with business language
- improves service boundaries
- reduces domain confusion

What problem it solved:

- unclear ownership of business logic
- poor domain naming and boundaries

Interview answer:

- I use DDD ideas in larger business systems where domain boundaries matter. It helps define cleaner business modules and keeps the software model closer to the actual business processes.

Source:

- Resume

## 17. Technology 10 - CQRS

What it is:

- separating write operations from read operations

Where used realistically:

- analytics modules
- reporting-heavy modules
- complex business write/read flows

Why used:

- read optimization
- cleaner write-side logic
- better control of read and write models

When not used:

- simple CRUD systems

Interview answer:

- I see CQRS as useful in modules where read and write concerns are significantly different, especially in reporting-heavy or complex business domains. I would not use it in a simple CRUD application without a clear reason.

Source:

- Resume + industry expansion

## 18. Technology 11 - Dependency Injection

What it is:

- giving dependencies to a class from outside instead of creating them inside

Where used:

- all .NET Core APIs
- service layer
- repository layer
- integration clients

Why used:

- loose coupling
- easier testing
- cleaner architecture

What problem it solved:

- hardcoded dependencies
- difficult mocking
- tightly coupled classes

Interview answer:

- I used dependency injection across all modern .NET Core projects because it improves testability, keeps components loosely coupled, and fits naturally with clean architecture and service-based application design.

Source:

- Resume + industry standard expansion

## 19. Technology 12 - Repository Pattern

What it is:

- abstraction around data access

Where used:

- CRUD-heavy modules
- enterprise service layers
- EF Core-backed modules

Why used:

- separates data access from business logic
- improves maintainability
- improves testability

What problem it solved:

- scattered SQL and data access logic inside business services

Interview answer:

- I use repository pattern when I want to keep business logic independent from direct database operations. It is useful in layered or clean architecture applications, especially in standard CRUD and business data modules.

Source:

- Resume + industry expansion

## 20. Technology 13 - Factory Pattern

What it is:

- a pattern used to control object creation logic

Where used realistically:

- payment provider creation
- notification channel selection
- integration client creation
- report formatter selection

Why used:

- centralizes creation logic
- avoids repeated if-else object creation
- supports extensibility

What problem it solved:

- complicated runtime object creation rules

Interview answer:

- I use factory-style design when object creation depends on provider, type, or configuration. In enterprise projects, this is useful for integrations, notifications, or workflow-based handler selection.

Source:

- industry expansion

## 21. Technology 14 - EF Core

What it is:

- ORM used in .NET for relational data access

Where used:

- business CRUD modules
- internal admin workflows
- standard relational backend modules

Why used:

- faster development
- strong .NET integration
- migrations support
- maintainable data access

What problem it solved:

- repetitive manual mapping
- slower CRUD development

When it fits best:

- standard business data operations
- maintainable backend systems

When not ideal alone:

- very complex reporting SQL
- extreme performance-tuned query paths

Interview answer:

- I used EF Core in modules where maintainability and productivity mattered, especially for standard business CRUD and relational data operations. It works well when development speed and model-driven data access are important.

Source:

- Resume

## 22. Technology 15 - Dapper

What it is:

- lightweight micro ORM

Where used:

- optimized query paths
- reporting
- performance-sensitive database access

Why used:

- more SQL control
- less abstraction overhead
- better for custom read queries

What problem it solved:

- slow or awkward ORM-generated patterns for complex queries

Interview answer:

- I used Dapper in cases where query performance and SQL control mattered more than ORM convenience. It is especially useful in reporting-heavy or optimized data access scenarios.

Source:

- Resume

## 23. Technology 16 - SQL Server

What it is:

- relational database platform

Where used:

- Hospital Management System
- PMS Application
- E-Commerce platform

Why used:

- transactional consistency
- strong relational support
- reporting compatibility
- mature enterprise ecosystem

What problem it solved:

- structured and transactional business data management

Interview answer:

- I used SQL Server in projects with highly relational and transactional data, such as healthcare records, accounting data, and order workflows. It was the right fit because consistency and reporting were both important.

Source:

- Resume

## 24. Technology 17 - PostgreSQL

What it is:

- open-source relational database

Where used or applicable:

- cloud-native backend scenarios
- modern API services
- enterprise relational workloads

Why used:

- strong relational support
- open-source flexibility
- rich SQL features

Interview answer:

- PostgreSQL is a strong choice for modern backend systems where a powerful relational database is needed in a more open and flexible stack. I include it in my database experience for modern cloud-oriented application work.

Source:

- Resume

## 25. Technology 18 - MongoDB

What it is:

- document database

Where used or applicable:

- flexible schema data
- metadata documents
- log-like or dynamic document storage

Why used:

- schema flexibility
- natural document storage

When not used:

- strict transactional systems
- accounting core logic

Interview answer:

- MongoDB is useful where the data is more document-based and the schema can change more often. For strongly relational or transactional systems like accounting or billing, I would still prefer SQL.

Source:

- Resume + industry expansion

## 26. Technology 19 - SQL vs NoSQL

Decision rule:

- use SQL for transactions, relationships, structured reporting
- use NoSQL for flexible schema and document-oriented storage

SQL examples from your project world:

- patient records
- invoices
- ledgers
- order and inventory transactions

NoSQL examples from your project world:

- dynamic metadata
- document payloads
- loosely structured audit objects

Interview answer:

- I decide between SQL and NoSQL based on data shape and consistency requirements. For business-critical transactional systems, SQL is usually the right choice. For flexible document-oriented data, NoSQL can be a better fit.

Source:

- Resume + industry expansion

## 27. Technology 20 - Redis

What it is:

- in-memory cache

Where used:

- performance-sensitive APIs
- dashboard-related data acceleration
- repeated lookup patterns

Why used:

- reduce database load
- improve response time
- support hot-read scenarios

What problem it solved:

- repeated expensive reads
- unnecessary database pressure

Interview answer:

- I use Redis where the same data is read frequently and performance matters. It helps improve API response time and reduces pressure on the main database.

Source:

- Resume

## 28. Technology 21 - RabbitMQ

What it is:

- message broker for asynchronous communication

Where used or applicable:

- notification processing
- integration workflows
- decoupled background operations

Why used:

- loose coupling
- async workflow support
- better reliability for background processing

What problem it solved:

- long-running or non-critical tasks blocking user requests

Interview answer:

- I use RabbitMQ when workflows should be decoupled and processed asynchronously, such as notifications, integrations, or background task chains. It keeps the main request flow cleaner and more scalable.

Source:

- Resume mentions RabbitMQ

## 29. Technology 22 - Azure Service Bus

What it is:

- Azure-managed messaging system

Where used:

- Azure-based asynchronous processing
- service decoupling
- queue-based workflow handling

Why used:

- managed messaging
- integration with Azure ecosystem
- enterprise-grade async communication

What problem it solved:

- tightly coupled cloud workflows
- need for reliable message-based communication

Interview answer:

- Azure Service Bus is useful in Azure-hosted enterprise applications where reliable message-based communication is needed between components. It reduces coupling and supports asynchronous workflow design.

Source:

- Resume

## 30. Technology 23 - Azure Functions

What it is:

- serverless compute on Azure

Where used or applicable:

- queue-triggered jobs
- timer-based jobs
- webhook handlers
- event-driven business operations
- integration callbacks

Why used:

- good for lightweight background work
- no full app host needed
- cost-effective for triggered workflows

What problem it solved:

- not every process needs a full service
- async work should not block user request

Interview answer:

- I use Azure Functions for event-driven and background tasks such as webhook processing, queue-based work, or scheduled jobs. It is useful when the workload is triggered and does not need a full always-on application service.

Source:

- Resume

## 31. Technology 24 - AWS Lambda

What it is:

- serverless compute in AWS

Where used or applicable:

- S3-triggered tasks
- scheduled processing
- lightweight integration handlers
- event-triggered business logic

Why used:

- event-driven processing
- low infrastructure overhead
- strong AWS integration

What problem it solved:

- short-lived jobs do not need dedicated server infrastructure

Interview answer:

- I use AWS Lambda for event-driven workloads in AWS, especially when the task is short-lived and integrated with other AWS services. It is a practical option for lightweight serverless processing.

Source:

- Resume + industry expansion

## 32. Technology 25 - Azure App Service

What it is:

- managed hosting for web applications and APIs

Where used:

- ASP.NET Core APIs
- cloud-hosted enterprise web apps

Why used:

- simpler hosting
- managed platform
- easy CI/CD integration

What problem it solved:

- reduced infrastructure management for standard web hosting

Interview answer:

- Azure App Service is useful when a .NET API or web app needs reliable managed hosting with easier deployment and less server management overhead.

Source:

- Resume

## 33. Technology 26 - AWS EC2

What it is:

- virtual machine compute service

Where used or applicable:

- legacy migration workloads
- applications needing full server control
- custom-hosted backend environments

Why used:

- infrastructure flexibility
- custom environment control
- support for workloads not ready for serverless or managed hosting

Interview answer:

- EC2 is useful when more operating system or infrastructure-level control is required. It often fits migrated systems or workloads with custom deployment needs.

Source:

- Resume

## 34. Technology 27 - AWS RDS

What it is:

- managed relational database in AWS

Where used or applicable:

- transactional cloud applications
- managed SQL workloads

Why used:

- managed operations
- backups
- easier database hosting

Interview answer:

- RDS is useful when you need relational database capability in AWS without managing the full database infrastructure yourself. It supports enterprise workloads while reducing operational effort.

Source:

- Resume + industry expansion

## 35. Technology 28 - AWS S3

What it is:

- object storage service

Where used or applicable:

- report exports
- file uploads
- document storage
- media assets

Why used:

- scalable storage
- durable storage
- application file separation

Interview answer:

- S3 is useful for file-based workloads such as exports, uploaded documents, and generated reports. It separates file storage cleanly from the main application and database concerns.

Source:

- Resume + industry expansion

## 36. Technology 29 - Docker

What it is:

- containerization platform

Where used:

- packaging applications
- CI/CD deployments
- cloud deployment consistency

Why used:

- same app package across environments
- less environment mismatch
- better deployment portability

What problem it solved:

- local vs test vs production differences

Interview answer:

- I use Docker to package applications consistently so the same build can move across environments with fewer surprises. It supports cleaner CI/CD and deployment reliability.

Source:

- Resume

## 37. Technology 30 - Kubernetes

What it is:

- container orchestration platform

Where used or applicable:

- containerized microservices
- scalable service deployments
- cloud-native environments

Why used:

- scaling
- orchestration
- rollout control
- self-healing deployment behavior

When it makes sense:

- multiple services
- larger environments
- operational maturity

Interview answer:

- Kubernetes is useful when multiple containerized services need coordinated deployment, scaling, and operational control. I see it as a good fit for larger cloud-native environments rather than for small applications.

Source:

- Resume

## 38. Technology 31 - Azure DevOps

What it is:

- platform for CI/CD and team delivery workflows

Where used:

- Hospital Management System
- deployment automation
- build pipelines
- release pipelines

Why used:

- repeatable deployment
- build automation
- release consistency
- work tracking alignment

Interview answer:

- I used Azure DevOps for CI/CD automation and release workflows in enterprise projects. It helped us automate builds, tests, and deployments so releases became more consistent and less manual.

Source:

- Resume

## 39. Technology 32 - Jenkins

What it is:

- automation server

Where used or applicable:

- CI/CD
- custom job automation
- build and deployment workflows

Why used:

- flexible automation
- customizable build workflows

Interview answer:

- Jenkins is useful when teams need flexible build and deployment automation. It works well for custom CI/CD flows where more control is needed across multiple project types.

Source:

- Resume

## 40. Technology 33 - CI/CD

What it is:

- continuous integration and continuous deployment

Where used:

- enterprise .NET applications
- Azure DevOps pipelines
- deployment workflows

Why used:

- reduce manual deployment risk
- speed delivery
- improve release consistency

Interview answer:

- CI/CD is important because it turns delivery into a repeatable process. In enterprise systems, it reduces deployment mistakes, shortens release cycles, and improves confidence in production changes.

Source:

- Resume

## 41. Technology 34 - OAuth2

What it is:

- authorization framework used in modern secure systems

Where used:

- APIs
- external integrations
- identity-provider-based auth flows

Why used:

- secure delegated authorization
- token-based access control

Interview answer:

- I use OAuth2 when secure token-based authorization is needed, especially where APIs interact with identity providers or protected client applications.

Source:

- Resume

## 42. Technology 35 - JWT

What it is:

- token format used for stateless authentication

Where used:

- Hospital Management System
- dashboard login
- API authentication

Why used:

- stateless API auth
- role claims
- scalable token-based access

Interview answer:

- I used JWT in API-based systems where stateless authentication was needed between frontend clients and backend services. It was useful for secure role-aware API access.

Source:

- Resume

## 43. Technology 36 - Azure AD / Microsoft Entra ID

What it is:

- enterprise identity and SSO platform

Where used or applicable:

- organization-managed login
- enterprise internal systems
- role-controlled access

Why used:

- centralized identity
- SSO
- enterprise user management

Interview answer:

- Azure AD or Entra ID is a strong fit in enterprise systems where centralized authentication, SSO, and organization-managed identity are important.

Source:

- Resume

## 44. Technology 37 - Role-Based Access Control

What it is:

- permission model based on user roles

Where used:

- E-Commerce platform
- Hospital workflows
- Internal Admin Panel

Why used:

- different users need different permissions
- sensitive operations must be controlled

What problem it solved:

- not every user should see or do everything

Interview answer:

- I used role-based access control in systems where different user groups needed different responsibilities, such as admins, operators, finance users, or hospital staff. It helps protect sensitive functionality and data.

Source:

- Resume

## 45. Technology 38 - REST APIs

What it is:

- standard HTTP-based API style

Where used:

- Hospital integrations
- E-Commerce APIs
- dashboard data APIs
- internal admin services

Why used:

- interoperability
- standard client support
- easy frontend-backend communication

Interview answer:

- REST APIs were a natural fit for most of my projects because they work well for web clients, internal systems, and third-party integrations. They are simple, standard, and widely supported.

Source:

- Resume

## 46. Technology 39 - gRPC

What it is:

- high-performance RPC communication style

Where used or applicable:

- internal service-to-service communication
- low-latency internal APIs

Why used:

- strong contracts
- efficient serialization
- better fit for some internal calls than public REST

Interview answer:

- I associate gRPC with internal service-to-service communication where stronger contracts and performance matter more than public API simplicity. It fits internal distributed systems more than general client-facing APIs.

Source:

- Resume architecture section

## 47. Technology 40 - Event-Driven Architecture

What it is:

- system parts communicate through events

Where used or applicable:

- notifications
- async workflows
- integrations
- long-running processes

Why used:

- loose coupling
- independent processing
- scalable async workflows

Interview answer:

- I use event-driven architecture when direct synchronous coupling would make the system too rigid. It is useful for notifications, integrations, and workflow steps that can happen asynchronously.

Source:

- Resume architecture alignment

## 48. Technology 41 - Azure OpenAI

What it is:

- Azure-managed AI integration

Where used or explored:

- Hospital Management System stack mention
- AI-assisted business workflow ideas

Possible practical scenarios:

- document summarization
- intelligent assistant workflows
- support-side productivity
- knowledge retrieval assistance

Why used:

- productivity support
- smart workflow enhancement

Interview answer:

- I see Azure OpenAI as useful when AI is connected to a real workflow, such as summarization, guided assistance, or productivity improvement, rather than using AI without a business use case.

Source:

- Resume

## 49. Technology 42 - ChatGPT and Copilot Style AI Tools

What it is:

- AI-assisted productivity support for engineering work

Where used:

- development productivity
- learning
- code drafting
- explanation support

Why used:

- accelerate routine work
- improve research speed
- help with developer productivity

Interview answer:

- I use AI tools such as ChatGPT and Copilot as productivity support, especially for acceleration and idea exploration, while keeping architectural and code-quality decisions grounded in engineering fundamentals.

Source:

- Resume

## 50. Technology 43 - SQL Optimization

What it is:

- improving queries, indexes, execution plans, and DB usage

Where used:

- Hospital Management System
- PMS
- E-Commerce

Why used:

- improve response time
- reduce database load
- support reporting performance

Impact mentioned in resume:

- 30 percent performance improvement

Interview answer:

- SQL optimization was important in my projects because enterprise systems often slow down due to inefficient queries or indexing. I worked on query tuning and database efficiency to improve application responsiveness.

Source:

- Resume

## 51. Technology 44 - Caching

What it is:

- storing frequently used data for faster access

Where used or applicable:

- dashboards
- reference lookups
- performance-sensitive APIs

Why used:

- reduce repeat database hits
- improve latency

Interview answer:

- I use caching where the same data is read repeatedly and the refresh frequency is manageable. It helps improve performance and reduce pressure on the main database.

Source:

- Resume performance section

## 52. Technology 45 - Load Balancing

What it is:

- distributing requests across multiple instances

Where used or applicable:

- scalable API hosting
- cloud deployments
- multi-instance services

Why used:

- performance
- scalability
- availability

Interview answer:

- Load balancing becomes important when a service is deployed across multiple instances and traffic or reliability requirements justify distributing requests for better availability and scale.

Source:

- Resume architecture/performance alignment

## 53. Technology 46 - Logging

What it is:

- capturing application and system events

Where used:

- APIs
- production troubleshooting
- integration debugging
- operations analysis

Why used:

- diagnostics
- root cause analysis
- operational visibility

Interview answer:

- Logging is essential in enterprise systems because production issues are often understood through logs first. It supports troubleshooting, diagnostics, and operational visibility.

Source:

- industry expansion

## 54. Technology 47 - Monitoring and Observability

What it is:

- measuring system health, performance, and failure behavior

Where used or applicable:

- production APIs
- distributed systems
- cloud-hosted platforms

Why used:

- detect failures early
- understand latency
- improve reliability

Interview answer:

- Monitoring matters because building the application is only part of the job. In production, teams need visibility into health, error rates, and performance so the system stays stable and supportable.

Source:

- industry expansion

## 55. Technology 48 - Background Jobs

What it is:

- processing tasks outside the main request flow

Where used or applicable:

- notifications
- report generation
- integrations
- data sync
- delayed processing

Why used:

- keep user response fast
- move heavy work outside main request

Interview answer:

- I use background jobs where work should not block the main user flow, such as notifications, integrations, or report generation. It improves response time and keeps the API path cleaner.

Source:

- Resume + industry expansion

## 56. Technology 49 - Scheduled Jobs / Cron

What it is:

- recurring timed process execution

Where used or applicable:

- nightly sync
- periodic reports
- cleanup tasks
- maintenance tasks

Why used:

- recurring system operations
- business workflows that run on schedule

Interview answer:

- Scheduled jobs are useful for recurring system or business operations, such as reports, syncs, or cleanup tasks that need predictable timed execution.

Source:

- industry expansion

## 57. Technology 50 - API Versioning

What it is:

- maintaining compatibility across API changes

Where used or applicable:

- external APIs
- multiple client systems
- integration-heavy platforms

Why used:

- prevent breaking consumers
- safer API evolution

Interview answer:

- API versioning becomes important when multiple consumers depend on the same APIs and changes need to be introduced safely without breaking older clients immediately.

Source:

- industry expansion

## 58. Technology 51 - Security by Design

What it is:

- building security into system design from the start

Where used:

- healthcare
- finance
- admin systems
- APIs

Why used:

- protect sensitive data
- enforce proper access
- reduce security risk

Interview answer:

- In healthcare, finance, and enterprise applications, security has to be part of the design from the start. That includes auth, validation, access control, and secure handling of sensitive data.

Source:

- Resume security section

## 59. Technology 52 - Unit Testing

What it is:

- testing small units of code in isolation

Where used or applicable:

- service layer
- validators
- business rules
- calculation logic

Why used:

- catch regressions
- support safe refactoring
- improve confidence in logic-heavy code

Interview answer:

- Unit testing is important for business logic, calculations, and service-layer rules because those areas change over time and need confidence during refactoring and releases.

Source:

- industry expansion aligned to your study material

## 60. Technology 53 - Integration Testing

What it is:

- testing interactions between real components

Where used or applicable:

- API + DB
- auth flow
- service integration
- queue processing

Why used:

- validate real interactions
- catch environment-level failures

Interview answer:

- Integration testing matters when correctness depends on components working together, such as APIs, databases, auth middleware, or integration endpoints.

Source:

- industry expansion

## 61. Technology 54 - Rate Limiting

What it is:

- controlling how many requests a client can make

Where used or applicable:

- public APIs
- login endpoints
- partner integrations

Why used:

- prevent abuse
- protect stability
- control heavy traffic

Interview answer:

- Rate limiting is useful in APIs to prevent abuse, reduce overload risk, and keep the service stable under uneven or excessive request volume.

Source:

- industry expansion

## 62. Technology 55 - API Gateway / API Management

What it is:

- centralized API entry point and policy layer

Where used or applicable:

- microservices
- external client APIs
- partner APIs

Why used:

- auth
- routing
- throttling
- versioning
- observability

Azure example:

- Azure API Management

Interview answer:

- API Management or API Gateway becomes useful when multiple APIs need centralized handling for security, throttling, routing, and lifecycle control.

Source:

- industry expansion

## 63. Technology 56 - Serverless Design

What it is:

- event-driven architecture built using function-like execution units

Where used:

- Azure Functions
- AWS Lambda
- lightweight triggered jobs

Why used:

- lower ops overhead
- event-driven execution
- no need for full app host for every workflow

Interview answer:

- I use serverless design when the workload is event-driven, lightweight, and not continuously active. It is a practical choice for triggered jobs, callback handlers, and automation workflows.

Source:

- Resume + industry expansion

## 64. Technology 57 - Legacy Migration

What it is:

- moving older applications to modern frameworks

Where used:

- your migration of 10+ legacy apps to .NET Core

Why used:

- maintainability
- scalability
- lower cost
- modernization

Impact mentioned:

- 25 percent hosting cost reduction

Interview answer:

- I worked on migrating legacy applications to .NET Core to improve maintainability, modernize deployments, and reduce hosting cost. It was not only a framework upgrade, but also a modernization effort.

Source:

- Resume

## 65. Technology 58 - Cloud Migration

What it is:

- moving workloads to Azure or AWS

Where used:

- Azure and AWS based implementations
- cloud-native modernization

Why used:

- managed services
- scalability
- better deployment automation
- operational flexibility

Interview answer:

- Cloud migration is useful when the goal is better scalability, automation, and managed service support. The exact cloud platform and service choice depends on workload type and operational goals.

Source:

- Resume

## 66. Technology 59 - Team Leadership

What it is:

- guiding technical execution across the team

Where used:

- led a 12-member team

What it included:

- architecture guidance
- code quality
- issue resolution
- planning support
- mentoring

Interview answer:

- My team leadership work included guiding architecture decisions, maintaining code quality, helping resolve technical blockers, and mentoring developers so delivery stayed technically strong as well as timely.

Source:

- Resume

## 67. Technology 60 - Agile / Scrum

What it is:

- iterative delivery model

Where used:

- project planning
- sprint execution
- team coordination

Why used:

- smaller delivery cycles
- regular feedback
- better planning visibility

Interview answer:

- Agile and Scrum practices help break large work into smaller deliverable units and improve communication between technical teams and stakeholders during ongoing delivery.

Source:

- Resume

## 68. Technology 61 - Git

What it is:

- version control platform and workflow tool

Where used:

- all code collaboration
- branches
- pull requests
- release history

Why used:

- collaboration
- change tracking
- safer team development

Interview answer:

- Git is central to team development because it supports collaboration, version history, branching strategy, and controlled code changes across multiple developers.

Source:

- Resume

## 69. Technology 62 - Postman

What it is:

- API testing tool

Where used:

- endpoint validation
- auth testing
- request/response debugging
- integration checks

Why used:

- quick API verification
- easier debugging

Interview answer:

- I use Postman for validating API endpoints, checking authentication flows, and debugging request-response issues during development and testing.

Source:

- Resume

## 70. Technology 63 - Jira / Trello

What it is:

- work tracking and planning tools

Where used:

- sprint planning
- issue tracking
- task visibility

Why used:

- planning clarity
- workflow management
- delivery tracking

Interview answer:

- Project tracking tools like Jira help maintain visibility across tasks, bugs, and delivery commitments so engineering work stays organized and traceable.

Source:

- Resume

## 71. Technology 64 - IIS

What it is:

- Windows web hosting platform

Where used or applicable:

- traditional .NET hosting
- enterprise Windows environments

Why used:

- common Windows-hosted deployment option
- supports internal enterprise app hosting

Interview answer:

- IIS remains relevant in enterprise environments where .NET applications are hosted on Windows infrastructure. It is part of practical deployment experience for many business systems.

Source:

- Resume deployment section

## 72. Technology 65 - Node.js / npm / Webpack in Full-Stack Projects

What it is:

- frontend build ecosystem often used with React-based work

Where used:

- React projects
- dashboard frontend builds
- frontend package management

Why used:

- package management
- asset bundling
- frontend build workflow

Interview answer:

- In full-stack projects, Node.js tooling is often used on the frontend side even if the backend is .NET. It supports React build flow, asset bundling, and modern frontend dependency management.

Source:

- Resume build tools section

## 73. Technology 66 - Visual Studio / VS Code / SSMS / RedGate

What it is:

- development and database productivity tooling

Where used:

- coding
- debugging
- SQL profiling
- query tuning
- developer productivity

Why used:

- better engineering workflow
- diagnostics
- database insight

Interview answer:

- Tooling matters in real engineering work. Visual Studio, VS Code, SSMS, and SQL profiling tools help with productivity, debugging, and database optimization across backend projects.

Source:

- Resume
