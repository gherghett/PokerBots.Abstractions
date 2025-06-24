using System.Collections.Generic;

namespace PokerBots.Abstractions;

// Bots/IPokerBot.cs
// namespace TournamentRunner.Bots

public interface IPokerBot
{
    string Name { get; }
    PokerAction GetAction(GameState state);
}


// Bots/PokerAction.cs
// namespace TournamentRunner.Bots

public enum PokerActionType { Fold, Call, Raise }

public class PokerAction
{
    public PokerActionType ActionType { get; set; }
    public int? Amount { get; set; } // Only for Raise
}


// Bots/GameState.cs
// namespace TournamentRunner.Bots

public class GameState
{
    public int MyStack { get; set; }
    public int OpponentStack { get; set; }
    public int Pot { get; set; }
    public Card MyCard { get; set; }
    public int ToCall { get; set; }
    public int MinRaise { get; set; }
    public List<PokerAction> ActionHistory { get; set; } = new();
}

public class Card
{
    public string Rank { get; set; } // "2" through "A"
    public string Suit { get; set; } // "♠", "♦", etc

    public int GetValue()
    {
        return Rank switch
        {
            "2" => 2,
            "3" => 3,
            "4" => 4,
            "5" => 5,
            "6" => 6,
            "7" => 7,
            "8" => 8,
            "9" => 9,
            "10" => 10,
            "J" => 11,
            "Q" => 12,
            "K" => 13,
            "A" => 14,
            _ => 0
        };
    }

    public override string ToString() => $"{Rank}{Suit}";
}

