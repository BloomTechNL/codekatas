import { describe, it, expect } from 'vitest';
import { add } from './string-calculator';

describe('add', () => {
  it('exists', () => {
    expect(typeof add).toBe('function');
  });
});
