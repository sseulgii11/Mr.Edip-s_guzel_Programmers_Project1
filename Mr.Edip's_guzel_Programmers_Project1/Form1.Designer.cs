namespace Mr.Edip_s_guzel_Programmers_Project1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tb1PlayerName = new System.Windows.Forms.TextBox();
            this.tb2PlayerName = new System.Windows.Forms.TextBox();
            this.numberRounds = new System.Windows.Forms.NumericUpDown();
            this.SecondPlayerName = new System.Windows.Forms.Label();
            this.FirstPlayerName = new System.Windows.Forms.Label();
            this.initializationsRounds = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pbDice = new System.Windows.Forms.PictureBox();
            this.buttonRoll = new System.Windows.Forms.Button();
            this.actionTurnIndicator = new System.Windows.Forms.Label();
            this.actionCurrentRound = new System.Windows.Forms.Label();
            this.actionRound = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.pb4Avatar = new System.Windows.Forms.PictureBox();
            this.pb3Avatar = new System.Windows.Forms.PictureBox();
            this.pb2Avatar = new System.Windows.Forms.PictureBox();
            this.pb1Avatar = new System.Windows.Forms.PictureBox();
            this.rb4Avatar = new System.Windows.Forms.RadioButton();
            this.rb3Avatar = new System.Windows.Forms.RadioButton();
            this.rb2Avatar = new System.Windows.Forms.RadioButton();
            this.rb1Avatar = new System.Windows.Forms.RadioButton();
            this.gbPlayer1 = new System.Windows.Forms.GroupBox();
            this.lblPoint1 = new System.Windows.Forms.Label();
            this.lblPlayer1Points = new System.Windows.Forms.Label();
            this.fp1Avatar = new System.Windows.Forms.PictureBox();
            this.gbPlayer2 = new System.Windows.Forms.GroupBox();
            this.lblPoint2 = new System.Windows.Forms.Label();
            this.lblPlayer2Points = new System.Windows.Forms.Label();
            this.sp2Avatar = new System.Windows.Forms.PictureBox();
            this.btnSetUpPlayer1 = new System.Windows.Forms.Button();
            this.btnSetUpPlayer2 = new System.Windows.Forms.Button();
            this.buttonResetAll = new System.Windows.Forms.Button();
            this.buttonStart = new System.Windows.Forms.Button();
            this.buttonShowResult = new System.Windows.Forms.Button();
            this.gbReport = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numberRounds)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbDice)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb4Avatar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb3Avatar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb2Avatar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb1Avatar)).BeginInit();
            this.gbPlayer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fp1Avatar)).BeginInit();
            this.gbPlayer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sp2Avatar)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tb1PlayerName);
            this.groupBox1.Controls.Add(this.tb2PlayerName);
            this.groupBox1.Controls.Add(this.numberRounds);
            this.groupBox1.Controls.Add(this.SecondPlayerName);
            this.groupBox1.Controls.Add(this.FirstPlayerName);
            this.groupBox1.Controls.Add(this.initializationsRounds);
            this.groupBox1.Location = new System.Drawing.Point(6, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(230, 138);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Initializations";
            // 
            // tb1PlayerName
            // 
            this.tb1PlayerName.Location = new System.Drawing.Point(112, 85);
            this.tb1PlayerName.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.tb1PlayerName.Name = "tb1PlayerName";
            this.tb1PlayerName.Size = new System.Drawing.Size(106, 20);
            this.tb1PlayerName.TabIndex = 5;
            this.tb1PlayerName.TextChanged += new System.EventHandler(this.tb1PlayerName_TextChanged);
            // 
            // tb2PlayerName
            // 
            this.tb2PlayerName.Location = new System.Drawing.Point(112, 105);
            this.tb2PlayerName.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.tb2PlayerName.Name = "tb2PlayerName";
            this.tb2PlayerName.Size = new System.Drawing.Size(106, 20);
            this.tb2PlayerName.TabIndex = 4;
            this.tb2PlayerName.TextChanged += new System.EventHandler(this.tb2PlayerName_TextChanged);
            // 
            // numberRounds
            // 
            this.numberRounds.Location = new System.Drawing.Point(49, 23);
            this.numberRounds.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.numberRounds.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numberRounds.Name = "numberRounds";
            this.numberRounds.Size = new System.Drawing.Size(45, 20);
            this.numberRounds.TabIndex = 3;
            this.numberRounds.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // SecondPlayerName
            // 
            this.SecondPlayerName.AutoSize = true;
            this.SecondPlayerName.Location = new System.Drawing.Point(4, 105);
            this.SecondPlayerName.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.SecondPlayerName.Name = "SecondPlayerName";
            this.SecondPlayerName.Size = new System.Drawing.Size(107, 13);
            this.SecondPlayerName.TabIndex = 2;
            this.SecondPlayerName.Text = "Second Player Name";
            // 
            // FirstPlayerName
            // 
            this.FirstPlayerName.AutoSize = true;
            this.FirstPlayerName.Location = new System.Drawing.Point(4, 86);
            this.FirstPlayerName.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.FirstPlayerName.Name = "FirstPlayerName";
            this.FirstPlayerName.Size = new System.Drawing.Size(89, 13);
            this.FirstPlayerName.TabIndex = 1;
            this.FirstPlayerName.Text = "First Player Name";
            // 
            // initializationsRounds
            // 
            this.initializationsRounds.AutoSize = true;
            this.initializationsRounds.Location = new System.Drawing.Point(4, 23);
            this.initializationsRounds.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.initializationsRounds.Name = "initializationsRounds";
            this.initializationsRounds.Size = new System.Drawing.Size(44, 13);
            this.initializationsRounds.TabIndex = 0;
            this.initializationsRounds.Text = "Rounds";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.pbDice);
            this.groupBox2.Controls.Add(this.buttonRoll);
            this.groupBox2.Controls.Add(this.actionTurnIndicator);
            this.groupBox2.Controls.Add(this.actionCurrentRound);
            this.groupBox2.Controls.Add(this.actionRound);
            this.groupBox2.Location = new System.Drawing.Point(6, 180);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.groupBox2.Size = new System.Drawing.Size(230, 216);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Action";
            // 
            // pbDice
            // 
            this.pbDice.BackgroundImage = global::Mr.Edip_s_guzel_Programmers_Project1.Properties.Resources.mickey_clubhouse_0_88521e9b3d8047a7b8edc91a803e1e4c;
            this.pbDice.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbDice.Location = new System.Drawing.Point(69, 134);
            this.pbDice.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.pbDice.Name = "pbDice";
            this.pbDice.Size = new System.Drawing.Size(72, 70);
            this.pbDice.TabIndex = 4;
            this.pbDice.TabStop = false;
            // 
            // buttonRoll
            // 
            this.buttonRoll.Enabled = false;
            this.buttonRoll.Location = new System.Drawing.Point(6, 97);
            this.buttonRoll.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.buttonRoll.Name = "buttonRoll";
            this.buttonRoll.Size = new System.Drawing.Size(216, 22);
            this.buttonRoll.TabIndex = 3;
            this.buttonRoll.Text = "ROLL";
            this.buttonRoll.UseVisualStyleBackColor = true;
            // 
            // actionTurnIndicator
            // 
            this.actionTurnIndicator.AutoSize = true;
            this.actionTurnIndicator.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.actionTurnIndicator.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.actionTurnIndicator.ForeColor = System.Drawing.SystemColors.InfoText;
            this.actionTurnIndicator.Location = new System.Drawing.Point(9, 71);
            this.actionTurnIndicator.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.actionTurnIndicator.Name = "actionTurnIndicator";
            this.actionTurnIndicator.Size = new System.Drawing.Size(100, 17);
            this.actionTurnIndicator.TabIndex = 2;
            this.actionTurnIndicator.Text = "Player Name";
            // 
            // actionCurrentRound
            // 
            this.actionCurrentRound.AutoSize = true;
            this.actionCurrentRound.Location = new System.Drawing.Point(48, 32);
            this.actionCurrentRound.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.actionCurrentRound.Name = "actionCurrentRound";
            this.actionCurrentRound.Size = new System.Drawing.Size(35, 13);
            this.actionCurrentRound.TabIndex = 1;
            this.actionCurrentRound.Text = "label3";
            // 
            // actionRound
            // 
            this.actionRound.AutoSize = true;
            this.actionRound.Location = new System.Drawing.Point(6, 32);
            this.actionRound.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.actionRound.Name = "actionRound";
            this.actionRound.Size = new System.Drawing.Size(42, 13);
            this.actionRound.TabIndex = 0;
            this.actionRound.Text = "Round:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.pb4Avatar);
            this.groupBox3.Controls.Add(this.pb3Avatar);
            this.groupBox3.Controls.Add(this.pb2Avatar);
            this.groupBox3.Controls.Add(this.pb1Avatar);
            this.groupBox3.Controls.Add(this.rb4Avatar);
            this.groupBox3.Controls.Add(this.rb3Avatar);
            this.groupBox3.Controls.Add(this.rb2Avatar);
            this.groupBox3.Controls.Add(this.rb1Avatar);
            this.groupBox3.Location = new System.Drawing.Point(247, 28);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.groupBox3.Size = new System.Drawing.Size(103, 290);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Avatars";
            // 
            // pb4Avatar
            // 
            this.pb4Avatar.Image = global::Mr.Edip_s_guzel_Programmers_Project1.Properties.Resources._142767_goofy;
            this.pb4Avatar.Location = new System.Drawing.Point(26, 215);
            this.pb4Avatar.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.pb4Avatar.Name = "pb4Avatar";
            this.pb4Avatar.Size = new System.Drawing.Size(52, 56);
            this.pb4Avatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb4Avatar.TabIndex = 7;
            this.pb4Avatar.TabStop = false;
            // 
            // pb3Avatar
            // 
            this.pb3Avatar.Image = global::Mr.Edip_s_guzel_Programmers_Project1.Properties.Resources._49929_7_daisy_duck_free_hd_image;
            this.pb3Avatar.Location = new System.Drawing.Point(26, 151);
            this.pb3Avatar.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.pb3Avatar.Name = "pb3Avatar";
            this.pb3Avatar.Size = new System.Drawing.Size(52, 56);
            this.pb3Avatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb3Avatar.TabIndex = 6;
            this.pb3Avatar.TabStop = false;
            // 
            // pb2Avatar
            // 
            this.pb2Avatar.Image = global::Mr.Edip_s_guzel_Programmers_Project1.Properties.Resources.mickey_mouse_icon_3;
            this.pb2Avatar.Location = new System.Drawing.Point(26, 86);
            this.pb2Avatar.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.pb2Avatar.Name = "pb2Avatar";
            this.pb2Avatar.Size = new System.Drawing.Size(52, 56);
            this.pb2Avatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb2Avatar.TabIndex = 5;
            this.pb2Avatar.TabStop = false;
            // 
            // pb1Avatar
            // 
            this.pb1Avatar.Image = global::Mr.Edip_s_guzel_Programmers_Project1.Properties.Resources.minnie_mouse_png_photos_1;
            this.pb1Avatar.Location = new System.Drawing.Point(26, 23);
            this.pb1Avatar.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.pb1Avatar.Name = "pb1Avatar";
            this.pb1Avatar.Size = new System.Drawing.Size(52, 56);
            this.pb1Avatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb1Avatar.TabIndex = 4;
            this.pb1Avatar.TabStop = false;
            // 
            // rb4Avatar
            // 
            this.rb4Avatar.AutoSize = true;
            this.rb4Avatar.ForeColor = System.Drawing.SystemColors.Control;
            this.rb4Avatar.Location = new System.Drawing.Point(12, 235);
            this.rb4Avatar.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.rb4Avatar.Name = "rb4Avatar";
            this.rb4Avatar.Size = new System.Drawing.Size(85, 17);
            this.rb4Avatar.TabIndex = 3;
            this.rb4Avatar.TabStop = true;
            this.rb4Avatar.Text = "radioButton4";
            this.rb4Avatar.UseVisualStyleBackColor = true;
            // 
            // rb3Avatar
            // 
            this.rb3Avatar.AutoSize = true;
            this.rb3Avatar.ForeColor = System.Drawing.SystemColors.Control;
            this.rb3Avatar.Location = new System.Drawing.Point(12, 171);
            this.rb3Avatar.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.rb3Avatar.Name = "rb3Avatar";
            this.rb3Avatar.Size = new System.Drawing.Size(85, 17);
            this.rb3Avatar.TabIndex = 2;
            this.rb3Avatar.TabStop = true;
            this.rb3Avatar.Text = "radioButton3";
            this.rb3Avatar.UseVisualStyleBackColor = true;
            // 
            // rb2Avatar
            // 
            this.rb2Avatar.AutoSize = true;
            this.rb2Avatar.ForeColor = System.Drawing.SystemColors.Control;
            this.rb2Avatar.Location = new System.Drawing.Point(12, 103);
            this.rb2Avatar.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.rb2Avatar.Name = "rb2Avatar";
            this.rb2Avatar.Size = new System.Drawing.Size(85, 17);
            this.rb2Avatar.TabIndex = 1;
            this.rb2Avatar.TabStop = true;
            this.rb2Avatar.Text = "radioButton2";
            this.rb2Avatar.UseVisualStyleBackColor = true;
            // 
            // rb1Avatar
            // 
            this.rb1Avatar.AutoSize = true;
            this.rb1Avatar.ForeColor = System.Drawing.SystemColors.Control;
            this.rb1Avatar.Location = new System.Drawing.Point(12, 34);
            this.rb1Avatar.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.rb1Avatar.Name = "rb1Avatar";
            this.rb1Avatar.Size = new System.Drawing.Size(85, 17);
            this.rb1Avatar.TabIndex = 0;
            this.rb1Avatar.TabStop = true;
            this.rb1Avatar.Text = "radioButton1";
            this.rb1Avatar.UseVisualStyleBackColor = true;
            // 
            // gbPlayer1
            // 
            this.gbPlayer1.Controls.Add(this.lblPoint1);
            this.gbPlayer1.Controls.Add(this.lblPlayer1Points);
            this.gbPlayer1.Controls.Add(this.fp1Avatar);
            this.gbPlayer1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbPlayer1.Location = new System.Drawing.Point(363, 36);
            this.gbPlayer1.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.gbPlayer1.Name = "gbPlayer1";
            this.gbPlayer1.Padding = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.gbPlayer1.Size = new System.Drawing.Size(156, 96);
            this.gbPlayer1.TabIndex = 3;
            this.gbPlayer1.TabStop = false;
            this.gbPlayer1.Text = "PLAYER 1";
            // 
            // lblPoint1
            // 
            this.lblPoint1.AutoSize = true;
            this.lblPoint1.Location = new System.Drawing.Point(72, 28);
            this.lblPoint1.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblPoint1.Name = "lblPoint1";
            this.lblPoint1.Size = new System.Drawing.Size(50, 13);
            this.lblPoint1.TabIndex = 2;
            this.lblPoint1.Text = "POINTS:";
            // 
            // lblPlayer1Points
            // 
            this.lblPlayer1Points.AutoSize = true;
            this.lblPlayer1Points.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayer1Points.Location = new System.Drawing.Point(98, 61);
            this.lblPlayer1Points.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblPlayer1Points.Name = "lblPlayer1Points";
            this.lblPlayer1Points.Size = new System.Drawing.Size(16, 24);
            this.lblPlayer1Points.TabIndex = 1;
            this.lblPlayer1Points.Text = "-";
            // 
            // fp1Avatar
            // 
            this.fp1Avatar.BackgroundImage = global::Mr.Edip_s_guzel_Programmers_Project1.Properties.Resources.Mickey_Mouse_head_and_ears;
            this.fp1Avatar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.fp1Avatar.Location = new System.Drawing.Point(12, 26);
            this.fp1Avatar.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.fp1Avatar.Name = "fp1Avatar";
            this.fp1Avatar.Size = new System.Drawing.Size(54, 57);
            this.fp1Avatar.TabIndex = 0;
            this.fp1Avatar.TabStop = false;
            // 
            // gbPlayer2
            // 
            this.gbPlayer2.Controls.Add(this.lblPoint2);
            this.gbPlayer2.Controls.Add(this.lblPlayer2Points);
            this.gbPlayer2.Controls.Add(this.sp2Avatar);
            this.gbPlayer2.Location = new System.Drawing.Point(363, 140);
            this.gbPlayer2.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.gbPlayer2.Name = "gbPlayer2";
            this.gbPlayer2.Padding = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.gbPlayer2.Size = new System.Drawing.Size(156, 96);
            this.gbPlayer2.TabIndex = 4;
            this.gbPlayer2.TabStop = false;
            this.gbPlayer2.Text = "PLAYER 2";
            // 
            // lblPoint2
            // 
            this.lblPoint2.AutoSize = true;
            this.lblPoint2.Location = new System.Drawing.Point(72, 28);
            this.lblPoint2.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblPoint2.Name = "lblPoint2";
            this.lblPoint2.Size = new System.Drawing.Size(50, 13);
            this.lblPoint2.TabIndex = 2;
            this.lblPoint2.Text = "POINTS:";
            // 
            // lblPlayer2Points
            // 
            this.lblPlayer2Points.AutoSize = true;
            this.lblPlayer2Points.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayer2Points.Location = new System.Drawing.Point(98, 63);
            this.lblPlayer2Points.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblPlayer2Points.Name = "lblPlayer2Points";
            this.lblPlayer2Points.Size = new System.Drawing.Size(17, 24);
            this.lblPlayer2Points.TabIndex = 1;
            this.lblPlayer2Points.Text = "-";
            // 
            // sp2Avatar
            // 
            this.sp2Avatar.BackgroundImage = global::Mr.Edip_s_guzel_Programmers_Project1.Properties.Resources.Mickey_Mouse_head_and_ears;
            this.sp2Avatar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.sp2Avatar.Location = new System.Drawing.Point(13, 28);
            this.sp2Avatar.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.sp2Avatar.Name = "sp2Avatar";
            this.sp2Avatar.Size = new System.Drawing.Size(54, 57);
            this.sp2Avatar.TabIndex = 0;
            this.sp2Avatar.TabStop = false;
            // 
            // btnSetUpPlayer1
            // 
            this.btnSetUpPlayer1.Enabled = false;
            this.btnSetUpPlayer1.Location = new System.Drawing.Point(247, 327);
            this.btnSetUpPlayer1.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.btnSetUpPlayer1.Name = "btnSetUpPlayer1";
            this.btnSetUpPlayer1.Size = new System.Drawing.Size(103, 21);
            this.btnSetUpPlayer1.TabIndex = 5;
            this.btnSetUpPlayer1.Text = "Set Up Player 1";
            this.btnSetUpPlayer1.UseVisualStyleBackColor = true;
            this.btnSetUpPlayer1.Click += new System.EventHandler(this.btnSetUpPlayer1_Click);
            // 
            // btnSetUpPlayer2
            // 
            this.btnSetUpPlayer2.Enabled = false;
            this.btnSetUpPlayer2.Location = new System.Drawing.Point(247, 351);
            this.btnSetUpPlayer2.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.btnSetUpPlayer2.Name = "btnSetUpPlayer2";
            this.btnSetUpPlayer2.Size = new System.Drawing.Size(103, 21);
            this.btnSetUpPlayer2.TabIndex = 6;
            this.btnSetUpPlayer2.Text = "Set Up Player 2";
            this.btnSetUpPlayer2.UseVisualStyleBackColor = true;
            this.btnSetUpPlayer2.Click += new System.EventHandler(this.btnSetUpPlayer2_Click);
            // 
            // buttonResetAll
            // 
            this.buttonResetAll.Location = new System.Drawing.Point(247, 377);
            this.buttonResetAll.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.buttonResetAll.Name = "buttonResetAll";
            this.buttonResetAll.Size = new System.Drawing.Size(102, 19);
            this.buttonResetAll.TabIndex = 7;
            this.buttonResetAll.Text = "RESET ALL";
            this.buttonResetAll.UseVisualStyleBackColor = true;
            // 
            // buttonStart
            // 
            this.buttonStart.Enabled = false;
            this.buttonStart.Location = new System.Drawing.Point(363, 248);
            this.buttonStart.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(156, 51);
            this.buttonStart.TabIndex = 8;
            this.buttonStart.Text = "START";
            this.buttonStart.UseVisualStyleBackColor = true;
           
            // 
            // buttonShowResult
            // 
            this.buttonShowResult.Location = new System.Drawing.Point(532, 306);
            this.buttonShowResult.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.buttonShowResult.Name = "buttonShowResult";
            this.buttonShowResult.Size = new System.Drawing.Size(161, 51);
            this.buttonShowResult.TabIndex = 9;
            this.buttonShowResult.Text = "SHOW RESULT";
            this.buttonShowResult.UseVisualStyleBackColor = true;
            // 
            // gbReport
            // 
            this.gbReport.Location = new System.Drawing.Point(532, 58);
            this.gbReport.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.gbReport.Name = "gbReport";
            this.gbReport.Padding = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.gbReport.Size = new System.Drawing.Size(161, 241);
            this.gbReport.TabIndex = 10;
            this.gbReport.TabStop = false;
            this.gbReport.Text = "REPORT";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 417);
            this.Controls.Add(this.gbReport);
            this.Controls.Add(this.buttonShowResult);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.buttonResetAll);
            this.Controls.Add(this.btnSetUpPlayer2);
            this.Controls.Add(this.btnSetUpPlayer1);
            this.Controls.Add(this.gbPlayer2);
            this.Controls.Add(this.gbPlayer1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Mr.Edip\'s_guzel_Programmers_HigherLuck";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numberRounds)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbDice)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb4Avatar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb3Avatar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb2Avatar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb1Avatar)).EndInit();
            this.gbPlayer1.ResumeLayout(false);
            this.gbPlayer1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fp1Avatar)).EndInit();
            this.gbPlayer2.ResumeLayout(false);
            this.gbPlayer2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sp2Avatar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.PictureBox pb4Avatar;
        private System.Windows.Forms.PictureBox pb3Avatar;
        private System.Windows.Forms.PictureBox pb2Avatar;
        private System.Windows.Forms.PictureBox pb1Avatar;
        private System.Windows.Forms.RadioButton rb4Avatar;
        private System.Windows.Forms.RadioButton rb3Avatar;
        private System.Windows.Forms.RadioButton rb2Avatar;
        private System.Windows.Forms.RadioButton rb1Avatar;
        private System.Windows.Forms.Label initializationsRounds;
        private System.Windows.Forms.Label SecondPlayerName;
        private System.Windows.Forms.Label FirstPlayerName;
        private System.Windows.Forms.NumericUpDown numberRounds;
        private System.Windows.Forms.TextBox tb1PlayerName;
        private System.Windows.Forms.TextBox tb2PlayerName;
        private System.Windows.Forms.Label actionRound;
        private System.Windows.Forms.Label actionCurrentRound;
        private System.Windows.Forms.Label actionTurnIndicator;
        private System.Windows.Forms.Button buttonRoll;
        private System.Windows.Forms.PictureBox pbDice;
        private System.Windows.Forms.GroupBox gbPlayer1;
        private System.Windows.Forms.GroupBox gbPlayer2;
        private System.Windows.Forms.PictureBox fp1Avatar;
        private System.Windows.Forms.PictureBox sp2Avatar;
        private System.Windows.Forms.Label lblPlayer1Points;
        private System.Windows.Forms.Label lblPlayer2Points;
        private System.Windows.Forms.Label lblPoint1;
        private System.Windows.Forms.Label lblPoint2;
        private System.Windows.Forms.Button btnSetUpPlayer1;
        private System.Windows.Forms.Button btnSetUpPlayer2;
        private System.Windows.Forms.Button buttonResetAll;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Button buttonShowResult;
        private System.Windows.Forms.GroupBox gbReport;
    }
}

