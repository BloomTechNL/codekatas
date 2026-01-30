#!/usr/bin/env bash

if [ -z "$1" ]; then
  echo "Usage: ./tcr.sh <directory-in-src>"
  echo "Example: ./tcr.sh gilded-rose-refactoring-kata"
  exit 1
fi

DIR="src/$1"

if [ ! -d "$DIR" ]; then
  echo "Error: Directory '$DIR' does not exist"
  exit 1
fi

echo "Running tests for $DIR..."
npx vitest run "$DIR"

TEST_EXIT_CODE=$?

if [ $TEST_EXIT_CODE -ne 0 ]; then
  echo "❌ Tests failed. Reverting non-spec changes in $DIR..."

  git diff --name-only "$DIR" | grep -v '\.spec\.ts$' | xargs -r git checkout --

  git ls-files --others --exclude-standard "$DIR" | grep -v '\.spec\.ts$' | xargs -r rm -f

  echo "Reverted non-spec changes."
  exit 1
else
  echo "✅ Tests passed. Committing changes in $DIR..."

  git add "$DIR"
  git commit -m "Tests passing changes"

  echo "Committed successfully."
fi