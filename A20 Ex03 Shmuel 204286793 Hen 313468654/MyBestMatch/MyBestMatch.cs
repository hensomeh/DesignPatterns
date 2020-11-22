using System;
using System.Collections.Generic;
using System.Threading;
using System.Collections;
using FacebookWrapper.ObjectModel;

namespace A20_Ex03_Shmuel_204286793_Hen_313468654
{
    public class MyBestMatch : IEnumerable
    {
        private readonly int r_NumberOfMatches;
        private FetchDataFromFaceBook m_FetchDataFromFaceBook = Singleton<FetchDataFromFaceBook>.Instance;
        private User m_LogedUser;
        private Dictionary<string, Friend> m_FriendsScoreDictionary;
        private Exception m_Exception = null;
        private List<Friend> m_FriendsScoreList;

        public MyBestMatch(User i_LogedUser, int i_NumberOfMatches)
        {
            m_LogedUser = i_LogedUser;
            r_NumberOfMatches = i_NumberOfMatches;
        }

        public void GetYourBestMatches(MatchOptions i_MatchOptions)
        { 
            m_FriendsScoreDictionary = getPotentialFriends(i_MatchOptions);
            m_FriendsScoreList = new List<Friend>();
            
            if (m_FriendsScoreDictionary.Count != 0)
            {
                try
                {
                    calculateFriendsScore();

                    if(m_Exception != null)
                    {
                        throw m_Exception;
                    }

                    m_FriendsScoreList = convertFriendsScoreToList();
                    SortList(i_MatchOptions);
                }
                catch(Exception ex)
                {
                    throw new Exception(ex.Message);
                } 
            }
        }

        private void SortList(MatchOptions i_MatchOptions)
        {
            SortScore<Friend> sortScore;
               // $G$ DSN-999 (-5)code duplication, why you dont call mergeSort after the if/else block?   
               if (i_MatchOptions.BestOrWorstMatches == "Best")
            {
                sortScore = new SortScore<Friend>((Firend1, Friend2) => Firend1.FriendScore > Friend2.FriendScore);
                m_FriendsScoreList = sortScore.MergeSort(m_FriendsScoreList);
            }
            else if (i_MatchOptions.BestOrWorstMatches == "Worst")
            {
                sortScore = new SortScore<Friend>((Firend1, Friend2) => Firend1.FriendScore < Friend2.FriendScore);
                m_FriendsScoreList = sortScore.MergeSort(m_FriendsScoreList);
            }
        }

        private List<Friend> convertFriendsScoreToList()
        {
            List<Friend> friendsScoreList = new List<Friend>();

            foreach (KeyValuePair<string, Friend> friend in m_FriendsScoreDictionary)
            {
                friendsScoreList.Add(friend.Value);
            }

            return friendsScoreList;
        }

        private void calculateFriendsScore()
        {
            Thread threadFetchScoreFromPosts = new Thread(fetchScoreFromPosts);
            Thread threadFetchScoreFromAlbums = new Thread(fetchScoreFromAlbums);
            Thread threadFetchScoreOfMatchedPagesLiked = new Thread(fetchScoreOfMatchedPagesLiked);

            threadFetchScoreFromPosts.Start();
            threadFetchScoreFromAlbums.Start();
            threadFetchScoreOfMatchedPagesLiked.Start();

            threadFetchScoreFromPosts.Join();
            threadFetchScoreFromAlbums.Join();
            threadFetchScoreOfMatchedPagesLiked.Join();
        }

