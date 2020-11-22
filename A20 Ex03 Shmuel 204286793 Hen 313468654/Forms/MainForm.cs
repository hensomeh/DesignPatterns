using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Diagnostics;
using System.Threading;
using System.Collections;
using FacebookWrapper.ObjectModel;
using FacebookWrapper;

namespace A20_Ex03_Shmuel_204286793_Hen_313468654
{
    public partial class MainForm : Form
    {
        private const int k_Limit = 5;
        private const int k_NumberOfMatches = 5;
        private string m_InterestedIn = string.Empty;
        private string m_BestOrWorst = string.Empty;
        private string m_AgeRange = string.Empty;
        private bool m_isFirstTimeSearchMatches = true;
        private FacbookAppFacade m_FacbookAppFacade;
        private MenuActivity m_MenuFetcher2;

        public MainForm(User i_LoggedInUser)
        {
            InitializeComponent();

            FacebookService.s_CollectionLimit = k_Limit;
            FacebookService.s_FbApiVersion = 2.8f;
            m_FacbookAppFacade = new FacbookAppFacade(i_LoggedInUser, k_NumberOfMatches);
            fetchForMainPanel();
        }

        private void fetchForMainPanel()
        {
            try
            {
                addMainDataSource();
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("Problem:{0}. Check your intenet connection", ex.Message));
            }
        }

        private void addMainDataSource()
        {
            userBindingSource.DataSource = m_FacbookAppFacade.GetLogedUser();
            postsBindingSource.DataSource = m_FacbookAppFacade.GetRecentPosts(k_Limit);
            friendsBindingSource.DataSource = m_FacbookAppFacade.GetBirthDayToday();
        }

        private void buttonFetcher1_Click(object sender, EventArgs e)
        {
            panelFetcher1.BringToFront();
            changeSelctedButtonColor(labelSelectFindMatch);
            handelIntearestedIn();
        }

        private void handelIntearestedIn()
        {
            if (m_FacbookAppFacade.GetLogedUser().InterestedIn != null)
            {
                DialogResult dialogResult = MessageBox.Show(
                    string.Format(
                    "The app detect that you are interseted in {0}. " +
                    "Would you like to change that? ",
                    m_FacbookAppFacade.GetLogedUser().InterestedIn), 
                    "Interseted In", 
                    MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.No)
                {
                    checkBoxMale.Invoke(new Action(() =>
                        checkBoxMale.Visible = false));
                    checkBoxFemale.Invoke(new Action(() =>
                        checkBoxFemale.Visible = false));
                    labelIfInterestedExist.Invoke(new Action(() =>
                        labelIfInterestedExist.Text = m_FacbookAppFacade.GetLogedUser().InterestedIn.ToString()));
                }
            }
        }

        private void changeSelctedButtonColor(Label i_LabelSelected)
        {
            labelSelectFindMatch.BackColor = Color.FromArgb(66, 103, 178);
            labelSelectedPopularity.BackColor = Color.FromArgb(66, 103, 178);
            labelSelectedMainPage.BackColor = Color.FromArgb(66, 103, 178);

            if (i_LabelSelected.Name == labelSelectFindMatch.Name)
            {
                labelSelectFindMatch.BackColor = Color.FromArgb(153, 204, 255);
            }
            else if (i_LabelSelected.Name == labelSelectedPopularity.Name)
            {
                labelSelectedPopularity.BackColor = Color.FromArgb(153, 204, 255);
            }
            else if (i_LabelSelected.Name == labelSelectedMainPage.Name)
            {
                labelSelectedMainPage.BackColor = Color.FromArgb(153, 204, 255);
            }
        }

        private void handleLogOut()
        {
            m_FacbookAppFacade.Logout();
            LoginForm loginForm = new LoginForm();
            Close();
            loginForm.Show();
            MessageBox.Show(string.Format("{0} logged out from the app", m_FacbookAppFacade.GetLogedUser().Name));
        }

        private void buttonLogOut_Click(object sender, EventArgs e)
        {
            handleLogOut();
        }

