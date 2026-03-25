# System Design Study Materials

Last updated: March 23, 2026

Purpose:

- understand confusing software terms in simple language
- separate system design from architecture and design patterns
- learn where each concept is used
- study both theory and practical diagram thinking
- focus on industry-use thinking, not only interview buzzwords

## 0. Industry Rule

Do not study these topics like dictionary words only.

For each concept, always connect it to:

- business problem
- team size
- system size
- operational complexity
- maintainability
- delivery speed

That is how these concepts are actually used in industry.

## 1. First Big Confusion to Clear

Many people mix these words together:

- system design
- software architecture
- application architecture
- design patterns
- architectural patterns
- coding patterns
- frameworks

They are related, but they are not the same.

## 2. Simple Meaning of Each Word

### System Design

System design is the high-level design of a software system.

It answers:

- what are the main parts of the system
- how users reach the system
- how data flows
- how services communicate
- how the system scales
- how the system stays reliable

Examples:

- design an e-commerce platform
- design a hospital management system
- design a URL shortener
- design a chat application

### Software Architecture

Software architecture is the structural style of the software.

It answers:

- how the application is organized internally
- how modules are separated
- how responsibilities are divided

Examples:

- monolith
- layered architecture
- clean architecture
- microservices
- event-driven architecture

### Design Patterns

Design patterns are reusable small or medium-level coding solutions.

They answer:

- how to create objects
- how objects communicate
- how responsibilities are organized in code

Examples:

- Singleton
- Factory
- Strategy
- Repository
- Observer

### Architectural Patterns

Architectural patterns are bigger than design patterns.

They define the shape of the application.

Examples:

- MVC
- microservices
- CQRS
- event sourcing
- layered architecture

## 3. Easy Rule to Remember

- design pattern = code-level solution
- architectural pattern = application-level structure
- system design = whole system view

## 4. Different Levels of Design

Think in levels:

### Level 1: Code Level

Examples:

- Singleton
- Factory
- Strategy
- Dependency Injection

### Level 2: Application Level

Examples:

- MVC
- Clean Architecture
- Monolith
- Microservices
- CQRS

### Level 3: System Level

Examples:

- API Gateway
- load balancer
- cache
- message queue
- CDN
- database replication
- service-to-service communication

## 5. Common Terms Explained

## MVC

Meaning:

- Model View Controller

Used for:

- web applications
- UI-based applications

Why used:

- separates data, UI, and control logic

Where used:

- ASP.NET MVC
- many older and still common web applications

Simple idea:

- Model = data/business object
- View = UI
- Controller = request handler

## Microservices

Meaning:

- application split into smaller independent services

Used for:

- large systems
- teams working independently
- systems needing separate deployment/scaling

Why used:

- better separation
- independent deployment
- easier scaling for specific modules

Risk:

- higher complexity
- harder debugging
- network communication problems

Use when:

- system is large
- domains are clearly separate
- team maturity is good

## Monolith

Meaning:

- one application, one deployment unit

Used for:

- small to medium systems
- faster initial delivery

Why used:

- simpler development
- simpler debugging
- fewer distributed system problems

Important:

- monolith is not bad
- bad monolith is bad, not monolith itself

## Singleton

Meaning:

- only one instance of a class should exist

Used for:

- configuration
- logging
- shared service in some cases

Why used:

- controlled global access

Risk:

- hidden global state
- hard to test if misused

Use carefully.

## Factory

Meaning:

- object creation logic is separated into a factory

Used for:

- when object creation is complex
- when different object types are created dynamically

Why used:

- cleaner code
- loose coupling

## Repository

Meaning:

- abstraction around data access

Used for:

- database operations
- storage access

Why used:

- cleaner business logic
- easier testing

## Dependency Injection

Meaning:

- dependencies are provided from outside instead of created inside the class

Used for:

- almost all modern enterprise applications

Why used:

- testability
- loose coupling
- easier replacement of implementations

## CQRS

Meaning:

- Command Query Responsibility Segregation

Simple rule:

- write operations and read operations are separated

Used for:

- complex business systems
- systems with heavy read/write differences

Why used:

- better control over writes and reads
- read optimization
- cleaner domain handling in some cases

Risk:

- extra complexity

Do not use CQRS only because it sounds advanced.

## Event-Driven Architecture

Meaning:

- systems communicate through events

Used for:

- async workflows
- distributed systems
- audit-heavy or integration-heavy systems

