﻿using System;
using System.Collections.Generic;

namespace Blackjack
{
    public class Dealer
    {
        public string Name { get; set; }
        public int SkillLevel { get; set; }
        public IGameRules GameMode { get; private set; }

        private Table _table { get; set; }

        public void AssignGameMode(IGameRules gameMode)
        {
            GameMode = gameMode;
        }

        public void AssignTable(Table table)
        {
            _table = table;
        }

        public void IntroduceSelf()
        {
            Logger.Write(Name + " says, \"Hello Everyone, I will be your dealer today. Best of luck!\"");
        }

        public void StartTurn(List<Player> players)
        {
            DealOpenningBlackJackHand(players);
        }

        public void DealOpenningBlackJackHand(List<Player> players)
        {

        }
    }
}
