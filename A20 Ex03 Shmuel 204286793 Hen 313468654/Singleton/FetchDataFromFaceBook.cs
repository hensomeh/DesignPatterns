using System.Collections.Generic;
using FacebookWrapper.ObjectModel;
using FacebookWrapper;

namespace A20_Ex03_Shmuel_204286793_Hen_313468654
{
    public class FetchDataFromFaceBook
    {
        private bool s_isAddedPhotoLikesAndComment = false;
        private bool s_isAddedPostLikesAndComment = false; 
        private LinkedList<Photo> s_UserPhotos = new LinkedList<Photo>();
        private LinkedList<Post> s_UserPosts = new LinkedList<Post>();
        private LinkedList<Video> s_UserVideos = new LinkedList<Video>();
        private LinkedList<User> s_Friends = new LinkedList<User>();
        private FacebookObjectCollection<Page> s_UserListPages = new FacebookObjectCollection<Page>();
        private LinkedList<FacebookObjectCollection<User>> s_UserListPhotoLikedBy = new LinkedList<FacebookObjectCollection<User>>();
        private LinkedList<FacebookObjectCollection<User>> s_UserListPostLikedBy = new LinkedList<FacebookObjectCollection<User>>();
        private LinkedList<FacebookObjectCollection<Comment>> s_UserListPhotoComments = new LinkedList<FacebookObjectCollection<Comment>>();
        private LinkedList<FacebookObjectCollection<Comment>> s_UserListPostComments = new LinkedList<FacebookObjectCollection<Comment>>();
        private Dictionary<string, FacebookObjectCollection<Page>> s_UserFriendsPageLikes = new Dictionary<string, FacebookObjectCollection<Page>>();
        private Dictionary<string, int> s_VideoLikedCount = new Dictionary<string, int>();
        private Dictionary<string, int> s_VideoCommentCount = new Dictionary<string, int>();
        private Dictionary<string, int> s_PhotoLikedCount = new Dictionary<string, int>();
        private Dictionary<string, int> s_PhotoCommentCount = new Dictionary<string, int>();
        private Dictionary<string, int> s_PostLikedCount = new Dictionary<string, int>();
        private Dictionary<string, int> s_PostCommentCount = new Dictionary<string, int>();

        private FetchDataFromFaceBook()
        {
        }

        public FacebookObjectCollection<Page> GetUserFriendsPageLikesById(string i_FriendId)
        {
            if (!s_UserFriendsPageLikes.TryGetValue(i_FriendId, out FacebookObjectCollection<Page> o_Value))
            {
                addUserFriendsPageLikes(i_FriendId);
            }

            return s_UserFriendsPageLikes.TryGetValue(i_FriendId, out o_Value) ? s_UserFriendsPageLikes[i_FriendId] : null;
        }

        private void addUserFriendsPageLikes(string i_FriendId)
        {
            s_UserFriendsPageLikes.Add(i_FriendId, FacebookService.GetCollection<Page>("likes", i_FriendId));
        }

        private void addUserPhotos(User i_LogedUser)
        {
            foreach (Album album in i_LogedUser.Albums)
            {
                foreach(Photo photo in album.Photos)
                {
                    s_UserPhotos.AddLast(photo);
                }             
            }
        }

        private void addUserVideos(User i_LogedUser)
        {
            foreach (Video video in i_LogedUser.Videos)
            {
                s_UserVideos.AddLast(video);
            }
        }

        private void addLikesOnVideo(User i_LogedUser)
        {
            foreach (Video video in GetUserVideos(i_LogedUser))
            {
                s_VideoLikedCount[video.Id] = video.LikedBy.Count;
            }
        }

        private void addCommentsOnVideo(User i_LogedUser)
        {
            foreach (Video video in GetUserVideos(i_LogedUser))
            {
                s_VideoLikedCount[video.Id] = video.Comments.Count;
            }
        }

