using System;
using System.Windows.Forms;
using FacebookWrapper;

namespace A20_Ex03_Shmuel_204286793_Hen_313468654
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void loginToFaceBook()
        {
            /// Owner:muli.orgatz, hen.someh
            LoginResult result = FacebookService.Login(
                "373635516722198",
                "public_profile",
                "email",
                "user_birthday",
                "user_age_range",
                "user_gender",
                "user_link",
                "user_tagged_places",
                "user_videos",
                "user_friends",
                "user_likes",
                "user_location",
                "user_photos",
                "user_posts");

            if (!string.IsNullOrEmpty(result.AccessToken))
            {
                MainForm mainForm = new MainForm(result.LoggedInUser);
                this.Hide();
                try
                {
                    mainForm.Show();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show(result.ErrorMessage);
            }
        }

        private void FBLoginButton_Click(object sender, EventArgs e)
        {
            try
            {
                loginToFaceBook();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
