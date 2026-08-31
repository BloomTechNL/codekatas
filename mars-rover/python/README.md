# Mars Rover Kata (Python)

This is a refactoring kata: the `Rover` interface and its tests are already in place, and the working implementation will be dropped in as-is. The goal is not to build the rover from scratch, but to improve the design of an existing (messy) implementation while keeping the tests green.

A `Rover` starts at position `(0, 0)`, facing north, on an open grid (no boundaries or obstacles to worry about).

- `move()` — moves the rover one step forward in the direction it's currently facing.
- `turn_left()` — rotates the rover 90° counter-clockwise in place (does not change its position).
- `turn_right()` — rotates the rover 90° clockwise in place (does not change its position).
- `get_position()` — returns the rover's current `Position(x, y)`.

North increases `y`, east increases `x`, south decreases `y`, and west decreases `x`. See `test_rover.py` for the full set of example behaviors.

## Setup

Requires Python 3.10+. No dependencies to install.

## Running the tests

```bash
python3 -m unittest
```
