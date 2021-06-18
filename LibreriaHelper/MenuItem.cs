using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaHelper.Menu
{
    public class MenuItem
    {
        private int _index;
        private string _name;
        private string _method;

        public int Index
        {
            get { return this._index; }
            set { this._index = value; }
        }

        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }
        public string Method
        {
            get { return this._method; }
            set { this._method = value; }
        }
    }
}
