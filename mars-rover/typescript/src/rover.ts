export interface Position {
  x: number;
  y: number;
}

type Direction = 'north' | 'east' | 'south' | 'west';

export class Rover {
  private position: Position = { x: 0, y: 0 };
  private direction: Direction = 'north';

  getPosition(): Position {
    return this.position;
  }

  turnLeft(): void {
    if (this.direction === 'north') {
      this.direction = 'west';
    } else if (this.direction === 'west') {
      this.direction = 'south';
    } else if (this.direction === 'south') {
      this.direction = 'east';
    } else if (this.direction === 'east') {
      this.direction = 'north';
    }
  }

  turnRight(): void {
    if (this.direction === 'north') {
      this.direction = 'east';
    } else if (this.direction === 'east') {
      this.direction = 'south';
    } else if (this.direction === 'south') {
      this.direction = 'west';
    } else if (this.direction === 'west') {
      this.direction = 'north';
    }
  }

  move(): void {
    if (this.direction === 'north') {
      this.position = { x: this.position.x, y: this.position.y + 1 };
    } else if (this.direction === 'east') {
      this.position = { x: this.position.x + 1, y: this.position.y };
    } else if (this.direction === 'south') {
      this.position = { x: this.position.x, y: this.position.y - 1 };
    } else if (this.direction === 'west') {
      this.position = { x: this.position.x - 1, y: this.position.y };
    }
  }
}