        private void getFiledInfoFromMatchesPanel()
        {
            if (labelIfInterestedExist.Visible == true)
            {
                if (labelIfInterestedExist.Text == eGenderIntrested.Male.ToString())
                {
                    m_InterestedIn = eGenderIntrested.Male.ToString();
                }
                else if (labelIfInterestedExist.Text == eGenderIntrested.Female.ToString())
                {
                    m_InterestedIn = eGenderIntrested.Female.ToString();
                }
            }
            else
            {
                if (checkBoxMale.Checked)
                {
                    m_InterestedIn = eGenderIntrested.Male.ToString();
                    if (checkBoxFemale.Checked)
                    {
                        m_InterestedIn = eGenderIntrested.MaleAndfemale.ToString();
                    }
                }
                else if (checkBoxFemale.Checked)
                {
                    m_InterestedIn = eGenderIntrested.Female.ToString();
                }
                else
                {
                    m_InterestedIn = string.Empty;
                }
            }

            m_BestOrWorst = comboBoxBestOrWorstMatches.Text;
        }

        private void DynimcPictureBoxCreate()
        {
            int left = 591;
            int top = 105;
            
            for (int i = 0; i < k_NumberOfMatches; i++)
            {
                createPictureOfMatches(i, top, left);
                left += 172;
                if (i == 2)
                {
                    left = 666;
                    top = 313;
                }
            }

            m_isFirstTimeSearchMatches = false;
        }

        private void findMatch()
        {
            try
            {  
                if (m_isFirstTimeSearchMatches)
                {
                    DynimcPictureBoxCreate();
                }

                pictureBoxAndLabelOfMatchesVisbleFalse();                  
                MatchOptions matchOptions = m_FacbookAppFacade.GetMatchOptions(
                    m_InterestedIn, 
                    int.Parse(textBoxLowAge.Text), 
                    int.Parse(textBoxHighAge.Text),
                    m_BestOrWorst);
                IEnumerator matches = m_FacbookAppFacade.GetEnumerator(matchOptions);

                if (!matches.MoveNext())
                {
                    labelMatchResultTitle.Invoke(new Action(() => labelMatchResultTitle.Visible = false));
                    labelSubTitleMatchResult.Invoke(new Action(() => labelSubTitleMatchResult.Visible = false));
                    MessageBox.Show("Sorry, no match founded");
                }
                else
                {
                    labelMatchResultTitle.Invoke(new Action(() => labelMatchResultTitle.Visible = true));
                    labelSubTitleMatchResult.Invoke(new Action(() => labelSubTitleMatchResult.Visible = true));
                    updatePictureBoxAndLabelOfMatches(matches);
                }
            }
            catch (ArgumentNullException excption)
            {
                MessageBox.Show(excption.Message);
            }
            catch (FormatException)
            {
                MessageBox.Show("Please fill only numbers in the age range");
            }
            catch (Exception excption)
            {
                MessageBox.Show(excption.Message);
            }
        }

        private void buttonFindMatch_Click(object sender, EventArgs e)
        {
            getFiledInfoFromMatchesPanel();
            new Thread(findMatch).Start();
        }

        private void pictureBoxAndLabelOfMatchesVisbleFalse()
        {
            EllipseLoadingAndGrowingPictureBox pictureBoxMatch;
            Label labelMatch;
            
            for (int i = 0; i < k_NumberOfMatches; i++)
            {
                labelMatch = this.Controls.Find(string.Format("labelMatchName{0}", i + 1), true)[0] as Label;
                labelMatch.Invoke(new Action(() => labelMatch.Visible = false));
                pictureBoxMatch = this.Controls.Find(string.Format("pictureBoxMatch{0}", i + 1), true)[0] as EllipseLoadingAndGrowingPictureBox;           
                pictureBoxMatch.Invoke(new Action(() => pictureBoxMatch.Visible = false));
            }
        }

        private void updatePictureBoxAndLabelOfMatches(IEnumerator i_Matches)
        {
            int index = 0;

            updatePictureOfMatches(index, (i_Matches.Current as PartialFriendScore).PictureNormalURL);
            updateLabelOfMatches(index, (i_Matches.Current as PartialFriendScore).Name);
            index++;

            while (i_Matches.MoveNext())
            {
                updatePictureOfMatches(index, (i_Matches.Current as PartialFriendScore).PictureNormalURL);
                updateLabelOfMatches(index, (i_Matches.Current as PartialFriendScore).Name);
                index++;
            }
        }

