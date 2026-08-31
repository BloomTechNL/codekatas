# Tennis Kata (Python)

Implement the scoring for a game of tennis.

## Rules

Two players — `Player.ONE` and `Player.TWO` — play a game of tennis. Every time a player wins a point, `won_point` is called with that player. `get_score()` returns a human-readable description of the current score, following these rules:

- Points are named, in order: Love (0), Fifteen (1), Thirty (2), Forty (3).
- While both players have fewer than four points and their scores differ, the score is `"<player one's score>-<player two's score>"`, e.g. `"Thirty-Fifteen"`.
- When both players are tied on fewer than three points, the score is `"<score>-All"`, e.g. `"Fifteen-All"`. At 0-0 this reads `"Love-All"`.
- When both players are tied on three points or more, the score is `"Deuce"`, however many times play returns to it.
- Once a player has at least four points and leads by exactly one, the score is `"Advantage <player>"`, e.g. `"Advantage Player One"`.
- Once a player has at least four points and leads by two or more, that player has won the game: `"Win for <player>"`, e.g. `"Win for Player One"`.
- Once a game has been won, calling `won_point` again raises — there's nothing left to score.

## Setup

Requires Python 3.10+. No dependencies to install.

## Running the tests

```bash
python3 -m unittest
```

You should see the full suite passing. The `Player` enum, `TennisGame` protocol, and `Game` implementation live in `tennis_game.py`; its tests live in `test_tennis_game.py`.
