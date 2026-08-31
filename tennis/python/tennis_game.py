from enum import Enum, auto
from typing import Protocol


class Player(Enum):
    ONE = auto()
    TWO = auto()


class TennisGame(Protocol):
    def won_point(self, player: Player) -> None: ...

    def get_score(self) -> str: ...


_POINT_NAMES = ["Love", "Fifteen", "Thirty", "Forty"]

_PLAYER_NAMES = {
    Player.ONE: "Player One",
    Player.TWO: "Player Two",
}


class Game(TennisGame):
    def __init__(self):
        self._points = {Player.ONE: 0, Player.TWO: 0}

    def won_point(self, player: Player) -> None:
        if self.get_score().startswith("Win for"):
            raise RuntimeError("The game has already been won")

        self._points[player] += 1

    def get_score(self) -> str:
        points_one = self._points[Player.ONE]
        points_two = self._points[Player.TWO]

        if points_one == points_two:
            return f"{_POINT_NAMES[points_one]}-All" if points_one < 3 else "Deuce"

        if points_one >= 4 or points_two >= 4:
            leader = Player.ONE if points_one > points_two else Player.TWO

            return (
                f"Advantage {_PLAYER_NAMES[leader]}"
                if abs(points_one - points_two) == 1
                else f"Win for {_PLAYER_NAMES[leader]}"
            )

        return f"{_POINT_NAMES[points_one]}-{_POINT_NAMES[points_two]}"
