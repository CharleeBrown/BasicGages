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
        private List<string> _gages= new List<string>();
        public List<string> GageTypes() {


            string[] gageList = { "Calipers", "Plug", "Ring", "Taper", "Snap", "Feeler", "Thread", "Form" };
            
            foreach(var item in gageList)
            {
                _gages.Add(item.ToString());
            }



            return _gages;
        }
    }
}
