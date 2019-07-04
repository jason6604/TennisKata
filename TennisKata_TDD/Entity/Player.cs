
namespace TennisKata_TDD.Entity
{
    public class Player
    {
        public string Name { get; set; }
        public int Score { get; set; } = 0;
        public void AddScore()
        {
            Score += 1;
        }
    }
}
