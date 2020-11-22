namespace A20_Ex03_Shmuel_204286793_Hen_313468654
{
    public class PostedItemStatistics
    {
        private int m_Likes;
        private int m_Comments;
        private int m_TotalItems;

        public PostedItemStatistics()
        {
            m_Likes = 0;
            m_Comments = 0;
            m_TotalItems = 0;
        }

        public int Likes { get => m_Likes; set => m_Likes = value; }

        public int Comments { get => m_Comments; set => m_Comments = value; }

        public int TotalItems { get => m_TotalItems; set => m_TotalItems = value; }
    }
}
