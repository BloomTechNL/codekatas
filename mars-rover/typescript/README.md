# Mars Rover Kata (TypeScript)

This is a refactoring kata: the `Rover` interface and its tests are already in place, and the working implementation will be dropped in as-is. The goal is not to build the rover from scratch, but to improve the design of an existing (messy) implementation while keeping the tests green.

A `Rover` starts at position `(0, 0)`, facing north, on an open grid (no boundaries or obstacles to worry about).

- `move()` — moves the rover one step forward in the direction it's currently facing.
- `turnLeft()` — rotates the rover 90° counter-clockwise in place (does not change its position).
- `turnRight()` — rotates the rover 90° clockwise in place (does not change its position).
- `getPosition()` — returns the rover's current `{ x, y }` coordinates.

North increases `y`, east increases `x`, south decreases `y`, and west decreases `x`. See `src/rover.spec.ts` for the full set of example behaviors.

## Setup

Requires [pnpm](https://pnpm.io/installation).

```bash
pnpm install
```

## Running the tests

```bash
pnpm test
```