        private void updatePictureOfMatches(int i_Index, string i_PictureNormalURL)
        {
            EllipseLoadingAndGrowingPictureBox pictureBoxMatch;

            pictureBoxMatch = this.Controls.Find(
                string.Format("pictureBoxMatch{0}", i_Index + 1), true)[0] as EllipseLoadingAndGrowingPictureBox;
            pictureBoxMatch.Invoke(new Action(() => pictureBoxMatch.Visible = true));

            pictureBoxMatch.Load(i_PictureNormalURL);
        }

        private void createPictureOfMatches(int i_Index, int i_Top, int i_Left)
        {
            EllipseLoadingAndGrowingPictureBox pictureBoxMatch = new EllipseLoadingAndGrowingPictureBox(true)
            {
                Size = new Size(128, 129),
                Top = i_Top,
                Left = i_Left,
                Name = string.Format("pictureBoxMatch{0}", i_Index + 1)
            };
            pictureBoxMatch.Click += this.PictureClick;
            pictureBoxMatch.Visible = false;
            panelFetcher1.Invoke(new Action(() => panelFetcher1.Controls.Add(pictureBoxMatch)));     
        }

        private void updateLabelOfMatches(int i_Index, string i_Name)
        {
            Label nameMatch;

            nameMatch = this.Controls.Find(string.Format("labelMatchName{0}", i_Index + 1), true)[0] as Label;
            nameMatch.Invoke(new Action(() => nameMatch.Visible = true));
            nameMatch.Invoke(new Action(() =>
                nameMatch.Text = string.Format("{0}.{1}", i_Index + 1, i_Name)));
        }

        private void PictureClick(object sender, EventArgs e)
        {
            PictureBox oPictureBox = (PictureBox)sender;
            int MatchPlace = int.Parse(oPictureBox.Name[oPictureBox.Name.Length - 1].ToString());
            openChatWith(MatchPlace - 1);
        }

        private void buttonFetcher2_Click(object sender, EventArgs e)
        {
            panelFetcher2Choice.BringToFront();
            initMenuCheckBox();
            changeSelctedButtonColor(labelSelectedPopularity);
        }

        private void makeFetcher2PanelsNotVisible()
        {
            panelFetcher2ResultPhoto.Invoke(new Action(() => 
                panelFetcher2ResultPhoto.Visible = false));
            panelFetcher2ResultVideo.Invoke(new Action(() =>
                panelFetcher2ResultVideo.Visible = false));
            panelFetcher2ResultPost.Invoke(new Action(() =>
                panelFetcher2ResultPost.Visible = false));
        }

        private void initMenuCheckBox()
        {
            m_MenuFetcher2 = new MenuActivity()
            {
                new MenuItemCheckBox("Photo", photoChecked),
                new MenuItemCheckBox("Post", postChecked),
                new MenuItemCheckBox("Video", videoChecked)
            };
            execute();
        }

        private void execute()
        {
            m_MenuFetcher2.ShowMenu(panelFetcher2Choice);
        }

        private void photoChecked()
        {
            panelFetcher2ResultPhoto.Invoke(new Action(() =>
                panelFetcher2ResultPhoto.Visible = true));
            managerPhotosResultsDesign();
        }

        private void postChecked()
        {
            panelFetcher2ResultPost.Invoke(new Action(() =>
                            panelFetcher2ResultPost.Visible = true));
            managerPostsResultsDesign();
        }

        private void videoChecked()
        {
            panelFetcher2ResultVideo.Invoke(new Action(() =>
                            panelFetcher2ResultVideo.Visible = true));
            managerVideosResultsDesign();
        }

