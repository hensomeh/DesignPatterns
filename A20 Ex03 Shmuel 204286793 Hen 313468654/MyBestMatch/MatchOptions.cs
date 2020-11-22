using System;

namespace A20_Ex03_Shmuel_204286793_Hen_313468654
{
    public class MatchOptions
    {
        private string m_GenderIntrest;
        private int m_LowAge;
        private int m_HighAge;
        private string m_AgeExcptionMassage;

        public string BestOrWorstMatches { get; set; }

        public string GenderIntrest { get => m_GenderIntrest; }

        public int LowAge { get => m_LowAge; }

        public int HighAge { get => m_HighAge; }

        public MatchOptions(string i_GenderIntrest, int i_LowAge, int i_HighAge, string i_BestOrWorstMatches)
        {
            if (!checkValidIntrestGender(i_GenderIntrest))
            {
                throw new ArgumentNullException(null, "Gender interested is empty");
            }

            if (i_BestOrWorstMatches == string.Empty)
            {
                throw new ArgumentNullException(null, "Best or worst is empty");
            }

            if (!checkValidAgeRange(i_LowAge, i_HighAge))
            {
                throw new Exception(m_AgeExcptionMassage);
            }

            m_GenderIntrest = i_GenderIntrest;
            m_LowAge = i_LowAge;
            m_HighAge = i_HighAge;
            BestOrWorstMatches = i_BestOrWorstMatches;
        }

        private bool checkValidAgeRange(int i_LowAge, int i_HighAge)
        {
            bool isValidAgeRange = true;

            if (i_LowAge == 0 || i_HighAge == 0)
            {
                m_AgeExcptionMassage = "Fill the Age Range";
                isValidAgeRange = false;
            }
            else if (i_LowAge < 10 || i_HighAge > 80)
            {
                m_AgeExcptionMassage = "Fill age range only between 10-80";
                isValidAgeRange = false;
            }
            else if (i_LowAge > i_HighAge)
            {
                m_AgeExcptionMassage = "Age range not valid, e.g 19-22";
                isValidAgeRange = false;
            }

            return isValidAgeRange;
        }

        private bool checkValidIntrestGender(string i_GenderIntrest)
        {
            bool isInterestGender = true;

            if (i_GenderIntrest == string.Empty)
            {
                isInterestGender = false;
            }

            return isInterestGender;
        }
    }
}
