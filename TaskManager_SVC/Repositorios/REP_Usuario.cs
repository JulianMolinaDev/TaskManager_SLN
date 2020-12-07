using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManager_MDL.Modelos;
using TaskManager_SVC.Interfaces;

namespace TaskManager_SVC.Repositorios
{
    class REP_Usuario : ISVC_Usuario
    {
        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<MDL_Usuario> Get()
        {
            throw new NotImplementedException();
        }

        public MDL_Usuario Get(int id)
        {
            throw new NotImplementedException();
        }

        public void Post(MDL_Usuario reg)
        {
            throw new NotImplementedException();
        }

        public void Put(int id, MDL_Usuario reg)
        {
            throw new NotImplementedException();
        }
    }
}
