using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicGages
{
    internal class MenuClicks
    {
        public static void EditClick(ListViewItem item)
        {
            string GageNum = "";
            string GageType = "";
            string Status = "";
            string CurrentLoc = "";
            string StorageLoc = "";
            string isActive = "";


            item.Text = GageNum;
            item.SubItems[0].Text = GageType;
            item.SubItems[1].Text = Status;
            item.SubItems[2].Text = CurrentLoc;
            item.SubItems[3].Text = StorageLoc;
            item.SubItems[4].Text = isActive;
            

        }
    }
}
