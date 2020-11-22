using System;
using System.Collections.Generic;
using FacebookWrapper.ObjectModel;

namespace A20_Ex03_Shmuel_204286793_Hen_313468654
{
    public class MyBestActivity
    {
        private const int k_numberOfItems = 3;
        private readonly User r_LoggedUser;
        private FetchDataFromFaceBook m_FetchDataFromFaceBook = Singleton<FetchDataFromFaceBook>.Instance;
        private List<PostedItem> m_BestUserActivities;
        private List<PostedItem> m_WorstUserActivities;
        private List<PostedItemStatistics> m_StatisticOfActivities;

        public MyBestActivity(User i_LoggedUser)
        {
            m_BestUserActivities = new List<PostedItem>();
            m_WorstUserActivities = new List<PostedItem>();
            m_StatisticOfActivities = new List<PostedItemStatistics>();
            r_LoggedUser = i_LoggedUser;
        }

        public void MangeBestActivity(bool i_PhotoSelected, bool i_PostSelected, bool i_VideoSelected)
        {
            for(int i = 0; i < k_numberOfItems; i++)
            {
                m_StatisticOfActivities.Add(new PostedItemStatistics());
                m_BestUserActivities.Add(null);
                m_WorstUserActivities.Add(null);
            }

            if (i_PhotoSelected)
            {
                fetchUserActivitiesFromPhotos();
            }

            if (i_PostSelected)
            {
                fetchUserActivitiesFromPosts();
            }

            if (i_VideoSelected)
            {
                fetchUserActivitiesFromVideos();
            }
        }

        private int compareList(PostedItemScore i_FirstPostedItemScore, PostedItemScore i_SecondPostedItemScore)
        {
            int compareScore = i_FirstPostedItemScore.PostedItemScoreValue.CompareTo(i_SecondPostedItemScore.PostedItemScoreValue);

            return compareScore;
        }

        private List<PostedItemScore> convertDictionaryToList(Dictionary<string, PostedItemScore> i_ScoreByValue)
        {
            List<PostedItemScore> ScoreList = new List<PostedItemScore>();

            foreach (KeyValuePair<string, PostedItemScore> item in i_ScoreByValue)
            {
                ScoreList.Add(item.Value);
            }

            return ScoreList;
        }

        private void fetchUserActivitiesFromPhotos()
        {
            try
            {
                List<PostedItemScore> postedPhotoScores = new List<PostedItemScore>();
                Dictionary<string, PostedItemScore> m_UserPhotosScore = new Dictionary<string, PostedItemScore>();

                foreach (Photo photo in m_FetchDataFromFaceBook.GetUserPhotos(r_LoggedUser))
                {
                    m_UserPhotosScore[photo.Id] = new PostedItemScore(photo)
                    {
                        PostedItemScoreValue =
                        m_FetchDataFromFaceBook.GetPhotoUserLikeCount(r_LoggedUser, photo.Id) +
                        m_FetchDataFromFaceBook.GetPhotoUserCommentCount(r_LoggedUser, photo.Id)
                    };
                    m_StatisticOfActivities[(int)ePostedItemTypes.Photo].Likes +=
                        m_FetchDataFromFaceBook.GetPhotoUserLikeCount(r_LoggedUser, photo.Id);
                    m_StatisticOfActivities[(int)ePostedItemTypes.Photo].Comments +=
                        m_FetchDataFromFaceBook.GetPhotoUserCommentCount(r_LoggedUser, photo.Id);
                    m_StatisticOfActivities[(int)ePostedItemTypes.Photo].TotalItems += 1;
                }

                postedPhotoScores = convertDictionaryToList(m_UserPhotosScore);

                if(postedPhotoScores.Count != 0)
                {
                    postedPhotoScores.Sort(compareList);

                    string bestPhotoID = postedPhotoScores[postedPhotoScores.Count - 1].PostedItem.Id;
                    string worstPhotoID = postedPhotoScores[0].PostedItem.Id;

                    foreach (Photo photo in m_FetchDataFromFaceBook.GetUserPhotos(r_LoggedUser))
                    {  
                       if (photo.Id == bestPhotoID)
                        {
                            m_BestUserActivities[(int)ePostedItemTypes.Photo] = photo;
                        }

                        if (photo.Id == worstPhotoID)
                        {
                            m_WorstUserActivities[(int)ePostedItemTypes.Photo] = photo;
                        }
                    }
                } 
            }
            catch (Exception)
            {
                throw new Exception("Failed to find your photos, please try again later.");
            }
        }

