using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace BasicGages
{
    internal class GageInfo
    {
        private string[] gageList = { "Calipers", "Plug", "Ring", "Taper", "Snap", "Feeler", "Thread", "Form" };
        //private List<string> _gages= new List<string>();
        public List<string> GageTypes()
        {
            return gageList.Select(item => item.ToString()).ToList();
        }
    
    }
}
