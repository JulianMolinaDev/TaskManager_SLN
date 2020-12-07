using System.Collections.Generic;
using TaskManager_MDL.Modelos;
using TaskManager_SVC.Interfaces;
using TaskManager_SVC.Repositorios;

namespace TaskManager_SVC.Servicios
{
    public class SVC_Empresa : ISVC_Empresa
    {
        private readonly ISVC_Empresa _repositorio;
        public SVC_Empresa()
        {
            _repositorio = new REP_Empresa();
        }
        public void Delete(int id)
        {
            _repositorio.Delete(id);
        }

        public IEnumerable<MDL_Empresa> Get()
        {
            return _repositorio.Get();
        }

        public MDL_Empresa Get(int id)
        {
            return _repositorio.Get(id);
        }

        public void Post(MDL_Empresa reg)
        {
            _repositorio.Post(reg);
        }

        public void Put(int id, MDL_Empresa reg)
        {
            _repositorio.Put(id, reg);
        }
    }
}