        private void checkBoxSelectionViewer() 
        {
            try
            {
                makeFetcher2PanelsNotVisible();
                panelFecher2Results.Invoke(new Action(() =>
                    panelFecher2Results.BringToFront()));
                Dictionary<string, bool> checkedValue = m_MenuFetcher2.WhoIsChecked(panelFetcher2Choice);
                m_FacbookAppFacade.MangeBestActivity(checkedValue["Photo"], checkedValue["Post"], checkedValue["Video"]);
                if(!m_MenuFetcher2.AfterSelction(panelFetcher2Choice))
                {
                    panelFetcher2Choice.Invoke(new Action(() => 
                        panelFetcher2Choice.BringToFront()));
                    MessageBox.Show("Please fill one or more of the activities");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("Problem:{0}. Check your intenet connection", ex.Message));
            }
        }

        private void buttonFindOut_Click(object sender, EventArgs e)
        {  
            new Thread(checkBoxSelectionViewer).Start();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            panelMain.BringToFront();
            changeSelctedButtonColor(labelSelectedMainPage);
        }

        private void buttonMainPage_Click(object sender, EventArgs e)
        {
            panelMain.BringToFront();
            changeSelctedButtonColor(labelSelectedMainPage);
        }

        private void managerPhotosResultsDesign()
        {
            if (m_FacbookAppFacade.GetStatisticOfActivitiesTotalItam(ePostedItemTypes.Photo) == 0)
            {
                panelFetcher2ResultPhoto.Invoke(new Action(() =>
                    panelFetcher2ResultPhoto.Visible = false));
                MessageBox.Show("You dont have photos yet, please try later.");
            }
            else
            {  
                pictureBoxBestPicture.LoadAsync(m_FacbookAppFacade.GetBestPhotoUrl(ePostedItemTypes.Photo));
                pictureBoxWorstPicture.LoadAsync(m_FacbookAppFacade.GetWorstPhotoUrl(ePostedItemTypes.Photo));
                labelLikesBestPicture.Invoke(new Action(() => 
                    labelLikesBestPicture.Text = m_FacbookAppFacade.GetBestLikes(ePostedItemTypes.Photo)));
                labelCommentsBestPicture.Invoke(new Action(() =>
                    labelCommentsBestPicture.Text = m_FacbookAppFacade.GetBestComments(ePostedItemTypes.Photo)));
                labelLikesWorstPicture.Invoke(new Action(() =>
                    labelLikesWorstPicture.Text = m_FacbookAppFacade.GetWorstLikes(ePostedItemTypes.Photo)));
                labelCommentsWorstPicture.Invoke(new Action(() =>
                    labelCommentsWorstPicture.Text = m_FacbookAppFacade.GetWorstComments(ePostedItemTypes.Photo)));

                if (m_FacbookAppFacade.GetStatisticOfActivitiesLikes(ePostedItemTypes.Photo) != 0)
                {
                    labelLikesStatisticsPicture.Invoke(new Action(() =>
                           labelLikesStatisticsPicture.Text = m_FacbookAppFacade.GetStatisticLikeAVG(ePostedItemTypes.Photo)));
                }
                else
                {
                    labelLikesStatisticsPicture.Invoke(new Action(() => 
                        labelLikesStatisticsPicture.Text = "0"));
                }

                if (m_FacbookAppFacade.GetStatisticOfActivitiesComments(ePostedItemTypes.Photo) != 0)
                {
                    labelCommentsStatisticsPicture.Invoke(new Action(() =>
                        labelCommentsStatisticsPicture.Text = m_FacbookAppFacade.GetStatisticCommentsAVG(ePostedItemTypes.Photo)));
                }
                else
                {
                    labelCommentsStatisticsPicture.Invoke(new Action(() =>
                        labelCommentsStatisticsPicture.Text = "0"));
                }
            }
        }

