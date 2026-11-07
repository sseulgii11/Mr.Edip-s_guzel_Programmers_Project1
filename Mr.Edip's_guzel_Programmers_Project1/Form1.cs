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

        public Form1()
        {
            InitializeComponent();
            SetupInitialState();
        }

        private void SetupInitialState()
        {

            numberRounds.Minimum = 5;
            numberRounds.Maximum = 30;
            numberRounds.Value = 5;

            btnSetUpPlayer1.Enabled = false;
            btnSetUpPlayer2.Enabled = false;
            buttonStart.Enabled = false;
            buttonRoll.Enabled = false;

        }

        private void tb1PlayerName_TextChanged(object sender, EventArgs e)
        {
            btnSetUpPlayer1.Enabled = !string.IsNullOrWhiteSpace(tb1PlayerName.Text);
        }

        private void tb2PlayerName_TextChanged(object sender, EventArgs e)
        {
            btnSetUpPlayer2.Enabled = !string.IsNullOrWhiteSpace(tb2PlayerName.Text);
        }
        private void btnSetUpPlayer1_Click(object sender, EventArgs e)
        {
            int selectedAvatar = 0;
            if (rb1Avatar.Checked) selectedAvatar = 1;
            else if (rb1Avatar.Checked) selectedAvatar = 2;
            else if (rb1Avatar.Checked) selectedAvatar = 3;
            else if (rb1Avatar.Checked) selectedAvatar = 4;

            if (selectedAvatar == 0)
            {
                MessageBox.Show("Please select an avatar for Player 1.", "Avatar Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            player1 = new Player(tb1PlayerName.Text, selectedAvatar);

            tb1PlayerName.Text = player1.Name;
            tb1PlayerName.Enabled = false;
            btnSetUpPlayer1.Enabled = false;

            gbPlayer1.Text = player1.Name;
            fp1Avatar.BackgroundImage = null;
            fp1Avatar.SizeMode = PictureBoxSizeMode.Zoom;

            if (selectedAvatar == 1) fp1Avatar.Image = pb1Avatar.Image;
            else if (selectedAvatar == 2) fp1Avatar.Image = pb2Avatar.Image;
            else if (selectedAvatar == 3) fp1Avatar.Image = pb3Avatar.Image;
            else if (selectedAvatar == 4) fp1Avatar.Image = pb4Avatar.Image;
        }

        private void btnSetUpPlayer2_Click(object sender, EventArgs e)
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

            player2 = new Player(tb2PlayerName.Text, selectedAvatar);

            tb2PlayerName.Text = player2.Name;
            tb2PlayerName.Enabled = false;
            btnSetUpPlayer2.Enabled = false;

            gbPlayer2.Text = player2.Name;
            sp2Avatar.BackgroundImage = null;
            sp2Avatar.SizeMode = PictureBoxSizeMode.Zoom;

            if (selectedAvatar == 1) sp2Avatar.Image = pb1Avatar.Image;
            else if (selectedAvatar == 2) sp2Avatar.Image = pb2Avatar.Image;
            else if (selectedAvatar == 3) sp2Avatar.Image = pb3Avatar.Image;
            else if (selectedAvatar == 4) sp2Avatar.Image = pb4Avatar.Image;

            buttonStart.Enabled = true;
        }

        // task 4
    }
}
