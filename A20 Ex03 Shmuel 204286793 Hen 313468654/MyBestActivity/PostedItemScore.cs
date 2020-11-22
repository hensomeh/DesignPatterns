using FacebookWrapper.ObjectModel;

namespace A20_Ex03_Shmuel_204286793_Hen_313468654
{
    public class PostedItemScore
    {
        private PostedItem m_PostedItem;
        private int m_PostedItemScoreValue;

        public PostedItemScore(PostedItem i_PostedItem)
        {
            m_PostedItemScoreValue = 0;
            m_PostedItem = i_PostedItem;
        }

        public PostedItem PostedItem { get => m_PostedItem; }

        public int PostedItemScoreValue { get => m_PostedItemScoreValue; set => m_PostedItemScoreValue = value; }
    }
}