        private void managerVideosResultsDesign()
        {
            if (m_FacbookAppFacade.GetStatisticOfActivitiesTotalItam(ePostedItemTypes.Video) == 0)
            {
                panelFetcher2ResultVideo.Invoke(new Action(() =>
                    panelFetcher2ResultVideo.Visible = false));
                MessageBox.Show("You dont have videos yet, please try later.");
            }
            else
            {
                pictureBoxBestVideo.LoadAsync(m_FacbookAppFacade.GetBestVideoUrl(ePostedItemTypes.Video));
                pictureBoxWorstVideo.LoadAsync(m_FacbookAppFacade.GetWorstVideoUrl(ePostedItemTypes.Video));
                labelLikesBestVideo.Invoke(new Action(() =>
                    labelLikesBestVideo.Text = m_FacbookAppFacade.GetBestLikes(ePostedItemTypes.Video)));
                labelCommentsBestVideo.Invoke(new Action(() =>
                     labelCommentsBestVideo.Text = m_FacbookAppFacade.GetBestComments(ePostedItemTypes.Video)));
                labelLikesWorstVideo.Invoke(new Action(() =>
                     labelLikesWorstVideo.Text = m_FacbookAppFacade.GetWorstLikes(ePostedItemTypes.Video)));
                labelCommentsWorstVideo.Invoke(new Action(() =>
                     labelCommentsWorstVideo.Text = m_FacbookAppFacade.GetWorstComments(ePostedItemTypes.Video)));

                if (m_FacbookAppFacade.GetStatisticOfActivitiesLikes(ePostedItemTypes.Video) != 0)
                {
                    labelLikesStatisticsVideo.Invoke(new Action(() =>
                     labelLikesStatisticsVideo.Text = m_FacbookAppFacade.GetStatisticLikeAVG(ePostedItemTypes.Video)));
                }
                else
                {
                    labelLikesStatisticsVideo.Invoke(new Action(() =>
                     labelLikesStatisticsVideo.Text = "0"));
                }

                if (m_FacbookAppFacade.GetStatisticOfActivitiesComments(ePostedItemTypes.Video) != 0)
                {
                    labelCommentsStatisticsVideo.Invoke(new Action(() =>
                        labelCommentsStatisticsVideo.Text = m_FacbookAppFacade.GetStatisticCommentsAVG(ePostedItemTypes.Video)));
                }
                else
                {
                    labelCommentsStatisticsVideo.Invoke(new Action(() =>
                        labelCommentsStatisticsVideo.Text = "0"));
                }
            }
        }

        private void managerPostsResultsDesign()
        {
            if (m_FacbookAppFacade.GetStatisticOfActivitiesTotalItam(ePostedItemTypes.Post) == 0)
            {
                panelFetcher2ResultPost.Invoke(new Action(() =>
                    panelFetcher2ResultPost.Visible = false));
                MessageBox.Show("You dont have posts yet, please try later."); 
            }
            else
            {
                makeDesignPosts(m_FacbookAppFacade.GetBestPostUserActivities(), m_FacbookAppFacade.GetWorstPostUserActivities());
                labelLikesBestPost.Invoke(new Action(() =>
                    labelLikesBestPost.Text = m_FacbookAppFacade.GetBestLikes(ePostedItemTypes.Post)));
                labelCommentsBestPost.Invoke(new Action(() =>
                    labelCommentsBestPost.Text = m_FacbookAppFacade.GetBestComments(ePostedItemTypes.Post)));
                labelLikesWorstPost.Invoke(new Action(() =>
                    labelLikesWorstPost.Text = m_FacbookAppFacade.GetWorstLikes(ePostedItemTypes.Post)));
                labelCommentsWorstPost.Invoke(new Action(() =>
                    labelCommentsWorstPost.Text = m_FacbookAppFacade.GetWorstComments(ePostedItemTypes.Post)));

                if (m_FacbookAppFacade.GetStatisticOfActivitiesLikes(ePostedItemTypes.Post) != 0)
                {
                    labelLikesStatisticsPost.Invoke(new Action(() =>
                        labelLikesStatisticsPost.Text = m_FacbookAppFacade.GetStatisticLikeAVG(ePostedItemTypes.Post)));
                }
                else
                {
                    labelLikesStatisticsPost.Invoke(new Action(() =>
                        labelLikesStatisticsPost.Text = "0"));
                }

                if (m_FacbookAppFacade.GetStatisticOfActivitiesComments(ePostedItemTypes.Post) != 0)
                {
                    labelCommentsStatisticsPost.Invoke(new Action(() =>
                        labelCommentsStatisticsPost.Text = m_FacbookAppFacade.GetStatisticCommentsAVG(ePostedItemTypes.Post)));
                }
                else
                {
                    labelCommentsStatisticsPost.Invoke(new Action(() =>
                        labelCommentsStatisticsPost.Text = "0"));
                }
            } 
        }

