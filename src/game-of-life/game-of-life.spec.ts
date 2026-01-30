import { describe, it, expect } from 'vitest';
import { nextGeneration } from './game-of-life';

describe('Game of life', () => {
  it("empty grid stays empty", () => {
    expect(nextGeneration([[0]])).toEqual([[0]]);
  });

});
