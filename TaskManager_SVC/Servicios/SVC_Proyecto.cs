using System.Collections.Generic;
using TaskManager_MDL.Modelos;
using TaskManager_SVC.Interfaces;
using TaskManager_SVC.Repositorios;

namespace TaskManager_SVC.Servicios
{
    public class SVC_Proyecto : ISVC_Proyecto
    {
        private readonly ISVC_Proyecto _repositorio;
        public SVC_Proyecto()
        {
            _repositorio = new REP_Proyecto();
        }
        public void Delete(int id)
        {
            _repositorio.Delete(id);
        }

        public IEnumerable<MDL_Proyecto> Get()
        {
            return _repositorio.Get();
        }

        public MDL_Proyecto Get(int id)
        {
            return _repositorio.Get(id);
        }

        public void Post(MDL_Proyecto reg)
        {
            _repositorio.Post(reg);
        }

        public void Put(int id, MDL_Proyecto reg)
        {
            _repositorio.Put(id, reg);
        }
    }
}