Why used:

- loose coupling
- better async processing

Examples:

- order created event
- payment completed event
- email notification event

## Clean Architecture

Meaning:

- business logic stays independent from framework and infrastructure

Used for:

- maintainable enterprise apps

Why used:

- separation of concerns
- testability
- framework independence

## DDD

Meaning:

- Domain-Driven Design

Used for:

- business-heavy systems with complex rules

Why used:

- software model reflects business language and domain boundaries

## Event Sourcing

Meaning:

- store every change as an event instead of storing only latest state

Used for:

- auditing
- highly traceable systems

Why used:

- full history
- rebuild state from events

Risk:

- harder implementation

## 6. How Many Types of System Design Are There

There is no one fixed official number.

But for practical study, divide system design into these categories:

### 1. High-Level System Design

Focus:

- services
- databases
- cache
- queues
- APIs
- scaling

### 2. Low-Level Design

Focus:

- classes
- interfaces
- methods
- object interactions
- design patterns

### 3. Application Architecture Design

Focus:

- MVC
- clean architecture
- modular monolith
- microservices

### 4. Data Design

Focus:

- relational database
- NoSQL
- schema design
- indexing
- partitioning

### 5. Infrastructure Design

Focus:

- deployment
- containers
- CI/CD
- cloud networking
- load balancing

### 6. Integration Design

Focus:

- REST
- gRPC
- messaging
- event buses
- third-party integrations

## 7. When to Use What

### MVC

Use when:

- standard web app with UI and request-response flow

### Microservices

Use when:

- system is large and domain boundaries are clear

### Monolith

Use when:

- product is early
- team is small
- simplicity matters more than distributed scale

### CQRS

Use when:

- complex domain
- read and write workloads are very different

### Singleton

Use when:

- one shared instance is truly needed

### Factory

Use when:

- object creation logic is dynamic or complicated

## 8. Practical Learning Approach

Do not learn only definitions.

Learn each term with these 5 questions:

1. what is it
2. what problem does it solve
3. where is it used
4. when should I not use it
5. show me one real example

Add these 3 industry questions too:

6. what team or company problem does it solve
7. what new complexity does it introduce
8. would I choose it for a small, medium, or large system

## 9. What to Draw in Practice

Use drawing tools to understand systems visually.

Good tools:

- draw.io
- Excalidraw
- PowerPoint
- Excel
- Mermaid diagrams in markdown

## 10. Drawings You Should Practice

### A. Context Diagram

Show:

- user
- system
- external systems

### B. Container Diagram

Show:

- frontend
- backend
- database
- cache
- queue

### C. Component Diagram

Show:

- modules inside backend
- auth
- order
- payment
- notification

### D. Sequence Diagram

Show:

- step-by-step request flow

### E. Deployment Diagram

Show:

- load balancer
- app instances
- database
- Redis
- queue

## 11. What Tool to Use for What

### draw.io

Best for:

- system diagrams
- architecture diagrams
- sequence diagrams

### Excel

Best for:

- comparison tables
- capacity planning
- API inventory
- service dependency matrix

### Excalidraw

Best for:

- rough fast thinking
- interview-style diagrams

### Mermaid

Best for:

- text-based diagrams stored in files

## 12. Study Order for You

Based on your confusion, study in this order:

1. difference between system design, architecture, and design patterns
2. monolith vs microservices
3. MVC
4. dependency injection
5. repository pattern
6. factory and singleton
7. clean architecture
8. CQRS
9. event-driven architecture
10. practical system diagrams

## 13. Real Example Mapping

### Hospital Management System

System design level:

- users
- web app
- API
- auth
- patient service
- billing service
- lab integration
- database
- cache

Architecture level:

- microservices or modular backend

Pattern level:

- repository
- factory
- dependency injection
- strategy

## 14. Common Mistake

Do not speak like this:

- MVC is architecture
- singleton is system design
- microservice is design pattern

Better:

- MVC is an architectural pattern
- singleton is a design pattern
- microservices are an architectural style
- system design is the broader overall solution design

## 15. Final Mental Model

Think like this:

- system design = city plan
- architecture = building structure
- design patterns = room furniture arrangement

All three matter, but at different levels.

## 16. Final Industry Advice

The real goal is not to memorize words like:

- MVC
- CQRS
- Singleton
- Microservices

The real goal is to say:

- what it is
- why it exists
- where it fits
- what tradeoff it brings
- whether it is right for this system
