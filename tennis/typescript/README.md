# Tennis Kata (TypeScript)

Implement the scoring for a game of tennis.

## Rules

Two players — `Player.One` and `Player.Two` — play a game of tennis. Every time a player wins a point, `wonPoint` is called with that player. `getScore()` returns a human-readable description of the current score, following these rules:

- Points are named, in order: Love (0), Fifteen (1), Thirty (2), Forty (3).
- While both players have fewer than four points and their scores differ, the score is `"<player one's score>-<player two's score>"`, e.g. `"Thirty-Fifteen"`.
- When both players are tied on fewer than three points, the score is `"<score>-All"`, e.g. `"Fifteen-All"`. At 0-0 this reads `"Love-All"`.
- When both players are tied on three points or more, the score is `"Deuce"`, however many times play returns to it.
- Once a player has at least four points and leads by exactly one, the score is `"Advantage <player>"`, e.g. `"Advantage Player One"`.
- Once a player has at least four points and leads by two or more, that player has won the game: `"Win for <player>"`, e.g. `"Win for Player One"`.
- Once a game has been won, calling `wonPoint` again throws — there's nothing left to score.

## Setup

Requires [pnpm](https://pnpm.io/installation).

```bash
pnpm install
```

## Running the tests

```bash
pnpm test
```

You should see the full suite passing. The `Player` enum, `TennisGame` interface, and `Game` implementation live in `src/tennis-game.ts`; its tests live in `src/tennis-game.spec.ts`.
