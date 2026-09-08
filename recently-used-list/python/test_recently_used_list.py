import unittest

from recently_used_list import RecentlyUsedList


class RecentlyUsedListTests(unittest.TestCase):
    def test_can_be_constructed(self):
        RecentlyUsedList()


if __name__ == "__main__":
    unittest.main()
