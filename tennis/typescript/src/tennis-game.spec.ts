import { describe, it, expect } from 'vitest';
import { Game, Player, TennisGame } from './tennis-game';

describe('Game', () => {
  it('returns Love-All when no points have been scored', () => {
    const game = new Game();

    expect(game.getScore()).toBe('Love-All');
  });

  it('returns Fifteen-Love after player one wins a point', () => {
    const game = new Game();

    game.wonPoint(Player.One);

    expect(game.getScore()).toBe('Fifteen-Love');
  });

  it('returns Love-Fifteen after player two wins a point', () => {
    const game = new Game();

    game.wonPoint(Player.Two);

    expect(game.getScore()).toBe('Love-Fifteen');
  });

  it('returns Thirty-Love after player one wins two points', () => {
    const game = new Game();

    game.wonPoint(Player.One);
    game.wonPoint(Player.One);

    expect(game.getScore()).toBe('Thirty-Love');
  });

  it('returns Forty-Love after player one wins three points', () => {
    const game = new Game();

    game.wonPoint(Player.One);
    game.wonPoint(Player.One);
    game.wonPoint(Player.One);

    expect(game.getScore()).toBe('Forty-Love');
  });

  it('returns Fifteen-All after both players win a point each', () => {
    const game = new Game();

    game.wonPoint(Player.One);
    game.wonPoint(Player.Two);

    expect(game.getScore()).toBe('Fifteen-All');
  });

  it('returns Thirty-All after both players win two points each', () => {
    const game = new Game();

    game.wonPoint(Player.One);
    game.wonPoint(Player.One);
    game.wonPoint(Player.Two);
    game.wonPoint(Player.Two);

    expect(game.getScore()).toBe('Thirty-All');
  });

  it('returns Thirty-Fifteen after player one wins two points and player two wins one', () => {
    const game = new Game();

    game.wonPoint(Player.One);
    game.wonPoint(Player.One);
    game.wonPoint(Player.Two);

    expect(game.getScore()).toBe('Thirty-Fifteen');
  });

  it('returns Deuce after both players win three points each', () => {
    const game = new Game();

    game.wonPoint(Player.One);
    game.wonPoint(Player.One);
    game.wonPoint(Player.One);
    game.wonPoint(Player.Two);
    game.wonPoint(Player.Two);
    game.wonPoint(Player.Two);

    expect(game.getScore()).toBe('Deuce');
  });

  it('returns Advantage Player One after player one wins a point at deuce', () => {
    const game = new Game();

    game.wonPoint(Player.One);
    game.wonPoint(Player.One);
    game.wonPoint(Player.One);
    game.wonPoint(Player.Two);
    game.wonPoint(Player.Two);
    game.wonPoint(Player.Two);
    game.wonPoint(Player.One);

    expect(game.getScore()).toBe('Advantage Player One');
  });

  it('returns Deuce again after player two wins a point at advantage player one', () => {
    const game = new Game();

    game.wonPoint(Player.One);
    game.wonPoint(Player.One);
    game.wonPoint(Player.One);
    game.wonPoint(Player.Two);
    game.wonPoint(Player.Two);
    game.wonPoint(Player.Two);
    game.wonPoint(Player.One);
    game.wonPoint(Player.Two);

    expect(game.getScore()).toBe('Deuce');
  });

  it('returns Win for Player One after player one wins four points to love', () => {
    const game = new Game();

    game.wonPoint(Player.One);
    game.wonPoint(Player.One);
    game.wonPoint(Player.One);
    game.wonPoint(Player.One);

    expect(game.getScore()).toBe('Win for Player One');
  });

  it('returns Win for Player One after player one wins a point at advantage player one', () => {
    const game = new Game();

    game.wonPoint(Player.One);
    game.wonPoint(Player.One);
    game.wonPoint(Player.One);
    game.wonPoint(Player.Two);
    game.wonPoint(Player.Two);
    game.wonPoint(Player.Two);
    game.wonPoint(Player.One);
    game.wonPoint(Player.One);

    expect(game.getScore()).toBe('Win for Player One');
  });

  it('can be driven through the TennisGame contract alone', () => {
    const game: TennisGame = new Game();

    game.wonPoint(Player.Two);

    expect(game.getScore()).toBe('Love-Fifteen');
  });

  it('throws when a point is awarded after the game has already been won', () => {
    const game = new Game();

    game.wonPoint(Player.One);
    game.wonPoint(Player.One);
    game.wonPoint(Player.One);
    game.wonPoint(Player.One);

    expect(() => game.wonPoint(Player.Two)).toThrow();
  });
});
