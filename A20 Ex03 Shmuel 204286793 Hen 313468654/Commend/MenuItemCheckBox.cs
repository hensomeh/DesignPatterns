using System;
using System.Windows.Forms;

namespace A20_Ex03_Shmuel_204286793_Hen_313468654
{
    public class MenuItemCheckBox
    {
        protected Action m_Command;

        public CheckBox m_CheckBox { get; set; }

        public string m_NameOfCatagory { get; set; }

        public MenuItemCheckBox(string i_NameOfCatagory, Action i_Comamnd)
        {
            m_NameOfCatagory = i_NameOfCatagory;
            m_Command = i_Comamnd;
        }

        public virtual void Selected()
        {
            if (m_Command != null)
            {
                m_Command.Invoke();
            }
        }
    }
}
