import unittest

from main import main


class MainTests(unittest.TestCase):
    def test_main_runs(self):
        main()


if __name__ == "__main__":
    unittest.main()
