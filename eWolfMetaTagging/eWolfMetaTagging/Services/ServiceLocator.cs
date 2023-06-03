using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eWolfMetaTagging.Services
{

    public class ServiceLocator : ServiceLocatorBase
    {
        private ServiceLocator()
        {
            _services = new Dictionary<Type, object>
            {
            };
        }

        public static ServiceLocatorBase Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new ServiceLocator();
                }
                return _instance;
            }
        }
    }
}
