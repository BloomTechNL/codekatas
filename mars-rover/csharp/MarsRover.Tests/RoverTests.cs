namespace MarsRover.Tests;

public class RoverTests
{
    [Fact]
    public void StartsAtTheOrigin()
    {
        var rover = new Rover();

        Assert.Equal(new Position(0, 0), rover.GetPosition());
    }

    [Fact]
    public void MovesOneStepForward()
    {
        var rover = new Rover();

        rover.Move();

        Assert.Equal(new Position(0, 1), rover.GetPosition());
    }

    [Fact]
    public void MovesMultipleStepsForward()
    {
        var rover = new Rover();

        rover.Move();
        rover.Move();
        rover.Move();

        Assert.Equal(new Position(0, 3), rover.GetPosition());
    }

    [Fact]
    public void MovesEastAfterTurningRightOnce()
    {
        var rover = new Rover();

        rover.TurnRight();
        rover.Move();

        Assert.Equal(new Position(1, 0), rover.GetPosition());
    }

    [Fact]
    public void MovesSouthAfterTurningRightTwice()
    {
        var rover = new Rover();

        rover.TurnRight();
        rover.TurnRight();
        rover.Move();

        Assert.Equal(new Position(0, -1), rover.GetPosition());
    }

    [Fact]
    public void FacesNorthAgainAfterTurningRightAFullCircle()
    {
        var rover = new Rover();

        rover.TurnRight();
        rover.TurnRight();
        rover.TurnRight();
        rover.TurnRight();
        rover.Move();

        Assert.Equal(new Position(0, 1), rover.GetPosition());
    }

    [Fact]
    public void MovesWestAfterTurningLeftOnce()
    {
        var rover = new Rover();

        rover.TurnLeft();
        rover.Move();

        Assert.Equal(new Position(-1, 0), rover.GetPosition());
    }

    [Fact]
    public void FacesNorthAgainAfterTurningLeftAFullCircle()
    {
        var rover = new Rover();

        rover.TurnLeft();
        rover.TurnLeft();
        rover.TurnLeft();
        rover.TurnLeft();
        rover.Move();

        Assert.Equal(new Position(0, 1), rover.GetPosition());
    }

    [Fact]
    public void CancelsOutARightTurnWithALeftTurn()
    {
        var rover = new Rover();

        rover.TurnRight();
        rover.TurnLeft();
        rover.Move();

        Assert.Equal(new Position(0, 1), rover.GetPosition());
    }

    [Fact]
    public void TracesASquareBackToTheOrigin()
    {
        var rover = new Rover();

        rover.Move();
        rover.TurnRight();
        rover.Move();
        rover.TurnRight();
        rover.Move();
        rover.TurnRight();
        rover.Move();

        Assert.Equal(new Position(0, 0), rover.GetPosition());
    }
}
