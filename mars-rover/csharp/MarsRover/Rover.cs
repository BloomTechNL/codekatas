namespace MarsRover;

public record Position(int X, int Y);

public enum Direction
{
    North,
    East,
    South,
    West,
}

public class Rover
{
    private Position _position = new(0, 0);
    private Direction _direction = Direction.North;

    public Position GetPosition() => _position;

    public void TurnLeft()
    {
        if (_direction == Direction.North)
        {
            _direction = Direction.West;
        }
        else if (_direction == Direction.West)
        {
            _direction = Direction.South;
        }
        else if (_direction == Direction.South)
        {
            _direction = Direction.East;
        }
        else if (_direction == Direction.East)
        {
            _direction = Direction.North;
        }
    }

    public void TurnRight()
    {
        if (_direction == Direction.North)
        {
            _direction = Direction.East;
        }
        else if (_direction == Direction.East)
        {
            _direction = Direction.South;
        }
        else if (_direction == Direction.South)
        {
            _direction = Direction.West;
        }
        else if (_direction == Direction.West)
        {
            _direction = Direction.North;
        }
    }

    public void Move()
    {
        if (_direction == Direction.North)
        {
            _position = new Position(_position.X, _position.Y + 1);
        }
        else if (_direction == Direction.East)
        {
            _position = new Position(_position.X + 1, _position.Y);
        }
        else if (_direction == Direction.South)
        {
            _position = new Position(_position.X, _position.Y - 1);
        }
        else if (_direction == Direction.West)
        {
            _position = new Position(_position.X - 1, _position.Y);
        }
    }
}