        private void fetchUserActivitiesFromPosts()
        {
            try
            {
                List<PostedItemScore> postedPostScores = new List<PostedItemScore>();
                Dictionary<string, PostedItemScore> m_UserPostsScore = new Dictionary<string, PostedItemScore>();

                foreach (Post post in m_FetchDataFromFaceBook.GetUserPosts(r_LoggedUser))
                {
                    m_UserPostsScore[post.Id] = new PostedItemScore(post)
                    {
                        PostedItemScoreValue =
                        m_FetchDataFromFaceBook.GetPostUserLikeCount(r_LoggedUser, post.Id) +
                        m_FetchDataFromFaceBook.GetPostUserCommentCount(r_LoggedUser, post.Id)
                    };
                    m_StatisticOfActivities[(int)ePostedItemTypes.Post].Likes +=
                        m_FetchDataFromFaceBook.GetPostUserLikeCount(r_LoggedUser, post.Id);
                    m_StatisticOfActivities[(int)ePostedItemTypes.Post].Comments +=
                        m_FetchDataFromFaceBook.GetPostUserCommentCount(r_LoggedUser, post.Id);
                    m_StatisticOfActivities[(int)ePostedItemTypes.Post].TotalItems += 1;
                }

                postedPostScores = convertDictionaryToList(m_UserPostsScore);

                if (postedPostScores.Count != 0)
                {
                    postedPostScores.Sort(compareList);

                    string bestPostID = postedPostScores[postedPostScores.Count - 1].PostedItem.Id;
                    string worstPostID = postedPostScores[0].PostedItem.Id;

                    foreach (Post post in m_FetchDataFromFaceBook.GetUserPosts(r_LoggedUser))
                    {
                         if (post.Id == bestPostID)
                         {
                             m_BestUserActivities[(int)ePostedItemTypes.Post] = post;
                         }

                         if (post.Id == worstPostID)
                         {
                             m_WorstUserActivities[(int)ePostedItemTypes.Post] = post;
                         }
                    }
                }
            }
            catch (Exception)
            {
                throw new Exception("Failed to find your posts, please try again later.");
            }
        }

        private void fetchUserActivitiesFromVideos()
        {
            try
            {
                List<PostedItemScore> postedVideoScores = new List<PostedItemScore>();
                Dictionary<string, PostedItemScore> m_UserVideosScore = new Dictionary<string, PostedItemScore>();

                foreach (Video video in m_FetchDataFromFaceBook.GetUserVideos(r_LoggedUser))
                {
                    m_UserVideosScore[video.Id] = new PostedItemScore(video)
                    {
                        PostedItemScoreValue =
                        m_FetchDataFromFaceBook.GetVideoUserLikeCount(r_LoggedUser, video.Id) +
                        m_FetchDataFromFaceBook.GetVideoUserCommentCount(r_LoggedUser, video.Id)
                    };
                    m_StatisticOfActivities[(int)ePostedItemTypes.Video].Likes +=
                        m_FetchDataFromFaceBook.GetVideoUserLikeCount(r_LoggedUser, video.Id);
                    m_StatisticOfActivities[(int)ePostedItemTypes.Video].Comments +=
                        m_FetchDataFromFaceBook.GetVideoUserCommentCount(r_LoggedUser, video.Id);
                    m_StatisticOfActivities[(int)ePostedItemTypes.Video].TotalItems += 1;
                }

                postedVideoScores = convertDictionaryToList(m_UserVideosScore);

                if(postedVideoScores.Count != 0)
                {
                    postedVideoScores.Sort(compareList);

                    string bestVideoID = postedVideoScores[postedVideoScores.Count - 1].PostedItem.Id;
                    string worstVideoID = postedVideoScores[0].PostedItem.Id;

                    foreach (Video video in m_FetchDataFromFaceBook.GetUserVideos(r_LoggedUser))
                    {
                        if (video.Id == bestVideoID)
                        {
                            m_BestUserActivities[(int)ePostedItemTypes.Video] = video;
                        }

                        if (video.Id == worstVideoID)
                        {
                            m_WorstUserActivities[(int)ePostedItemTypes.Video] = video;
                        }
                    }
                }     
            }
            catch (Exception)
            {
                throw new Exception("Failed to find your videos, please try again later.");
            }
        }

