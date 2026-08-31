namespace Tennis.Tests;

public class GameTests
{
    [Fact]
    public void ReturnsLoveAllWhenNoPointsHaveBeenScored()
    {
        var game = new Game();

        Assert.Equal("Love-All", game.GetScore());
    }

    [Fact]
    public void ReturnsFifteenLoveAfterPlayerOneWinsAPoint()
    {
        var game = new Game();

        game.WonPoint(Player.One);

        Assert.Equal("Fifteen-Love", game.GetScore());
    }

    [Fact]
    public void ReturnsLoveFifteenAfterPlayerTwoWinsAPoint()
    {
        var game = new Game();

        game.WonPoint(Player.Two);

        Assert.Equal("Love-Fifteen", game.GetScore());
    }

    [Fact]
    public void ReturnsThirtyLoveAfterPlayerOneWinsTwoPoints()
    {
        var game = new Game();

        game.WonPoint(Player.One);
        game.WonPoint(Player.One);

        Assert.Equal("Thirty-Love", game.GetScore());
    }

    [Fact]
    public void ReturnsFortyLoveAfterPlayerOneWinsThreePoints()
    {
        var game = new Game();

        game.WonPoint(Player.One);
        game.WonPoint(Player.One);
        game.WonPoint(Player.One);

        Assert.Equal("Forty-Love", game.GetScore());
    }

    [Fact]
    public void ReturnsFifteenAllAfterBothPlayersWinAPointEach()
    {
        var game = new Game();

        game.WonPoint(Player.One);
        game.WonPoint(Player.Two);

        Assert.Equal("Fifteen-All", game.GetScore());
    }

    [Fact]
    public void ReturnsThirtyAllAfterBothPlayersWinTwoPointsEach()
    {
        var game = new Game();

        game.WonPoint(Player.One);
        game.WonPoint(Player.One);
        game.WonPoint(Player.Two);
        game.WonPoint(Player.Two);

        Assert.Equal("Thirty-All", game.GetScore());
    }

    [Fact]
    public void ReturnsThirtyFifteenAfterPlayerOneWinsTwoPointsAndPlayerTwoWinsOne()
    {
        var game = new Game();

        game.WonPoint(Player.One);
        game.WonPoint(Player.One);
        game.WonPoint(Player.Two);

        Assert.Equal("Thirty-Fifteen", game.GetScore());
    }

    [Fact]
    public void ReturnsDeuceAfterBothPlayersWinThreePointsEach()
    {
        var game = new Game();

        game.WonPoint(Player.One);
        game.WonPoint(Player.One);
        game.WonPoint(Player.One);
        game.WonPoint(Player.Two);
        game.WonPoint(Player.Two);
        game.WonPoint(Player.Two);

        Assert.Equal("Deuce", game.GetScore());
    }

    [Fact]
    public void ReturnsAdvantagePlayerOneAfterPlayerOneWinsAPointAtDeuce()
    {
        var game = new Game();

        game.WonPoint(Player.One);
        game.WonPoint(Player.One);
        game.WonPoint(Player.One);
        game.WonPoint(Player.Two);
        game.WonPoint(Player.Two);
        game.WonPoint(Player.Two);
        game.WonPoint(Player.One);

        Assert.Equal("Advantage Player One", game.GetScore());
    }

    [Fact]
    public void ReturnsDeuceAgainAfterPlayerTwoWinsAPointAtAdvantagePlayerOne()
    {
        var game = new Game();

        game.WonPoint(Player.One);
        game.WonPoint(Player.One);
        game.WonPoint(Player.One);
        game.WonPoint(Player.Two);
        game.WonPoint(Player.Two);
        game.WonPoint(Player.Two);
        game.WonPoint(Player.One);
        game.WonPoint(Player.Two);

        Assert.Equal("Deuce", game.GetScore());
    }

    [Fact]
    public void ReturnsWinForPlayerOneAfterPlayerOneWinsFourPointsToLove()
    {
        var game = new Game();

        game.WonPoint(Player.One);
        game.WonPoint(Player.One);
        game.WonPoint(Player.One);
        game.WonPoint(Player.One);

        Assert.Equal("Win for Player One", game.GetScore());
    }

    [Fact]
    public void ReturnsWinForPlayerOneAfterPlayerOneWinsAPointAtAdvantagePlayerOne()
    {
        var game = new Game();

        game.WonPoint(Player.One);
        game.WonPoint(Player.One);
        game.WonPoint(Player.One);
        game.WonPoint(Player.Two);
        game.WonPoint(Player.Two);
        game.WonPoint(Player.Two);
        game.WonPoint(Player.One);
        game.WonPoint(Player.One);

        Assert.Equal("Win for Player One", game.GetScore());
    }

    [Fact]
    public void CanBeDrivenThroughTheITennisGameInterfaceAlone()
    {
        ITennisGame game = new Game();

        game.WonPoint(Player.Two);

        Assert.Equal("Love-Fifteen", game.GetScore());
    }

    [Fact]
    public void ThrowsWhenAPointIsAwardedAfterTheGameHasAlreadyBeenWon()
    {
        var game = new Game();

        game.WonPoint(Player.One);
        game.WonPoint(Player.One);
        game.WonPoint(Player.One);
        game.WonPoint(Player.One);

        Assert.Throws<InvalidOperationException>(() => game.WonPoint(Player.Two));
    }
}
