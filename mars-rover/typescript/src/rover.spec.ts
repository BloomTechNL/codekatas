import { describe, it, expect } from 'vitest';
import { Rover } from './rover';

describe('Rover', () => {
  it('starts at the origin', () => {
    const rover = new Rover();

    expect(rover.getPosition()).toEqual({ x: 0, y: 0 });
  });

  it('moves one step forward', () => {
    const rover = new Rover();

    rover.move();

    expect(rover.getPosition()).toEqual({ x: 0, y: 1 });
  });

  it('moves multiple steps forward', () => {
    const rover = new Rover();

    rover.move();
    rover.move();
    rover.move();

    expect(rover.getPosition()).toEqual({ x: 0, y: 3 });
  });

  it('moves east after turning right once', () => {
    const rover = new Rover();

    rover.turnRight();
    rover.move();

    expect(rover.getPosition()).toEqual({ x: 1, y: 0 });
  });

  it('moves south after turning right twice', () => {
    const rover = new Rover();

    rover.turnRight();
    rover.turnRight();
    rover.move();

    expect(rover.getPosition()).toEqual({ x: 0, y: -1 });
  });

  it('faces north again after turning right a full circle', () => {
    const rover = new Rover();

    rover.turnRight();
    rover.turnRight();
    rover.turnRight();
    rover.turnRight();
    rover.move();

    expect(rover.getPosition()).toEqual({ x: 0, y: 1 });
  });

  it('moves west after turning left once', () => {
    const rover = new Rover();

    rover.turnLeft();
    rover.move();

    expect(rover.getPosition()).toEqual({ x: -1, y: 0 });
  });

  it('faces north again after turning left a full circle', () => {
    const rover = new Rover();

    rover.turnLeft();
    rover.turnLeft();
    rover.turnLeft();
    rover.turnLeft();
    rover.move();

    expect(rover.getPosition()).toEqual({ x: 0, y: 1 });
  });

  it('cancels out a right turn with a left turn', () => {
    const rover = new Rover();

    rover.turnRight();
    rover.turnLeft();
    rover.move();

    expect(rover.getPosition()).toEqual({ x: 0, y: 1 });
  });

  it('traces a square back to the origin', () => {
    const rover = new Rover();

    rover.move();
    rover.turnRight();
    rover.move();
    rover.turnRight();
    rover.move();
    rover.turnRight();
    rover.move();

    expect(rover.getPosition()).toEqual({ x: 0, y: 0 });
  });
});
