using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mr.Edip_s_guzel_Programmers_Project1
{
    public partial class Form1 : Form
    {

        private Player player1;
        private Player player2;

        private int totalRounds;
        private int currentRound;
        private Player currentPlayer;

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
    }
}
