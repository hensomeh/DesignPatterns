using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;

namespace A20_Ex03_Shmuel_204286793_Hen_313468654
{
    public class FacbookAppFacade
    {
        private readonly User r_LogedUser;
        private MyBestMatch m_MyBestMatch;
        private MyBestActivity m_MyBestActivity;
        private MatchOptions m_MatchOptions;
        private FetchDataFromFaceBook m_FetchDataFromFaceBook = Singleton<FetchDataFromFaceBook>.Instance;

        public FacbookAppFacade(User i_LogedUser, int i_NumberOfMatches)
        {
            r_LogedUser = i_LogedUser;
            m_MyBestActivity = new MyBestActivity(r_LogedUser);
            m_MyBestMatch = new MyBestMatch(r_LogedUser, i_NumberOfMatches);
        }

        public IEnumerator GetEnumerator(MatchOptions i_MatchOptions)
        {
            m_MyBestMatch.GetYourBestMatches(i_MatchOptions);
               // $G$ DSN-999 (-5) there is no reason to do the catsing the function GetEnumerator available with the regular ref
               IEnumerator it1 = (m_MyBestMatch as IEnumerable).GetEnumerator();

            return it1;
        }

        public User GetLogedUser()
        {
            return r_LogedUser;
        }

        public List<User> GetBirthDayToday()
        {
            List<User> todayBirthday = new List<User>();

            foreach (User friend in m_FetchDataFromFaceBook.GetUserFriends(r_LogedUser))
            {
                string[] formats = { "MM/dd/yyyy", "M/d/yyyy", "dd/MM", "M/d", "dd/MM/yyyy" };
                DateTime birthDay;
                
                for (int i = 0; i < formats.Length; i++)
                {
                    try
                    {
                        birthDay = DateTime.ParseExact(friend.Birthday, formats[i], null);
                        if (birthDay.Day == DateTime.Today.Day && birthDay.Month == DateTime.Today.Month)
                        {
                            todayBirthday.Add(friend);
                            break;
                        }

                        i = formats.Length;
                    }
                    catch (FormatException)
                    {
                        if (i == formats.Length - 1)
                        {
                            break;
                        }
                    }
                } 
            }

            return todayBirthday;
        }

        public List<Post> GetRecentPosts(int i_FacebookLimit)
        {
            int limit = i_FacebookLimit < 10 ? i_FacebookLimit : 10;
            List<Post> recentPosts = new List<Post>();
            recentPosts = m_FetchDataFromFaceBook.GetUserPosts(r_LogedUser).ToList<Post>();

            return recentPosts.GetRange(0, limit);
        }

        public MatchOptions GetMatchOptions(string i_InterestedIn, int i_LowAge, int i_HighAge, string i_BestOrWorstMatches)
        {
            m_MatchOptions = new MatchOptions(i_InterestedIn, i_LowAge, i_HighAge, i_BestOrWorstMatches);

            return m_MatchOptions;
        }

        public void Logout()
        {
            try
            {
                m_FetchDataFromFaceBook.ClearAll();
                FacebookService.Logout(() => { });
            }
            catch (Exception ex)
            {
                throw new Exception(string.Format("Problem:{0}. Check your intenet connection", ex.Message));
            }
        }

        public void MangeBestActivity(bool i_PhotoSelected, bool i_PostSelected, bool i_VideoSelected)
        {
            m_MyBestActivity.MangeBestActivity(i_PhotoSelected, i_PostSelected, i_VideoSelected);
        }

        public string GetWorstPhotoUrl(ePostedItemTypes ePostedItemTypes)
        {
            return m_MyBestActivity.GetWorstPhotoUrl(ePostedItemTypes);
        }

        public string GetWorstPostUrl(ePostedItemTypes ePostedItemTypes)
        {
            return m_MyBestActivity.GetWorstPostUrl(ePostedItemTypes);
        }

        public string GetWorstVideoUrl(ePostedItemTypes ePostedItemTypes)
        {
            return m_MyBestActivity.GetWorstVideoUrl(ePostedItemTypes);
        }

        public string GetBestLikes(ePostedItemTypes ePostedItemTypes)
        {
            return m_MyBestActivity.GetBestLikes(ePostedItemTypes);
        }

        public string GetBestComments(ePostedItemTypes ePostedItemTypes)
        {
            return m_MyBestActivity.GetBestComments(ePostedItemTypes);
        }

        public string GetWorstComments(ePostedItemTypes ePostedItemTypes)
        {
            return m_MyBestActivity.GetWorstComments(ePostedItemTypes);
        }

        public string GetWorstLikes(ePostedItemTypes ePostedItemTypes)
        {
            return m_MyBestActivity.GetWorstLikes(ePostedItemTypes);
        }

        public string GetBestPhotoUrl(ePostedItemTypes ePostedItemTypes)
        {
            return m_MyBestActivity.GetBestPhotoUrl(ePostedItemTypes);
        }

        public string GetBestVideoUrl(ePostedItemTypes ePostedItemTypes)
        {
            return m_MyBestActivity.GetBestVideoUrl(ePostedItemTypes);
        }

        public string GetBestPostUrl(ePostedItemTypes ePostedItemTypes)
        {
            return m_MyBestActivity.GetBestPostUrl(ePostedItemTypes);
        }

        public int GetStatisticOfActivitiesLikes(ePostedItemTypes ePostedItemTypes)
        {
            return m_MyBestActivity.GetStatisticOfActivitiesLikes(ePostedItemTypes);
        }

        public int GetStatisticOfActivitiesComments(ePostedItemTypes ePostedItemTypes)
        {
            return m_MyBestActivity.GetStatisticOfActivitiesComments(ePostedItemTypes);
        }

        public int GetStatisticOfActivitiesTotalItam(ePostedItemTypes ePostedItemTypes)
        {
            return m_MyBestActivity.GetStatisticOfActivitiesTotalItam(ePostedItemTypes);
        }

        public string GetStatisticLikeAVG(ePostedItemTypes ePostedItemTypes)
        {
            return m_MyBestActivity.GetStatisticLikeAVG(ePostedItemTypes);
        }

        public string GetStatisticCommentsAVG(ePostedItemTypes ePostedItemTypes)
        {
            return m_MyBestActivity.GetStatisticCommentsAVG(ePostedItemTypes);
        }

        public Post GetBestPostUserActivities()
        {
            return m_MyBestActivity.GetBestPostUserActivities();
        }

        public Post GetWorstPostUserActivities()
        {
            return m_MyBestActivity.GetWorstPostUserActivities();
        }
    }
}
