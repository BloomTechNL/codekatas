import unittest

from tennis_game import Game, Player, TennisGame


class GameTests(unittest.TestCase):
    def test_returns_love_all_when_no_points_have_been_scored(self):
        game = Game()

        self.assertEqual(game.get_score(), "Love-All")

    def test_returns_fifteen_love_after_player_one_wins_a_point(self):
        game = Game()

        game.won_point(Player.ONE)

        self.assertEqual(game.get_score(), "Fifteen-Love")

    def test_returns_love_fifteen_after_player_two_wins_a_point(self):
        game = Game()

        game.won_point(Player.TWO)

        self.assertEqual(game.get_score(), "Love-Fifteen")

    def test_returns_thirty_love_after_player_one_wins_two_points(self):
        game = Game()

        game.won_point(Player.ONE)
        game.won_point(Player.ONE)

        self.assertEqual(game.get_score(), "Thirty-Love")

    def test_returns_forty_love_after_player_one_wins_three_points(self):
        game = Game()

        game.won_point(Player.ONE)
        game.won_point(Player.ONE)
        game.won_point(Player.ONE)

        self.assertEqual(game.get_score(), "Forty-Love")

    def test_returns_fifteen_all_after_both_players_win_a_point_each(self):
        game = Game()

        game.won_point(Player.ONE)
        game.won_point(Player.TWO)

        self.assertEqual(game.get_score(), "Fifteen-All")

    def test_returns_thirty_all_after_both_players_win_two_points_each(self):
        game = Game()

        game.won_point(Player.ONE)
        game.won_point(Player.ONE)
        game.won_point(Player.TWO)
        game.won_point(Player.TWO)

        self.assertEqual(game.get_score(), "Thirty-All")

    def test_returns_thirty_fifteen_after_player_one_wins_two_points_and_player_two_wins_one(self):
        game = Game()

        game.won_point(Player.ONE)
        game.won_point(Player.ONE)
        game.won_point(Player.TWO)

        self.assertEqual(game.get_score(), "Thirty-Fifteen")

    def test_returns_deuce_after_both_players_win_three_points_each(self):
        game = Game()

        game.won_point(Player.ONE)
        game.won_point(Player.ONE)
        game.won_point(Player.ONE)
        game.won_point(Player.TWO)
        game.won_point(Player.TWO)
        game.won_point(Player.TWO)

        self.assertEqual(game.get_score(), "Deuce")

    def test_returns_advantage_player_one_after_player_one_wins_a_point_at_deuce(self):
        game = Game()

        game.won_point(Player.ONE)
        game.won_point(Player.ONE)
        game.won_point(Player.ONE)
        game.won_point(Player.TWO)
        game.won_point(Player.TWO)
        game.won_point(Player.TWO)
        game.won_point(Player.ONE)

        self.assertEqual(game.get_score(), "Advantage Player One")

    def test_returns_deuce_again_after_player_two_wins_a_point_at_advantage_player_one(self):
        game = Game()

        game.won_point(Player.ONE)
        game.won_point(Player.ONE)
        game.won_point(Player.ONE)
        game.won_point(Player.TWO)
        game.won_point(Player.TWO)
        game.won_point(Player.TWO)
        game.won_point(Player.ONE)
        game.won_point(Player.TWO)

        self.assertEqual(game.get_score(), "Deuce")

    def test_returns_win_for_player_one_after_player_one_wins_four_points_to_love(self):
        game = Game()

        game.won_point(Player.ONE)
        game.won_point(Player.ONE)
        game.won_point(Player.ONE)
        game.won_point(Player.ONE)

        self.assertEqual(game.get_score(), "Win for Player One")

    def test_returns_win_for_player_one_after_player_one_wins_a_point_at_advantage_player_one(self):
        game = Game()

        game.won_point(Player.ONE)
        game.won_point(Player.ONE)
        game.won_point(Player.ONE)
        game.won_point(Player.TWO)
        game.won_point(Player.TWO)
        game.won_point(Player.TWO)
        game.won_point(Player.ONE)
        game.won_point(Player.ONE)

        self.assertEqual(game.get_score(), "Win for Player One")

    def test_can_be_driven_through_the_tennis_game_protocol_alone(self):
        game: TennisGame = Game()

        game.won_point(Player.TWO)

        self.assertEqual(game.get_score(), "Love-Fifteen")

    def test_raises_when_a_point_is_awarded_after_the_game_has_already_been_won(self):
        game = Game()

        game.won_point(Player.ONE)
        game.won_point(Player.ONE)
        game.won_point(Player.ONE)
        game.won_point(Player.ONE)

        with self.assertRaises(RuntimeError):
            game.won_point(Player.TWO)


if __name__ == "__main__":
    unittest.main()