        private void addUserFriends(User i_LogedUser)
        {
            foreach (User friend in i_LogedUser.Friends)
            {
                s_Friends.AddLast(friend);
            }
        }

        private void addAllUserListPostLikedByAndComments(User i_LogedUser)
        {
            if(s_UserPosts.Count == 0)
            {
                addUserPosts(i_LogedUser);
            }

            if (!s_isAddedPostLikesAndComment)
            {
                foreach (Post post in s_UserPosts)
                {
                    s_PostLikedCount[post.Id] = post.LikedBy.Count;
                    s_PostCommentCount[post.Id] = post.Comments.Count;

                    if (s_PostLikedCount[post.Id] != 0 )
                    {
                        s_UserListPostLikedBy.AddLast(post.LikedBy);
                    }
                    
                    if(s_PostCommentCount[post.Id] != 0)
                    {
                        s_UserListPostComments.AddLast(post.Comments);
                    } 
                }

                s_isAddedPostLikesAndComment = true;
            }
        }

        private void addAllUserListPhotoLikedByAndComments(User i_LogedUser)
        {
            if(s_UserPhotos.Count == 0)
            {
                addUserPhotos(i_LogedUser);
            }

            if (!s_isAddedPhotoLikesAndComment)
            {
                foreach (Photo photo in s_UserPhotos)
                {
                    s_PhotoLikedCount[photo.Id] = photo.LikedBy.Count;
                    s_PhotoCommentCount[photo.Id] = photo.Comments.Count;

                    if (s_PhotoLikedCount[photo.Id] != 0)
                    {
                        s_UserListPostLikedBy.AddLast(photo.LikedBy);
                    }
                    
                    if(s_PhotoCommentCount[photo.Id] != 0)
                    {
                        s_UserListPostComments.AddLast(photo.Comments);
                    }
                }

                s_isAddedPhotoLikesAndComment = true;
            }
        }

        private LinkedList<Post> addUserPosts(User i_LogedUser)
        {
            foreach(Post post in i_LogedUser.Posts)
            {
                s_UserPosts.AddLast(post);
            }

            return s_UserPosts;
        }

        private void addUserListPages()
        {
            s_UserListPages = FacebookService.GetCollection<Page>("likes");
        }

        public LinkedList<FacebookObjectCollection<User>> GetUserListPhotoLikedBy(User i_LogedUser)
        {
            if(s_UserListPhotoLikedBy.Count == 0)
            {
                addAllUserListPhotoLikedByAndComments(i_LogedUser);
            }

            return s_UserListPhotoLikedBy;
        }

        public int GetVideoUserLikeCount(User i_LogedUser, string i_Id)
        {
            if(s_VideoLikedCount.Count == 0)
            {
                addLikesOnVideo(i_LogedUser);
            }

            return s_VideoLikedCount.TryGetValue(i_Id, out int value) ? s_VideoLikedCount[i_Id] : 0;
        }

        public int GetVideoUserCommentCount(User i_LogedUser, string i_Id)
        {
            if (s_VideoCommentCount.Count == 0)
            {
                addCommentsOnVideo(i_LogedUser);
            }

            return s_VideoCommentCount.TryGetValue(i_Id, out int value) ? s_VideoCommentCount[i_Id] : 0;
        }

        public int GetPhotoUserLikeCount(User i_LogedUser, string i_Id)
        {
            if (s_PhotoLikedCount.Count == 0)
            {
                addAllUserListPhotoLikedByAndComments(i_LogedUser);
            }

            return s_PhotoLikedCount.TryGetValue(i_Id, out int value) ? s_PhotoLikedCount[i_Id] : 0;
        }

        public int GetPhotoUserCommentCount(User i_LogedUser, string i_Id)
        {
            if (s_PhotoCommentCount.Count == 0)
            {
                addAllUserListPhotoLikedByAndComments(i_LogedUser);
            }

            return s_PhotoCommentCount.TryGetValue(i_Id, out int value) ? s_PhotoCommentCount[i_Id] : 0;
        }

