import unittest

from rover import Position, Rover


class RoverTests(unittest.TestCase):
    def test_starts_at_the_origin(self):
        rover = Rover()

        self.assertEqual(rover.get_position(), Position(0, 0))

    def test_moves_one_step_forward(self):
        rover = Rover()

        rover.move()

        self.assertEqual(rover.get_position(), Position(0, 1))

    def test_moves_multiple_steps_forward(self):
        rover = Rover()

        rover.move()
        rover.move()
        rover.move()

        self.assertEqual(rover.get_position(), Position(0, 3))

    def test_moves_east_after_turning_right_once(self):
        rover = Rover()

        rover.turn_right()
        rover.move()

        self.assertEqual(rover.get_position(), Position(1, 0))

    def test_moves_south_after_turning_right_twice(self):
        rover = Rover()

        rover.turn_right()
        rover.turn_right()
        rover.move()

        self.assertEqual(rover.get_position(), Position(0, -1))

    def test_faces_north_again_after_turning_right_a_full_circle(self):
        rover = Rover()

        rover.turn_right()
        rover.turn_right()
        rover.turn_right()
        rover.turn_right()
        rover.move()

        self.assertEqual(rover.get_position(), Position(0, 1))

    def test_moves_west_after_turning_left_once(self):
        rover = Rover()

        rover.turn_left()
        rover.move()

        self.assertEqual(rover.get_position(), Position(-1, 0))

    def test_faces_north_again_after_turning_left_a_full_circle(self):
        rover = Rover()

        rover.turn_left()
        rover.turn_left()
        rover.turn_left()
        rover.turn_left()
        rover.move()

        self.assertEqual(rover.get_position(), Position(0, 1))

    def test_cancels_out_a_right_turn_with_a_left_turn(self):
        rover = Rover()

        rover.turn_right()
        rover.turn_left()
        rover.move()

        self.assertEqual(rover.get_position(), Position(0, 1))

    def test_traces_a_square_back_to_the_origin(self):
        rover = Rover()

        rover.move()
        rover.turn_right()
        rover.move()
        rover.turn_right()
        rover.move()
        rover.turn_right()
        rover.move()

        self.assertEqual(rover.get_position(), Position(0, 0))


if __name__ == "__main__":
    unittest.main()