        private void makeDesignPosts(Post i_BestPost, Post i_WorstPost)
        {
            if (i_BestPost.Type == Post.eType.photo)
            {
                labelBestPostContent.Invoke(new Action(() =>
                    labelBestPostContent.Visible = false));
                pictureBoxBestPost.Invoke(new Action(() =>
                    pictureBoxBestPost.Visible = true));
                pictureBoxBestPost.LoadAsync(m_FacbookAppFacade.GetBestPostUrl(ePostedItemTypes.Post));
            }
            else if(i_BestPost.Message != null)
            {
                pictureBoxBestPost.Invoke(new Action(() =>
                    pictureBoxBestPost.Visible = false));
                labelBestPostContent.Invoke(new Action(() =>
                    labelBestPostContent.Visible = true));
                labelBestPostContent.Invoke(new Action(() =>
                    labelBestPostContent.Text = i_BestPost.Message));
            }
            else if (i_BestPost.Type == Post.eType.video)
            {
                labelBestPostContent.Invoke(new Action(() =>
                    labelBestPostContent.Visible = false));
                pictureBoxBestPost.Invoke(new Action(() =>
                    pictureBoxBestPost.Visible = true));
                pictureBoxBestPost.LoadAsync(m_FacbookAppFacade.GetBestPostUrl(ePostedItemTypes.Post));
            }
            else
            {
                pictureBoxBestPost.Invoke(new Action(() =>
                    pictureBoxBestPost.Visible = false));
                labelBestPostContent.Invoke(new Action(() =>
                    labelBestPostContent.Visible = true));
                labelBestPostContent.Invoke(new Action(() =>
                    labelBestPostContent.Text = i_BestPost.Type.ToString()));
            }

            if (i_WorstPost.Type == Post.eType.photo)
            {
                labelWorstPostContent.Invoke(new Action(() =>
                    labelWorstPostContent.Visible = false));
                pictureBoxWorstPost.Invoke(new Action(() =>
                    pictureBoxWorstPost.Visible = true));
                pictureBoxWorstPost.LoadAsync(m_FacbookAppFacade.GetWorstPostUrl(ePostedItemTypes.Post));
            }
            else if (i_WorstPost.Message != null)
            {
                pictureBoxWorstPost.Invoke(new Action(() =>
                    pictureBoxWorstPost.Visible = false));
                labelWorstPostContent.Invoke(new Action(() =>
                    labelWorstPostContent.Visible = true));
                labelWorstPostContent.Invoke(new Action(() =>
                    labelWorstPostContent.Text = i_WorstPost.Message));
            }
            else if (i_WorstPost.Type == Post.eType.video)
            {
                labelWorstPostContent.Invoke(new Action(() =>
                    labelWorstPostContent.Visible = false));
                pictureBoxWorstPost.Invoke(new Action(() =>
                    pictureBoxWorstPost.Visible = true));
                pictureBoxWorstPost.LoadAsync(m_FacbookAppFacade.GetWorstVideoUrl(ePostedItemTypes.Post));
            }
            else
            {
                pictureBoxWorstPost.Invoke(new Action(() =>
                    pictureBoxWorstPost.Visible = false));
                labelWorstPostContent.Invoke(new Action(() =>
                    labelWorstPostContent.Visible = true));
                labelWorstPostContent.Invoke(new Action(() =>
                    labelWorstPostContent.Text = i_WorstPost.Type.ToString()));
            }
        }

        private void openChatWith(int i_IndexOfFriend)
        {
            Label labelMatch;
            string name = string.Empty;
            
            labelMatch = this.Controls.Find(string.Format("labelMatchName{0}", i_IndexOfFriend + 1), true)[0] as Label;
            int space1 = labelMatch.Text.ToString().IndexOf(' ');
            string firstName = labelMatch.Text.ToString().Substring(2, space1 - 2);
            string lastName = labelMatch.Text.ToString().Substring(space1 + 1);

            name = string.Format("{0}.{1}", firstName, lastName);
            ProcessStartInfo sInfo = new ProcessStartInfo(
                string.Format("https://www.facebook.com/messages/t/{0}", name));
            Process.Start(sInfo);
        }
    }
}