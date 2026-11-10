using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Mr.Edip_s_guzel_Programmers_Project1
{
    public partial class Form1 : Form
    {

        private Player player1;
        private Player player2;

        private int totalRounds;
        private int currentRound;
        private Player currentPlayer;

        private Random random = new Random();
        private int player1Roll;
        private int player2Roll;

        public Form1()
        {
            InitializeComponent();
            SetupInitialState();
        }

        private void SetupInitialState()
        {

            numberRounds.Minimum = 5;
            numberRounds.Maximum = 10;
            numberRounds.Value = 5;

            BtnSetUpPlayer1.Enabled = false;
            BtnSetUpPlayer2.Enabled = false;
            buttonStart.Enabled = false;
            buttonRoll.Enabled = false;

        }

        private void ResetGame()

        {
            player1 = null;
            player2 = null;

            Tb1PlayerName.Clear();
            Tb1PlayerName.Enabled = true;
            Tb2PlayerName.Clear();
            Tb2PlayerName.Enabled = true;

            gbPlayer1.Text = "Player 1";
            gbPlayer2.Text = "Player 2";
            lblPlayer1Points.Text = "-";
            lblPlayer2Points.Text = "-";

            fp1Avatar.Image = Properties.Resources.Mickey_Mouse_head_and_ears;
            sp2Avatar.Image = Properties.Resources.Mickey_Mouse_head_and_ears;
            pbDice.Image = Properties.Resources.mickey_clubhouse_0_88521e9b3d8047a7b8edc91a803e1e4c;
            actionCurrentRound.Text = "0";
            actionTurnIndicator.Text = "Player Name";

            numberRounds.Enabled = true;
            foreach (RadioButton rb in new[] { rb1Avatar, rb2Avatar, rb3Avatar, rb4Avatar })
            {
                rb.Checked = false;
                rb.Enabled = true;
            }

            SetupInitialState();
        }


        private void Tb1PlayerName_TextChanged(object sender, EventArgs e)
        {
            BtnSetUpPlayer1.Enabled = !string.IsNullOrWhiteSpace(Tb1PlayerName.Text);
        }

        private void Tb2PlayerName_TextChanged(object sender, EventArgs e)
        {
            BtnSetUpPlayer2.Enabled = !string.IsNullOrWhiteSpace(Tb2PlayerName.Text);
        }
        private void BtnSetUpPlayer1_Click(object sender, EventArgs e)
        {
            int selectedAvatar = 0;
            if (rb1Avatar.Checked) selectedAvatar = 1;
            else if (rb2Avatar.Checked) selectedAvatar = 2;
            else if (rb3Avatar.Checked) selectedAvatar = 3;
            else if (rb4Avatar.Checked) selectedAvatar = 4;

            if (selectedAvatar == 0)
            {
                MessageBox.Show("Please select an avatar for Player 1.", "Avatar Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            player1 = new Player(Tb1PlayerName.Text, selectedAvatar);

            Tb1PlayerName.Text = player1.Name;
            Tb1PlayerName.Enabled = false;
            BtnSetUpPlayer1.Enabled = false;

            gbPlayer1.Text = player1.Name;
            fp1Avatar.BackgroundImage = null;
            fp1Avatar.SizeMode = PictureBoxSizeMode.Zoom;

            if (selectedAvatar == 1) fp1Avatar.Image = pb1Avatar.Image;
            else if (selectedAvatar == 2) fp1Avatar.Image = pb2Avatar.Image;
            else if (selectedAvatar == 3) fp1Avatar.Image = pb3Avatar.Image;
            else if (selectedAvatar == 4) fp1Avatar.Image = pb4Avatar.Image;
        }

        private void BtnSetUpPlayer2_Click(object sender, EventArgs e)
        {
            int selectedAvatar = 0;
            if (rb1Avatar.Checked) selectedAvatar = 1;
            else if (rb2Avatar.Checked) selectedAvatar = 2;
            else if (rb3Avatar.Checked) selectedAvatar = 3;
            else if (rb4Avatar.Checked) selectedAvatar = 4;

            if (selectedAvatar == 0)
            {
                MessageBox.Show("Please select an avatar!", "Avatar Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (player1 != null && selectedAvatar == player1.AvatarIndex)
            {
                MessageBox.Show("Players cannot select the same avatar!", "Avatar Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            player2 = new Player(Tb2PlayerName.Text, selectedAvatar);

            Tb2PlayerName.Text = player2.Name;
            Tb2PlayerName.Enabled = false;
            BtnSetUpPlayer2.Enabled = false;

            gbPlayer2.Text = player2.Name;
            sp2Avatar.BackgroundImage = null;
            sp2Avatar.SizeMode = PictureBoxSizeMode.Zoom;

            if (selectedAvatar == 1) sp2Avatar.Image = pb1Avatar.Image;
            else if (selectedAvatar == 2) sp2Avatar.Image = pb2Avatar.Image;
            else if (selectedAvatar == 3) sp2Avatar.Image = pb3Avatar.Image;
            else if (selectedAvatar == 4) sp2Avatar.Image = pb4Avatar.Image;

            buttonStart.Enabled = true;
        }

        private void ButtonStart_Click(object sender, EventArgs e)
        {
            if (player1 == null || player2 == null)
            {
                MessageBox.Show("Both players must finish their setup before the game can start.",
                    "Setup Incomplete", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            totalRounds = (int)numberRounds.Value;

            numberRounds.Enabled = false;
            Tb1PlayerName.Enabled = false;
            Tb2PlayerName.Enabled = false;
            BtnSetUpPlayer1.Enabled = false;
            BtnSetUpPlayer2.Enabled = false;
            rb1Avatar.Enabled = false;
            rb2Avatar.Enabled = false;
            rb3Avatar.Enabled = false;
            rb4Avatar.Enabled = false;

            currentRound = 1;
            currentPlayer = player1;

            actionCurrentRound.Text = currentRound.ToString();
            actionTurnIndicator.Text = player1.Name;

            buttonStart.Enabled = false;
            buttonRoll.Enabled = true;
        }

        private void buttonRoll_Click(object sender, EventArgs e)
        {

            if (currentPlayer == player1)
            {
                player1Roll = random.Next(1, 7);
                DisplayDiceImage(player1Roll);

                currentPlayer = player2;
                actionTurnIndicator.Text = player2.Name;
            }
            else if (currentPlayer == player2)
            {
                player2Roll = random.Next(1, 7);
                DisplayDiceImage(player2Roll);
                if (player1Roll > player2Roll)
                {
                    player1.Points++;
                    MessageBox.Show(player1.Name + "wins this Round!");
                }
                else if (player2Roll > player1Roll)
                {
                    player2.Points++;
                    MessageBox.Show(player2.Name + "wins this Round!");
                }
                else
                {
                    player1.Points++;
                    player2.Points++;
                    MessageBox.Show("It's a tie!  both get 1 point");
                }
                lblPlayer1Points.Text = player1.Points.ToString();
                lblPlayer2Points.Text = player2.Points.ToString();




                if ((currentRound < totalRounds))
                {
                    currentRound++;
                    actionCurrentRound.Text = currentRound.ToString();
                    currentPlayer = player1;
                    actionTurnIndicator.Text = player1.Name;

                }

                else
                {

                    buttonRoll.Enabled = false;
                    buttonShowResult.Enabled = true;
                    MessageBox.Show("Game over! click show result");
                }


            }

        }


        private void DisplayDiceImage(int rollValue)
        {
            pbDice.SizeMode = PictureBoxSizeMode.Zoom;
            pbDice.BackgroundImage = null;
            switch (rollValue)
            {

                case 1:
                    pbDice.Image = Properties.Resources.Dice1;
                    break;
                case 2:
                    pbDice.Image = Properties.Resources.Dice2;
                    break;
                case 3:
                    pbDice.Image = Properties.Resources.Dice3;
                    break;
                case 4:
                    pbDice.Image = Properties.Resources.Dice4;
                    break;
                case 5:
                    pbDice.Image = Properties.Resources.Dice5;
                    break;
                case 6:
                    pbDice.Image = Properties.Resources.Dice6;
                    break;
            }
        }
        private void buttonShowResult_Click(object sender, EventArgs e)
        {
            string winner = "";

            if (player1.Points > player2.Points)
            {
                winner = player1.Name + " wins the game! :)";
            }
            else if (player2.Points > player1.Points)
            {
                winner = player2.Name + " wins the game! :)";
            }
            else
            {
                winner = "It's a tie! Player 1 and Player 2 have equal points.";
            }

            string gameSummary = "Player 1: " + player1.Name + " - Points: " + player1.Points + "\n" +
                                 "Player 2: " + player2.Name + " - Points: " + player2.Points + "\n" +
                                 winner; 

            string filePath = "results.txt";

            using (StreamWriter writer = new StreamWriter(filePath, true))
            {
                writer.WriteLine("Date: " + DateTime.Now.ToString());
                writer.WriteLine("Player 1: " + player1.Name + " - Points: " + player1.Points);
                writer.WriteLine("Player 2: " + player2.Name + " - Points: " + player2.Points);
                writer.WriteLine(winner);
                writer.WriteLine("------------------------------");
        }

            ListBox lbReport = gbReport.Controls.OfType<ListBox>().FirstOrDefault();
            if (lbReport == null)
            {
                lbReport = new ListBox();
                lbReport.Dock = DockStyle.Fill;
                gbReport.Controls.Add(lbReport);
            }

            lbReport.Items.Clear();
            foreach (string line in File.ReadAllLines(filePath))
            {
                lbReport.Items.Add(line);
    }

            MessageBox.Show(gameSummary, "Game Result");
            buttonShowResult.Enabled = false;

            ResetGame();
        }
    }
}


