# Design Patterns Study Materials

Purpose:

- understand common design patterns in simple language
- know where they fit in real industry code
- know when to use them and when not to

## 1. First Rule

Design patterns are not full system design.

They are code-level reusable solutions to common problems.

## 2. Pattern Categories

### Creational Patterns

Used for object creation.

Examples:

- Singleton
- Factory
- Abstract Factory
- Builder

### Structural Patterns

Used for object/class structure.

Examples:

- Adapter
- Decorator
- Facade
- Composite

### Behavioral Patterns

Used for object communication and behavior.

Examples:

- Strategy
- Observer
- Command
- State
- Template Method
- Mediator

## 3. Most Important Patterns for Industry

## Singleton

Problem solved:

- one shared instance needed

Common use:

- configuration
- logger
- cache manager in some cases

Do not overuse it.

## Factory

Problem solved:

- object creation depends on type, config, or runtime condition

Common use:

- notification sender
- payment provider creation
- parser selection

## Builder

Problem solved:

- object creation has many fields or many steps

Common use:

- request object
- complex configuration object

## Strategy

Problem solved:

- multiple algorithms for same behavior

Common use:

- discount calculation
- payment mode processing
- export format logic

## Observer

Problem solved:

- one change should notify multiple listeners

Common use:

- event handling
- UI updates
- notification triggers

## Adapter

Problem solved:

- old interface and new interface do not match

Common use:

- third-party API integration
- wrapping external SDKs

## Decorator

Problem solved:

- add behavior without changing original class

Common use:

- logging
- caching
- authorization checks

## Facade

Problem solved:

- complex subsystem needs one simple entry point

Common use:

- payment workflow wrapper
- reporting facade

## Command

Problem solved:

- action represented as object

Common use:

- queued operations
- undo/redo actions
- task execution

## Repository

Problem solved:

- data access logic should stay separate from business logic

Common use:

- EF Core repository
- database abstraction

## 4. Industry Mapping

### In .NET enterprise apps

Most common practical patterns:

- dependency injection
- repository
- factory
- strategy
- facade
- builder

### In frontend apps

Most common practical patterns:

- observer
- state pattern ideas
- facade for APIs

### In distributed systems

Most common practical patterns:

- adapter
- strategy
- command
- decorator

## 5. Important Warning

Do not force patterns into every class.

Use a pattern only when:

- a real repeated problem exists
- the pattern makes code clearer
- the team can understand it

## 6. Best Learning Order

1. Singleton
2. Factory
3. Strategy
4. Repository
5. Builder
6. Adapter
7. Facade
8. Observer
9. Decorator
10. Command

## 7. Best Question to Ask

For each pattern ask:

1. what problem does it solve
2. where is it used
3. what happens if I do not use it
4. when does it become overengineering

## 8. Final Rule

Patterns should reduce confusion, not increase it.

If the pattern makes the code harder to understand, it is probably the wrong place to use it.
