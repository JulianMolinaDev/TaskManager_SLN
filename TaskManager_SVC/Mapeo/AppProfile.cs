using AutoMapper;
using TaskManager_MDL.Modelos;
using TaskManager_SVC.Data;

namespace TaskManager_SVC.Mapeo
{
    internal class AppProfile : Profile
    {
        public AppProfile()
        {
            CreateMap<MDL_Division, TBL_Divisiones>().ReverseMap();
            CreateMap<MDL_Empresa, TBL_Empresas>().ReverseMap();
            CreateMap<MDL_Proyecto, TBL_Proyectos>().ReverseMap();
            CreateMap<MDL_Tarea, TBL_Tareas>().ReverseMap();
            CreateMap<MDL_TareaAvisado, TBL_TareasAvisados>().ReverseMap();
            CreateMap<MDL_Usuario, TBL_Usuarios>().ReverseMap();
        }
    }
}
