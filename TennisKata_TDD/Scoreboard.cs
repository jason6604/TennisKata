using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TennisKata_TDD.Entity;
using TennisKata_TDD.Services;

namespace TennisKata_TDD
{
    public partial class Scoreboard : Form
    {
        protected ScoreBoardService sbService;
        protected Player PlayerOne;
        protected Player PlayerTwo;
        protected string ScoreResult ="";
        protected bool IsStart = false;

        public Scoreboard()
        {
            InitializeComponent();
        }

        public void Init()
        {
            sbService = new ScoreBoardService();
            
            InitLayout();
            ScoreResult1.Anchor = AnchorStyles.None;
            ScoreResult2.Anchor = AnchorStyles.None;

            PanelScore1.Controls.Add(ScoreResult1);
            PanelScore2.Controls.Add(ScoreResult2);
        }

        public void InitLayout()
        {
            ScoreResult1.Left = (PanelScore1.ClientSize.Width - ScoreResult1.Width) / 2;
            ScoreResult1.Top = (PanelScore1.ClientSize.Height - ScoreResult1.Height) / 2;
            ScoreResult2.Left = (PanelScore1.ClientSize.Width - ScoreResult2.Width) / 2;
            ScoreResult2.Top = (PanelScore1.ClientSize.Height - ScoreResult2.Height) / 2;
        }

        private void InitControl()
        {
            textPlayer1.Enabled = !IsStart;
            textPlayer2.Enabled = !IsStart;
            Start.Enabled = !IsStart;
            PlayerAdd1.Enabled = IsStart;
            PlayerAdd2.Enabled = IsStart;
            Start.Enabled = !IsStart;
            End.Enabled = IsStart;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Init();
            InitControl();
        }

        private void Start_Click(object sender, EventArgs e)
        {
            int errorCode = sbService.CheckPlayer(textPlayer1.Text, textPlayer2.Text);
            if (errorCode == 0)
            {
                PlayerOne = new Player();
                PlayerTwo = new Player();

                PlayerOne.Name = textPlayer1.Text;
                PlayerTwo.Name = textPlayer2.Text;
                PlayerName1.Text = "";
                PlayerName2.Text = "";
                ScoreResult2.Text = "--";
                ScoreResult1.Text = "--";
                IsStart = true;
                InitControl();
                InitLayout();
            }
            else
            {
                if(errorCode==1)
                MessageBox.Show("Please Fill the Player's Name", "Alert", MessageBoxButtons.OK);
                if(errorCode==2)
                    MessageBox.Show("Players' Name can't be the Same", "Alert", MessageBoxButtons.OK);
            }
        }

        private void End_Click(object sender, EventArgs e)
        {
            IsStart = false;
            InitControl();
            ScoreResult2.Text = "--";
            ScoreResult1.Text = "--";
            InitLayout();
        }

        private void PlayerAdd1_Click(object sender, EventArgs e)
        {
            Score(PlayerOne);
        }

        private void PlayerAdd2_Click(object sender, EventArgs e)
        {
            Score(PlayerTwo);
        }

        private void Score(Player player)
        {
            player.AddScore();
            ScoreResult = sbService.GetScore(PlayerOne, PlayerTwo);
            var ResultList = ScoreResult.Split(new string[] { ":" }, StringSplitOptions.RemoveEmptyEntries).ToList();

            if (ResultList.Count.Equals(2))
            {
                ScoreResult1.Text = ResultList[0];
                ScoreResult2.Text = ResultList[1];
                InitLayout();
            }

            if (ScoreResult.Contains("Win"))
            {
                IsStart = false;
                InitControl();
                PlayerName1.Text = textPlayer1.Text;
                PlayerName2.Text = textPlayer2.Text;
            }
        }
    }
}
