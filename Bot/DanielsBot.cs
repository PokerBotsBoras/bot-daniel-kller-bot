using System;
using PokerBots.Abstractions;

public class DanielsBot : IPokerBot
{
    private static readonly Random rng = new();

    public string Name => "Daniels Bot";

    // GetAction is called by the game runner, an you need to return what action the bot should take, based on the GameState
    public PokerAction GetAction(GameState state)
    {   
        return new PokerAction { ActionType = PokerActionType.Fold };
    }
}
