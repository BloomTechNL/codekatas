# Conway’s Game of Life

Conway’s **Game of Life** is a cellular automaton devised by mathematician John Conway in 1970.

It is a **zero-player game**: after you choose an initial configuration, the system evolves automatically according to a few simple rules. Despite those simple rules, it can produce surprisingly complex and lifelike behavior.

---

## Concept

The world is a 2D grid of cells.

Each cell is either:

- alive
- dead

Time advances in discrete steps called **generations**.  
At every generation, all cells update **simultaneously** based only on their neighbors.

Each cell has **8 neighbors** (horizontal, vertical, and diagonal).

---

## Rules

For every generation:

1. A live cell with fewer than **2** live neighbors dies (underpopulation)
2. A live cell with **2 or 3** neighbors survives
3. A live cell with more than **3** neighbors dies (overpopulation)
4. A dead cell with exactly **3** neighbors becomes alive (reproduction)

All updates happen at the same time.

---

## Example

### Blinker (oscillator)

Generation 1

```
. # .
. # .
. # .
```
Generation 2

```
. . .
# # #
. . .
```

This pattern alternates forever.

---

## Why it’s interesting

Although the rules are simple, the Game of Life can produce:

- stable structures
- oscillators
- moving patterns (“gliders”)
- chaotic behavior
- complex emergent systems

It’s often used to explore:

- emergence and complexity
- simulation techniques
- algorithm design
- functional programming
- testing and refactoring practice

---

## Try it yourself

Start with small patterns and observe how they evolve.  
Even tiny changes in the initial state can lead to dramatically different outcomes.
