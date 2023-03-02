using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicGages
{
    internal class Gage
    {
        private string _name;
        private string _type;
        
        public string Name
        {
            get
            {
                return this._name;
            }

            set
            {
                _name = value;
            }
        }
            
        public string Type
        {
            get
            {
                return this._type;
            }

            set
            {
                _type = value;
            }
        }

    }



}
