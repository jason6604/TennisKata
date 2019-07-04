using System;
using System.Collections.Generic;
using TennisKata_TDD.Entity;

namespace TennisKata_TDD.Services
{
    public class ScoreBoardService : IScoreBoardService
    {
        private readonly Dictionary<int, string> _dicScore;
        private string _scoreResult = "";

        public ScoreBoardService()
        {
            _dicScore = new Dictionary<int, string>
            {
                {0, "Love"},
                {1, "Fifteen"},
                {2, "Thirty"},
                {3, "Forty"},
                {100, "All"},
                {101, "Deuce"},
                {102, "Win"},
                {103, "Lose"},
                {104, "Adv"},
            };
        }

        public string GetScore(Player player1, Player player2)
        {
            if ((player1.Score > 3 || player2.Score > 3))
            {
                if(!IsDeuce(player1, player2, out _scoreResult))
                    _scoreResult = GetWinLose(player1, player2);
            }
            else
            {
                if (!IsDeuce(player1, player2, out _scoreResult))
                    _scoreResult = player1.Score == player2.Score 
                    ? _dicScore[player1.Score] + ':' + _dicScore[100] 
                    : _dicScore[player1.Score] + ':' + _dicScore[player2.Score];
            }

            return _scoreResult;
        }

        public string GetWinLose(Player player1, Player player2)
        {
                _scoreResult = player1.Score > player2.Score
                    ? _dicScore[102] + ':' + _dicScore[103]
                    : _dicScore[103] + ':' + _dicScore[102];

            return _scoreResult;
        }

        public bool IsDeuce(Player player1, Player player2, out string result)
        {
            result = player1.Score == player2.Score
                    ? _dicScore[101] + ':' + _dicScore[101]
                    : player1.Score > player2.Score
                        ? player1.Name + ':' + _dicScore[104]
                        : player2.Name + ':' + _dicScore[104];

            return (player1.Score>2 && player2.Score>2 && Math.Abs(player1.Score- player2.Score)<=1);
        }

        public int CheckPlayer(string player1,string player2)
        {
            if (player1.Equals("") || player2.Equals(""))
            {
                return 1;
            }
            else if(player1 == player2)
            {
                return 2;
            }
                return 0;
        }
    }
}
