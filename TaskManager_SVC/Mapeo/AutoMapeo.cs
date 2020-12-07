using AutoMapper;

namespace TaskManager_SVC.Mapeo
{
    public sealed class AutoMapeo
    {
        private static IMapper instance = null;

        private AutoMapeo()
        {
        }

        public static IMapper Instance
        {
            get
            {
                if (instance == null)
                {
                    var config = new MapperConfiguration(cfg => {
                        cfg.AddProfile<AppProfile>();
                    });

                    instance = config.CreateMapper();
                }
                return instance;
            }
        }
    }
}
