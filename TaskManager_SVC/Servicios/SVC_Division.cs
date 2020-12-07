using System.Collections.Generic;
using TaskManager_MDL.Modelos;
using TaskManager_SVC.Interfaces;
using TaskManager_SVC.Repositorios;

namespace TaskManager_SVC.Servicios
{
    public class SVC_Division : ISVC_Division
    {
        private readonly ISVC_Division _repositorio;
        public SVC_Division()
        {
            _repositorio = new REP_Division();
        }
        public void Delete(int id)
        {
            _repositorio.Delete(id);
        }

        public IEnumerable<MDL_Division> Get()
        {
            return _repositorio.Get();
        }

        public MDL_Division Get(int id)
        {
            return _repositorio.Get(id);
        }

        public void Post(MDL_Division reg)
        {
            _repositorio.Post(reg);
        }

        public void Put(int id, MDL_Division reg)
        {
            _repositorio.Put(id, reg);
        }
    }
}
