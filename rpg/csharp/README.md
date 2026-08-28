# RPG Combat Kata (C#)

You'll be building an RPG. The rules will be introduced iteration by iteration on slides during the workshop — this repo is just here to get you up and running.

## Setup

Requires the [.NET SDK](https://dotnet.microsoft.com/download) (10.0 or later).

```bash
dotnet restore
```

## Running the tests

```bash
cd Rpg.Tests
dotnet test
```

You should see a single passing test. Start writing your RPG combat logic in `Rpg/Program.cs` and your tests in `Rpg.Tests/ProgramTests.cs` (or split into more files as you go).