        private void fetchScoreOfMatchedPagesLiked()
        {
            try
            {
                if (m_FetchDataFromFaceBook.GetUserListPages().Count != 0)
                {
                    foreach (KeyValuePair<string, Friend> friend in m_FriendsScoreDictionary)
                    {
                        if (m_FetchDataFromFaceBook.GetUserFriendsPageLikesById(friend.Value.User.Id) != null)
                        {
                            foreach (Page userLike in m_FetchDataFromFaceBook.GetUserListPages())
                            {
                                foreach (Page friendLike in m_FetchDataFromFaceBook.GetUserFriendsPageLikesById(friend.Value.User.Id))
                                {
                                    if (userLike.Id == friendLike.Id)
                                    {
                                        increaseFriendScore(friend.Value.User.Id);
                                    }
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                if (m_Exception == null)
                {
                    m_Exception = ex;
                }
            }
        }

        private void fetchScoreFromAlbums()
        {
            try
            {
                foreach (FacebookObjectCollection<User> likedByFriends in m_FetchDataFromFaceBook.GetUserListPhotoLikedBy(m_LogedUser))
                {
                    foreach (User friend in likedByFriends)
                    {
                        if (friend.Id != m_LogedUser.Id)
                        {
                            increaseFriendScore(friend.Id);
                        }
                    }
                }

                foreach (FacebookObjectCollection<Comment> commentsByFriends in m_FetchDataFromFaceBook.GetUserListPhotoComments(m_LogedUser))
                {
                    foreach (Comment comment in commentsByFriends)
                    {
                        if (comment.From.Id != m_LogedUser.Id)
                        {
                            increaseFriendScore(comment.From.Id);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                if (m_Exception == null)
                {
                    m_Exception = ex;
                }
            }
        }

        private void fetchScoreFromPosts()
        {
            try
            {
                foreach (FacebookObjectCollection<User> likedByFriend in m_FetchDataFromFaceBook.GetUserListPostLikedBy(m_LogedUser))
                {
                    foreach (User friend in likedByFriend)
                    {
                        if (friend.Id != m_LogedUser.Id)
                        {
                            increaseFriendScore(friend.Id);
                        }
                    }
                }

                foreach (FacebookObjectCollection<Comment> commentedByFriends in m_FetchDataFromFaceBook.GetUserListPostComments(m_LogedUser))
                {
                    foreach (Comment comment in commentedByFriends)
                    {
                        if (comment.From.Id != m_LogedUser.Id)
                        {
                            increaseFriendScore(comment.From.Id);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                if(m_Exception == null)
                {
                    m_Exception = ex;
                }     
            }
        }

        private bool checkIfCanMatch(User i_Friend, MatchOptions i_matchOptions)
        {
            string[] formats = { "M/d/yyyy", "MM/dd/yyyy", "dd/MM", "M/d", "dd/MM/yyyy" };
            DateTime birthdayDate;
            bool isValid = true;

            for (int i = 0; i < formats.Length; i++)
            {  
                try
                { 
                    birthdayDate = DateTime.ParseExact(i_Friend.Birthday, formats[i], null);
                    int age = DateTime.Now.Year - birthdayDate.Year;
                    if (DateTime.Now < birthdayDate.AddYears(age))
                    {
                        age--;
                    }
                        
                    if (age < i_matchOptions.LowAge || age > i_matchOptions.HighAge)
                    {
                        isValid = false;
                    }

                    break;
                }
                catch (FormatException)
                {
                    if (i == formats.Length - 1)
                    {
                        isValid = false;
                    }
                }
                catch (ArgumentNullException)
                {
                    isValid = false;
                }
            }

            if ((i_Friend.Gender == User.eGender.female &&
                i_matchOptions.GenderIntrest != eGenderIntrested.Female.ToString() &&
                (i_matchOptions.GenderIntrest != eGenderIntrested.MaleAndfemale.ToString())) ||
                (i_Friend.Gender == User.eGender.male &&
                (i_matchOptions.GenderIntrest != eGenderIntrested.Male.ToString()) && 
                (i_matchOptions.GenderIntrest != eGenderIntrested.MaleAndfemale.ToString())))
            {
                isValid = false;
            }

            return isValid;
        }

        private Dictionary<string, Friend> getPotentialFriends(MatchOptions i_matchOptions)
        {
            Dictionary<string, Friend> potentialFriends = new Dictionary<string, Friend>();

            try
            {
                foreach (User friend in m_FetchDataFromFaceBook.GetUserFriends(m_LogedUser))
                {
                    if (checkIfCanMatch(friend, i_matchOptions))
                    {
                        potentialFriends.Add(friend.Id, new Friend(friend));
                    }
                }
            }
            catch (ArgumentNullException)
            {
                throw new ArgumentNullException("No friend");
            }
            catch (Exception)
            {
                throw new Exception("Faild to load friends");
            }

            return potentialFriends;
        }

        private void increaseFriendScore(string i_Id)
        {
            if (m_FriendsScoreDictionary.TryGetValue(i_Id, out Friend value))
            {
                m_FriendsScoreDictionary[i_Id].FriendScore += 1;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            for (int i = 0; i < m_FriendsScoreList.Count; i++)
            {
                if(i < r_NumberOfMatches)
                {
                    yield return new PartialFriendScore()
                    {
                        PictureNormalURL = m_FriendsScoreList[i].User.PictureNormalURL,
                        Name = m_FriendsScoreList[i].User.Name
                    };
                }
            }
        }
    }
}