        public string GetWorstPhotoUrl(ePostedItemTypes ePostedItemTypes)
        {
            Photo worstPhoto = m_WorstUserActivities[(int)ePostedItemTypes] as Photo;
            return worstPhoto.PictureNormalURL;
        }

        public string GetWorstPostUrl(ePostedItemTypes ePostedItemTypes)
        {
            Post worstPhoto = m_WorstUserActivities[(int)ePostedItemTypes] as Post;
            return worstPhoto.PictureURL;
        }

        public string GetWorstVideoUrl(ePostedItemTypes ePostedItemTypes)
        {
            Video worstPhoto = m_WorstUserActivities[(int)ePostedItemTypes] as Video;
            return worstPhoto.PictureURL;
        }

        public string GetBestLikes(ePostedItemTypes ePostedItemTypes)
        {
            return m_BestUserActivities[(int)ePostedItemTypes].LikedBy.Count.ToString();
        }

        public string GetBestComments(ePostedItemTypes ePostedItemTypes)
        {
            return m_BestUserActivities[(int)ePostedItemTypes].Comments.Count.ToString();
        }

        public string GetWorstComments(ePostedItemTypes ePostedItemTypes)
        {
            return m_WorstUserActivities[(int)ePostedItemTypes].Comments.Count.ToString();
        }

        public string GetWorstLikes(ePostedItemTypes ePostedItemTypes)
        {
            return m_WorstUserActivities[(int)ePostedItemTypes].LikedBy.Count.ToString();
        }

        public string GetBestPhotoUrl(ePostedItemTypes ePostedItemTypes)
        {
            Photo bestPhoto = m_BestUserActivities[(int)ePostedItemTypes] as Photo;
            return bestPhoto.PictureNormalURL;
        }

        public string GetBestVideoUrl(ePostedItemTypes ePostedItemTypes)
        {
            Video bestPhoto = m_BestUserActivities[(int)ePostedItemTypes] as Video;
            return bestPhoto.PictureURL;
        }

        public string GetBestPostUrl(ePostedItemTypes ePostedItemTypes)
        {
            Post bestPhoto = m_BestUserActivities[(int)ePostedItemTypes] as Post;
            return bestPhoto.PictureURL;
        }

        public int GetStatisticOfActivitiesLikes(ePostedItemTypes ePostedItemTypes)
        {
            return m_StatisticOfActivities[(int)ePostedItemTypes].Likes;
        }

        public int GetStatisticOfActivitiesComments(ePostedItemTypes ePostedItemTypes)
        {
            return m_StatisticOfActivities[(int)ePostedItemTypes].Comments;
        }

        public int GetStatisticOfActivitiesTotalItam(ePostedItemTypes ePostedItemTypes)
        {
            return m_StatisticOfActivities[(int)ePostedItemTypes].TotalItems;
        }

        private string calculateAvarge(int i_Divided, int i_Divide)
        {
            int avarge = i_Divided / i_Divide;

            return avarge.ToString();
        }

        public string GetStatisticLikeAVG(ePostedItemTypes ePostedItemTypes)
        {
            string avarge = calculateAvarge(
            m_StatisticOfActivities[(int)ePostedItemTypes].Likes,
            m_StatisticOfActivities[(int)ePostedItemTypes].TotalItems);

            return avarge;
        }

        public string GetStatisticCommentsAVG(ePostedItemTypes ePostedItemTypes)
        {
            string avarge = calculateAvarge(
            m_StatisticOfActivities[(int)ePostedItemTypes].Comments,
            m_StatisticOfActivities[(int)ePostedItemTypes].TotalItems);

            return avarge;
        }

        public Post GetBestPostUserActivities()
        {
            return m_BestUserActivities[(int)ePostedItemTypes.Post] as Post;
        }

        public Post GetWorstPostUserActivities()
        {
            return m_WorstUserActivities[(int)ePostedItemTypes.Post] as Post;
        }
    }
}
