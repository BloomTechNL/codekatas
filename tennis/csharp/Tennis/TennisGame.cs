namespace Tennis;

public enum Player
{
    One,
    Two,
}

public interface ITennisGame
{
    void WonPoint(Player player);
    string GetScore();
}

public class Game : ITennisGame
{
    private static readonly string[] PointNames = ["Love", "Fifteen", "Thirty", "Forty"];

    private readonly Dictionary<Player, int> _points = new()
    {
        [Player.One] = 0,
        [Player.Two] = 0,
    };

    public void WonPoint(Player player)
    {
        if (GetScore().StartsWith("Win for"))
        {
            throw new InvalidOperationException("The game has already been won");
        }

        _points[player]++;
    }

    public string GetScore()
    {
        var pointsOne = _points[Player.One];
        var pointsTwo = _points[Player.Two];

        if (pointsOne == pointsTwo)
        {
            return pointsOne < 3 ? $"{PointNames[pointsOne]}-All" : "Deuce";
        }

        if (pointsOne >= 4 || pointsTwo >= 4)
        {
            var leader = pointsOne > pointsTwo ? Player.One : Player.Two;

            return Math.Abs(pointsOne - pointsTwo) == 1
                ? $"Advantage {PlayerName(leader)}"
                : $"Win for {PlayerName(leader)}";
        }

        return $"{PointNames[pointsOne]}-{PointNames[pointsTwo]}";
    }

    private static string PlayerName(Player player) => player == Player.One ? "Player One" : "Player Two";
}
