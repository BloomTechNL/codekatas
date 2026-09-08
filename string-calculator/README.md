# String Calculator Kata

Implement a single `add` function that takes a string of numbers and returns their sum.

## Rules

- `add("")` returns `0`.
- `add("1")` returns the number itself, e.g. `1`.
- `add("1,2")` returns the sum of the two numbers, e.g. `3`.
- `add` handles an unknown amount of comma-separated numbers, e.g. `"1,2,3,4"` returns `10`.
- Newlines between numbers are allowed instead of commas, e.g. `"1\n2,3"` returns `6`. (You don't need to support a string ending in a newline or comma.)
- The delimiter can be changed. A custom delimiter is specified on its own first line, in the format `"//<delimiter>\n<numbers>"`, e.g. `"//;\n1;2"` returns `3`.
- A custom delimiter can be more than one character long when wrapped in brackets, e.g. `"//[***]\n1***2***3"` returns `6`.
- There can be multiple delimiters at once, each wrapped in brackets, e.g. `"//[*][%]\n1*2%3"` returns `6`. This includes multiple delimiters longer than one character.
- Passing a negative number raises an exception whose message names that number, e.g. `"negatives not allowed: -2"`. If multiple negatives are passed, the message names all of them.
- Numbers bigger than 1000 are ignored, e.g. `"2,1001"` returns `2`.

## TDD discipline

Work in strict red-green-refactor cycles: write one small failing test, write the minimum code to make it pass, refactor, repeat. Do not write more implementation than the current test demands — don't handle a case you haven't written a test for yet.

Your score for this kata is the number of tests that each drove a genuine change to the implementation. A test only counts if it fails (red) before you touch the implementation and passes (green) after a real code change. A test that passes the moment you write it, with no implementation change needed, doesn't count — that's a sign an earlier step over-implemented and solved a case before it was asked for.

For example, if you write a test for `add("")` and implement the whole rule set in one go, you can no longer write a test that goes red, so your score is 1. The aim is to maximize your score: as many tests as possible, each one earned by writing only the code that test forces you to write.

This kata has more than one axis to apply zero/one/many along — the count of numbers being summed, the number and length of delimiters, and the number of negatives collected into one exception — so look for opportunities to triangulate along each of them separately rather than jumping straight to the general case.

Pick your language and follow the setup instructions in its subdirectory:

- [python](python/README.md)
