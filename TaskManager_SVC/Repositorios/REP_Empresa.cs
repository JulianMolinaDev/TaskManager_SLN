using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManager_MDL.Modelos;
using TaskManager_SVC.Interfaces;

namespace TaskManager_SVC.Repositorios
{
    class REP_Empresa : ISVC_Empresa
    {
        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<MDL_Empresa> Get()
        {
            throw new NotImplementedException();
        }

        public MDL_Empresa Get(int id)
        {
            throw new NotImplementedException();
        }

        public void Post(MDL_Empresa reg)
        {
            throw new NotImplementedException();
        }

        public void Put(int id, MDL_Empresa reg)
        {
            throw new NotImplementedException();
        }
    }
}
