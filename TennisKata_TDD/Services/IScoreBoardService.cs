using TennisKata_TDD.Entity;

namespace TennisKata_TDD.Services
{
    interface IScoreBoardService
    {
        string GetScore(Player player1, Player player2);
        string GetWinLose(Player player1, Player player2);
        bool IsDeuce(Player player1, Player player2, out string result);
    }
}
