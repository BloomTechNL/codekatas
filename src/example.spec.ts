import { describe, it, expect } from 'vitest';
import { add, multiply } from './example';

describe('Math functions', () => {
  it('should add two numbers', () => {
    expect(add(2, 3)).toBe(5);
  });

  it('should add two numbers', () => {
    expect(add(2, 10)).toBe(12);
  });

  it('should multiply two numbers', () => {
    expect(multiply(2, 3)).toBe(6);
  });
});
