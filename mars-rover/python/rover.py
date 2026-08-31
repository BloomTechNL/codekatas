from dataclasses import dataclass
from typing import Literal

Direction = Literal["north", "east", "south", "west"]


@dataclass(frozen=True)
class Position:
    x: int
    y: int


class Rover:
    def __init__(self):
        self._position = Position(0, 0)
        self._direction: Direction = "north"

    def get_position(self):
        return self._position

    def turn_left(self):
        if self._direction == "north":
            self._direction = "west"
        elif self._direction == "west":
            self._direction = "south"
        elif self._direction == "south":
            self._direction = "east"
        elif self._direction == "east":
            self._direction = "north"

    def turn_right(self):
        if self._direction == "north":
            self._direction = "east"
        elif self._direction == "east":
            self._direction = "south"
        elif self._direction == "south":
            self._direction = "west"
        elif self._direction == "west":
            self._direction = "north"

    def move(self):
        if self._direction == "north":
            self._position = Position(self._position.x, self._position.y + 1)
        elif self._direction == "east":
            self._position = Position(self._position.x + 1, self._position.y)
        elif self._direction == "south":
            self._position = Position(self._position.x, self._position.y - 1)
        elif self._direction == "west":
            self._position = Position(self._position.x - 1, self._position.y)