        public int GetPostUserLikeCount(User i_LogedUser, string i_Id)
        {
            if (s_PostLikedCount.Count == 0)
            {
                addAllUserListPostLikedByAndComments(i_LogedUser);
            }

            return s_PostLikedCount.TryGetValue(i_Id, out int value) ? s_PostLikedCount[i_Id] : 0;
        }

        public int GetPostUserCommentCount(User i_LogedUser, string i_Id)
        {
            if (s_PostCommentCount.Count == 0)
            {
                addAllUserListPostLikedByAndComments(i_LogedUser);
            }

            return s_PostCommentCount.TryGetValue(i_Id, out int value) ? s_PostCommentCount[i_Id] : 0;
        }

        public LinkedList<FacebookObjectCollection<User>> GetUserListPostLikedBy(User i_LogedUser)
        {
            if(s_UserListPostLikedBy.Count == 0)
            {
                addAllUserListPostLikedByAndComments(i_LogedUser);
            }

            return s_UserListPostLikedBy;
        }

        public LinkedList<FacebookObjectCollection<Comment>> GetUserListPhotoComments(User i_LogedUser)
        {
            if(s_UserListPhotoComments.Count == 0)
            {
                addAllUserListPhotoLikedByAndComments(i_LogedUser);
            }

            return s_UserListPhotoComments;
        }

        public LinkedList<FacebookObjectCollection<Comment>> GetUserListPostComments(User i_LogedUser)
        {
            if (s_UserListPostComments.Count == 0)
            {
                addAllUserListPostLikedByAndComments(i_LogedUser);
            }

            return s_UserListPostComments;
        }

        public FacebookObjectCollection<Page> GetUserListPages()
        {
            if(s_UserListPages.Count == 0)
            {
                addUserListPages();
            }

            return s_UserListPages;
        }

        public LinkedList<User> GetUserFriends(User i_LogedUser)
        {
            if(s_Friends.Count == 0)
            {
                addUserFriends(i_LogedUser);
            }

            return s_Friends;
        }

        public LinkedList<Post> GetUserPosts(User i_LogedUser)
        {
            if (s_UserPosts.Count == 0)
            {
                addUserPosts(i_LogedUser);
            }

            return s_UserPosts;
        }

        public LinkedList<Photo> GetUserPhotos(User i_LogedUser)
        {
            if (s_UserPhotos.Count == 0)
            {
                addUserPhotos(i_LogedUser);
            }

            return s_UserPhotos;
        }

        public LinkedList<Video> GetUserVideos(User i_LogedUser)
        {
            if(s_UserVideos.Count == 0)
            {
                addUserVideos(i_LogedUser);
            }

            return s_UserVideos;
        }

        public void ClearAll()
        {
            s_UserListPhotoLikedBy = new LinkedList<FacebookObjectCollection<User>>();
            s_UserListPhotoComments = new LinkedList<FacebookObjectCollection<Comment>>();
            s_UserListPostLikedBy = new LinkedList<FacebookObjectCollection<User>>();
            s_UserListPostComments = new LinkedList<FacebookObjectCollection<Comment>>();
            s_UserFriendsPageLikes = new Dictionary<string, FacebookObjectCollection<Page>>();
            s_UserListPages = new FacebookObjectCollection<Page>();
            s_UserPhotos = new LinkedList<Photo>();
            s_UserPosts = new LinkedList<Post>();
            s_UserVideos = new LinkedList<Video>();
            s_Friends = new LinkedList<User>();
            s_VideoLikedCount = new Dictionary<string, int>();
            s_VideoCommentCount = new Dictionary<string, int>();
            s_PhotoLikedCount = new Dictionary<string, int>();
            s_PhotoCommentCount = new Dictionary<string, int>();
            s_PostLikedCount = new Dictionary<string, int>();
            s_PostCommentCount = new Dictionary<string, int>();
            s_isAddedPhotoLikesAndComment = false;
            s_isAddedPostLikesAndComment = false;
        }
    }
}