using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Windows.Controls;
using CarConfigurator.DTO;

namespace CarConfigurator
{
    class Logic
    {
        CarConfiguratorEntities db = new CarConfiguratorEntities();
        public List<Option> GetOptionsOfType(int a)
        {
            var g = db.Option.Where(b => b.ID_type == a).ToList();
            return g;
        }

        public void Balance(int? price, int? balance)
        {
            
            balance += (price);
        }


    }
}


