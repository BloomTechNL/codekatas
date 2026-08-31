# Mars Rover Kata (C#)

This is a refactoring kata: the `Rover` interface and its tests are already in place, and the working implementation will be dropped in as-is. The goal is not to build the rover from scratch, but to improve the design of an existing (messy) implementation while keeping the tests green.

A `Rover` starts at position `(0, 0)`, facing north, on an open grid (no boundaries or obstacles to worry about).

- `Move()` — moves the rover one step forward in the direction it's currently facing.
- `TurnLeft()` — rotates the rover 90° counter-clockwise in place (does not change its position).
- `TurnRight()` — rotates the rover 90° clockwise in place (does not change its position).
- `GetPosition()` — returns the rover's current `Position` record.

North increases `Y`, east increases `X`, south decreases `Y`, and west decreases `X`. See `MarsRover.Tests/RoverTests.cs` for the full set of example behaviors.

## Setup

Requires the [.NET SDK](https://dotnet.microsoft.com/download) (10.0 or later).

```bash
dotnet restore
```

## Running the tests

```bash
cd MarsRover.Tests
dotnet test
```
