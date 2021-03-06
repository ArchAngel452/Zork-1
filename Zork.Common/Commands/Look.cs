﻿using System;

namespace Zork
{
    [CommandClass]
    public static class LookCommand
    {
        [Command("LOOK", new string[] { "LOOK", "L" })]
        public static void Look(Game game, CommandContext commandContext) => Game.Instance.Output.WriteLine($"{game.Player.Location}\n{game.Player.Location.Description}");
    }
}