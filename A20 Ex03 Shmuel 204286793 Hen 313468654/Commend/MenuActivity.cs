using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace A20_Ex03_Shmuel_204286793_Hen_313468654
{
    public class MenuActivity : List<MenuItemCheckBox>
    {
        public bool AfterSelction(Panel i_PanelFetcher2)
        {
            int index = 0;
            bool anySelection = false;

            foreach (MenuItemCheckBox item in this)
            {
                string checkBoxName = string.Format("checkBoxActivity{0}", index);
                item.m_CheckBox = (CheckBox)i_PanelFetcher2.Controls.Find(checkBoxName, true)[0];
                if (item.m_CheckBox.Checked)
                {
                    anySelection = true;
                    this[index].Selected();
                }

                index++;
            }

            return anySelection;
        }

        public Dictionary<string, bool> WhoIsChecked(Panel i_PanelFetcher2)
        {
            Dictionary<string, bool> check = new Dictionary<string, bool>();
            int index = 0;
            
            foreach (MenuItemCheckBox item in this)
            {
                string checkBoxName = string.Format("checkBoxActivity{0}", index);
                item.m_CheckBox = (CheckBox)i_PanelFetcher2.Controls.Find(checkBoxName, true)[0];
                if (item.m_CheckBox.Checked)
                {
                    check[item.m_NameOfCatagory] = true;
                }
                else
                {
                    check[item.m_NameOfCatagory] = false;
                }

                index++;
            }

            return check;
        }

        public void ShowMenu(Panel i_PanelFetcher2)
        {
            int index = 0;
            int top = 135;
            int left = 14;

            foreach (MenuItemCheckBox item in this)
            {
                item.m_CheckBox = new CheckBox
                {
                    Text = item.m_NameOfCatagory,
                    Name = string.Format("checkBoxActivity{0}", index),
                    Location = new System.Drawing.Point(left, top),
                    Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)177)
                };
                i_PanelFetcher2.Controls.Add(item.m_CheckBox);
                top += 31;
                index++;
            }
        }
    }
}
