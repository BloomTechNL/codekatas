#!/usr/bin/env bash

echo "Running tests..."
npx vitest run

TEST_EXIT_CODE=$?

if [ $TEST_EXIT_CODE -ne 0 ]; then
  echo "❌ Tests failed. Reverting non-spec changes..."

  git diff --name-only | grep -v '\.spec\.ts$' | xargs -r git checkout --

  git ls-files --others --exclude-standard | grep -v '\.spec\.ts$' | xargs -r rm -f

  echo "Reverted non-spec changes."
  exit 1
else
  echo "✅ Tests passed. Committing changes..."

  git add .
  git commit -m "Tests passing changes"

  echo "Committed successfully."
fi