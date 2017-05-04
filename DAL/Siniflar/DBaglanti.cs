using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Siniflar
{
    public class DBaglanti
    {
        private static teknikservisdbEntities _entity;
        protected static teknikservisdbEntities Entity
        {
            get
            {
                if (_entity == null)
                    _entity = new teknikservisdbEntities();
                return _entity;
            }
        }
    }
}
