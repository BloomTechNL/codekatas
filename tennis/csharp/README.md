# Tennis Kata (C#)

Implement the scoring for a game of tennis.

## Rules

Two players — `Player.One` and `Player.Two` — play a game of tennis. Every time a player wins a point, `WonPoint` is called with that player. `GetScore()` returns a human-readable description of the current score, following these rules:

- Points are named, in order: Love (0), Fifteen (1), Thirty (2), Forty (3).
- While both players have fewer than four points and their scores differ, the score is `"<player one's score>-<player two's score>"`, e.g. `"Thirty-Fifteen"`.
- When both players are tied on fewer than three points, the score is `"<score>-All"`, e.g. `"Fifteen-All"`. At 0-0 this reads `"Love-All"`.
- When both players are tied on three points or more, the score is `"Deuce"`, however many times play returns to it.
- Once a player has at least four points and leads by exactly one, the score is `"Advantage <player>"`, e.g. `"Advantage Player One"`.
- Once a player has at least four points and leads by two or more, that player has won the game: `"Win for <player>"`, e.g. `"Win for Player One"`.
- Once a game has been won, calling `WonPoint` again throws — there's nothing left to score.

## Setup

Requires the [.NET SDK](https://dotnet.microsoft.com/download) (10.0 or later).

```bash
dotnet restore
```

## Running the tests

```bash
cd Tennis.Tests
dotnet test
```

You should see the full suite passing. The `Player` enum, `ITennisGame` interface, and `Game` implementation live in `Tennis/TennisGame.cs`; its tests live in `Tennis.Tests/GameTests.cs`.
