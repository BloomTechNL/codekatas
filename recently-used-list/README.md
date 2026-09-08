# Recently Used List Kata

Develop a recently-used-list class to hold strings uniquely in last-in-first-out order.

## Rules

- A recently-used-list is initially empty.
- The most recently added item is first, the least recently added item is last.
- Items can be looked up by index, which counts from zero.
- Items in the list are unique, so adding an item that's already present moves it to the front rather than adding a duplicate.

## TDD discipline

Work in strict red-green-refactor cycles: write one small failing test, write the minimum code to make it pass, refactor, repeat. Do not write more implementation than the current test demands — don't handle a case you haven't written a test for yet.

Your score for this kata is the number of tests that each drove a genuine change to the implementation. A test only counts if it fails (red) before you touch the implementation and passes (green) after a real code change. A test that passes the moment you write it, with no implementation change needed, doesn't count — that's a sign an earlier step over-implemented and solved a case before it was asked for.

For example:
- Write a test for the empty-list case, then implement the whole class in one go. You can no longer write a test that goes red, so your score is 1.
- Write a test for adding one item, implement just enough to pass it, then write a test for adding a second item — if that second test is already green without any code change, it didn't count either. Score is still 1.

The aim is to maximize your score: as many tests as possible, each one earned by writing only the code that test forces you to write.

Pick your language and follow the setup instructions in its subdirectory:

- [python](python/README.md)
