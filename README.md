# Ngp

[![](https://img.shields.io/nuget/v/Ngp.svg?logo=nuget)](https://www.nuget.org/packages/Ngp) 

**Ngp** is a C# library available on NuGet that parses PGN (Portable Game Notation) strings and converts them into structured C# objects. It's ideal for chess-related applications like bots, analysis tools, or storage systems.

## 📦 Installation

Using the .NET CLI:

```bash
dotnet add package Ngp
```

Using the Package Manager

```bash
Install-Package Ngp
```

## 🧩 Example Usage
```csharp
using Ngp;

string pgnText = @"
[Event ""F/S Return Match""]
[Site ""Belgrade, Serbia JUG""]
[Date ""1992.11.04""]
[Round ""29""]
[White ""Fischer, Robert J.""]
[Black ""Spassky, Boris V.""]
[Result ""1/2-1/2""]

1. e4 e5 2. Nf3 Nc6 3. Bb5 a6 4. Ba4 Nf6
";

Pgn game = Pgn.Convert(pgnText);

Console.WriteLine(game.White); // Fischer, Robert J.
```

The Pgn class can be seen [here](https://github.com/NormanFrieman/Ngp/blob/main/src/Ngp/Pgn.cs)
