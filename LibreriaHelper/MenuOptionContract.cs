using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaHelper.Menu
{
    public abstract class MenuOptionContract
    {
        public abstract List<MenuItem> getItems();
    }
}
