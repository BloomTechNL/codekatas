export enum Player {
  One,
  Two,
}

export interface TennisGame {
  wonPoint(player: Player): void;
  getScore(): string;
}

const POINT_NAMES = ['Love', 'Fifteen', 'Thirty', 'Forty'];

export class Game implements TennisGame {
  private readonly points: [number, number] = [0, 0];

  wonPoint(player: Player): void {
    if (this.getScore().startsWith('Win for')) {
      throw new Error('The game has already been won');
    }

    this.points[player]++;
  }

  getScore(): string {
    const [pointsOne, pointsTwo] = this.points;

    if (pointsOne === pointsTwo) {
      return pointsOne < 3 ? `${POINT_NAMES[pointsOne]}-All` : 'Deuce';
    }

    if (pointsOne >= 4 || pointsTwo >= 4) {
      const leader = pointsOne > pointsTwo ? Player.One : Player.Two;

      return Math.abs(pointsOne - pointsTwo) === 1
        ? `Advantage ${this.playerName(leader)}`
        : `Win for ${this.playerName(leader)}`;
    }

    return `${POINT_NAMES[pointsOne]}-${POINT_NAMES[pointsTwo]}`;
  }

  private playerName(player: Player): string {
    return player === Player.One ? 'Player One' : 'Player Two';
  }
}
