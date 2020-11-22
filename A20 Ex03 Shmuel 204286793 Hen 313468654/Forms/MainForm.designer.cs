using System.Windows.Forms;

namespace A20_Ex03_Shmuel_204286793_Hen_313468654
{
    public partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label birthdayLabel;
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label nameLabel2;
            System.Windows.Forms.Label religionLabel;
            System.Windows.Forms.Label relationshipStatusLabel;
            System.Windows.Forms.Label LanguagesLabel;
            System.Windows.Forms.Label aboutLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.labelMenuBackGround = new System.Windows.Forms.Label();
            this.panelFetcher1 = new System.Windows.Forms.Panel();
            this.labelSubTitleMatchResult = new System.Windows.Forms.Label();
            this.labelIfInterestedExist = new System.Windows.Forms.Label();
            this.labelMatchName5 = new System.Windows.Forms.Label();
            this.labelMatchName4 = new System.Windows.Forms.Label();
            this.labelMatchName3 = new System.Windows.Forms.Label();
            this.labelMatchName2 = new System.Windows.Forms.Label();
            this.labelMatchResultTitle = new System.Windows.Forms.Label();
            this.labelMatchName1 = new System.Windows.Forms.Label();
            this.buttonFindMatch = new System.Windows.Forms.Button();
            this.labelBetweenNumbers = new System.Windows.Forms.Label();
            this.textBoxHighAge = new System.Windows.Forms.TextBox();
            this.textBoxLowAge = new System.Windows.Forms.TextBox();
            this.labelAgeRangeTitle = new System.Windows.Forms.Label();
            this.checkBoxFemale = new System.Windows.Forms.CheckBox();
            this.checkBoxMale = new System.Windows.Forms.CheckBox();
            this.labelInterestedInTitle = new System.Windows.Forms.Label();
            this.labelSubExplantionInMatched = new System.Windows.Forms.Label();
            this.labelMatchedTitle = new System.Windows.Forms.Label();
            this.panelMain = new System.Windows.Forms.Panel();
            this.birthdayFriendNameListBox = new System.Windows.Forms.ListBox();
            this.friendsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.recentPostsListBox = new System.Windows.Forms.ListBox();
            this.postsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.aboutTextBox = new System.Windows.Forms.TextBox();
            this.nameLabel1 = new System.Windows.Forms.Label();
            this.languagesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.relationshipStatusLabel1 = new System.Windows.Forms.Label();
            this.religionLabel1 = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.emailLabel1 = new System.Windows.Forms.Label();
            this.birthdayLabel1 = new System.Windows.Forms.Label();
            this.labelTodayFriendBirthdayTitle = new System.Windows.Forms.Label();
            this.labelRecentPostsTitle = new System.Windows.Forms.Label();
            this.labelAboutMeTitle = new System.Windows.Forms.Label();
            this.labelSelectFindMatch = new System.Windows.Forms.Label();
            this.labelSelectedPopularity = new System.Windows.Forms.Label();
            this.labelBestPicture = new System.Windows.Forms.Label();
            this.labelWorstPicture = new System.Windows.Forms.Label();
            this.labelLikesBestPicture = new System.Windows.Forms.Label();
            this.labelCommentsBestPicture = new System.Windows.Forms.Label();
            this.labelCommentsWorstPicture = new System.Windows.Forms.Label();
            this.labelLikesWorstPicture = new System.Windows.Forms.Label();
            this.labelStatisticsPicture = new System.Windows.Forms.Label();
            this.labelLikesStatisticsPicture = new System.Windows.Forms.Label();
            this.labelCommentsStatisticsPicture = new System.Windows.Forms.Label();
            this.labelBestVideo = new System.Windows.Forms.Label();
            this.labelWorstVideo = new System.Windows.Forms.Label();
            this.labelBestPost = new System.Windows.Forms.Label();
            this.labelWorstPost = new System.Windows.Forms.Label();
            this.labelLikesBestVideo = new System.Windows.Forms.Label();
            this.labelCommentsBestVideo = new System.Windows.Forms.Label();
            this.labelCommentsWorstVideo = new System.Windows.Forms.Label();
            this.labelLikesWorstVideo = new System.Windows.Forms.Label();
            this.labelStatisticsVideo = new System.Windows.Forms.Label();
            this.labelLikesStatisticsVideo = new System.Windows.Forms.Label();
            this.labelCommentsStatisticsVideo = new System.Windows.Forms.Label();
            this.labelLikesBestPost = new System.Windows.Forms.Label();
            this.labelCommentsBestPost = new System.Windows.Forms.Label();
            this.labelCommentsWorstPost = new System.Windows.Forms.Label();
            this.labelLikesWorstPost = new System.Windows.Forms.Label();
            this.labelStatisticsPost = new System.Windows.Forms.Label();
            this.labelLikesStatisticsPost = new System.Windows.Forms.Label();
            this.labelCommentsStatisticsPost = new System.Windows.Forms.Label();
            this.panelFecher2Results = new System.Windows.Forms.Panel();
            this.panelFetcher2ResultPost = new System.Windows.Forms.Panel();
            this.labelWorstPostContent = new System.Windows.Forms.Label();
            this.labelBestPostContent = new System.Windows.Forms.Label();
            this.pictureBoxStatisticsPost = new System.Windows.Forms.PictureBox();
            this.pictureBoxCommentsStatisticsPost = new System.Windows.Forms.PictureBox();
            this.pictureBoxLikesStatisticsPost = new System.Windows.Forms.PictureBox();
            this.pictureBoxCommentsWorstPost = new System.Windows.Forms.PictureBox();
            this.pictureBoxLikesWorstPost = new System.Windows.Forms.PictureBox();
            this.pictureBoxLikesBestPost = new System.Windows.Forms.PictureBox();
            this.pictureBoxCommentsBestPost = new System.Windows.Forms.PictureBox();
            this.pictureBoxWorstPost = new A20_Ex03_Shmuel_204286793_Hen_313468654.EllipseLoadingAndGrowingPictureBox();
            this.pictureBoxBestPost = new A20_Ex03_Shmuel_204286793_Hen_313468654.EllipseLoadingAndGrowingPictureBox();
            this.panelFetcher2ResultVideo = new System.Windows.Forms.Panel();
            this.pictureBoxStatisticsVideo = new System.Windows.Forms.PictureBox();
            this.pictureBoxCommentsStatisticsVideo = new System.Windows.Forms.PictureBox();
            this.pictureBoxLikesStatisticsVideo = new System.Windows.Forms.PictureBox();
            this.pictureBoxCommentsWorstVideo = new System.Windows.Forms.PictureBox();
            this.pictureBoxLikesWorstVideo = new System.Windows.Forms.PictureBox();
            this.pictureBoxLikesBestVideo = new System.Windows.Forms.PictureBox();
            this.pictureBoxCommentsBestVideo = new System.Windows.Forms.PictureBox();
            this.pictureBoxWorstVideo = new A20_Ex03_Shmuel_204286793_Hen_313468654.EllipseLoadingAndGrowingPictureBox();
            this.pictureBoxBestVideo = new A20_Ex03_Shmuel_204286793_Hen_313468654.EllipseLoadingAndGrowingPictureBox();
            this.panelFetcher2ResultPhoto = new System.Windows.Forms.Panel();
            this.pictureBoxStatisticsPicture = new System.Windows.Forms.PictureBox();
            this.pictureBoxCommentsStatisticsPicture = new System.Windows.Forms.PictureBox();
            this.pictureBoxLikesStatisticsPicture = new System.Windows.Forms.PictureBox();
            this.pictureBoxCommentsWorstPicture = new System.Windows.Forms.PictureBox();
            this.pictureBoxLikesWorstPicture = new System.Windows.Forms.PictureBox();
            this.pictureBoxLikesBestPicture = new System.Windows.Forms.PictureBox();
            this.pictureBoxCommentsBestPicture = new System.Windows.Forms.PictureBox();
            this.pictureBoxWorstPicture = new A20_Ex03_Shmuel_204286793_Hen_313468654.EllipseLoadingAndGrowingPictureBox();
            this.pictureBoxBestPicture = new A20_Ex03_Shmuel_204286793_Hen_313468654.EllipseLoadingAndGrowingPictureBox();
            this.labelTitleFindPopularity = new System.Windows.Forms.Label();
            this.labelSubTitleOfFindPopualrity = new System.Windows.Forms.Label();
            this.panelFetcher2Choice = new System.Windows.Forms.Panel();
            this.buttonFindOut = new System.Windows.Forms.Button();
            this.labelSelectedMainPage = new System.Windows.Forms.Label();
            this.panelHelloUser = new System.Windows.Forms.Panel();
            this.labelWelcome = new System.Windows.Forms.Label();
            this.nameLabel5 = new System.Windows.Forms.Label();
            this.imageNormalEllipseLoadingAndGrowingPictureBox = new A20_Ex03_Shmuel_204286793_Hen_313468654.EllipseLoadingAndGrowingPictureBox();
            this.buttonMainPage = new System.Windows.Forms.Button();
            this.buttonFetcher2 = new System.Windows.Forms.Button();
            this.buttonFetcher1 = new System.Windows.Forms.Button();
            this.buttonLogOut = new System.Windows.Forms.Button();
            this.bestOrWorstMatchesLabel = new System.Windows.Forms.Label();
            this.comboBoxBestOrWorstMatches = new System.Windows.Forms.ComboBox();
            birthdayLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            nameLabel2 = new System.Windows.Forms.Label();
            religionLabel = new System.Windows.Forms.Label();
            relationshipStatusLabel = new System.Windows.Forms.Label();
            LanguagesLabel = new System.Windows.Forms.Label();
            aboutLabel = new System.Windows.Forms.Label();
            this.panelFetcher1.SuspendLayout();
            this.panelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.friendsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.postsBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.languagesBindingSource)).BeginInit();
            this.panelFecher2Results.SuspendLayout();
            this.panelFetcher2ResultPost.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxStatisticsPost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCommentsStatisticsPost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLikesStatisticsPost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCommentsWorstPost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLikesWorstPost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLikesBestPost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCommentsBestPost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWorstPost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBestPost)).BeginInit();
            this.panelFetcher2ResultVideo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxStatisticsVideo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCommentsStatisticsVideo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLikesStatisticsVideo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCommentsWorstVideo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLikesWorstVideo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLikesBestVideo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCommentsBestVideo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWorstVideo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBestVideo)).BeginInit();
            this.panelFetcher2ResultPhoto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxStatisticsPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCommentsStatisticsPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLikesStatisticsPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCommentsWorstPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLikesWorstPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLikesBestPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCommentsBestPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWorstPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBestPicture)).BeginInit();
            this.panelFetcher2Choice.SuspendLayout();
            this.panelHelloUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageNormalEllipseLoadingAndGrowingPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // birthdayLabel
            // 
            birthdayLabel.AutoSize = true;
            birthdayLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            birthdayLabel.Location = new System.Drawing.Point(15, 68);
            birthdayLabel.Name = "birthdayLabel";
            birthdayLabel.Size = new System.Drawing.Size(93, 25);
            birthdayLabel.TabIndex = 2;
            birthdayLabel.Text = "Birthday:";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            emailLabel.Location = new System.Drawing.Point(15, 20);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(64, 25);
            emailLabel.TabIndex = 9;
            emailLabel.Text = "Email:";
            // 
            // nameLabel2
            // 
            nameLabel2.AutoSize = true;
            nameLabel2.Location = new System.Drawing.Point(15, 164);
            nameLabel2.Name = "nameLabel2";
            nameLabel2.Size = new System.Drawing.Size(94, 25);
            nameLabel2.TabIndex = 11;
            nameLabel2.Text = "Location:";
            // 
            // religionLabel
            // 
            religionLabel.AutoSize = true;
            religionLabel.Location = new System.Drawing.Point(15, 212);
            religionLabel.Name = "religionLabel";
            religionLabel.Size = new System.Drawing.Size(90, 25);
            religionLabel.TabIndex = 12;
            religionLabel.Text = "Religion:";
            // 
            // relationshipStatusLabel
            // 
            relationshipStatusLabel.AutoSize = true;
            relationshipStatusLabel.Location = new System.Drawing.Point(15, 260);
            relationshipStatusLabel.Name = "relationshipStatusLabel";
            relationshipStatusLabel.Size = new System.Drawing.Size(126, 25);
            relationshipStatusLabel.TabIndex = 13;
            relationshipStatusLabel.Text = "Relationship:";
            // 
            // LanguagesLabel
            // 
            LanguagesLabel.AutoSize = true;
            LanguagesLabel.Location = new System.Drawing.Point(15, 116);
            LanguagesLabel.Name = "LanguagesLabel";
            LanguagesLabel.Size = new System.Drawing.Size(105, 25);
            LanguagesLabel.TabIndex = 15;
            LanguagesLabel.Text = "Language:";
            // 
            // aboutLabel
            // 
            aboutLabel.AutoSize = true;
            aboutLabel.Location = new System.Drawing.Point(15, 308);
            aboutLabel.Name = "aboutLabel";
            aboutLabel.Size = new System.Drawing.Size(73, 25);
            aboutLabel.TabIndex = 16;
            aboutLabel.Text = "About:";
            // 
            // labelMenuBackGround
            // 
            this.labelMenuBackGround.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(103)))), ((int)(((byte)(178)))));
            this.labelMenuBackGround.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMenuBackGround.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(119)))), ((int)(((byte)(242)))));
            this.labelMenuBackGround.Location = new System.Drawing.Point(0, 0);
            this.labelMenuBackGround.Name = "labelMenuBackGround";
            this.labelMenuBackGround.Size = new System.Drawing.Size(1129, 81);
            this.labelMenuBackGround.TabIndex = 1;
            // 
            // panelFetcher1
            // 
            this.panelFetcher1.AutoScroll = true;
            this.panelFetcher1.AutoSize = true;
            this.panelFetcher1.Controls.Add(this.comboBoxBestOrWorstMatches);
            this.panelFetcher1.Controls.Add(this.bestOrWorstMatchesLabel);
            this.panelFetcher1.Controls.Add(this.labelSubTitleMatchResult);
            this.panelFetcher1.Controls.Add(this.labelIfInterestedExist);
            this.panelFetcher1.Controls.Add(this.labelMatchName5);
            this.panelFetcher1.Controls.Add(this.labelMatchName4);
            this.panelFetcher1.Controls.Add(this.labelMatchName3);
            this.panelFetcher1.Controls.Add(this.labelMatchName2);
            this.panelFetcher1.Controls.Add(this.labelMatchResultTitle);
            this.panelFetcher1.Controls.Add(this.labelMatchName1);
            this.panelFetcher1.Controls.Add(this.buttonFindMatch);
            this.panelFetcher1.Controls.Add(this.labelBetweenNumbers);
            this.panelFetcher1.Controls.Add(this.textBoxHighAge);
            this.panelFetcher1.Controls.Add(this.textBoxLowAge);
            this.panelFetcher1.Controls.Add(this.labelAgeRangeTitle);
            this.panelFetcher1.Controls.Add(this.checkBoxFemale);
            this.panelFetcher1.Controls.Add(this.checkBoxMale);
            this.panelFetcher1.Controls.Add(this.labelInterestedInTitle);
            this.panelFetcher1.Controls.Add(this.labelSubExplantionInMatched);
            this.panelFetcher1.Controls.Add(this.labelMatchedTitle);
            this.panelFetcher1.Location = new System.Drawing.Point(0, 81);
            this.panelFetcher1.Name = "panelFetcher1";
            this.panelFetcher1.Size = new System.Drawing.Size(1124, 551);
            this.panelFetcher1.TabIndex = 8;
            // 
            // labelSubTitleMatchResult
            // 
            this.labelSubTitleMatchResult.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.labelSubTitleMatchResult.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelSubTitleMatchResult.ForeColor = System.Drawing.Color.Black;
            this.labelSubTitleMatchResult.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelSubTitleMatchResult.Location = new System.Drawing.Point(576, 59);
            this.labelSubTitleMatchResult.Name = "labelSubTitleMatchResult";
            this.labelSubTitleMatchResult.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelSubTitleMatchResult.Size = new System.Drawing.Size(510, 36);
            this.labelSubTitleMatchResult.TabIndex = 25;
            this.labelSubTitleMatchResult.Text = "Click on Picture to send a massage from facebook NOW";
            this.labelSubTitleMatchResult.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelSubTitleMatchResult.Visible = false;
            // 
            // labelIfInterestedExist
            // 
            this.labelIfInterestedExist.BackColor = System.Drawing.Color.White;
            this.labelIfInterestedExist.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIfInterestedExist.ForeColor = System.Drawing.Color.Black;
            this.labelIfInterestedExist.Location = new System.Drawing.Point(229, 175);
            this.labelIfInterestedExist.Name = "labelIfInterestedExist";
            this.labelIfInterestedExist.Size = new System.Drawing.Size(159, 25);
            this.labelIfInterestedExist.TabIndex = 24;
            this.labelIfInterestedExist.Text = "to see";
            this.labelIfInterestedExist.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelIfInterestedExist.Visible = false;
            // 
            // labelMatchName5
            // 
            this.labelMatchName5.BackColor = System.Drawing.Color.White;
            this.labelMatchName5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMatchName5.ForeColor = System.Drawing.Color.Black;
            this.labelMatchName5.Location = new System.Drawing.Point(848, 445);
            this.labelMatchName5.Name = "labelMatchName5";
            this.labelMatchName5.Size = new System.Drawing.Size(128, 25);
            this.labelMatchName5.TabIndex = 23;
            this.labelMatchName5.Text = "to see";
            this.labelMatchName5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelMatchName5.Visible = false;
            // 
            // labelMatchName4
            // 
            this.labelMatchName4.BackColor = System.Drawing.Color.White;
            this.labelMatchName4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMatchName4.ForeColor = System.Drawing.Color.Black;
            this.labelMatchName4.Location = new System.Drawing.Point(672, 445);
            this.labelMatchName4.Name = "labelMatchName4";
            this.labelMatchName4.Size = new System.Drawing.Size(128, 25);
            this.labelMatchName4.TabIndex = 22;
            this.labelMatchName4.Text = "to see";
            this.labelMatchName4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelMatchName4.Visible = false;
            // 
            // labelMatchName3
            // 
            this.labelMatchName3.BackColor = System.Drawing.Color.White;
            this.labelMatchName3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMatchName3.ForeColor = System.Drawing.Color.Black;
            this.labelMatchName3.Location = new System.Drawing.Point(936, 237);
            this.labelMatchName3.Name = "labelMatchName3";
            this.labelMatchName3.Size = new System.Drawing.Size(128, 25);
            this.labelMatchName3.TabIndex = 21;
            this.labelMatchName3.Text = "to see";
            this.labelMatchName3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelMatchName3.Visible = false;
            // 
            // labelMatchName2
            // 
            this.labelMatchName2.BackColor = System.Drawing.Color.White;
            this.labelMatchName2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMatchName2.ForeColor = System.Drawing.Color.Black;
            this.labelMatchName2.Location = new System.Drawing.Point(763, 237);
            this.labelMatchName2.Name = "labelMatchName2";
            this.labelMatchName2.Size = new System.Drawing.Size(128, 25);
            this.labelMatchName2.TabIndex = 20;
            this.labelMatchName2.Text = "to see";
            this.labelMatchName2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelMatchName2.Visible = false;
            // 
            // labelMatchResultTitle
            // 
            this.labelMatchResultTitle.AutoSize = true;
            this.labelMatchResultTitle.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelMatchResultTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(119)))), ((int)(((byte)(242)))));
            this.labelMatchResultTitle.Location = new System.Drawing.Point(681, 16);
            this.labelMatchResultTitle.Name = "labelMatchResultTitle";
            this.labelMatchResultTitle.Size = new System.Drawing.Size(322, 45);
            this.labelMatchResultTitle.TabIndex = 15;
            this.labelMatchResultTitle.Text = "Your 5 Best Matches";
            this.labelMatchResultTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelMatchResultTitle.Visible = false;
            // 
            // labelMatchName1
            // 
            this.labelMatchName1.BackColor = System.Drawing.Color.White;
            this.labelMatchName1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMatchName1.ForeColor = System.Drawing.Color.Black;
            this.labelMatchName1.Location = new System.Drawing.Point(591, 237);
            this.labelMatchName1.Name = "labelMatchName1";
            this.labelMatchName1.Size = new System.Drawing.Size(128, 25);
            this.labelMatchName1.TabIndex = 13;
            this.labelMatchName1.Text = "to see";
            this.labelMatchName1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelMatchName1.Visible = false;
            // 
            // buttonFindMatch
            // 
            this.buttonFindMatch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(103)))), ((int)(((byte)(178)))));
            this.buttonFindMatch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonFindMatch.FlatAppearance.BorderSize = 0;
            this.buttonFindMatch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFindMatch.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.buttonFindMatch.ForeColor = System.Drawing.Color.White;
            this.buttonFindMatch.Image = global::A20_Ex03_Shmuel_204286793_Hen_313468654.Properties.Resources.worker;
            this.buttonFindMatch.Location = new System.Drawing.Point(6, 325);
            this.buttonFindMatch.Name = "buttonFindMatch";
            this.buttonFindMatch.Size = new System.Drawing.Size(388, 108);
            this.buttonFindMatch.TabIndex = 11;
            this.buttonFindMatch.Text = "Click To Find";
            this.buttonFindMatch.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonFindMatch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonFindMatch.UseVisualStyleBackColor = false;
            this.buttonFindMatch.Click += new System.EventHandler(this.buttonFindMatch_Click);
            // 
            // labelBetweenNumbers
            // 
            this.labelBetweenNumbers.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelBetweenNumbers.ForeColor = System.Drawing.Color.Black;
            this.labelBetweenNumbers.Location = new System.Drawing.Point(181, 210);
            this.labelBetweenNumbers.Name = "labelBetweenNumbers";
            this.labelBetweenNumbers.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelBetweenNumbers.Size = new System.Drawing.Size(20, 35);
            this.labelBetweenNumbers.TabIndex = 10;
            this.labelBetweenNumbers.Text = "-";
            this.labelBetweenNumbers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBoxHighAge
            // 
            this.textBoxHighAge.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.textBoxHighAge.Location = new System.Drawing.Point(207, 216);
            this.textBoxHighAge.Name = "textBoxHighAge";
            this.textBoxHighAge.Size = new System.Drawing.Size(35, 29);
            this.textBoxHighAge.TabIndex = 9;
            this.textBoxHighAge.Text = "0";
            // 
            // textBoxLowAge
            // 
            this.textBoxLowAge.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.textBoxLowAge.Location = new System.Drawing.Point(139, 216);
            this.textBoxLowAge.Name = "textBoxLowAge";
            this.textBoxLowAge.Size = new System.Drawing.Size(36, 29);
            this.textBoxLowAge.TabIndex = 8;
            this.textBoxLowAge.Text = "0";
            // 
            // labelAgeRangeTitle
            // 
            this.labelAgeRangeTitle.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelAgeRangeTitle.ForeColor = System.Drawing.Color.Black;
            this.labelAgeRangeTitle.Location = new System.Drawing.Point(17, 210);
            this.labelAgeRangeTitle.Name = "labelAgeRangeTitle";
            this.labelAgeRangeTitle.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelAgeRangeTitle.Size = new System.Drawing.Size(126, 35);
            this.labelAgeRangeTitle.TabIndex = 7;
            this.labelAgeRangeTitle.Text = "Age range:";
            this.labelAgeRangeTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // checkBoxFemale
            // 
            this.checkBoxFemale.AutoSize = true;
            this.checkBoxFemale.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.checkBoxFemale.Location = new System.Drawing.Point(315, 173);
            this.checkBoxFemale.Name = "checkBoxFemale";
            this.checkBoxFemale.Size = new System.Drawing.Size(79, 25);
            this.checkBoxFemale.TabIndex = 6;
            this.checkBoxFemale.Text = "Female";
            this.checkBoxFemale.UseVisualStyleBackColor = true;
            // 
            // checkBoxMale
            // 
            this.checkBoxMale.AutoSize = true;
            this.checkBoxMale.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.checkBoxMale.Location = new System.Drawing.Point(246, 173);
            this.checkBoxMale.Name = "checkBoxMale";
            this.checkBoxMale.Size = new System.Drawing.Size(63, 25);
            this.checkBoxMale.TabIndex = 5;
            this.checkBoxMale.Text = "Male";
            this.checkBoxMale.UseVisualStyleBackColor = true;
            // 
            // labelInterestedInTitle
            // 
            this.labelInterestedInTitle.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelInterestedInTitle.ForeColor = System.Drawing.Color.Black;
            this.labelInterestedInTitle.Location = new System.Drawing.Point(14, 165);
            this.labelInterestedInTitle.Name = "labelInterestedInTitle";
            this.labelInterestedInTitle.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelInterestedInTitle.Size = new System.Drawing.Size(228, 35);
            this.labelInterestedInTitle.TabIndex = 4;
            this.labelInterestedInTitle.Text = "You are interested in:";
            this.labelInterestedInTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelSubExplantionInMatched
            // 
            this.labelSubExplantionInMatched.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelSubExplantionInMatched.ForeColor = System.Drawing.Color.Black;
            this.labelSubExplantionInMatched.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelSubExplantionInMatched.Location = new System.Drawing.Point(12, 97);
            this.labelSubExplantionInMatched.Name = "labelSubExplantionInMatched";
            this.labelSubExplantionInMatched.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelSubExplantionInMatched.Size = new System.Drawing.Size(350, 58);
            this.labelSubExplantionInMatched.TabIndex = 3;
            this.labelSubExplantionInMatched.Text = "Please fill in all fields";
            this.labelSubExplantionInMatched.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelMatchedTitle
            // 
            this.labelMatchedTitle.AutoSize = true;
            this.labelMatchedTitle.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelMatchedTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(119)))), ((int)(((byte)(242)))));
            this.labelMatchedTitle.Location = new System.Drawing.Point(11, 16);
            this.labelMatchedTitle.Name = "labelMatchedTitle";
            this.labelMatchedTitle.Size = new System.Drawing.Size(383, 45);
            this.labelMatchedTitle.TabIndex = 2;
            this.labelMatchedTitle.Text = "Let\'s find your next date";
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.birthdayFriendNameListBox);
            this.panelMain.Controls.Add(this.recentPostsListBox);
            this.panelMain.Controls.Add(this.panel1);
            this.panelMain.Controls.Add(this.labelTodayFriendBirthdayTitle);
            this.panelMain.Controls.Add(this.labelRecentPostsTitle);
            this.panelMain.Controls.Add(this.labelAboutMeTitle);
            this.panelMain.Location = new System.Drawing.Point(0, 83);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(1127, 549);
            this.panelMain.TabIndex = 11;
            // 
            // birthdayFriendNameListBox
            // 
            this.birthdayFriendNameListBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.friendsBindingSource, "Name", true, System.Windows.Forms.DataSourceUpdateMode.Never, "No birthday Today"));
            this.birthdayFriendNameListBox.DataSource = this.friendsBindingSource;
            this.birthdayFriendNameListBox.DisplayMember = "Name";
            this.birthdayFriendNameListBox.Enabled = false;
            this.birthdayFriendNameListBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.birthdayFriendNameListBox.FormattingEnabled = true;
            this.birthdayFriendNameListBox.ItemHeight = 21;
            this.birthdayFriendNameListBox.Location = new System.Drawing.Point(761, 121);
            this.birthdayFriendNameListBox.Name = "birthdayFriendNameListBox";
            this.birthdayFriendNameListBox.Size = new System.Drawing.Size(338, 382);
            this.birthdayFriendNameListBox.TabIndex = 24;
            // 
            // friendsBindingSource
            // 
            this.friendsBindingSource.DataSource = this.userBindingSource;
            // 
            // userBindingSource
            // 
            this.userBindingSource.DataSource = typeof(FacebookWrapper.ObjectModel.User);
            // 
            // recentPostsListBox
            // 
            this.recentPostsListBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.postsBindingSource, "Message", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, "Status without Text"));
            this.recentPostsListBox.DataSource = this.postsBindingSource;
            this.recentPostsListBox.DisplayMember = "Message";
            this.recentPostsListBox.Enabled = false;
            this.recentPostsListBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.recentPostsListBox.FormattingEnabled = true;
            this.recentPostsListBox.ItemHeight = 21;
            this.recentPostsListBox.Location = new System.Drawing.Point(375, 121);
            this.recentPostsListBox.Name = "recentPostsListBox";
            this.recentPostsListBox.Size = new System.Drawing.Size(338, 382);
            this.recentPostsListBox.TabIndex = 23;
            // 
            // postsBindingSource
            // 
            this.postsBindingSource.DataMember = "Posts";
            this.postsBindingSource.DataSource = this.userBindingSource;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(aboutLabel);
            this.panel1.Controls.Add(this.aboutTextBox);
            this.panel1.Controls.Add(LanguagesLabel);
            this.panel1.Controls.Add(this.nameLabel1);
            this.panel1.Controls.Add(relationshipStatusLabel);
            this.panel1.Controls.Add(this.relationshipStatusLabel1);
            this.panel1.Controls.Add(religionLabel);
            this.panel1.Controls.Add(this.religionLabel1);
            this.panel1.Controls.Add(nameLabel2);
            this.panel1.Controls.Add(this.nameTextBox);
            this.panel1.Controls.Add(emailLabel);
            this.panel1.Controls.Add(this.emailLabel1);
            this.panel1.Controls.Add(birthdayLabel);
            this.panel1.Controls.Add(this.birthdayLabel1);
            this.panel1.Font = new System.Drawing.Font("Segoe UI", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.panel1.Location = new System.Drawing.Point(11, 121);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(322, 382);
            this.panel1.TabIndex = 22;
            // 
            // aboutTextBox
            // 
            this.aboutTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "About", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, "Not Provided"));
            this.aboutTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.aboutTextBox.Location = new System.Drawing.Point(94, 305);
            this.aboutTextBox.Name = "aboutTextBox";
            this.aboutTextBox.Size = new System.Drawing.Size(143, 29);
            this.aboutTextBox.TabIndex = 17;
            // 
            // nameLabel1
            // 
            this.nameLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.languagesBindingSource, "Name", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, "Not Provided"));
            this.nameLabel1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.nameLabel1.Location = new System.Drawing.Point(126, 118);
            this.nameLabel1.Name = "nameLabel1";
            this.nameLabel1.Size = new System.Drawing.Size(100, 23);
            this.nameLabel1.TabIndex = 16;
            this.nameLabel1.Text = "label1";
            // 
            // languagesBindingSource
            // 
            this.languagesBindingSource.DataMember = "Languages";
            this.languagesBindingSource.DataSource = this.userBindingSource;
            // 
            // relationshipStatusLabel1
            // 
            this.relationshipStatusLabel1.AutoSize = true;
            this.relationshipStatusLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "RelationshipStatus", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, "Not Provided"));
            this.relationshipStatusLabel1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.relationshipStatusLabel1.Location = new System.Drawing.Point(147, 263);
            this.relationshipStatusLabel1.Name = "relationshipStatusLabel1";
            this.relationshipStatusLabel1.Size = new System.Drawing.Size(51, 21);
            this.relationshipStatusLabel1.TabIndex = 14;
            this.relationshipStatusLabel1.Text = "label1";
            // 
            // religionLabel1
            // 
            this.religionLabel1.AutoSize = true;
            this.religionLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "Religion", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, "Not Provided"));
            this.religionLabel1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.religionLabel1.Location = new System.Drawing.Point(111, 215);
            this.religionLabel1.Name = "religionLabel1";
            this.religionLabel1.Size = new System.Drawing.Size(51, 21);
            this.religionLabel1.TabIndex = 13;
            this.religionLabel1.Text = "label1";
            // 
            // nameTextBox
            // 
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "Location.Name", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, "Not Provided"));
            this.nameTextBox.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.nameTextBox.Location = new System.Drawing.Point(115, 164);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(122, 29);
            this.nameTextBox.TabIndex = 12;
            // 
            // emailLabel1
            // 
            this.emailLabel1.AutoSize = true;
            this.emailLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "Email", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, "Not Provided"));
            this.emailLabel1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.emailLabel1.Location = new System.Drawing.Point(85, 23);
            this.emailLabel1.Name = "emailLabel1";
            this.emailLabel1.Size = new System.Drawing.Size(51, 21);
            this.emailLabel1.TabIndex = 10;
            this.emailLabel1.Text = "label1";
            // 
            // birthdayLabel1
            // 
            this.birthdayLabel1.AutoSize = true;
            this.birthdayLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "Birthday", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, "Not Provided"));
            this.birthdayLabel1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.birthdayLabel1.Location = new System.Drawing.Point(113, 71);
            this.birthdayLabel1.Name = "birthdayLabel1";
            this.birthdayLabel1.Size = new System.Drawing.Size(51, 21);
            this.birthdayLabel1.TabIndex = 3;
            this.birthdayLabel1.Text = "label1";
            // 
            // labelTodayFriendBirthdayTitle
            // 
            this.labelTodayFriendBirthdayTitle.AutoSize = true;
            this.labelTodayFriendBirthdayTitle.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelTodayFriendBirthdayTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(119)))), ((int)(((byte)(242)))));
            this.labelTodayFriendBirthdayTitle.Location = new System.Drawing.Point(753, 52);
            this.labelTodayFriendBirthdayTitle.Name = "labelTodayFriendBirthdayTitle";
            this.labelTodayFriendBirthdayTitle.Size = new System.Drawing.Size(352, 45);
            this.labelTodayFriendBirthdayTitle.TabIndex = 5;
            this.labelTodayFriendBirthdayTitle.Text = "Today Friend Birthday";
            // 
            // labelRecentPostsTitle
            // 
            this.labelRecentPostsTitle.AutoSize = true;
            this.labelRecentPostsTitle.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelRecentPostsTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(119)))), ((int)(((byte)(242)))));
            this.labelRecentPostsTitle.Location = new System.Drawing.Point(435, 52);
            this.labelRecentPostsTitle.Name = "labelRecentPostsTitle";
            this.labelRecentPostsTitle.Size = new System.Drawing.Size(208, 45);
            this.labelRecentPostsTitle.TabIndex = 4;
            this.labelRecentPostsTitle.Text = "Recent Posts";
            // 
            // labelAboutMeTitle
            // 
            this.labelAboutMeTitle.AutoSize = true;
            this.labelAboutMeTitle.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelAboutMeTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(119)))), ((int)(((byte)(242)))));
            this.labelAboutMeTitle.Location = new System.Drawing.Point(14, 52);
            this.labelAboutMeTitle.Name = "labelAboutMeTitle";
            this.labelAboutMeTitle.Size = new System.Drawing.Size(171, 45);
            this.labelAboutMeTitle.TabIndex = 3;
            this.labelAboutMeTitle.Text = "About Me";
            // 
            // labelSelectFindMatch
            // 
            this.labelSelectFindMatch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(103)))), ((int)(((byte)(178)))));
            this.labelSelectFindMatch.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSelectFindMatch.ForeColor = System.Drawing.Color.White;
            this.labelSelectFindMatch.Location = new System.Drawing.Point(775, 76);
            this.labelSelectFindMatch.Name = "labelSelectFindMatch";
            this.labelSelectFindMatch.Size = new System.Drawing.Size(105, 5);
            this.labelSelectFindMatch.TabIndex = 9;
            this.labelSelectFindMatch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelSelectedPopularity
            // 
            this.labelSelectedPopularity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(103)))), ((int)(((byte)(178)))));
            this.labelSelectedPopularity.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSelectedPopularity.ForeColor = System.Drawing.Color.White;
            this.labelSelectedPopularity.Location = new System.Drawing.Point(883, 76);
            this.labelSelectedPopularity.Name = "labelSelectedPopularity";
            this.labelSelectedPopularity.Size = new System.Drawing.Size(105, 5);
            this.labelSelectedPopularity.TabIndex = 10;
            this.labelSelectedPopularity.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelBestPicture
            // 
            this.labelBestPicture.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelBestPicture.ForeColor = System.Drawing.Color.Black;
            this.labelBestPicture.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelBestPicture.Location = new System.Drawing.Point(6, 19);
            this.labelBestPicture.Name = "labelBestPicture";
            this.labelBestPicture.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelBestPicture.Size = new System.Drawing.Size(161, 27);
            this.labelBestPicture.TabIndex = 59;
            this.labelBestPicture.Text = "Your best picture";
            this.labelBestPicture.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelWorstPicture
            // 
            this.labelWorstPicture.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelWorstPicture.ForeColor = System.Drawing.Color.Black;
            this.labelWorstPicture.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelWorstPicture.Location = new System.Drawing.Point(178, 19);
            this.labelWorstPicture.Name = "labelWorstPicture";
            this.labelWorstPicture.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelWorstPicture.Size = new System.Drawing.Size(161, 27);
            this.labelWorstPicture.TabIndex = 60;
            this.labelWorstPicture.Text = "Your worst picture";
            this.labelWorstPicture.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelLikesBestPicture
            // 
            this.labelLikesBestPicture.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelLikesBestPicture.ForeColor = System.Drawing.Color.Black;
            this.labelLikesBestPicture.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelLikesBestPicture.Location = new System.Drawing.Point(68, 202);
            this.labelLikesBestPicture.Name = "labelLikesBestPicture";
            this.labelLikesBestPicture.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelLikesBestPicture.Size = new System.Drawing.Size(83, 40);
            this.labelLikesBestPicture.TabIndex = 65;
            this.labelLikesBestPicture.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelCommentsBestPicture
            // 
            this.labelCommentsBestPicture.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelCommentsBestPicture.ForeColor = System.Drawing.Color.Black;
            this.labelCommentsBestPicture.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelCommentsBestPicture.Location = new System.Drawing.Point(68, 248);
            this.labelCommentsBestPicture.Name = "labelCommentsBestPicture";
            this.labelCommentsBestPicture.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelCommentsBestPicture.Size = new System.Drawing.Size(83, 40);
            this.labelCommentsBestPicture.TabIndex = 66;
            this.labelCommentsBestPicture.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelCommentsWorstPicture
            // 
            this.labelCommentsWorstPicture.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelCommentsWorstPicture.ForeColor = System.Drawing.Color.Black;
            this.labelCommentsWorstPicture.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelCommentsWorstPicture.Location = new System.Drawing.Point(247, 248);
            this.labelCommentsWorstPicture.Name = "labelCommentsWorstPicture";
            this.labelCommentsWorstPicture.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelCommentsWorstPicture.Size = new System.Drawing.Size(78, 40);
            this.labelCommentsWorstPicture.TabIndex = 67;
            this.labelCommentsWorstPicture.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelLikesWorstPicture
            // 
            this.labelLikesWorstPicture.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelLikesWorstPicture.ForeColor = System.Drawing.Color.Black;
            this.labelLikesWorstPicture.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelLikesWorstPicture.Location = new System.Drawing.Point(247, 202);
            this.labelLikesWorstPicture.Name = "labelLikesWorstPicture";
            this.labelLikesWorstPicture.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelLikesWorstPicture.Size = new System.Drawing.Size(78, 40);
            this.labelLikesWorstPicture.TabIndex = 68;
            this.labelLikesWorstPicture.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelStatisticsPicture
            // 
            this.labelStatisticsPicture.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelStatisticsPicture.ForeColor = System.Drawing.Color.Black;
            this.labelStatisticsPicture.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelStatisticsPicture.Location = new System.Drawing.Point(146, 308);
            this.labelStatisticsPicture.Name = "labelStatisticsPicture";
            this.labelStatisticsPicture.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelStatisticsPicture.Size = new System.Drawing.Size(95, 40);
            this.labelStatisticsPicture.TabIndex = 69;
            this.labelStatisticsPicture.Text = "Statistics";
            this.labelStatisticsPicture.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelLikesStatisticsPicture
            // 
            this.labelLikesStatisticsPicture.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelLikesStatisticsPicture.ForeColor = System.Drawing.Color.Black;
            this.labelLikesStatisticsPicture.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelLikesStatisticsPicture.Location = new System.Drawing.Point(146, 354);
            this.labelLikesStatisticsPicture.Name = "labelLikesStatisticsPicture";
            this.labelLikesStatisticsPicture.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelLikesStatisticsPicture.Size = new System.Drawing.Size(83, 40);
            this.labelLikesStatisticsPicture.TabIndex = 72;
            this.labelLikesStatisticsPicture.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelCommentsStatisticsPicture
            // 
            this.labelCommentsStatisticsPicture.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelCommentsStatisticsPicture.ForeColor = System.Drawing.Color.Black;
            this.labelCommentsStatisticsPicture.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelCommentsStatisticsPicture.Location = new System.Drawing.Point(146, 400);
            this.labelCommentsStatisticsPicture.Name = "labelCommentsStatisticsPicture";
            this.labelCommentsStatisticsPicture.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelCommentsStatisticsPicture.Size = new System.Drawing.Size(83, 40);
            this.labelCommentsStatisticsPicture.TabIndex = 73;
            this.labelCommentsStatisticsPicture.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelBestVideo
            // 
            this.labelBestVideo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelBestVideo.ForeColor = System.Drawing.Color.Black;
            this.labelBestVideo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelBestVideo.Location = new System.Drawing.Point(11, 18);
            this.labelBestVideo.Name = "labelBestVideo";
            this.labelBestVideo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelBestVideo.Size = new System.Drawing.Size(161, 27);
            this.labelBestVideo.TabIndex = 77;
            this.labelBestVideo.Text = "Your best video";
            this.labelBestVideo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelWorstVideo
            // 
            this.labelWorstVideo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelWorstVideo.ForeColor = System.Drawing.Color.Black;
            this.labelWorstVideo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelWorstVideo.Location = new System.Drawing.Point(183, 18);
            this.labelWorstVideo.Name = "labelWorstVideo";
            this.labelWorstVideo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelWorstVideo.Size = new System.Drawing.Size(161, 27);
            this.labelWorstVideo.TabIndex = 78;
            this.labelWorstVideo.Text = "Your worst video";
            this.labelWorstVideo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelBestPost
            // 
            this.labelBestPost.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelBestPost.ForeColor = System.Drawing.Color.Black;
            this.labelBestPost.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelBestPost.Location = new System.Drawing.Point(10, 17);
            this.labelBestPost.Name = "labelBestPost";
            this.labelBestPost.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelBestPost.Size = new System.Drawing.Size(161, 27);
            this.labelBestPost.TabIndex = 81;
            this.labelBestPost.Text = "Your best post";
            this.labelBestPost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelWorstPost
            // 
            this.labelWorstPost.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelWorstPost.ForeColor = System.Drawing.Color.Black;
            this.labelWorstPost.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelWorstPost.Location = new System.Drawing.Point(182, 17);
            this.labelWorstPost.Name = "labelWorstPost";
            this.labelWorstPost.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelWorstPost.Size = new System.Drawing.Size(161, 27);
            this.labelWorstPost.TabIndex = 82;
            this.labelWorstPost.Text = "Your worst post";
            this.labelWorstPost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelLikesBestVideo
            // 
            this.labelLikesBestVideo.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelLikesBestVideo.ForeColor = System.Drawing.Color.Black;
            this.labelLikesBestVideo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelLikesBestVideo.Location = new System.Drawing.Point(75, 205);
            this.labelLikesBestVideo.Name = "labelLikesBestVideo";
            this.labelLikesBestVideo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelLikesBestVideo.Size = new System.Drawing.Size(83, 40);
            this.labelLikesBestVideo.TabIndex = 87;
            this.labelLikesBestVideo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelCommentsBestVideo
            // 
            this.labelCommentsBestVideo.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelCommentsBestVideo.ForeColor = System.Drawing.Color.Black;
            this.labelCommentsBestVideo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelCommentsBestVideo.Location = new System.Drawing.Point(75, 251);
            this.labelCommentsBestVideo.Name = "labelCommentsBestVideo";
            this.labelCommentsBestVideo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelCommentsBestVideo.Size = new System.Drawing.Size(83, 40);
            this.labelCommentsBestVideo.TabIndex = 88;
            this.labelCommentsBestVideo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelCommentsWorstVideo
            // 
            this.labelCommentsWorstVideo.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelCommentsWorstVideo.ForeColor = System.Drawing.Color.Black;
            this.labelCommentsWorstVideo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelCommentsWorstVideo.Location = new System.Drawing.Point(254, 251);
            this.labelCommentsWorstVideo.Name = "labelCommentsWorstVideo";
            this.labelCommentsWorstVideo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelCommentsWorstVideo.Size = new System.Drawing.Size(78, 40);
            this.labelCommentsWorstVideo.TabIndex = 89;
            this.labelCommentsWorstVideo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelLikesWorstVideo
            // 
            this.labelLikesWorstVideo.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelLikesWorstVideo.ForeColor = System.Drawing.Color.Black;
            this.labelLikesWorstVideo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelLikesWorstVideo.Location = new System.Drawing.Point(254, 205);
            this.labelLikesWorstVideo.Name = "labelLikesWorstVideo";
            this.labelLikesWorstVideo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelLikesWorstVideo.Size = new System.Drawing.Size(78, 40);
            this.labelLikesWorstVideo.TabIndex = 90;
            this.labelLikesWorstVideo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelStatisticsVideo
            // 
            this.labelStatisticsVideo.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelStatisticsVideo.ForeColor = System.Drawing.Color.Black;
            this.labelStatisticsVideo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelStatisticsVideo.Location = new System.Drawing.Point(153, 311);
            this.labelStatisticsVideo.Name = "labelStatisticsVideo";
            this.labelStatisticsVideo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelStatisticsVideo.Size = new System.Drawing.Size(95, 40);
            this.labelStatisticsVideo.TabIndex = 91;
            this.labelStatisticsVideo.Text = "Statistics";
            this.labelStatisticsVideo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelLikesStatisticsVideo
            // 
            this.labelLikesStatisticsVideo.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelLikesStatisticsVideo.ForeColor = System.Drawing.Color.Black;
            this.labelLikesStatisticsVideo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelLikesStatisticsVideo.Location = new System.Drawing.Point(153, 357);
            this.labelLikesStatisticsVideo.Name = "labelLikesStatisticsVideo";
            this.labelLikesStatisticsVideo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelLikesStatisticsVideo.Size = new System.Drawing.Size(83, 40);
            this.labelLikesStatisticsVideo.TabIndex = 94;
            this.labelLikesStatisticsVideo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelCommentsStatisticsVideo
            // 
            this.labelCommentsStatisticsVideo.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelCommentsStatisticsVideo.ForeColor = System.Drawing.Color.Black;
            this.labelCommentsStatisticsVideo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelCommentsStatisticsVideo.Location = new System.Drawing.Point(153, 403);
            this.labelCommentsStatisticsVideo.Name = "labelCommentsStatisticsVideo";
            this.labelCommentsStatisticsVideo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelCommentsStatisticsVideo.Size = new System.Drawing.Size(83, 40);
            this.labelCommentsStatisticsVideo.TabIndex = 95;
            this.labelCommentsStatisticsVideo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelLikesBestPost
            // 
            this.labelLikesBestPost.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelLikesBestPost.ForeColor = System.Drawing.Color.Black;
            this.labelLikesBestPost.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelLikesBestPost.Location = new System.Drawing.Point(73, 204);
            this.labelLikesBestPost.Name = "labelLikesBestPost";
            this.labelLikesBestPost.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelLikesBestPost.Size = new System.Drawing.Size(83, 40);
            this.labelLikesBestPost.TabIndex = 101;
            this.labelLikesBestPost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelCommentsBestPost
            // 
            this.labelCommentsBestPost.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelCommentsBestPost.ForeColor = System.Drawing.Color.Black;
            this.labelCommentsBestPost.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelCommentsBestPost.Location = new System.Drawing.Point(73, 250);
            this.labelCommentsBestPost.Name = "labelCommentsBestPost";
            this.labelCommentsBestPost.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelCommentsBestPost.Size = new System.Drawing.Size(83, 40);
            this.labelCommentsBestPost.TabIndex = 102;
            this.labelCommentsBestPost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelCommentsWorstPost
            // 
            this.labelCommentsWorstPost.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelCommentsWorstPost.ForeColor = System.Drawing.Color.Black;
            this.labelCommentsWorstPost.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelCommentsWorstPost.Location = new System.Drawing.Point(252, 250);
            this.labelCommentsWorstPost.Name = "labelCommentsWorstPost";
            this.labelCommentsWorstPost.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelCommentsWorstPost.Size = new System.Drawing.Size(78, 40);
            this.labelCommentsWorstPost.TabIndex = 103;
            this.labelCommentsWorstPost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelLikesWorstPost
            // 
            this.labelLikesWorstPost.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelLikesWorstPost.ForeColor = System.Drawing.Color.Black;
            this.labelLikesWorstPost.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelLikesWorstPost.Location = new System.Drawing.Point(252, 204);
            this.labelLikesWorstPost.Name = "labelLikesWorstPost";
            this.labelLikesWorstPost.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelLikesWorstPost.Size = new System.Drawing.Size(78, 40);
            this.labelLikesWorstPost.TabIndex = 104;
            this.labelLikesWorstPost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelStatisticsPost
            // 
            this.labelStatisticsPost.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelStatisticsPost.ForeColor = System.Drawing.Color.Black;
            this.labelStatisticsPost.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelStatisticsPost.Location = new System.Drawing.Point(151, 310);
            this.labelStatisticsPost.Name = "labelStatisticsPost";
            this.labelStatisticsPost.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelStatisticsPost.Size = new System.Drawing.Size(95, 40);
            this.labelStatisticsPost.TabIndex = 105;
            this.labelStatisticsPost.Text = "Statistics";
            this.labelStatisticsPost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelLikesStatisticsPost
            // 
            this.labelLikesStatisticsPost.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelLikesStatisticsPost.ForeColor = System.Drawing.Color.Black;
            this.labelLikesStatisticsPost.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelLikesStatisticsPost.Location = new System.Drawing.Point(151, 356);
            this.labelLikesStatisticsPost.Name = "labelLikesStatisticsPost";
            this.labelLikesStatisticsPost.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelLikesStatisticsPost.Size = new System.Drawing.Size(83, 40);
            this.labelLikesStatisticsPost.TabIndex = 108;
            this.labelLikesStatisticsPost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelCommentsStatisticsPost
            // 
            this.labelCommentsStatisticsPost.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelCommentsStatisticsPost.ForeColor = System.Drawing.Color.Black;
            this.labelCommentsStatisticsPost.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelCommentsStatisticsPost.Location = new System.Drawing.Point(151, 402);
            this.labelCommentsStatisticsPost.Name = "labelCommentsStatisticsPost";
            this.labelCommentsStatisticsPost.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelCommentsStatisticsPost.Size = new System.Drawing.Size(83, 40);
            this.labelCommentsStatisticsPost.TabIndex = 109;
            this.labelCommentsStatisticsPost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelFecher2Results
            // 
            this.panelFecher2Results.Controls.Add(this.panelFetcher2ResultPost);
            this.panelFecher2Results.Controls.Add(this.panelFetcher2ResultVideo);
            this.panelFecher2Results.Controls.Add(this.panelFetcher2ResultPhoto);
            this.panelFecher2Results.Location = new System.Drawing.Point(1, 83);
            this.panelFecher2Results.Name = "panelFecher2Results";
            this.panelFecher2Results.Size = new System.Drawing.Size(1127, 548);
            this.panelFecher2Results.TabIndex = 21;
            // 
            // panelFetcher2ResultPost
            // 
            this.panelFetcher2ResultPost.Controls.Add(this.labelWorstPostContent);
            this.panelFetcher2ResultPost.Controls.Add(this.labelBestPostContent);
            this.panelFetcher2ResultPost.Controls.Add(this.pictureBoxStatisticsPost);
            this.panelFetcher2ResultPost.Controls.Add(this.labelCommentsStatisticsPost);
            this.panelFetcher2ResultPost.Controls.Add(this.labelLikesStatisticsPost);
            this.panelFetcher2ResultPost.Controls.Add(this.pictureBoxCommentsStatisticsPost);
            this.panelFetcher2ResultPost.Controls.Add(this.pictureBoxLikesStatisticsPost);
            this.panelFetcher2ResultPost.Controls.Add(this.labelStatisticsPost);
            this.panelFetcher2ResultPost.Controls.Add(this.labelLikesWorstPost);
            this.panelFetcher2ResultPost.Controls.Add(this.labelCommentsWorstPost);
            this.panelFetcher2ResultPost.Controls.Add(this.labelCommentsBestPost);
            this.panelFetcher2ResultPost.Controls.Add(this.labelLikesBestPost);
            this.panelFetcher2ResultPost.Controls.Add(this.pictureBoxCommentsWorstPost);
            this.panelFetcher2ResultPost.Controls.Add(this.pictureBoxLikesWorstPost);
            this.panelFetcher2ResultPost.Controls.Add(this.pictureBoxLikesBestPost);
            this.panelFetcher2ResultPost.Controls.Add(this.pictureBoxCommentsBestPost);
            this.panelFetcher2ResultPost.Controls.Add(this.labelWorstPost);
            this.panelFetcher2ResultPost.Controls.Add(this.labelBestPost);
            this.panelFetcher2ResultPost.Controls.Add(this.pictureBoxWorstPost);
            this.panelFetcher2ResultPost.Controls.Add(this.pictureBoxBestPost);
            this.panelFetcher2ResultPost.Location = new System.Drawing.Point(768, 45);
            this.panelFetcher2ResultPost.Name = "panelFetcher2ResultPost";
            this.panelFetcher2ResultPost.Size = new System.Drawing.Size(347, 482);
            this.panelFetcher2ResultPost.TabIndex = 113;
            this.panelFetcher2ResultPost.Visible = false;
            // 
            // labelWorstPostContent
            // 
            this.labelWorstPostContent.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelWorstPostContent.Location = new System.Drawing.Point(182, 47);
            this.labelWorstPostContent.Name = "labelWorstPostContent";
            this.labelWorstPostContent.Size = new System.Drawing.Size(161, 147);
            this.labelWorstPostContent.TabIndex = 114;
            // 
            // labelBestPostContent
            // 
            this.labelBestPostContent.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelBestPostContent.Location = new System.Drawing.Point(11, 47);
            this.labelBestPostContent.Name = "labelBestPostContent";
            this.labelBestPostContent.Size = new System.Drawing.Size(161, 147);
            this.labelBestPostContent.TabIndex = 113;
            // 
            // pictureBoxStatisticsPost
            // 
            this.pictureBoxStatisticsPost.Image = global::A20_Ex03_Shmuel_204286793_Hen_313468654.Properties.Resources.StatisticsIconPNG;
            this.pictureBoxStatisticsPost.Location = new System.Drawing.Point(105, 310);
            this.pictureBoxStatisticsPost.Name = "pictureBoxStatisticsPost";
            this.pictureBoxStatisticsPost.Size = new System.Drawing.Size(40, 40);
            this.pictureBoxStatisticsPost.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxStatisticsPost.TabIndex = 110;
            this.pictureBoxStatisticsPost.TabStop = false;
            // 
            // pictureBoxCommentsStatisticsPost
            // 
            this.pictureBoxCommentsStatisticsPost.Image = global::A20_Ex03_Shmuel_204286793_Hen_313468654.Properties.Resources.CommentIconPNG;
            this.pictureBoxCommentsStatisticsPost.Location = new System.Drawing.Point(104, 402);
            this.pictureBoxCommentsStatisticsPost.Name = "pictureBoxCommentsStatisticsPost";
            this.pictureBoxCommentsStatisticsPost.Size = new System.Drawing.Size(40, 40);
            this.pictureBoxCommentsStatisticsPost.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxCommentsStatisticsPost.TabIndex = 107;
            this.pictureBoxCommentsStatisticsPost.TabStop = false;
            // 
            // pictureBoxLikesStatisticsPost
            // 
            this.pictureBoxLikesStatisticsPost.Image = global::A20_Ex03_Shmuel_204286793_Hen_313468654.Properties.Resources.LikeIconJPG;
            this.pictureBoxLikesStatisticsPost.Location = new System.Drawing.Point(104, 356);
            this.pictureBoxLikesStatisticsPost.Name = "pictureBoxLikesStatisticsPost";
            this.pictureBoxLikesStatisticsPost.Size = new System.Drawing.Size(40, 40);
            this.pictureBoxLikesStatisticsPost.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLikesStatisticsPost.TabIndex = 106;
            this.pictureBoxLikesStatisticsPost.TabStop = false;
            // 
            // pictureBoxCommentsWorstPost
            // 
            this.pictureBoxCommentsWorstPost.Image = global::A20_Ex03_Shmuel_204286793_Hen_313468654.Properties.Resources.CommentIconPNG;
            this.pictureBoxCommentsWorstPost.Location = new System.Drawing.Point(205, 250);
            this.pictureBoxCommentsWorstPost.Name = "pictureBoxCommentsWorstPost";
            this.pictureBoxCommentsWorstPost.Size = new System.Drawing.Size(40, 40);
            this.pictureBoxCommentsWorstPost.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxCommentsWorstPost.TabIndex = 99;
            this.pictureBoxCommentsWorstPost.TabStop = false;
            // 
            // pictureBoxLikesWorstPost
            // 
            this.pictureBoxLikesWorstPost.Image = global::A20_Ex03_Shmuel_204286793_Hen_313468654.Properties.Resources.LikeIconJPG;
            this.pictureBoxLikesWorstPost.Location = new System.Drawing.Point(205, 204);
            this.pictureBoxLikesWorstPost.Name = "pictureBoxLikesWorstPost";
            this.pictureBoxLikesWorstPost.Size = new System.Drawing.Size(40, 40);
            this.pictureBoxLikesWorstPost.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLikesWorstPost.TabIndex = 98;
            this.pictureBoxLikesWorstPost.TabStop = false;
            // 
            // pictureBoxLikesBestPost
            // 
            this.pictureBoxLikesBestPost.Image = global::A20_Ex03_Shmuel_204286793_Hen_313468654.Properties.Resources.LikeIconJPG;
            this.pictureBoxLikesBestPost.Location = new System.Drawing.Point(26, 204);
            this.pictureBoxLikesBestPost.Name = "pictureBoxLikesBestPost";
            this.pictureBoxLikesBestPost.Size = new System.Drawing.Size(40, 40);
            this.pictureBoxLikesBestPost.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLikesBestPost.TabIndex = 97;
            this.pictureBoxLikesBestPost.TabStop = false;
            // 
            // pictureBoxCommentsBestPost
            // 
            this.pictureBoxCommentsBestPost.Image = global::A20_Ex03_Shmuel_204286793_Hen_313468654.Properties.Resources.CommentIconPNG;
            this.pictureBoxCommentsBestPost.Location = new System.Drawing.Point(26, 250);
            this.pictureBoxCommentsBestPost.Name = "pictureBoxCommentsBestPost";
            this.pictureBoxCommentsBestPost.Size = new System.Drawing.Size(40, 40);
            this.pictureBoxCommentsBestPost.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxCommentsBestPost.TabIndex = 100;
            this.pictureBoxCommentsBestPost.TabStop = false;
            // 
            // pictureBoxWorstPost
            // 
            this.pictureBoxWorstPost.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxWorstPost.Image")));
            this.pictureBoxWorstPost.Location = new System.Drawing.Point(182, 47);
            this.pictureBoxWorstPost.Name = "pictureBoxWorstPost";
            this.pictureBoxWorstPost.Size = new System.Drawing.Size(161, 147);
            this.pictureBoxWorstPost.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxWorstPost.TabIndex = 80;
            this.pictureBoxWorstPost.TabStop = false;
            // 
            // pictureBoxBestPost
            // 
            this.pictureBoxBestPost.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxBestPost.Image")));
            this.pictureBoxBestPost.Location = new System.Drawing.Point(10, 47);
            this.pictureBoxBestPost.Name = "pictureBoxBestPost";
            this.pictureBoxBestPost.Size = new System.Drawing.Size(161, 147);
            this.pictureBoxBestPost.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxBestPost.TabIndex = 79;
            this.pictureBoxBestPost.TabStop = false;
            // 
            // panelFetcher2ResultVideo
            // 
            this.panelFetcher2ResultVideo.Controls.Add(this.pictureBoxStatisticsVideo);
            this.panelFetcher2ResultVideo.Controls.Add(this.labelCommentsStatisticsVideo);
            this.panelFetcher2ResultVideo.Controls.Add(this.labelLikesStatisticsVideo);
            this.panelFetcher2ResultVideo.Controls.Add(this.pictureBoxCommentsStatisticsVideo);
            this.panelFetcher2ResultVideo.Controls.Add(this.pictureBoxLikesStatisticsVideo);
            this.panelFetcher2ResultVideo.Controls.Add(this.labelStatisticsVideo);
            this.panelFetcher2ResultVideo.Controls.Add(this.labelLikesWorstVideo);
            this.panelFetcher2ResultVideo.Controls.Add(this.labelCommentsWorstVideo);
            this.panelFetcher2ResultVideo.Controls.Add(this.labelCommentsBestVideo);
            this.panelFetcher2ResultVideo.Controls.Add(this.labelLikesBestVideo);
            this.panelFetcher2ResultVideo.Controls.Add(this.pictureBoxCommentsWorstVideo);
            this.panelFetcher2ResultVideo.Controls.Add(this.pictureBoxLikesWorstVideo);
            this.panelFetcher2ResultVideo.Controls.Add(this.pictureBoxLikesBestVideo);
            this.panelFetcher2ResultVideo.Controls.Add(this.pictureBoxCommentsBestVideo);
            this.panelFetcher2ResultVideo.Controls.Add(this.labelWorstVideo);
            this.panelFetcher2ResultVideo.Controls.Add(this.labelBestVideo);
            this.panelFetcher2ResultVideo.Controls.Add(this.pictureBoxWorstVideo);
            this.panelFetcher2ResultVideo.Controls.Add(this.pictureBoxBestVideo);
            this.panelFetcher2ResultVideo.Location = new System.Drawing.Point(394, 44);
            this.panelFetcher2ResultVideo.Name = "panelFetcher2ResultVideo";
            this.panelFetcher2ResultVideo.Size = new System.Drawing.Size(366, 483);
            this.panelFetcher2ResultVideo.TabIndex = 112;
            this.panelFetcher2ResultVideo.Visible = false;
            // 
            // pictureBoxStatisticsVideo
            // 
            this.pictureBoxStatisticsVideo.Image = global::A20_Ex03_Shmuel_204286793_Hen_313468654.Properties.Resources.StatisticsIconPNG;
            this.pictureBoxStatisticsVideo.Location = new System.Drawing.Point(107, 311);
            this.pictureBoxStatisticsVideo.Name = "pictureBoxStatisticsVideo";
            this.pictureBoxStatisticsVideo.Size = new System.Drawing.Size(40, 40);
            this.pictureBoxStatisticsVideo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxStatisticsVideo.TabIndex = 96;
            this.pictureBoxStatisticsVideo.TabStop = false;
            // 
            // pictureBoxCommentsStatisticsVideo
            // 
            this.pictureBoxCommentsStatisticsVideo.Image = global::A20_Ex03_Shmuel_204286793_Hen_313468654.Properties.Resources.CommentIconPNG;
            this.pictureBoxCommentsStatisticsVideo.Location = new System.Drawing.Point(106, 403);
            this.pictureBoxCommentsStatisticsVideo.Name = "pictureBoxCommentsStatisticsVideo";
            this.pictureBoxCommentsStatisticsVideo.Size = new System.Drawing.Size(40, 40);
            this.pictureBoxCommentsStatisticsVideo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxCommentsStatisticsVideo.TabIndex = 93;
            this.pictureBoxCommentsStatisticsVideo.TabStop = false;
            // 
            // pictureBoxLikesStatisticsVideo
            // 
            this.pictureBoxLikesStatisticsVideo.Image = global::A20_Ex03_Shmuel_204286793_Hen_313468654.Properties.Resources.LikeIconJPG;
            this.pictureBoxLikesStatisticsVideo.Location = new System.Drawing.Point(106, 357);
            this.pictureBoxLikesStatisticsVideo.Name = "pictureBoxLikesStatisticsVideo";
            this.pictureBoxLikesStatisticsVideo.Size = new System.Drawing.Size(40, 40);
            this.pictureBoxLikesStatisticsVideo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLikesStatisticsVideo.TabIndex = 92;
            this.pictureBoxLikesStatisticsVideo.TabStop = false;
            // 
            // pictureBoxCommentsWorstVideo
            // 
            this.pictureBoxCommentsWorstVideo.Image = global::A20_Ex03_Shmuel_204286793_Hen_313468654.Properties.Resources.CommentIconPNG;
            this.pictureBoxCommentsWorstVideo.Location = new System.Drawing.Point(207, 251);
            this.pictureBoxCommentsWorstVideo.Name = "pictureBoxCommentsWorstVideo";
            this.pictureBoxCommentsWorstVideo.Size = new System.Drawing.Size(40, 40);
            this.pictureBoxCommentsWorstVideo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxCommentsWorstVideo.TabIndex = 85;
            this.pictureBoxCommentsWorstVideo.TabStop = false;
            // 
            // pictureBoxLikesWorstVideo
            // 
            this.pictureBoxLikesWorstVideo.Image = global::A20_Ex03_Shmuel_204286793_Hen_313468654.Properties.Resources.LikeIconJPG;
            this.pictureBoxLikesWorstVideo.Location = new System.Drawing.Point(207, 205);
            this.pictureBoxLikesWorstVideo.Name = "pictureBoxLikesWorstVideo";
            this.pictureBoxLikesWorstVideo.Size = new System.Drawing.Size(40, 40);
            this.pictureBoxLikesWorstVideo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLikesWorstVideo.TabIndex = 84;
            this.pictureBoxLikesWorstVideo.TabStop = false;
            // 
            // pictureBoxLikesBestVideo
            // 
            this.pictureBoxLikesBestVideo.Image = global::A20_Ex03_Shmuel_204286793_Hen_313468654.Properties.Resources.LikeIconJPG;
            this.pictureBoxLikesBestVideo.Location = new System.Drawing.Point(28, 205);
            this.pictureBoxLikesBestVideo.Name = "pictureBoxLikesBestVideo";
            this.pictureBoxLikesBestVideo.Size = new System.Drawing.Size(40, 40);
            this.pictureBoxLikesBestVideo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLikesBestVideo.TabIndex = 83;
            this.pictureBoxLikesBestVideo.TabStop = false;
            // 
            // pictureBoxCommentsBestVideo
            // 
            this.pictureBoxCommentsBestVideo.Image = global::A20_Ex03_Shmuel_204286793_Hen_313468654.Properties.Resources.CommentIconPNG;
            this.pictureBoxCommentsBestVideo.Location = new System.Drawing.Point(28, 251);
            this.pictureBoxCommentsBestVideo.Name = "pictureBoxCommentsBestVideo";
            this.pictureBoxCommentsBestVideo.Size = new System.Drawing.Size(40, 40);
            this.pictureBoxCommentsBestVideo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxCommentsBestVideo.TabIndex = 86;
            this.pictureBoxCommentsBestVideo.TabStop = false;
            // 
            // pictureBoxWorstVideo
            // 
            this.pictureBoxWorstVideo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxWorstVideo.Image")));
            this.pictureBoxWorstVideo.Location = new System.Drawing.Point(183, 48);
            this.pictureBoxWorstVideo.Name = "pictureBoxWorstVideo";
            this.pictureBoxWorstVideo.Size = new System.Drawing.Size(161, 147);
            this.pictureBoxWorstVideo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxWorstVideo.TabIndex = 76;
            this.pictureBoxWorstVideo.TabStop = false;
            // 
            // pictureBoxBestVideo
            // 
            this.pictureBoxBestVideo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxBestVideo.Image")));
            this.pictureBoxBestVideo.Location = new System.Drawing.Point(11, 48);
            this.pictureBoxBestVideo.Name = "pictureBoxBestVideo";
            this.pictureBoxBestVideo.Size = new System.Drawing.Size(161, 147);
            this.pictureBoxBestVideo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxBestVideo.TabIndex = 75;
            this.pictureBoxBestVideo.TabStop = false;
            // 
            // panelFetcher2ResultPhoto
            // 
            this.panelFetcher2ResultPhoto.Controls.Add(this.pictureBoxStatisticsPicture);
            this.panelFetcher2ResultPhoto.Controls.Add(this.labelCommentsStatisticsPicture);
            this.panelFetcher2ResultPhoto.Controls.Add(this.labelLikesStatisticsPicture);
            this.panelFetcher2ResultPhoto.Controls.Add(this.pictureBoxCommentsStatisticsPicture);
            this.panelFetcher2ResultPhoto.Controls.Add(this.pictureBoxLikesStatisticsPicture);
            this.panelFetcher2ResultPhoto.Controls.Add(this.labelStatisticsPicture);
            this.panelFetcher2ResultPhoto.Controls.Add(this.labelLikesWorstPicture);
            this.panelFetcher2ResultPhoto.Controls.Add(this.labelCommentsWorstPicture);
            this.panelFetcher2ResultPhoto.Controls.Add(this.labelCommentsBestPicture);
            this.panelFetcher2ResultPhoto.Controls.Add(this.labelLikesBestPicture);
            this.panelFetcher2ResultPhoto.Controls.Add(this.pictureBoxCommentsWorstPicture);
            this.panelFetcher2ResultPhoto.Controls.Add(this.pictureBoxLikesWorstPicture);
            this.panelFetcher2ResultPhoto.Controls.Add(this.pictureBoxLikesBestPicture);
            this.panelFetcher2ResultPhoto.Controls.Add(this.pictureBoxCommentsBestPicture);
            this.panelFetcher2ResultPhoto.Controls.Add(this.labelWorstPicture);
            this.panelFetcher2ResultPhoto.Controls.Add(this.labelBestPicture);
            this.panelFetcher2ResultPhoto.Controls.Add(this.pictureBoxWorstPicture);
            this.panelFetcher2ResultPhoto.Controls.Add(this.pictureBoxBestPicture);
            this.panelFetcher2ResultPhoto.Location = new System.Drawing.Point(7, 41);
            this.panelFetcher2ResultPhoto.Name = "panelFetcher2ResultPhoto";
            this.panelFetcher2ResultPhoto.Size = new System.Drawing.Size(361, 486);
            this.panelFetcher2ResultPhoto.TabIndex = 111;
            this.panelFetcher2ResultPhoto.Visible = false;
            // 
            // pictureBoxStatisticsPicture
            // 
            this.pictureBoxStatisticsPicture.Image = global::A20_Ex03_Shmuel_204286793_Hen_313468654.Properties.Resources.StatisticsIconPNG;
            this.pictureBoxStatisticsPicture.Location = new System.Drawing.Point(100, 308);
            this.pictureBoxStatisticsPicture.Name = "pictureBoxStatisticsPicture";
            this.pictureBoxStatisticsPicture.Size = new System.Drawing.Size(40, 40);
            this.pictureBoxStatisticsPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxStatisticsPicture.TabIndex = 74;
            this.pictureBoxStatisticsPicture.TabStop = false;
            // 
            // pictureBoxCommentsStatisticsPicture
            // 
            this.pictureBoxCommentsStatisticsPicture.Image = global::A20_Ex03_Shmuel_204286793_Hen_313468654.Properties.Resources.CommentIconPNG;
            this.pictureBoxCommentsStatisticsPicture.Location = new System.Drawing.Point(99, 400);
            this.pictureBoxCommentsStatisticsPicture.Name = "pictureBoxCommentsStatisticsPicture";
            this.pictureBoxCommentsStatisticsPicture.Size = new System.Drawing.Size(40, 40);
            this.pictureBoxCommentsStatisticsPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxCommentsStatisticsPicture.TabIndex = 71;
            this.pictureBoxCommentsStatisticsPicture.TabStop = false;
            // 
            // pictureBoxLikesStatisticsPicture
            // 
            this.pictureBoxLikesStatisticsPicture.Image = global::A20_Ex03_Shmuel_204286793_Hen_313468654.Properties.Resources.LikeIconJPG;
            this.pictureBoxLikesStatisticsPicture.Location = new System.Drawing.Point(99, 354);
            this.pictureBoxLikesStatisticsPicture.Name = "pictureBoxLikesStatisticsPicture";
            this.pictureBoxLikesStatisticsPicture.Size = new System.Drawing.Size(40, 40);
            this.pictureBoxLikesStatisticsPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLikesStatisticsPicture.TabIndex = 70;
            this.pictureBoxLikesStatisticsPicture.TabStop = false;
            // 
            // pictureBoxCommentsWorstPicture
            // 
            this.pictureBoxCommentsWorstPicture.Image = global::A20_Ex03_Shmuel_204286793_Hen_313468654.Properties.Resources.CommentIconPNG;
            this.pictureBoxCommentsWorstPicture.Location = new System.Drawing.Point(200, 248);
            this.pictureBoxCommentsWorstPicture.Name = "pictureBoxCommentsWorstPicture";
            this.pictureBoxCommentsWorstPicture.Size = new System.Drawing.Size(40, 40);
            this.pictureBoxCommentsWorstPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxCommentsWorstPicture.TabIndex = 63;
            this.pictureBoxCommentsWorstPicture.TabStop = false;
            // 
            // pictureBoxLikesWorstPicture
            // 
            this.pictureBoxLikesWorstPicture.Image = global::A20_Ex03_Shmuel_204286793_Hen_313468654.Properties.Resources.LikeIconJPG;
            this.pictureBoxLikesWorstPicture.Location = new System.Drawing.Point(200, 202);
            this.pictureBoxLikesWorstPicture.Name = "pictureBoxLikesWorstPicture";
            this.pictureBoxLikesWorstPicture.Size = new System.Drawing.Size(40, 40);
            this.pictureBoxLikesWorstPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLikesWorstPicture.TabIndex = 62;
            this.pictureBoxLikesWorstPicture.TabStop = false;
            // 
            // pictureBoxLikesBestPicture
            // 
            this.pictureBoxLikesBestPicture.Image = global::A20_Ex03_Shmuel_204286793_Hen_313468654.Properties.Resources.LikeIconJPG;
            this.pictureBoxLikesBestPicture.Location = new System.Drawing.Point(21, 202);
            this.pictureBoxLikesBestPicture.Name = "pictureBoxLikesBestPicture";
            this.pictureBoxLikesBestPicture.Size = new System.Drawing.Size(40, 40);
            this.pictureBoxLikesBestPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLikesBestPicture.TabIndex = 61;
            this.pictureBoxLikesBestPicture.TabStop = false;
            // 
            // pictureBoxCommentsBestPicture
            // 
            this.pictureBoxCommentsBestPicture.Image = global::A20_Ex03_Shmuel_204286793_Hen_313468654.Properties.Resources.CommentIconPNG;
            this.pictureBoxCommentsBestPicture.Location = new System.Drawing.Point(21, 248);
            this.pictureBoxCommentsBestPicture.Name = "pictureBoxCommentsBestPicture";
            this.pictureBoxCommentsBestPicture.Size = new System.Drawing.Size(40, 40);
            this.pictureBoxCommentsBestPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxCommentsBestPicture.TabIndex = 64;
            this.pictureBoxCommentsBestPicture.TabStop = false;
            // 
            // pictureBoxWorstPicture
            // 
            this.pictureBoxWorstPicture.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxWorstPicture.Image")));
            this.pictureBoxWorstPicture.Location = new System.Drawing.Point(178, 49);
            this.pictureBoxWorstPicture.Name = "pictureBoxWorstPicture";
            this.pictureBoxWorstPicture.Size = new System.Drawing.Size(161, 147);
            this.pictureBoxWorstPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxWorstPicture.TabIndex = 58;
            this.pictureBoxWorstPicture.TabStop = false;
            // 
            // pictureBoxBestPicture
            // 
            this.pictureBoxBestPicture.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxBestPicture.Image")));
            this.pictureBoxBestPicture.Location = new System.Drawing.Point(6, 49);
            this.pictureBoxBestPicture.Name = "pictureBoxBestPicture";
            this.pictureBoxBestPicture.Size = new System.Drawing.Size(161, 147);
            this.pictureBoxBestPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxBestPicture.TabIndex = 57;
            this.pictureBoxBestPicture.TabStop = false;
            // 
            // labelTitleFindPopularity
            // 
            this.labelTitleFindPopularity.AutoSize = true;
            this.labelTitleFindPopularity.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelTitleFindPopularity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(119)))), ((int)(((byte)(242)))));
            this.labelTitleFindPopularity.Location = new System.Drawing.Point(6, 14);
            this.labelTitleFindPopularity.Name = "labelTitleFindPopularity";
            this.labelTitleFindPopularity.Size = new System.Drawing.Size(445, 45);
            this.labelTitleFindPopularity.TabIndex = 9;
            this.labelTitleFindPopularity.Text = "Find out your best activities!";
            // 
            // labelSubTitleOfFindPopualrity
            // 
            this.labelSubTitleOfFindPopualrity.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelSubTitleOfFindPopualrity.ForeColor = System.Drawing.Color.Black;
            this.labelSubTitleOfFindPopualrity.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelSubTitleOfFindPopualrity.Location = new System.Drawing.Point(7, 59);
            this.labelSubTitleOfFindPopualrity.Name = "labelSubTitleOfFindPopualrity";
            this.labelSubTitleOfFindPopualrity.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelSubTitleOfFindPopualrity.Size = new System.Drawing.Size(585, 58);
            this.labelSubTitleOfFindPopualrity.TabIndex = 10;
            this.labelSubTitleOfFindPopualrity.Text = "Please choose one or more of the activities";
            this.labelSubTitleOfFindPopualrity.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panelFetcher2Choice
            // 
            this.panelFetcher2Choice.Controls.Add(this.buttonFindOut);
            this.panelFetcher2Choice.Controls.Add(this.labelSubTitleOfFindPopualrity);
            this.panelFetcher2Choice.Controls.Add(this.labelTitleFindPopularity);
            this.panelFetcher2Choice.Location = new System.Drawing.Point(1, 83);
            this.panelFetcher2Choice.Name = "panelFetcher2Choice";
            this.panelFetcher2Choice.Size = new System.Drawing.Size(1128, 548);
            this.panelFetcher2Choice.TabIndex = 111;
            // 
            // buttonFindOut
            // 
            this.buttonFindOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(103)))), ((int)(((byte)(178)))));
            this.buttonFindOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonFindOut.FlatAppearance.BorderSize = 0;
            this.buttonFindOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFindOut.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.buttonFindOut.ForeColor = System.Drawing.Color.White;
            this.buttonFindOut.Image = global::A20_Ex03_Shmuel_204286793_Hen_313468654.Properties.Resources.worker;
            this.buttonFindOut.Location = new System.Drawing.Point(13, 263);
            this.buttonFindOut.Name = "buttonFindOut";
            this.buttonFindOut.Size = new System.Drawing.Size(388, 108);
            this.buttonFindOut.TabIndex = 15;
            this.buttonFindOut.Text = "Click To Find";
            this.buttonFindOut.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonFindOut.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonFindOut.UseVisualStyleBackColor = false;
            this.buttonFindOut.Click += new System.EventHandler(this.buttonFindOut_Click);
            // 
            // labelSelectedMainPage
            // 
            this.labelSelectedMainPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(103)))), ((int)(((byte)(178)))));
            this.labelSelectedMainPage.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSelectedMainPage.ForeColor = System.Drawing.Color.White;
            this.labelSelectedMainPage.Location = new System.Drawing.Point(663, 76);
            this.labelSelectedMainPage.Name = "labelSelectedMainPage";
            this.labelSelectedMainPage.Size = new System.Drawing.Size(105, 5);
            this.labelSelectedMainPage.TabIndex = 113;
            this.labelSelectedMainPage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelHelloUser
            // 
            this.panelHelloUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(103)))), ((int)(((byte)(178)))));
            this.panelHelloUser.Controls.Add(this.labelWelcome);
            this.panelHelloUser.Controls.Add(this.nameLabel5);
            this.panelHelloUser.Controls.Add(this.imageNormalEllipseLoadingAndGrowingPictureBox);
            this.panelHelloUser.Location = new System.Drawing.Point(1, 1);
            this.panelHelloUser.Name = "panelHelloUser";
            this.panelHelloUser.Size = new System.Drawing.Size(289, 80);
            this.panelHelloUser.TabIndex = 114;
            // 
            // labelWelcome
            // 
            this.labelWelcome.AutoSize = true;
            this.labelWelcome.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWelcome.ForeColor = System.Drawing.Color.White;
            this.labelWelcome.Location = new System.Drawing.Point(81, 34);
            this.labelWelcome.Name = "labelWelcome";
            this.labelWelcome.Size = new System.Drawing.Size(93, 25);
            this.labelWelcome.TabIndex = 3;
            this.labelWelcome.Text = "Welcome";
            // 
            // nameLabel5
            // 
            this.nameLabel5.AutoSize = true;
            this.nameLabel5.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "Name", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, "No Name Provid"));
            this.nameLabel5.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel5.ForeColor = System.Drawing.Color.White;
            this.nameLabel5.Location = new System.Drawing.Point(169, 34);
            this.nameLabel5.Name = "nameLabel5";
            this.nameLabel5.Size = new System.Drawing.Size(65, 25);
            this.nameLabel5.TabIndex = 2;
            this.nameLabel5.Text = "label1";
            // 
            // imageNormalEllipseLoadingAndGrowingPictureBox
            // 
            this.imageNormalEllipseLoadingAndGrowingPictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.userBindingSource, "ImageNormal", true));
            this.imageNormalEllipseLoadingAndGrowingPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("imageNormalEllipseLoadingAndGrowingPictureBox.Image")));
            this.imageNormalEllipseLoadingAndGrowingPictureBox.Location = new System.Drawing.Point(4, 4);
            this.imageNormalEllipseLoadingAndGrowingPictureBox.Name = "imageNormalEllipseLoadingAndGrowingPictureBox";
            this.imageNormalEllipseLoadingAndGrowingPictureBox.Size = new System.Drawing.Size(76, 71);
            this.imageNormalEllipseLoadingAndGrowingPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imageNormalEllipseLoadingAndGrowingPictureBox.TabIndex = 1;
            this.imageNormalEllipseLoadingAndGrowingPictureBox.TabStop = false;
            // 
            // buttonMainPage
            // 
            this.buttonMainPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(103)))), ((int)(((byte)(178)))));
            this.buttonMainPage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonMainPage.FlatAppearance.BorderSize = 0;
            this.buttonMainPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMainPage.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.buttonMainPage.ForeColor = System.Drawing.Color.White;
            this.buttonMainPage.Image = global::A20_Ex03_Shmuel_204286793_Hen_313468654.Properties.Resources.main;
            this.buttonMainPage.Location = new System.Drawing.Point(664, 1);
            this.buttonMainPage.Name = "buttonMainPage";
            this.buttonMainPage.Size = new System.Drawing.Size(105, 80);
            this.buttonMainPage.TabIndex = 112;
            this.buttonMainPage.Text = "Main Page";
            this.buttonMainPage.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonMainPage.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonMainPage.UseVisualStyleBackColor = false;
            this.buttonMainPage.Click += new System.EventHandler(this.buttonMainPage_Click);
            // 
            // buttonFetcher2
            // 
            this.buttonFetcher2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(103)))), ((int)(((byte)(178)))));
            this.buttonFetcher2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonFetcher2.FlatAppearance.BorderSize = 0;
            this.buttonFetcher2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFetcher2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.buttonFetcher2.ForeColor = System.Drawing.Color.White;
            this.buttonFetcher2.Image = global::A20_Ex03_Shmuel_204286793_Hen_313468654.Properties.Resources.top;
            this.buttonFetcher2.Location = new System.Drawing.Point(883, 1);
            this.buttonFetcher2.Name = "buttonFetcher2";
            this.buttonFetcher2.Size = new System.Drawing.Size(106, 80);
            this.buttonFetcher2.TabIndex = 8;
            this.buttonFetcher2.Text = "Popularity";
            this.buttonFetcher2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonFetcher2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonFetcher2.UseVisualStyleBackColor = false;
            this.buttonFetcher2.Click += new System.EventHandler(this.buttonFetcher2_Click);
            // 
            // buttonFetcher1
            // 
            this.buttonFetcher1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(103)))), ((int)(((byte)(178)))));
            this.buttonFetcher1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonFetcher1.FlatAppearance.BorderSize = 0;
            this.buttonFetcher1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFetcher1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.buttonFetcher1.ForeColor = System.Drawing.Color.White;
            this.buttonFetcher1.Image = global::A20_Ex03_Shmuel_204286793_Hen_313468654.Properties.Resources.match;
            this.buttonFetcher1.Location = new System.Drawing.Point(775, 1);
            this.buttonFetcher1.Name = "buttonFetcher1";
            this.buttonFetcher1.Size = new System.Drawing.Size(105, 80);
            this.buttonFetcher1.TabIndex = 7;
            this.buttonFetcher1.Text = "Find Match";
            this.buttonFetcher1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonFetcher1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonFetcher1.UseVisualStyleBackColor = false;
            this.buttonFetcher1.Click += new System.EventHandler(this.buttonFetcher1_Click);
            // 
            // buttonLogOut
            // 
            this.buttonLogOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(103)))), ((int)(((byte)(178)))));
            this.buttonLogOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonLogOut.FlatAppearance.BorderSize = 0;
            this.buttonLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLogOut.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.buttonLogOut.ForeColor = System.Drawing.Color.Transparent;
            this.buttonLogOut.Image = global::A20_Ex03_Shmuel_204286793_Hen_313468654.Properties.Resources.logout;
            this.buttonLogOut.Location = new System.Drawing.Point(1023, 1);
            this.buttonLogOut.Name = "buttonLogOut";
            this.buttonLogOut.Size = new System.Drawing.Size(105, 80);
            this.buttonLogOut.TabIndex = 6;
            this.buttonLogOut.Text = "LogOut";
            this.buttonLogOut.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonLogOut.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonLogOut.UseVisualStyleBackColor = false;
            this.buttonLogOut.Click += new System.EventHandler(this.buttonLogOut_Click);
            // 
            // bestOrWorstMatchesLabel
            // 
            this.bestOrWorstMatchesLabel.AutoSize = true;
            this.bestOrWorstMatchesLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.bestOrWorstMatchesLabel.ForeColor = System.Drawing.Color.Black;
            this.bestOrWorstMatchesLabel.Location = new System.Drawing.Point(14, 264);
            this.bestOrWorstMatchesLabel.Name = "bestOrWorstMatchesLabel";
            this.bestOrWorstMatchesLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bestOrWorstMatchesLabel.Size = new System.Drawing.Size(231, 30);
            this.bestOrWorstMatchesLabel.TabIndex = 26;
            this.bestOrWorstMatchesLabel.Text = "Best Or Worst Matches:";
            this.bestOrWorstMatchesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // comboBoxBestOrWorstMatches
            // 
            this.comboBoxBestOrWorstMatches.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.comboBoxBestOrWorstMatches.FormattingEnabled = true;
            this.comboBoxBestOrWorstMatches.Items.AddRange(new object[] {
            "Best",
            "Worst"});
            this.comboBoxBestOrWorstMatches.Location = new System.Drawing.Point(262, 265);
            this.comboBoxBestOrWorstMatches.Name = "comboBoxBestOrWorstMatches";
            this.comboBoxBestOrWorstMatches.Size = new System.Drawing.Size(71, 29);
            this.comboBoxBestOrWorstMatches.TabIndex = 27;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1129, 634);
            this.Controls.Add(this.panelHelloUser);
            this.Controls.Add(this.labelSelectedMainPage);
            this.Controls.Add(this.buttonMainPage);
            this.Controls.Add(this.labelSelectedPopularity);
            this.Controls.Add(this.labelSelectFindMatch);
            this.Controls.Add(this.buttonFetcher2);
            this.Controls.Add(this.buttonFetcher1);
            this.Controls.Add(this.buttonLogOut);
            this.Controls.Add(this.labelMenuBackGround);
            this.Controls.Add(this.panelFetcher1);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelFecher2Results);
            this.Controls.Add(this.panelFetcher2Choice);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FaceBook App";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panelFetcher1.ResumeLayout(false);
            this.panelFetcher1.PerformLayout();
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.friendsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.postsBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.languagesBindingSource)).EndInit();
            this.panelFecher2Results.ResumeLayout(false);
            this.panelFetcher2ResultPost.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxStatisticsPost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCommentsStatisticsPost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLikesStatisticsPost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCommentsWorstPost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLikesWorstPost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLikesBestPost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCommentsBestPost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWorstPost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBestPost)).EndInit();
            this.panelFetcher2ResultVideo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxStatisticsVideo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCommentsStatisticsVideo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLikesStatisticsVideo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCommentsWorstVideo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLikesWorstVideo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLikesBestVideo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCommentsBestVideo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWorstVideo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBestVideo)).EndInit();
            this.panelFetcher2ResultPhoto.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxStatisticsPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCommentsStatisticsPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLikesStatisticsPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCommentsWorstPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLikesWorstPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLikesBestPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCommentsBestPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWorstPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBestPicture)).EndInit();
            this.panelFetcher2Choice.ResumeLayout(false);
            this.panelFetcher2Choice.PerformLayout();
            this.panelHelloUser.ResumeLayout(false);
            this.panelHelloUser.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageNormalEllipseLoadingAndGrowingPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label labelMenuBackGround;
        private Button buttonLogOut;
        private Button buttonFetcher1;
        private Panel panelFetcher1;
        private Button buttonFetcher2;
        private Label labelMatchedTitle;
        private Label labelSubExplantionInMatched;
        private Label labelInterestedInTitle;
        private Label labelBetweenNumbers;
        private TextBox textBoxHighAge;
        private TextBox textBoxLowAge;
        private Label labelAgeRangeTitle;
        private CheckBox checkBoxFemale;
        private CheckBox checkBoxMale;
        private Button buttonFindMatch;
        private Label labelMatchName5;
        private Label labelMatchName4;
        private Label labelMatchName3;
        private Label labelMatchName2;
        private Label labelMatchResultTitle;
        private Label labelMatchName1;
        private Label labelIfInterestedExist;
        private Label labelSelectFindMatch;
        private Label labelSelectedPopularity;
        private Panel panelMain;
        private Label labelTodayFriendBirthdayTitle;
        private Label labelRecentPostsTitle;
        private Label labelAboutMeTitle;
        private Panel panelFecher2Results;
        private Panel panelFetcher2Choice;
        private Button buttonFindOut;
        private Label labelSubTitleOfFindPopualrity;
        private Label labelTitleFindPopularity;
        private PictureBox pictureBoxStatisticsPost;
        private Label labelCommentsStatisticsPost;
        private Label labelLikesStatisticsPost;
        private PictureBox pictureBoxCommentsStatisticsPost;
        private PictureBox pictureBoxLikesStatisticsPost;
        private Label labelStatisticsPost;
        private Label labelLikesWorstPost;
        private Label labelCommentsWorstPost;
        private Label labelCommentsBestPost;
        private Label labelLikesBestPost;
        private PictureBox pictureBoxCommentsWorstPost;
        private PictureBox pictureBoxLikesWorstPost;
        private PictureBox pictureBoxLikesBestPost;
        private PictureBox pictureBoxCommentsBestPost;
        private PictureBox pictureBoxStatisticsVideo;
        private Label labelCommentsStatisticsVideo;
        private Label labelLikesStatisticsVideo;
        private PictureBox pictureBoxCommentsStatisticsVideo;
        private PictureBox pictureBoxLikesStatisticsVideo;
        private Label labelStatisticsVideo;
        private Label labelLikesWorstVideo;
        private Label labelCommentsWorstVideo;
        private Label labelCommentsBestVideo;
        private Label labelLikesBestVideo;
        private PictureBox pictureBoxCommentsWorstVideo;
        private PictureBox pictureBoxLikesWorstVideo;
        private PictureBox pictureBoxLikesBestVideo;
        private PictureBox pictureBoxCommentsBestVideo;
        private Label labelWorstPost;
        private Label labelBestPost;
        private EllipseLoadingAndGrowingPictureBox pictureBoxWorstPost;
        private EllipseLoadingAndGrowingPictureBox pictureBoxBestPost;
        private Label labelWorstVideo;
        private Label labelBestVideo;
        private EllipseLoadingAndGrowingPictureBox pictureBoxWorstVideo;
        private EllipseLoadingAndGrowingPictureBox pictureBoxBestVideo;
        private PictureBox pictureBoxStatisticsPicture;
        private Label labelCommentsStatisticsPicture;
        private Label labelLikesStatisticsPicture;
        private PictureBox pictureBoxCommentsStatisticsPicture;
        private PictureBox pictureBoxLikesStatisticsPicture;
        private Label labelStatisticsPicture;
        private Label labelLikesWorstPicture;
        private Label labelCommentsWorstPicture;
        private Label labelCommentsBestPicture;
        private Label labelLikesBestPicture;
        private PictureBox pictureBoxCommentsWorstPicture;
        private PictureBox pictureBoxLikesWorstPicture;
        private PictureBox pictureBoxLikesBestPicture;
        private PictureBox pictureBoxCommentsBestPicture;
        private Label labelWorstPicture;
        private Label labelBestPicture;
        private EllipseLoadingAndGrowingPictureBox pictureBoxWorstPicture;
        private EllipseLoadingAndGrowingPictureBox pictureBoxBestPicture;
        private Panel panelFetcher2ResultPost;
        private Panel panelFetcher2ResultVideo;
        private Panel panelFetcher2ResultPhoto;
        private Button buttonMainPage;
        private Label labelSelectedMainPage;
        private Label labelSubTitleMatchResult;
        private Label labelWorstPostContent;
        private Label labelBestPostContent;
        private Panel panelHelloUser;
        private Panel panel1;
        private BindingSource userBindingSource;
        private Label birthdayLabel1;
        private EllipseLoadingAndGrowingPictureBox imageNormalEllipseLoadingAndGrowingPictureBox;
        private Label emailLabel1;
        private TextBox nameTextBox;
        private Label relationshipStatusLabel1;
        private Label religionLabel1;
        private BindingSource postsBindingSource;
        private ListBox recentPostsListBox;
        private ListBox birthdayFriendNameListBox;
        private BindingSource friendsBindingSource;
        private Label nameLabel5;
        private Label labelWelcome;
        private Label nameLabel1;
        private BindingSource languagesBindingSource;
        private TextBox aboutTextBox;
        private ComboBox comboBoxBestOrWorstMatches;
        private Label bestOrWorstMatchesLabel;
    }
}