# PokerBots.Abstractions

[![NuGet Version](https://img.shields.io/nuget/v/PokerBots.Abstractions?style=flat-square)](https://www.nuget.org/packages/PokerBots.Abstractions/)
[![NuGet Downloads](https://img.shields.io/nuget/dt/PokerBots.Abstractions?style=flat-square)](https://www.nuget.org/packages/PokerBots.Abstractions/)

This package provides the essential **abstract interfaces and data models** required for developing bots in the **PokerBots Borås** programming contest. It ensures compatibility with the official contest environment.

## 🏆 PokerBots Borås Contest

This package is a core component for the [PokerBots Borås](https://pokerbotsboras.grgta.xyz/) contest. Participants will use these abstractions to build their AI poker bots.

## 🚀 Getting Started

### Installation

To add `PokerBots.Abstractions` to your C# project, use the NuGet Package Manager.

**Using the .NET CLI:**
```bash
dotnet add package PokerBots.Abstractions
```
*(For a specific version, add `--version X.Y.Z`)*

### Key Abstractions

This package provides the following main types and interfaces for your bot:

*   `IPokerBot`: The primary interface your bot class must implement.
*   `PokerAction`: Defines the actions your bot can take (Fold, Call, Raise).
*   `GameState`: Represents the current state of the poker game.
*   `Card`: Represents a standard playing card.

**Example Bot Structure:**

```csharp
using PokerBots.Abstractions;
using System; // For Console.WriteLine

public class MyPokerBot : IPokerBot
{
    public string Name => "MyAwesomeBot";

    public PokerAction GetAction(GameState state)
    {
        // Your bot's poker logic goes here.
        // Use 'state' to make decisions.
        // Return an instance of PokerAction.
        
        Console.WriteLine($"My card: {state.MyCard}. Pot: {state.Pot}");
        return new PokerAction { ActionType = PokerActionType.Fold }; // Placeholder action
    }
}
```

## 📄 More Information

For complete contest rules, detailed usage, and the contest-supplied repository, please visit the official [PokerBots Borås website](https://pokerbotsboras.grgta.xyz/).

---