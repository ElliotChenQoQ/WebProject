using AutoMapper;
using WebProject.Init.Base.Interface;

namespace WebProject.Init.Base
{
    public abstract class BaseDao : BaseLayer, IBaseDao
    {
        /// <summary>
        /// AutoMapper
        /// </summary>
        protected IMapper Mapper { get; set; }

        /// <summary>
        /// AutoMapper
        /// </summary>
        protected abstract void AutoMapperConfiguration();

        /// <summary>
        /// Initializes a new instance 
        /// </summary>
        public BaseDao()
        {
            AutoMapperConfiguration();
        }
    }
}
