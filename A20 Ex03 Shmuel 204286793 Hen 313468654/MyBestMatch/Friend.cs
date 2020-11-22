using FacebookWrapper.ObjectModel;

namespace A20_Ex03_Shmuel_204286793_Hen_313468654
{
    public class Friend
    {
        private User m_User;
        private int m_FriendScore;

        public Friend(User i_User)
        {
            m_FriendScore = 0;
            m_User = i_User;
        }

        public User User { get => m_User; }

        public int FriendScore { get => m_FriendScore; set => m_FriendScore = value; }
    }
}
